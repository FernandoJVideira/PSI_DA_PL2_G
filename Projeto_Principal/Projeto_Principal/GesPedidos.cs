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
        private Model1Container model;
        private NewMenu menu = null;
        private Button gesRestaurant, gesClientes, gesGlobal, gesMenu;
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        public GesPedidos(NewMenu prevMenu, Button btnGesRestaurant, Button btnGesClientes, Button btnGesRestaurantGlobal, Button btnGesMenu)
        {
            menu = prevMenu;
            gesRestaurant = btnGesRestaurant;
            gesClientes = btnGesClientes;
            gesGlobal = btnGesRestaurantGlobal;
            gesMenu = btnGesMenu;

            InitializeComponent();
        }

        private void RefreshPedidos()
        {
            listBoxPayment.Items.Clear();
            listBoxProcessing.Items.Clear();

            if(model.Pedido == null) { return; }

            List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();


            IEnumerable<Pedido> PedidosAndando = from pedido in listaPedidos
                                                 where pedido.EstadoId == 1
                                                 where pedido.RestauranteId == NewMenu.IdRestaurante
                                                 select pedido;

            foreach (Pedido pedido in PedidosAndando)
            {
                listBoxProcessing.Items.Add(pedido);
            }

            //---pedidos por pagar

            IEnumerable<Pedido> PedidosPorPagar = from pedido in listaPedidos
                                                  where pedido.EstadoId == 2
                                                  where pedido.RestauranteId == NewMenu.IdRestaurante
                                                  select pedido;

            foreach (Pedido pedido in PedidosPorPagar)
            {
                listBoxPayment.Items.Add(pedido);
            }
        }

        private void Erro(string msg)
        {
            MessageBox.Show(msg);
        }

        private void LerDados()
        {
            model = new Model1Container();
            Restaurante restaurante = model.Restaurante.Find(NewMenu.IdRestaurante);
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
                    listBoxClientes.Items.Add(cliente);
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
            LerDados();
            LoadTheme();

            if (listBoxTrabalhadores.Items.Count == 0)
            {
                Erro("Não existem trabalhadores registados");
                menu.OpenChildForm(new GerirRestaurante(), gesRestaurant);
            }
            else if (listBoxClientes.Items.Count == 0)
            {
                Erro("Não existem clientes registados");
                menu.OpenChildForm(new GesClientes(), gesClientes);
            }
            else if (listBoxMetodosUsados.Items.Count == 0)
            {
                Erro("Não existem metodos de pagamento registados ou ativos");
                menu.OpenChildForm(new GesRestaurantGlobal(), gesGlobal);
            }
            else if (listBoxItems.Items.Count == 0)
            {
                Erro("Não existem pratos registados ou ativos");
                menu.OpenChildForm(new GesMenu(menu, gesGlobal), gesMenu);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listBoxClientes.SelectedItem;

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
            pedido.Cliente = cliente;

            if (pedido.Cliente == null) { return; }
            
            pedido.EstadoId = 1;

            pedido.RestauranteId = NewMenu.IdRestaurante;
            
            
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

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if(listBoxMenu.SelectedItem == null){ return; }

            listBoxItems.Items.Add(listBoxMenu.SelectedItem);
            listBoxMenu.SelectedItem = null;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (listBoxProcessing.SelectedItem == null) { return; }
            Pedido pedido = (Pedido)listBoxProcessing.SelectedItem;
            listBoxProcessing.Items.Remove(listBoxProcessing.SelectedItem);
            pedido.EstadoId = 3;
            model.SaveChanges();
            ChangeFile(pedido);
            RefreshPedidos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (listBoxProcessing.SelectedItem == null) { return; }
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
            if(listBoxPayment.SelectedItem == null) 
            { 
                MessageBox.Show("Selecione um pedido antes de fazer uma pagamento!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            Pedido pedido = (Pedido)listBoxPayment.SelectedItem;
            decimal Total = Convert.ToDecimal(labelValor.Text);


            try
            {
                pagamento.Valor = Convert.ToDecimal(textBoxValor.Value);
                pagamento.MetodoPagamento = (MetodoPagamento)comboBox1.SelectedItem;
                pagamento.PedidoId = pedido.Id;

                if (Total < textBoxValor.Value || 0 >= textBoxValor.Value)
                {
                    MessageBox.Show("Valor introduzido acima do valor do pedido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                decimal Restante = Convert.ToDecimal(labelValor.Text) - pagamento.Valor;

                labelValor.Text = Restante.ToString();
                listBoxMetodosUsados.Items.Add(pagamento);
                listBoxPayment.Visible = false;
                labelinfo.Visible = true;
                textBoxValor.Value = 0;

            }
            catch (Exception)
            {

                MessageBox.Show("Introduza um valor válido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
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
            Form menu = this.Parent.FindForm();
            Form form = new History(menu);
            form.Show();
            menu.Hide();
        }
    }
}
