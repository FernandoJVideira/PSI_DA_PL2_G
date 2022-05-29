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
    public partial class SelectRestaurant : Form
    {
        bool mouseDown;
        private Point offset;
        private Model1Container model;
        public SelectRestaurant()
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

        private void SelectRestaurant_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
        }

        public void LerDados()
        {
            listBoxRestaurantes.DataSource = model.Restaurante.ToList<Restaurante>();
        }

        private void btnGerir_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            
            MainMenu.IdRestaurate = restaurante.Id;
            new MainMenu().Show();
            this.Close();
        }

        private void listBoxRestaurantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
