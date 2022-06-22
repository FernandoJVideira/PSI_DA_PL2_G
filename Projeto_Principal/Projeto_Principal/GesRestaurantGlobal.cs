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

        private Model1Container model;

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
        public GesRestaurantGlobal()
        {
            InitializeComponent();
        }

        private void GesRestaurantGlobal_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
            cbDisponibilidadeCategoria.SelectedIndex = 0;
            cbDisponibilidadeMetodoPagamento.SelectedIndex = 0;
            LoadTheme();
        }

        public void LerDados()
        {
            listBoxRestaurantes.DataSource = model.Restaurante.ToList<Restaurante>();
            listBoxCat.DataSource = model.Categoria.ToList<Categoria>();
            listBoxMetodosPag.DataSource = model.MetodoPagamento.ToList<MetodoPagamento>();
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

                if (nome.Trim() == "" || rua.Trim() == "" || cidade.Trim() == "" || pais.Trim() == "" || codpostal.Trim() == "") { throw new Exception("Preencha todos os campos"); }

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

        private void btnRemoverRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;

            if (VerifyPresenceRestaurante(restaurante))
            {
                MessageBox.Show("Não pode apagar o Restaurante selecionado pois está a ser utlizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.Morada.Remove(restaurante.Morada);
                model.Restaurante.Remove(restaurante);
                model.SaveChanges();

                LerDados();
            }

        }


        private bool VerifyPresenceRestaurante(Restaurante restaurante)
        {
            List<Pessoa> pessoas = model.Pessoa.ToList<Pessoa>();
            List<Pedido> pedidos = model.Pedido.ToList<Pedido>();
            
            foreach (Pessoa pessoa in pessoas)
            {
                if(pessoa is Trabalhador)
                {
                    Trabalhador trabalhador = (Trabalhador)pessoa;

                    if(trabalhador.RestauranteId == restaurante.Id)
                    {
                        return true;
                        
                    }
                }
            }

            foreach (Pedido pedido in pedidos)
            {
                if(pedido.RestauranteId == restaurante.Id)
                {
                    return true;
                }
            }


            if (restaurante.Id == NewMenu.IdRestaurante)
            {
                return true;
            }
            

            return false;
        }


        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBoxCat.SelectedItem;

            if (VerifyPresenceCategoria(categoria))
            {
                MessageBox.Show("Não pode apagar a Categoria selecionada pois está a ser utlizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                model.Categoria.Remove(categoria);
                model.SaveChanges();

                LerDados();
            }


        }

        private bool VerifyPresenceCategoria(Categoria categoria)
        {
            List<ItemMenu> lista = model.ItemMenu.ToList();

            foreach (ItemMenu item in lista)
            {
                if(item.CategoriaId == categoria.Id)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnRemoverMetodoPagamento_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBoxMetodosPag.SelectedItem;

            if (VerifyPresenceMetodo(metodoPagamento))
            {
                MessageBox.Show("Não pode apagar o Metodo de Pagamento selecionado pois está a ser utlizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.MetodoPagamento.Remove(metodoPagamento);
                model.SaveChanges();

                LerDados();
            }
        }

        private bool VerifyPresenceMetodo(MetodoPagamento metodoP)
        {
            List<Pagamento> pagamentos = model.Pagamento.ToList();

            foreach (Pagamento pagamento in pagamentos)
            {
                if(pagamento.MetodoPagamento == metodoP)
                {
                    return true;
                }
            }

            return false;
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            Morada morada = restaurante.Morada;

            txtNome.Text = restaurante.Nome;
            txtRua.Text = morada.Rua;
            txtCidade.Text = morada.Cidade;
            txtPostalCod.Text = morada.CodPostal;
            txtPais.Text = morada.Pais;
        }

        private void listBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBoxCat.SelectedItem;

            txtNomeCategoria.Text = categoria.Nome;
            cbDisponibilidadeCategoria.Text = categoria.Ativo == true ? "Disponível" : "Indisponível";
        }

        private void listBoxMetodosPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBoxMetodosPag.SelectedItem;

            txtNomeMetodoPagamento.Text = metodoPagamento.Nome;
            cbDisponibilidadeMetodoPagamento.Text = metodoPagamento.Ativo == true ? "Disponível" : "Indisponível";
        }

        private void btnSalvarRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            Morada morada = restaurante.Morada;

            restaurante.Nome = txtNome.Text;
            morada.Rua = txtRua.Text;
            morada.Cidade = txtCidade.Text;
            morada.CodPostal = txtPostalCod.Text;
            morada.Pais = txtPais.Text;

            model.SaveChanges();
            LerDados();
        }

        private void btnSalvarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)listBoxCat.SelectedItem;

            categoria.Nome = txtNomeCategoria.Text;
            categoria.Ativo = cbDisponibilidadeCategoria.Text == "Disponível" ? true : false;

            model.SaveChanges();
            LerDados();
        }

        private void btnSalvarMetodoPagamento_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = (MetodoPagamento)listBoxMetodosPag.SelectedItem;

            metodoPagamento.Nome = txtNomeMetodoPagamento.Text;
            metodoPagamento.Ativo = cbDisponibilidadeMetodoPagamento.Text == "Disponível" ? true : false;

            model.SaveChanges();
            LerDados();
        }
    }
}
