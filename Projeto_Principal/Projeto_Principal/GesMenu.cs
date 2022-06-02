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
        private Model1Container model;
        private static string filepath = "";

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

        private void Lerdados()
        {
            listBoxMenu.Items.Clear();
            listBoxPratosInativos.Items.Clear();
            model = new Model1Container();
            List<ItemMenu> items = model.ItemMenu.ToList<ItemMenu>();

            IEnumerable<ItemMenu> itemsInativos = from item in items
                                                  where item.Ativo == false
                                                  select item;


            foreach (ItemMenu item in itemsInativos)
            {
                listBoxPratosInativos.Items.Add(item);
            }


            IEnumerable<ItemMenu> itemsAtivos = from item in items
                                                  where item.Ativo == true
                                                  select item;

            foreach (ItemMenu item in itemsAtivos)
            {
                listBoxMenu.Items.Add(item);
            }

            comboBoxCategoria.DataSource = model.Categoria.ToList<Categoria>();



        }

        private void buttonAddEngrediente_Click(object sender, EventArgs e)
        {
            if(txtIngredientes.Text.Trim() == "") { return; };

            listBoxIngredientes.Items.Add(txtIngredientes.Text);

            txtIngredientes.Clear();


        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {

            Categoria categoria = (Categoria)comboBoxCategoria.SelectedItem;
            string ingredientes = "";
            ItemMenu itemMenu = new ItemMenu();
            Restaurante restaurante = model.Restaurante.Find(MainMenu.IdRestaurate);


            itemMenu.Nome = txtNome.Text;
            itemMenu.Preco = Convert.ToDecimal(txtPreco.Text);
            itemMenu.Ativo = false;
            itemMenu.CategoriaId = categoria.Id;
            itemMenu.Restaurante.Add(restaurante);

            byte [] imageBytes = File.ReadAllBytes(filepath);


            itemMenu.Fotografia = imageBytes;

            foreach (string item in listBoxIngredientes.Items)
            {
                if(item.Trim() == "") { return;}
                
                ingredientes = ingredientes + item + ", ";

            }

            ingredientes = ingredientes.Remove(ingredientes.Length - 2);
            itemMenu.Ingredientes = ingredientes;
            itemMenu.CategoriaId = categoria.Id;

            model.ItemMenu.Add(itemMenu);
            model.SaveChanges();

            Lerdados();
        }

        private void GesMenu_Load(object sender, EventArgs e)
        {
            Lerdados();
        }

        private string getPath(string path)
        {
            return path;
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
                filepath = openFileDialog.FileName.ToString();
            }



        }

        private void buttonRemvEngrediente_Click(object sender, EventArgs e)
        {
            listBoxIngredientes.Items.Remove(listBoxIngredientes.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxPratosInativos.SelectedItem;
            listBoxMenu.Items.Add(item);
            listBoxPratosInativos.Items.Remove(listBoxPratosInativos.SelectedItem);

            item.Ativo = true;
            model.SaveChanges();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxMenu.SelectedItem;
            listBoxPratosInativos.Items.Add(item);
            listBoxMenu.Items.Remove(listBoxMenu.SelectedItem);

            item.Ativo = false;
            model.SaveChanges();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxPratosInativos.SelectedItem;

            txtNome.Text = item.Nome;
            txtPreco.Text = item.Preco.ToString();
            comboBoxCategoria.SelectedItem = item.CategoriaId;
            string[] ingredientes = item.Ingredientes.Split(',');

            foreach (string ingrediente in ingredientes)
            {
                listBoxIngredientes.Items.Add(ingrediente.Trim());
            }
        }

        private void listBoxPratosInativos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ItemMenu menuItem = (ItemMenu)listBoxPratosInativos.SelectedItem;
            string ingredientes = "";

            menuItem.Nome = txtNome.Text;
            menuItem.Preco = Convert.ToDecimal(txtPreco.Text);
            
            foreach (string item in listBoxIngredientes.Items)
            {
                if (item.Trim() == "") { return; }

                ingredientes = ingredientes + item + ", ";

            }

            ingredientes = ingredientes.Remove(ingredientes.Length - 2);
            menuItem.Ingredientes = ingredientes;
        }
    }
}
