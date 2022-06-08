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

        //-------------------------------------------------------------------------------------//

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

        private Restaurante GetRestaurante()
        {
            int row = dgvRestaurantes.SelectedCells[0].RowIndex;
            int id = (int)dgvRestaurantes.Rows[row].Cells["id"].Value;
            Restaurante data = model.Restaurante.First(r => r.Id == id);

            return data;
        }

        private Categoria GetCategoria()
        {
            int row = dgvCategorias.SelectedCells[0].RowIndex;
            int id = (int)dgvCategorias.Rows[row].Cells["id"].Value;
            Categoria data = model.Categoria.First(c => c.Id == id);

            return data;
        }

        private MetodoPagamento GetMetodoPagamento()
        {
            int row = dgvMetodosPagamento.SelectedCells[0].RowIndex;
            int id = (int)dgvMetodosPagamento.Rows[row].Cells["id"].Value;
            MetodoPagamento data = model.MetodoPagamento.First(m => m.Id == id);

            return data;
        }

        private void btnRemoverRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = GetRestaurante();

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


            if (restaurante.Id == MainMenu.IdRestaurate)
            {
                return true;
            }
            

            return false;
        }


        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {         
            Categoria categoria = GetCategoria();

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
            MetodoPagamento metodoPagamento = GetMetodoPagamento();

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

        private void dgvRestaurantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Restaurante restaurante = GetRestaurante();
            Morada morada = restaurante.Morada;

            txtNome.Text = restaurante.Nome;
            txtRua.Text = morada.Rua;
            txtCidade.Text = morada.Cidade;
            txtPostalCod.Text = morada.CodPostal;
            txtPais.Text = morada.Pais;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Categoria categoria = GetCategoria();

            txtNomeCategoria.Text = categoria.Nome;
            cbDisponibilidadeCategoria.Text = categoria.Ativo == true ? "Disponível" : "Indisponível";
        }

        private void dgvMetodosPagamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MetodoPagamento metodoPagamento = GetMetodoPagamento();

            txtNomeMetodoPagamento.Text = metodoPagamento.Nome;
            cbDisponibilidadeMetodoPagamento.Text = metodoPagamento.Ativo == true ? "Disponível" : "Indisponível";
        }

        private void btnSalvarRestaurante_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = GetRestaurante();
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
            Categoria categoria = GetCategoria();

            categoria.Nome = txtNomeCategoria.Text;
            categoria.Ativo = cbDisponibilidadeMetodoPagamento.Text == "Disponível" ? true : false;

            model.SaveChanges();
            LerDados();
        }

        private void btnSalvarMetodoPagamento_Click(object sender, EventArgs e)
        {
            MetodoPagamento metodoPagamento = GetMetodoPagamento();

            metodoPagamento.Nome = txtNomeMetodoPagamento.Text;
            metodoPagamento.Ativo = cbDisponibilidadeMetodoPagamento.Text == "Disponível" ? true : false;

            model.SaveChanges();
            LerDados();
        }
    }
}
