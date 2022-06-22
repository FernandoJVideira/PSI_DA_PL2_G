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
            }

            dataGridViewTrabalhadores.DataSource = listaTrabalhadores;
        }

        private void btnAddTrabalhador_Click(object sender, EventArgs e)
        {
            Morada morada = new Morada();
            Trabalhador trabalhador = new Trabalhador();

            try
            {
                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                string nome = txtNome.Text;
                string tele = txtTelemovel.Text;
                string posicao = txtPosicao.Text;

                if (nome.Trim() == "" || tele.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "" || posicao.Trim() == "") { throw new Exception("Preencha todos os campos"); }
                if (!txtPostalCod.MaskCompleted) { txtPostalCod.Focus(); throw new Exception("Preencha corretamente o código postal"); }
                if (!txtTelemovel.MaskCompleted) { txtTelemovel.Focus(); throw new Exception("Preencha corretamente o número de telemóvel"); }

                morada.Rua = rua;
                morada.Cidade = cidade;
                morada.Pais = pais;
                morada.CodPostal = codpostal;
                trabalhador.Posicao = posicao;

                trabalhador.Salario = txtSalario.Value;
                trabalhador.Morada = morada;
                trabalhador.Nome = nome;
                trabalhador.Telemovel = tele;
                trabalhador.RestauranteId = NewMenu.IdRestaurante;

                model.Morada.Add(morada);
                model.Pessoa.Add(trabalhador);

                model.SaveChanges();
                LerDados();
                ClearTxb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Trabalhador GetSelectedTrabalhador()
        {
            try
            {
                int row = dataGridViewTrabalhadores.SelectedCells[0].RowIndex;
                int id = (int)dataGridViewTrabalhadores.Rows[row].Cells["id"].Value;
                Trabalhador data = model.Pessoa.First(c => c.Id == id) as Trabalhador;

                return data;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione um Funcionário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
            try
            {
                Trabalhador userdata = GetSelectedTrabalhador();
                if(userdata == null) { return; }

                string rua = txtRua.Text;
                string cidade = txtCidade.Text;
                string pais = txtPais.Text;
                string codpostal = txtPostalCod.Text;

                string nome = txtNome.Text;
                string tele = txtTelemovel.Text;
                string posicao = txtPosicao.Text;

                if (nome.Trim() == "" || tele.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "" || posicao.Trim() == "") { throw new Exception("Preencha todos os campos"); }
                if (!txtPostalCod.MaskCompleted) { txtPostalCod.Focus(); throw new Exception("Preencha corretamente o código postal"); }
                if (!txtTelemovel.MaskCompleted) { txtTelemovel.Focus(); throw new Exception("Preencha corretamente o número de telemóvel"); }

                userdata.Morada.Rua = rua;
                userdata.Morada.Cidade = cidade;
                userdata.Morada.Pais = pais;
                userdata.Morada.CodPostal = codpostal;
                userdata.Posicao = posicao;

                userdata.Salario = txtSalario.Value;
                userdata.Nome = nome;
                userdata.Telemovel = tele;
                userdata.RestauranteId = NewMenu.IdRestaurante;

                model.SaveChanges();

                LerDados();
                ClearTxb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
