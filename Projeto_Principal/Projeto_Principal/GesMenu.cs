using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Principal
{
    public partial class GesMenu : Form
    {
        bool mouseDown;
        private Point offset;

        public GesMenu()
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

        private void buttonAddEngrediente_Click(object sender, EventArgs e)
        {
            if(txtIngredientes.Text.Trim() == "") { return; };

            listBoxIngredientes.Items.Add(txtIngredientes.Text);


        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)comboBoxCategoria.SelectedItem;
            string ingredientes = "";
            ItemMenu itemMenu = new ItemMenu();
            itemMenu.Nome = txtNome.Text;
            itemMenu.Preco = Convert.ToDecimal(txtPreco.Text);
            itemMenu.Ativo = false;
            itemMenu.CategoriaId = categoria.Id;
            var filepath = Path.GetDirectoryName(labelpath.Text);
            
            

            itemMenu.Fotografia = "a";

            foreach (string item in listBoxIngredientes.Items)
            {
                if(item.Trim() == "") { return;}
                
                ingredientes = ingredientes + item + ", ";

            }

            itemMenu.Ingredientes = ingredientes;
            itemMenu.CategoriaId = categoria.Id;

            listBoxPratosInativos.Items.Add(itemMenu);
            


        }

        private void GesMenu_Load(object sender, EventArgs e)
        {
            Model1Container model = new Model1Container();
            comboBoxCategoria.DataSource = model.Categoria.ToList<Categoria>();

            //falta filtrar nao ativos
            listBoxPratosInativos.DataSource = model.ItemMenu.ToList<ItemMenu>();
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "";
            openFileDialog.Title = "Images";
            openFileDialog.Filter = "All Images|*.jpg; *.bmp; *.png";
            openFileDialog.ShowDialog(this);

            if (openFileDialog.FileName.ToString() != "")  
            {
                labelpath.Text = openFileDialog.FileName.ToString();
            }
            


        }
    }
}
