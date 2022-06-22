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
    public partial class History : Form
    {

        private Model1Container model;
        public static int id;
        Form menu = null;

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
        public History(Form prevMenu)
        {
            menu = prevMenu;
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            if(id == 0)
            {
                label1.Text = "Lista de Pedidos";
                labelTotal.Visible = false;

                List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();

                IEnumerable<Pedido> pedidosRestaurante = from pedido in listaPedidos
                                                         where pedido.RestauranteId == NewMenu.IdRestaurante
                                                         select pedido;

                foreach (Pedido pedido in pedidosRestaurante)
                {
                    listBoxHistory.Items.Add(pedido);
                }

                comboBoxEstados.DataSource = model.Estado.ToList<Estado>();
            

            }
            else
            {
                decimal total = 0;
                Cliente cliente = (Cliente)model.Pessoa.Find(id);
                List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();
                comboBoxEstados.Visible = false;

                IEnumerable<Pedido> Pedidos = from pedido in listaPedidos
                                                    where pedido.Cliente == cliente
                                                    select pedido;


                foreach (Pedido pedido in Pedidos)
                {

                    listBoxHistory.Items.Add(pedido);
                    total += pedido.ValorTotal;
                }


                label1.Text = "Lista de Pedidos do cliente "+ cliente.Nome;
                labelTotal.Visible = true;
                labelTotal.Text = total.ToString() + " €";
            }

            LoadTheme();
        }


        private void buttonView_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(listBoxHistory.SelectedItem == null) { return; }
            Pedido pedido = listBoxHistory.SelectedItem as Pedido;

            string currentDir = Environment.CurrentDirectory;

            string fileName = pedido.Id + ".txt";
            string path = currentDir + @"\pedidos\" + fileName;

            MessageBox.Show(System.IO.File.ReadAllText(path));
            
        }

        private void comboBoxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxEstados.SelectedItem == null) { return; }
            Estado estado = (Estado)comboBoxEstados.SelectedItem;
            List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();
            IEnumerable<Pedido> Pedidos = Enumerable.Empty<Pedido>();

            switch (estado.Id)
            {
                case 1:
                    Pedidos = from pedido in listaPedidos
                                                  where pedido.EstadoId == 1
                                                  select pedido;
                    break;

                case 2:
                    Pedidos = from pedido in listaPedidos
                              where pedido.EstadoId == 2
                              select pedido;
                    break;

                case 3:
                    Pedidos = from pedido in listaPedidos
                              where pedido.EstadoId == 3
                              select pedido;
                    break;

                case 4:
                    Pedidos = from pedido in listaPedidos
                              where pedido.EstadoId == 4
                              select pedido;
                    break;
            }

            listBoxHistory.Items.Clear();

            foreach (Pedido pedido in Pedidos)
            {
                listBoxHistory.Items.Add(pedido);
            }
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Show();
        }
    }
}
