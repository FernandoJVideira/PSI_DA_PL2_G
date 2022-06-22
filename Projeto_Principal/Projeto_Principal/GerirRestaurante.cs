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
        private Model1Container model;

        public GerirRestaurante()
        {
            InitializeComponent();
        }

        private void listBoxTrabalhadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GerirRestaurante_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
            AjustDataColumns();
        }

        public void LerDados()
        {
            
            List<Trabalhador> listaTrabalhadores = new List<Trabalhador>();

            foreach (Pessoa pessoa in model.Pessoa)
            {
                if (pessoa is Trabalhador)
                {
                    Trabalhador trabalhador = (Trabalhador)pessoa;
                    if(trabalhador.RestauranteId == NewMenu.IdRestaurante)
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

                string texto = txtSalario.Text;
                texto = texto.Replace(".", ",");
                trabalhador.Salario = Convert.ToDecimal(texto);
                trabalhador.Morada = morada;
                trabalhador.Nome = txtNome.Text;
                trabalhador.Telemovel = txtTelemovel.Text;
                trabalhador.RestauranteId = NewMenu.IdRestaurante;

                model.Morada.Add(morada);
                model.Pessoa.Add(trabalhador);

                model.SaveChanges();
                LerDados();
                ClearTxb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            ClearTxb();
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

        private void AjustDataColumns()
        {
            dataGridViewTrabalhadores.Columns["Id"].DisplayIndex = 0;
            dataGridViewTrabalhadores.Columns["Nome"].DisplayIndex = 1;
        }

        private void btnAtualizarDados_Click(object sender, EventArgs e)
        {
            Trabalhador userdata = GetSelectedTrabalhador();

            userdata.Nome = txtNome.Text;
            userdata.Telemovel = txtTelemovel.Text;
            userdata.Morada.Cidade = txtCidade.Text;


            string texto = txtSalario.Text;
            texto = texto.Replace(".", ",");
            userdata.Salario = Convert.ToDecimal(texto);

            userdata.Posicao = txtPosicao.Text;

            userdata.Morada.CodPostal = txtPostalCod.Text;
            userdata.Morada.Rua = txtRua.Text;
            userdata.Morada.Pais = txtPais.Text;

            model.SaveChanges();

            LerDados();
            ClearTxb();
        }

        private void dataGridViewTrabalhadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Trabalhador userdata = GetSelectedTrabalhador();

                txtNome.Text = userdata.Nome;
                txtTelemovel.Text = userdata.Telemovel;
                txtCidade.Text = userdata.Morada.Cidade;

                txtPosicao.Text = userdata.Posicao;
                
                string texto = userdata.Salario.ToString();
                texto = texto.Replace(",", ".");
                txtSalario.Text = texto;
                
                
                txtPostalCod.Text = userdata.Morada.CodPostal;
                txtRua.Text = userdata.Morada.Rua;
                txtPais.Text = userdata.Morada.Pais;
            }
            catch { }
        }

        private void ClearTxb()
        {
           txtNome.Text = "";
           txtTelemovel.Text = "";
           txtCidade.Text = "";
           txtSalario.Text = "";
           txtPosicao.Text = "";
           txtPostalCod.Text = "";
           txtRua.Text = "";
           txtPais.Text = "";
        }
    }
}
