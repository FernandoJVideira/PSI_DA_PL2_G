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
    public partial class GesRestaurantGlobal : Form
    {
        bool mouseDown;
        private Point offset;
        private Model1Container model;
        
        public GesRestaurantGlobal()
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

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            model = new Model1Container();
            Restaurante tempRestaurante = new Restaurante();
            Morada tempMorada = new Morada();

            tempMorada.Rua = txtRua.Text;
            tempMorada.Cidade = txtCidade.Text;
            tempMorada.Pais = txtPais.Text;
            tempMorada.CodPostal = txtPostalCod.Text;

            tempRestaurante.Nome = txtNome.Text;
            tempRestaurante.Morada = tempMorada;

            model.Restaurante.Add(tempRestaurante);
            model.Morada.Add(tempMorada);

            model.SaveChanges();

            dataGridViewRestaurante.DataSource = model.Restaurante.ToList<Restaurante>();

        }

        public void LerDados()
        {
            dataGridViewRestaurante.DataSource = model.Restaurante.ToList<Restaurante>();
        }

        private void GesRestaurantGlobal_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
            cbDisponibilidadeCategoria.SelectedIndex = 0;
            cbDisponibilidadeMetodoPagamento.SelectedIndex = 0;
        }

        public void LerDados()
        {
            dgvRestaurantes.DataSource = model.Restaurante.ToList<Restaurante>();
            dgvCategorias.DataSource = model.Categoria.ToList<Categoria>();
            dgvMetodosPagamento.DataSource = model.MetodoPagamento.ToList<MetodoPagamento>();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;

                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                if(nome.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "") { throw new Exception("Preencha todos os campos"); }

                Restaurante restaurante = new Restaurante();
                Morada morada = new Morada();

                morada.Rua = rua;
                morada.Cidade = cidade;
                morada.Pais = pais;
                morada.CodPostal = codpostal;

                restaurante.Nome = txtNome.Text;
                restaurante.Morada = morada;

                model.Restaurante.Add(restaurante);
                model.Morada.Add(morada);

                model.SaveChanges();
                LerDados();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }           
        }

        private void btnRegistarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeCategoria.Text;
                string disponibilidade = cbDisponibilidadeCategoria.Text;

                if (nome.Trim() == "" || disponibilidade.Trim() == "") { throw new Exception("Preencha todos os campos"); }

                Categoria categoria = new Categoria();
                categoria.Nome = nome;
                categoria.Ativo = disponibilidade == "Disponível" ? true : false;

                model.Categoria.Add(categoria);

                model.SaveChanges();
                LerDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistarMetodoPagamento_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeMetodoPagamento.Text;
                string disponibilidade = cbDisponibilidadeMetodoPagamento.Text;

                if (nome.Trim() == "" || disponibilidade.Trim() == "") { throw new Exception("Preencha todos os campos"); }

                MetodoPagamento metodoPagamento = new MetodoPagamento();
                metodoPagamento.Nome = nome;
                metodoPagamento.Ativo = disponibilidade == "Disponível" ? true : false;

                model.MetodoPagamento.Add(metodoPagamento);

                model.SaveChanges();
                LerDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
