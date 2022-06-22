using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Principal
{
    public partial class NewMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public static int IdRestaurante = 0;
        Model1Container model = new Model1Container();

        public NewMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChild.Visible = false;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    CheckID();
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
                    topPanel.BackColor = color;
                    LogoPanel.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChild.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in menuPanel.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.formPanel.Controls.Add(childForm);
            this.formPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnGesPedidos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GesPedidos(), sender);
        }

        private void btnGesMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GesMenu(), sender);
        }

        private void btnGesRestaurant_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GerirRestaurante(), sender);
        }

        private void btnGesRestaurantGlobal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GesRestaurantGlobal(), sender);
        }

        private void btnSelectRestaurante_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectRestaurant(), sender);
        }

        private void btnGesClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GesClientes(), sender);
        }

        private void NewMenu_Load(object sender, EventArgs e)
        {
            string currentDir = Environment.CurrentDirectory;
            System.IO.Directory.CreateDirectory(currentDir + @"\pedidos");

            List<Estado> estados = model.Estado.ToList<Estado>();

            if (estados.Count == 0)
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
                            break;
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
        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            CheckID();
            DisableButton();
            lblTitle.Text = "MENU";
            topPanel.BackColor = Color.FromArgb(0, 150, 136);
            LogoPanel.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChild.Visible = false;
        }

        private void CheckID()
        {
            if (IdRestaurante != 0)
            {
                Model1Container model1 = new Model1Container();
                Restaurante restaurante = model1.Restaurante.Find(IdRestaurante);
                btnGesPedidos.Enabled = true;
                btnGesRestaurant.Enabled = true;
                btnGesMenu.Enabled = true;

                lblNomeRestaurante.Text = restaurante.Nome;
                lblDesc.Visible = false;
            }
        }
<<<<<<< Updated upstream
=======

        private void NewMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btmMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
>>>>>>> Stashed changes
    }
}
