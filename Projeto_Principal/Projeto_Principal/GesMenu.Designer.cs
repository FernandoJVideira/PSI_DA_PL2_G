namespace Projeto_Principal
{
    partial class GesMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GesMenu));
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.lblNomeRestaurante = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listBoxPratosInativos = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxIngredientes = new System.Windows.Forms.ListBox();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.buttonAddEngrediente = new System.Windows.Forms.Button();
            this.buttonRemvEngrediente = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpath = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(752, 131);
            this.listBoxMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(384, 524);
            this.listBoxMenu.TabIndex = 0;
            // 
            // lblNomeRestaurante
            // 
            this.lblNomeRestaurante.AutoSize = true;
            this.lblNomeRestaurante.Location = new System.Drawing.Point(747, 74);
            this.lblNomeRestaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeRestaurante.Name = "lblNomeRestaurante";
            this.lblNomeRestaurante.Size = new System.Drawing.Size(180, 20);
            this.lblNomeRestaurante.TabIndex = 1;
            this.lblNomeRestaurante.Text = "Menu do Restaurante ...";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(46, 131);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(46, 225);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(210, 26);
            this.txtPreco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(46, 677);
            this.btnRegistar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(127, 35);
            this.btnRegistar.TabIndex = 6;
            this.btnRegistar.Text = "Registar Prato";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(748, 677);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(386, 35);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listBoxPratosInativos
            // 
            this.listBoxPratosInativos.FormattingEnabled = true;
            this.listBoxPratosInativos.ItemHeight = 20;
            this.listBoxPratosInativos.Location = new System.Drawing.Point(404, 131);
            this.listBoxPratosInativos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPratosInativos.Name = "listBoxPratosInativos";
            this.listBoxPratosInativos.Size = new System.Drawing.Size(278, 524);
            this.listBoxPratosInativos.TabIndex = 8;
            this.listBoxPratosInativos.SelectedIndexChanged += new System.EventHandler(this.listBoxPratosInativos_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(398, 677);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(280, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar ao Menu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.Location = new System.Drawing.Point(282, 283);
            this.btnAddFoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(45, 35);
            this.btnAddFoto.TabIndex = 10;
            this.btnAddFoto.Text = "...";
            this.btnAddFoto.UseVisualStyleBackColor = true;
            this.btnAddFoto.Click += new System.EventHandler(this.btnAddFoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fotografia";
            // 
            // listBoxIngredientes
            // 
            this.listBoxIngredientes.FormattingEnabled = true;
            this.listBoxIngredientes.ItemHeight = 20;
            this.listBoxIngredientes.Location = new System.Drawing.Point(46, 478);
            this.listBoxIngredientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxIngredientes.Name = "listBoxIngredientes";
            this.listBoxIngredientes.Size = new System.Drawing.Size(278, 124);
            this.listBoxIngredientes.TabIndex = 12;
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(46, 438);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(238, 26);
            this.txtIngredientes.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 414);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ingredientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "$";
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopBar.Controls.Add(this.btnMinimize);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Location = new System.Drawing.Point(-10, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(1214, 48);
            this.TopBar.TabIndex = 36;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1110, 8);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 31);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1149, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // buttonAddEngrediente
            // 
            this.buttonAddEngrediente.Location = new System.Drawing.Point(296, 438);
            this.buttonAddEngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddEngrediente.Name = "buttonAddEngrediente";
            this.buttonAddEngrediente.Size = new System.Drawing.Size(32, 35);
            this.buttonAddEngrediente.TabIndex = 37;
            this.buttonAddEngrediente.Text = "+";
            this.buttonAddEngrediente.UseVisualStyleBackColor = true;
            this.buttonAddEngrediente.Click += new System.EventHandler(this.buttonAddEngrediente_Click);
            // 
            // buttonRemvEngrediente
            // 
            this.buttonRemvEngrediente.Location = new System.Drawing.Point(46, 614);
            this.buttonRemvEngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemvEngrediente.Name = "buttonRemvEngrediente";
            this.buttonRemvEngrediente.Size = new System.Drawing.Size(280, 35);
            this.buttonRemvEngrediente.TabIndex = 38;
            this.buttonRemvEngrediente.Text = "Remover Engrediente";
            this.buttonRemvEngrediente.UseVisualStyleBackColor = true;
            this.buttonRemvEngrediente.Click += new System.EventHandler(this.buttonRemvEngrediente_Click);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(146, 354);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(180, 28);
            this.comboBoxCategoria.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Categoria";
            // 
            // labelpath
            // 
            this.labelpath.AutoSize = true;
            this.labelpath.Location = new System.Drawing.Point(141, 291);
            this.labelpath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelpath.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(74, 20);
            this.labelpath.TabIndex = 41;
            this.labelpath.Text = "labelpath";
            this.labelpath.Visible = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(197, 677);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(127, 35);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "Atualizar Prato";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 722);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 35);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 803);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.buttonRemvEngrediente);
            this.Controls.Add(this.buttonAddEngrediente);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.listBoxIngredientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddFoto);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxPratosInativos);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeRestaurante);
            this.Controls.Add(this.listBoxMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GesMenu";
            this.Text = "GesMenu";
            this.Load += new System.EventHandler(this.GesMenu_Load);
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label lblNomeRestaurante;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listBoxPratosInativos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxIngredientes;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button buttonRemvEngrediente;
        private System.Windows.Forms.Button buttonAddEngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSave;
    }
}