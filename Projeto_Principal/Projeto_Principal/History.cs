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
        public History()
        {
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

                foreach (Pedido pedido in listaPedidos)
                {
                    listBoxHistory.Items.Add(pedido);
                }

            }
            else
            {
                decimal total = 0;
                Cliente cliente = (Cliente)model.Pessoa.Find(id);
                List<Pedido> listaPedidos = model.Pedido.ToList<Pedido>();

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

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            id = 0;
            this.Close();
           
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
    }
}
