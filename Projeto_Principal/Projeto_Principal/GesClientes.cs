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
            model = new Model1Container();
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

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            Morada moradaCliente = new Morada();
            Cliente cliente = new Cliente();

            moradaCliente.Rua = txtRua.Text;
            moradaCliente.Cidade = txtCidade.Text;
            moradaCliente.Pais = txtPais.Text;
            moradaCliente.CodPostal = txtPostalCod.Text;

            cliente.NIF = txtNumCont.Text;
            cliente.TotalGasto = 0;
            cliente.Morada = moradaCliente;
            cliente.Nome = txtNome.Text;
            cliente.Telemovel = txtTelemovel.Text;

            model.Morada.Add(moradaCliente);
            model.Pessoa.Add(cliente);

            model.SaveChanges();
            LerDados();
            ClearTxtBox();
        }

        //-------------------------------------------------------------------------------------//

        private void MouseDown_Event(object sender, MouseEventArgs e)
        public void LerDados()
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

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

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            dataGridViewCliente.ReadOnly = true;
            model = new Model1Container();
            LerDados();
            AjustDataColumns();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetCliente();
            model.Pessoa.Remove(userdata);
            model.SaveChanges();
            dataGridViewCliente.DataSource = model.Pessoa.ToList();

            ClearTxtBox();
        }
        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetCliente();

            userdata.Nome = txtNome.Text;
            userdata.Telemovel = txtTelemovel.Text;
            userdata.Morada.Cidade = txtCidade.Text;
            userdata.NIF = txtNumCont.Text;
            userdata.Morada.CodPostal = txtPostalCod.Text;
            userdata.Morada.Rua = txtRua.Text;
            userdata.Morada.Pais = txtPais.Text;

            model.SaveChanges();

            LerDados();
        }
        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cliente userdata = GetCliente();

                txtNome.Text = userdata.Nome;
                txtTelemovel.Text = userdata.Telemovel;
                txtCidade.Text = userdata.Morada.Cidade;
                txtNumCont.Text = userdata.NIF;
                txtPostalCod.Text = userdata.Morada.CodPostal;
                txtRua.Text = userdata.Morada.Rua;
                txtPais.Text = userdata.Morada.Pais;
            }
            catch { }
        }

        private void AjustDataColumns()
        {
            dataGridViewCliente.Columns["Id"].DisplayIndex = 0;
            dataGridViewCliente.Columns["Nome"].DisplayIndex = 1;
        }

        private void ClearTxtBox()
        {
            txtRua.Text = "";
            txtCidade.Text = "";
            txtPais.Text = "";
            txtPostalCod.Text = "";
            txtNumCont.Text = "";
            txtNome.Text = "";
            txtTelemovel.Text = "";
        }

        private Cliente GetCliente()
        {
            int clientID = (int)dataGridViewCliente.SelectedRows[0].Cells["id"].Value;
            Cliente userdata = model.Pessoa.First(c => c.Id == clientID) as Cliente;

            return userdata;
        }
    }
}
