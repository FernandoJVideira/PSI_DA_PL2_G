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
    public partial class MainMenu : Form
    {
        bool mouseDown;
        private Point offset;
        public static int IdRestaurate = 0;
        Model1Container model = new Model1Container();

        public MainMenu()
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
            DialogResult result = MessageBox.Show("Pretende sair do programa?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSelectRestaurante_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new SelectRestaurant());
        }

        private void btnGesRestaurantGlobal_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new GesRestaurantGlobal());
        }

        private void buttonGesClientes_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new GesClientes());
        }

        private void buttonGesMenu_Click(object sender, EventArgs e)
        {
            try
            {
                List<Categoria> categorias = model.Categoria.ToList<Categoria>();
                if (categorias.Count == 0) { throw new Exception("Não existem categorias de pratos registadas"); }

                ShowMenuForm(new GesMenu());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShowMenuForm(new GesRestaurantGlobal());

            }
        }

        private void buttonGesPedidos_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new GesPedidos());
        }

        private void buttonGesRestaurant_Click(object sender, EventArgs e)
        {
            ShowMenuForm(new GerirRestaurante());
        }

        private void ShowMenuForm(Form form)
        {
            form.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            List<Estado> estados = model.Estado.ToList<Estado>();

            if(estados.Count == 0)
            {
                for (int i = 1; i < 5; i++)
                {
                    Estado estado = new Estado();
                    estado.Id = i;

                    switch (i)
                    {
                        case 1:
                            estado.Pronto = "Recebido";
                            break;
                        case 2:
                            estado.Pronto = "Em Processamento";
                            break ;
                        case 3:
                            estado.Pronto = "Cancelado";
                            break;
                        case 4:
                            estado.Pronto = "Concluido";
                            break;
                    }
                    model.Estado.Add(estado);
                }
                model.SaveChanges();
            }

            if (IdRestaurate != 0)
            {
                Model1Container model1 = new Model1Container();
                Restaurante restaurante = model1.Restaurante.Find(IdRestaurate);
                btnGesPedidos.Enabled = true;
                btnGesRestaurant.Enabled = true;
                btnGesMenu.Enabled = true;

                lblNomeRestaurante.Text = restaurante.Nome;
            }

        }

    }
}
