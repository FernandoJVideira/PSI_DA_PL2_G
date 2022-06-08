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
    public partial class GerirRestaurante : Form
    {
        bool mouseDown;
        private Point offset;
        private Model1Container model;

        public GerirRestaurante()
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

        //-------------------------------------------------------------------------------------//

        private void listBoxTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GerirRestaurante_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
        }

        public void LerDados()
        {
            
            List<Trabalhador> listaTrabalhadores = new List<Trabalhador>();

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if (pessoa is Trabalhador)
                {
                    Trabalhador trabalhador = (Trabalhador)pessoa;
                    if(trabalhador.RestauranteId == MainMenu.IdRestaurate)
                    {
                        listaTrabalhadores.Add(trabalhador);

                    }
                }

                // falta verificar se pertence ao restaurante selecionado
            }

            dataGridViewTrabalhadores.DataSource = listaTrabalhadores;
        }

        private void btnAddTrabalhador_Click(object sender, EventArgs e)
        {
            Morada morada = new Morada();
            Trabalhador trabalhador = new Trabalhador();

            try
            {
                morada.Rua = txtRua.Text;
                morada.Cidade = txtCidade.Text;
                morada.Pais = txtPais.Text;
                morada.CodPostal = txtPostalCod.Text;
                
                trabalhador.Posicao = txtPosicao.Text;
                trabalhador.Salario = Convert.ToDecimal(txtSalario.Text);
                trabalhador.Morada = morada;
                trabalhador.Nome = txtNome.Text;
                trabalhador.Telemovel = txtTelemovel.Text;
                trabalhador.RestauranteId = MainMenu.IdRestaurate;

                model.Morada.Add(morada);
                model.Pessoa.Add(trabalhador);

                model.SaveChanges();
                LerDados();
            }
            catch (Exception)
            {
                MessageBox.Show("Salario invalido!!");
            }
        }

        private Trabalhador GetSelectedTrabalhador()
        {
            int row = dataGridViewTrabalhadores.SelectedCells[0].RowIndex;
            int id = (int)dataGridViewTrabalhadores.Rows[row].Cells["id"].Value;
            Trabalhador data = model.Pessoa.First(c => c.Id == id) as Trabalhador;

            return data;
        }

        private void txtRemove_Click(object sender, EventArgs e)
        {
            Trabalhador trabalhador = GetSelectedTrabalhador();

            if (VerifyPresence(trabalhador))
            {
                MessageBox.Show("Não pode apagar o Trabalhador pois ele já efetuou um pedido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Pessoa.Remove(trabalhador);
                model.SaveChanges();
                LerDados();
            }
        }

        private bool VerifyPresence(Trabalhador trabalhador)
        {
            List<Pedido> pedidos = model.Pedido.ToList<Pedido>();

            foreach (Pedido pedido in pedidos)
            {
                if(pedido.Trabalhador == trabalhador)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
