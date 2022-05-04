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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectRestaurant form = new SelectRestaurant();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GesRestaurantGlobal form = new GesRestaurantGlobal();
            form.ShowDialog();
            
        }

        private void buttonGesClientes_Click(object sender, EventArgs e)
        {
            GesClientes form = new GesClientes();
            form.ShowDialog();
        }

        private void buttonGesMenu_Click(object sender, EventArgs e)
        {
            GesMenu form = new GesMenu();
            form.ShowDialog();
        }

        private void buttonGesPedidos_Click(object sender, EventArgs e)
        {
            GesPedidos form = new GesPedidos();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGesRestaurant_Click(object sender, EventArgs e)
        {
            GerirRestaurante form = new GerirRestaurante();
            form.ShowDialog();
        }
    }
}
