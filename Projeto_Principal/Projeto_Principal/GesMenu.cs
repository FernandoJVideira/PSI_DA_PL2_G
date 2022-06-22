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
        private Model1Container model;
        private NewMenu menu = null;
        private Button gesBtn = null;
        private static string filepath = "";
        public static int IdRestaurante = 0;

        public GesMenu(NewMenu prevMenu, Button btn)
        {
            menu = prevMenu;
            gesBtn = btn;
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

        private void LerDados()
        {
            listBoxMenu.Items.Clear();
            listBoxPratosInativos.Items.Clear();
            model = new Model1Container();
            List<ItemMenu> items = model.ItemMenu.ToList<ItemMenu>();
            Restaurante restaurante = model.Restaurante.Find(NewMenu.IdRestaurante);

            IEnumerable <ItemMenu> itemsAtivos = from item in items
                                                where item.Restaurante.Contains(restaurante)
                                                select item;

            IEnumerable<ItemMenu> itemsInativos = model.ItemMenu.ToList<ItemMenu>().Except<ItemMenu>(itemsAtivos);

            foreach (ItemMenu item in itemsInativos)
            {
                listBoxPratosInativos.Items.Add(item);
            }

            foreach (ItemMenu item in itemsAtivos)
            {
                listBoxMenu.Items.Add(item);
            }

            comboBoxCategoria.DataSource = model.Categoria.ToList<Categoria>();
        }

        private void buttonAddEngrediente_Click(object sender, EventArgs e)
        {
            if(txtIngredientes.Text.Trim() == "") { return; };

            txtIngredientes.Text = txtIngredientes.Text.Replace(",", " ");
            listBoxIngredientes.Items.Add(txtIngredientes.Text);

            txtIngredientes.Clear();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)comboBoxCategoria.SelectedItem;
            string ingredientes = "";
            ItemMenu itemMenu = new ItemMenu();

            try
            {
                string nome = txtNome.Text;
                decimal preco = txtPreco.Value;

                byte[] imageBytes = File.ReadAllBytes(filepath);

                if(nome.Trim() == "" || preco < 0 || imageBytes == null) { throw new Exception("Preencha todos os campos corretamente"); }

                foreach (string item in listBoxIngredientes.Items)
                {
                    if (item.Trim() == "") { return; }

                    ingredientes = ingredientes + item + ", ";
                }

                itemMenu.Nome = nome;
                itemMenu.Preco = preco;
                ingredientes = ingredientes.Remove(ingredientes.Length - 2);
                itemMenu.Ingredientes = ingredientes;
                itemMenu.CategoriaId = categoria.Id;
                itemMenu.Fotografia = imageBytes;

                model.ItemMenu.Add(itemMenu);
                model.SaveChanges();

                LerDados();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void GesMenu_Load(object sender, EventArgs e)
        {
            LerDados();
            SetRestName();
            LoadTheme();
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
                itemPic.Image = Image.FromFile(filepath);
            }
        }

        private void buttonRemvEngrediente_Click(object sender, EventArgs e)
        {
            listBoxIngredientes.Items.Remove(listBoxIngredientes.SelectedItem);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxPratosInativos.SelectedItem;
            Restaurante restaurante = model.Restaurante.Find(NewMenu.IdRestaurante);
            listBoxMenu.Items.Add(item);
            listBoxPratosInativos.Items.Remove(listBoxPratosInativos.SelectedItem);


            item.Restaurante.Add(restaurante);
            model.SaveChanges();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            Restaurante restaurante = model.Restaurante.Find(NewMenu.IdRestaurante);
            ItemMenu item = (ItemMenu)listBoxMenu.SelectedItem;
            listBoxPratosInativos.Items.Add(item);
            listBoxMenu.Items.Remove(listBoxMenu.SelectedItem);

            item.Restaurante.Remove(restaurante);


        }

        private void GetItemPicture(byte[] imageSource)
        {
            using (MemoryStream stream = new MemoryStream(imageSource))
            {
                Bitmap image = new Bitmap(stream);
                itemPic.Image = image;
            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ItemMenu menuItem = (ItemMenu)listBoxPratosInativos.SelectedItem;
            string ingredientes = "";

            menuItem.Nome = txtNome.Text;
            string texto = txtPreco.Text;
            texto = texto.Replace(".", ",");
            menuItem.Preco = Convert.ToDecimal(texto);

            menuItem.Preco = Convert.ToDecimal(txtPreco.Text);
            if(filepath != "")
            {
                byte[] imageBytes = File.ReadAllBytes(filepath);


                menuItem.Fotografia = imageBytes;
            }     
                
            foreach (string item in listBoxIngredientes.Items)
            {
                if (item.Trim() == "") { return; }

                ingredientes = ingredientes + item + ", ";

            }

            ingredientes = ingredientes.Remove(ingredientes.Length - 2);
            menuItem.Ingredientes = ingredientes;


            model.SaveChanges();
            GetData();
        }

        private void SetRestName()
        {
            if (IdRestaurante != 0)
            {
                Model1Container model1 = new Model1Container();
                Restaurante restaurante = model1.Restaurante.Find(IdRestaurante);

                lblNomeRest.Text = restaurante.Nome;
            }
        }

        private void listBoxPratosInativos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            listBoxIngredientes.Items.Clear();
            ItemMenu item = (ItemMenu)listBoxPratosInativos.SelectedItem;

            if (item != null)
            {
                txtNome.Text = item.Nome;
                txtPreco.Text = item.Preco.ToString();

                GetItemPicture(item.Fotografia);

                comboBoxCategoria.SelectedItem = item.CategoriaId;
                string[] ingredientes = item.Ingredientes.Split(',');

                foreach (string ingrediente in ingredientes)
                {
                    listBoxIngredientes.Items.Add(ingrediente.Trim());
                }
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ItemMenu item = (ItemMenu)listBoxPratosInativos.SelectedItem;

            if (VerifyPresenceItem(item))
            {
                MessageBox.Show("Não pode apagar este Prato pois ele está a ser utilizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                model.ItemMenu.Remove(item);
                model.SaveChanges();
                LerDados();
            }

        }

        private bool VerifyPresenceItem(ItemMenu itemMenu)
        {
            List<Pedido> pedidos = model.Pedido.ToList();
            
            if(itemMenu.Restaurante.Count > 0)
            {
                return true;
            }


            foreach (Pedido pedido in pedidos)
            {
                if(pedido.ItemMenu.Contains(itemMenu))
                {
                    return true;
                }
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.OpenChildForm(new GesRestaurantGlobal(), gesBtn);
            this.Close();
        }
    }
}
