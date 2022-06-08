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
            try
            {

                Morada moradaCliente = new Morada();
                Cliente cliente = new Cliente();

                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                string nif = txtNumCont.Text;
                string nome = txtNome.Text;
                string tele = txtTelemovel.Text;

                if (nome.Trim() == "" || nif.Trim() == "" || tele.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "") { throw new Exception("Preencha todos os campos"); }

                moradaCliente.Rua = rua;
                moradaCliente.Cidade = cidade;
                moradaCliente.Pais = pais;
                moradaCliente.CodPostal = codpostal;

                cliente.NIF = nif;
                cliente.TotalGasto = 0;
                cliente.Morada = moradaCliente;
                cliente.Nome = nome;
                cliente.Telemovel = tele;

                model.Morada.Add(moradaCliente);
                model.Pessoa.Add(cliente);

                model.SaveChanges();
                LerDados();
                ClearTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LerDados()
        {
            List<Cliente> listaCLientes = new List<Cliente>();

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if (pessoa is Cliente)
                {
                    Cliente cliente = (Cliente)pessoa;
                    listaCLientes.Add(cliente);
                }
            }
            dataGridViewCliente.DataSource = listaCLientes;
        }

        private void GesClientes_Load(object sender, EventArgs e)
        {
            dataGridViewCliente.ReadOnly = true;
            model = new Model1Container();
            LerDados();
            AjustDataColumns();
        }

        private void btnApagarCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetSelectedCliente();

            if (VerifyPresenceCliente(userdata))
            {
                MessageBox.Show("Não pode apagar o Cliente selecionado pois ele já efetuou um pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                model.Pessoa.Remove(userdata);
                model.SaveChanges();
                LerDados();

                ClearTxtBox();
            }



        }


        private bool VerifyPresenceCliente(Cliente cliente)
        {
            List<Pedido> pedidos = model.Pedido.ToList();

            foreach (Pedido pedido in pedidos)
            {
                if(pedido.Cliente == cliente)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            Cliente userdata = GetSelectedCliente();

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
                Cliente userdata = GetSelectedCliente();

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

        private Cliente GetSelectedCliente()
        {
            int row = dataGridViewCliente.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewCliente.Rows[row].Cells["id"].Value;
            Cliente data = model.Pessoa.First(c => c.Id == id) as Cliente;

            return data;
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
