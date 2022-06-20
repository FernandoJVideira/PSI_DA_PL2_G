using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();


            IEnumerable<Pedido> PedidosAndando = from pedido in listaPedidos
                                                 where pedido.EstadoId == 1
                                                 where pedido.RestauranteId == MainMenu.IdRestaurate
                                                 select pedido;

            foreach (Pedido pedido in PedidosAndando)
            {
                listBoxProcessing.Items.Add(pedido);
            }

            //---pedidos por pagar

            IEnumerable<Pedido> PedidosPorPagar = from pedido in listaPedidos
                                                  where pedido.EstadoId == 2
                                                  where pedido.RestauranteId == MainMenu.IdRestaurate
                                                 select pedido;

            foreach (Pedido pedido in PedidosPorPagar)
            {
                listBoxPayment.Items.Add(pedido);
            }
        }

        private void Erro(string msg, Form form)
        {
            MessageBox.Show(msg);
            form.Show();
        }

        private void Lerdados()
        {
            model = new Model1Container();
            Restaurante restaurante = model.Restaurante.Find(MainMenu.IdRestaurate);
            List<Pessoa> pessoas = model.Pessoa.ToList<Pessoa>();
            List<ItemMenu> items = model.ItemMenu.ToList<ItemMenu>();
            List<Cliente> listaCLientes = new List<Cliente>();
            List<Trabalhador> listaTrabalhadores = new List<Trabalhador>();
            List<MetodoPagamento> listaMetodoPagamentos = model.MetodoPagamento.ToList<MetodoPagamento>();

            IEnumerable<ItemMenu> itemsAtivos = from item in items
                                                where item.Restaurante.Contains(restaurante)
                                                select item;


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
                        listaTrabalhadores.Add(trabalhador);
                        listBoxTrabalhadores.Items.Add(trabalhador);
                    }
                    
                }


            }

            if (listaTrabalhadores.Count == 0)
            {
                Erro("Não existem trabalhadores registados", new GerirRestaurante());
                this.Close();
            }
            else if (listaCLientes.Count == 0)
            {
                Erro("Não existem clientes registados", new GesClientes());
                this.Close();
            }            
            else if (listaMetodoPagamentos.Count == 0)
            {
                Erro("Não existem metodos de pagamento registados ou ativos", new GesRestaurantGlobal());
                this.Close();
            }
            else if (itemsAtivos.Count<ItemMenu>() == 0)
            {
                Erro("Não existem pratos registados ou ativos", new GesMenu());
                this.Close();
            }


            dataGridViewClientes.DataSource = listaCLientes;

            //--------------- load Lista menu


            foreach (ItemMenu item in itemsAtivos)
            {
                listBoxMenu.Items.Add(item);
            }


            //--------------- load metodos

            comboBox1.DataSource = listaMetodoPagamentos;

            
        }

        private void GesPedidos_Load(object sender, EventArgs e)
        {
            Lerdados();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (listBoxTrabalhadores.SelectedItem == null) { return; }
            if (listBoxItems.Items.Count == 0) { return; }

            Pedido pedido = new Pedido();
            decimal total = 0;

            pedido.Trabalhador = (Trabalhador)listBoxTrabalhadores.SelectedItem;

            foreach(ItemMenu item in listBoxItems.Items)
            {
                pedido.ItemMenu.Add(item);
                total += item.Preco;
            }

            pedido.ValorTotal = total;
            pedido.Cliente = GetCliente();

            if (pedido.Cliente == null) { return; }
            
            pedido.EstadoId = 1;

            pedido.RestauranteId = MainMenu.IdRestaurate;
            
            
            model.Pedido.Add(pedido);

            model.SaveChanges();
            WriteToFile(pedido);
            listBoxItems.Items.Clear();
            RefreshPedidos();

        }

        private void WriteToFile(Pedido pedido)
        {
            Cliente cliente = pedido.Cliente;
            string currentDir = Environment.CurrentDirectory;

            string fileName = pedido.Id + ".txt";
            string path = currentDir + @"\pedidos\" + fileName;
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Cliente: "+cliente.Nome +" ("+ cliente.NIF + ") em recebido em " + DateTime.Now.ToString());
            sw.WriteLine("--------------------------------------------------------------------");
            sw.WriteLine("");
            sw.WriteLine("Artigos:");


            foreach (ItemMenu item in listBoxItems.Items)
            {
                sw.WriteLine("\t"+item.Nome +" " +item.Preco +" €");
                sw.WriteLine("");
            }
            sw.WriteLine("--------------------------------------------------------------------");
            sw.WriteLine("");
            sw.WriteLine("O total do cliente é: " + pedido.ValorTotal.ToString() + " €");

            sw.Close();
        }

        private void ChangeFile(Pedido pedido)
        {
            Cliente cliente = pedido.Cliente;
            string currentDir = Environment.CurrentDirectory;

            string fileName = pedido.Id + ".txt";
            string path = currentDir + @"\pedidos\" + fileName;
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("");

            switch (pedido.EstadoId)
            {
                case 3:
                    sw.WriteLine("Pedido Cancelado: " + DateTime.Now.ToString());
                    break;

                case 2:
                    sw.WriteLine("Pedido em Processamento: " + DateTime.Now.ToString());
                    break;

                case 4:
                    sw.WriteLine("Pedido Finalizado: " + DateTime.Now.ToString());
                    sw.WriteLine("");
                    sw.WriteLine("Métodos de Pagamento:");

                    foreach (Pagamento pagamento in listBoxMetodosUsados.Items)
                    {
                        sw.WriteLine("\t"+ pagamento.Valor.ToString() + "€ via " + pagamento.MetodoPagamento.Nome);
                    }

                    break;
            }

            sw.Close();
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
            if(listBoxMenu.SelectedItem == null){ return; }

            listBoxItems.Items.Add(listBoxMenu.SelectedItem);
            listBoxMenu.SelectedItem = null;
 


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxProcessing.SelectedItem;
            listBoxProcessing.Items.Remove(listBoxProcessing.SelectedItem);
            pedido.EstadoId = 3;
            model.SaveChanges();
            ChangeFile(pedido);
            RefreshPedidos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)listBoxProcessing.SelectedItem;
            pedido.EstadoId = 2;
            model.SaveChanges();
            ChangeFile(pedido);
            RefreshPedidos();

        }



        private void buttonConcluir_Click(object sender, EventArgs e)
        {
            if (listBoxPayment.SelectedItem == null) { return; }
            Pedido pedido = (Pedido)listBoxPayment.SelectedItem;
            pedido.EstadoId = 4;

            foreach(Pagamento pagamento in listBoxMetodosUsados.Items)
            {
                model.Pagamento.Add(pagamento);
            }

            model.SaveChanges();
            ChangeFile(pedido);
            RefreshPedidos();

            listBoxMetodosUsados.Items.Clear();
            listBoxPayment.Visible = true;
            labelinfo.Visible = false;

        }

        private void buttonValor_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = new Pagamento();
            if(listBoxPayment.SelectedItem == null) { return; }
            Pedido pedido = (Pedido)listBoxPayment.SelectedItem;
            decimal Total = Convert.ToDecimal(labelValor.Text);


            try
            {
                pagamento.Valor = Convert.ToDecimal(textBoxValor.Text);

              
            }
            catch (Exception)
            {

                MessageBox.Show("Introduza um valor valido!!");
                return;
            }

            pagamento.MetodoPagamento = (MetodoPagamento)comboBox1.SelectedItem;
            pagamento.PedidoId = pedido.Id;

            if(Total < Convert.ToDecimal(textBoxValor.Text) || 0 >= Convert.ToDecimal(textBoxValor.Text))
            {
                MessageBox.Show("Valor introduzido acima");
                return;
            }

           
            decimal Restante = Convert.ToDecimal(labelValor.Text) - pagamento.Valor; 

            labelValor.Text = Restante.ToString();
            listBoxMetodosUsados.Items.Add(pagamento);
            listBoxPayment.Visible = false;
            labelinfo.Visible = true;
            textBoxValor.Clear();
            
        }

        private void listBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPayment.SelectedIndex == -1) { return; }

            int index = listBoxPayment.SelectedIndex;
            Pedido pedido = (Pedido)listBoxPayment.SelectedItem;
            labelValor.Text = pedido.ValorTotal.ToString();

            if (listBoxMetodosUsados.Items.Count > 0)
            {
                MessageBox.Show("Termine o pagamento do pedido selecionado antes de avançar");
                listBoxPayment.SelectedIndex = index;
            }
        }

        private void buttonRemMetodo_Click(object sender, EventArgs e)
        {
            Pagamento pagamento = (Pagamento)listBoxMetodosUsados.SelectedItem;

            if (listBoxMetodosUsados.SelectedItem == null) { return; }
            listBoxMetodosUsados.Items.Remove(listBoxMetodosUsados.SelectedItem);

            if(listBoxMetodosUsados.Items.Count == 0) 
            {
                listBoxPayment.Visible = true;
                labelinfo.Visible = false;
            }

            decimal novoTotal = Convert.ToDecimal(labelValor.Text) + pagamento.Valor;

            labelValor.Text = Convert.ToString(novoTotal);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowMenuForm(new History());
        }

        private void ShowMenuForm(Form form)
        {
            form.Show();
            this.Close();
        }


    }
}
