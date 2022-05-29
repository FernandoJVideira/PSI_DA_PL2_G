using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Principal
{
    public partial class GesPedidos : Form
    {
        bool mouseDown;
        private Point offset;
        private Model1Container model;
        public GesPedidos()
        {
            InitializeComponent();
        }

        private void MouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        //-------------------------------------------------------------------------------------//
        private void btnClose_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RefreshPedidos()
        {
            listBoxPayment.Items.Clear();
            listBoxProcessing.Items.Clear();
            model = new Model1Container();
            List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();
            IEnumerable<Pedido> PedidosAndando = from pedido in listaPedidos
                                                 where pedido.EstadoId == 1
                                                 select pedido;

            foreach (Pedido pedido in PedidosAndando)
            {
                listBoxProcessing.Items.Add(pedido);
            }

            //---pedidos por pagar

            IEnumerable<Pedido> PedidosPorPagar = from pedido in listaPedidos
                                                  where pedido.EstadoId == 2
                                                 select pedido;

            foreach (Pedido pedido in PedidosPorPagar)
            {
                listBoxPayment.Items.Add(pedido);
            }
        }

        private void Lerdados()
        {
            model = new Model1Container();
            Restaurante restaurante = model.Restaurante.Find(MainMenu.IdRestaurate);
            List<Pessoa> pessoas = model.Pessoa.ToList<Pessoa>();
            List<ItemMenu> items = model.ItemMenu.ToList<ItemMenu>();
            List<Cliente> listaCLientes = new List<Cliente>();
            List<Trabalhador> listaTrabalhadores = new List<Trabalhador>();
            RefreshPedidos();
            //--------------- load clientes

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if (pessoa is Cliente)
                {
                    Cliente cliente = (Cliente)pessoa;
                    listaCLientes.Add(cliente);
                }
                if (pessoa is Trabalhador)
                {
                    Trabalhador trabalhador = (Trabalhador)pessoa;
                    if(trabalhador.RestauranteId == restaurante.Id)
                    {
                        listBoxTrabalhadores.Items.Add(trabalhador);
                    }
                    
                }

            }
            
            dataGridViewClientes.DataSource = listaCLientes;

            //--------------- load Lista menu

            IEnumerable<ItemMenu> itemsAtivos = from item in items
                                                where item.Ativo == true
                                                where item.Restaurante.Contains(restaurante)
                                                select item;

            foreach (ItemMenu item in itemsAtivos)
            {
                listBoxMenu.Items.Add(item);
            }


            //--------------- load trabalhadores


        }

        private void GesPedidos_Load(object sender, EventArgs e)
        {
            Lerdados();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            model = new Model1Container();
            Pedido pedido = new Pedido();
            decimal total = 0;

            pedido.Trabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;

            foreach (ItemMenu item in listBoxItems.Items)
            {
                pedido.ItemMenu.Add(item);
                total += item.Preco;
            }

            pedido.ValorTotal = total;
            pedido.EstadoId = 1;
            pedido.Cliente = GetCliente();


            model.SaveChanges();

        }

        private Cliente GetCliente()
        {
            int row = dataGridViewClientes.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewClientes.Rows[row].Cells["id"].Value;
            Cliente data = model.Pessoa.First(c => c.Id == id) as Cliente;

            return data;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(listBoxMenu.SelectedItem == null)
            {
                return;
            }
            else
            {
                listBoxItems.Items.Add(listBoxMenu.SelectedItem);
                listBoxMenu.SelectedItem = null;
            }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxProcessing.SelectedItem;
            listBoxProcessing.Items.Remove(listBoxProcessing.SelectedItem);
            model.Pedido.Remove(pedido);
            model.SaveChanges();
            RefreshPedidos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxProcessing.SelectedItem;
            pedido.EstadoId = 2;
            model.SaveChanges();
            RefreshPedidos();

        }
    }
}
