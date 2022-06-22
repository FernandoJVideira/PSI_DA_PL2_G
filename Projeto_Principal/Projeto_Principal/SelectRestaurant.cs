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
        private Model1Container model;
        public SelectRestaurant()
        {
            InitializeComponent();
        }

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

        //-------------------------------------------------------------------------------------//

        private void SelectRestaurant_Load(object sender, EventArgs e)
        {
            model = new Model1Container();
            LerDados();
            LoadTheme();
        }

        public void LerDados()
        {
            listBoxRestaurantes.DataSource = model.Restaurante.ToList<Restaurante>();
        }

        private void btnGerir_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = (Restaurante)listBoxRestaurantes.SelectedItem;
            
            if(restaurante != null)
            {
                NewMenu.IdRestaurante = restaurante.Id;
                GesMenu.IdRestaurante = restaurante.Id;
                MessageBox.Show($"Restaurante {restaurante.Nome} Selecionado", "Seleção com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não existem restaurantes registados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
