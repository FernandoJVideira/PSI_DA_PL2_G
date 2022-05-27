using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Projeto_Principal
{
    public partial class GesClientes : Form
    {
        bool mouseDown;
        private Point offset;
        private Model1Container model;

        public GesClientes()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            model = new Model1Container();
            Morada tempMorada = new Morada();
            Cliente cliente = new Cliente();

            tempMorada.Rua = txtRua.Text;
            tempMorada.Cidade = txtCidade.Text;
            tempMorada.Pais = txtPais.Text;
            tempMorada.CodPostal = txtPostalCod.Text;


            
            cliente.NIF = txtNumCont.Text;
            cliente.TotalGasto = 0;
            cliente.Morada = tempMorada;
            cliente.Nome = txtNome.Text;
            cliente.Telemovel = txtTelemovel.Text;

            model.Morada.Add(tempMorada);
            model.Pessoa.Add(cliente);

            model.SaveChanges();
            LerDados();
            
            
        }

        public void LerDados()
        {
            List<Cliente> listaCLientes = new List<Cliente>();

            model = new Model1Container();

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if(pessoa is Cliente)
                {
                    Cliente cliente = (Cliente)pessoa;
                    listaCLientes.Add(cliente);
                }
                
            }
            
            dataGridViewCliente.DataSource = listaCLientes;

        }

        private void GesClientes_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
            



        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {



        }
    }
}
