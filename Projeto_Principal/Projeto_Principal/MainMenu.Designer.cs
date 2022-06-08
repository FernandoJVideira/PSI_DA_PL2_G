namespace Projeto_Principal
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btnGesRestaurantGlobal = new System.Windows.Forms.Button();
            this.btnGesClientes = new System.Windows.Forms.Button();
            this.btnGesRestaurant = new System.Windows.Forms.Button();
            this.btnGesMenu = new System.Windows.Forms.Button();
            this.btnSelectRestaurante = new System.Windows.Forms.Button();
            this.btnGesPedidos = new System.Windows.Forms.Button();
            this.lblNomeRestaurante = new System.Windows.Forms.Label();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGesRestaurantGlobal
            // 
            this.btnGesRestaurantGlobal.Location = new System.Drawing.Point(86, 415);
            this.btnGesRestaurantGlobal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGesRestaurantGlobal.Name = "btnGesRestaurantGlobal";
            this.btnGesRestaurantGlobal.Size = new System.Drawing.Size(172, 131);
            this.btnGesRestaurantGlobal.TabIndex = 0;
            this.btnGesRestaurantGlobal.Text = "Registar Restaurantes";
            this.btnGesRestaurantGlobal.UseVisualStyleBackColor = true;
            this.btnGesRestaurantGlobal.Click += new System.EventHandler(this.btnGesRestaurantGlobal_Click);
            // 
            // btnGesClientes
            // 
            this.btnGesClientes.Location = new System.Drawing.Point(722, 415);
            this.btnGesClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGesClientes.Name = "btnGesClientes";
            this.btnGesClientes.Size = new System.Drawing.Size(172, 131);
            this.btnGesClientes.TabIndex = 1;
            this.btnGesClientes.Text = "Gerir Clientes";
            this.btnGesClientes.UseVisualStyleBackColor = true;
            this.btnGesClientes.Click += new System.EventHandler(this.buttonGesClientes_Click);
            // 
            // btnGesRestaurant
            // 
            this.btnGesRestaurant.Enabled = false;
            this.btnGesRestaurant.Location = new System.Drawing.Point(414, 246);
            this.btnGesRestaurant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGesRestaurant.Name = "btnGesRestaurant";
            this.btnGesRestaurant.Size = new System.Drawing.Size(172, 131);
            this.btnGesRestaurant.TabIndex = 2;
            this.btnGesRestaurant.Text = "Gerir Funcionários";
            this.btnGesRestaurant.UseVisualStyleBackColor = true;
            this.btnGesRestaurant.Click += new System.EventHandler(this.buttonGesRestaurant_Click);
            // 
            // btnGesMenu
            // 
            this.btnGesMenu.Enabled = false;
            this.btnGesMenu.Location = new System.Drawing.Point(722, 246);
            this.btnGesMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGesMenu.Name = "btnGesMenu";
            this.btnGesMenu.Size = new System.Drawing.Size(172, 131);
            this.btnGesMenu.TabIndex = 5;
            this.btnGesMenu.Text = "Gerir Menu do Restaurante";
            this.btnGesMenu.UseVisualStyleBackColor = true;
            this.btnGesMenu.Click += new System.EventHandler(this.buttonGesMenu_Click);
            // 
            // btnSelectRestaurante
            // 
            this.btnSelectRestaurante.Location = new System.Drawing.Point(414, 415);
            this.btnSelectRestaurante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectRestaurante.Name = "btnSelectRestaurante";
            this.btnSelectRestaurante.Size = new System.Drawing.Size(172, 131);
            this.btnSelectRestaurante.TabIndex = 4;
            this.btnSelectRestaurante.Text = "Selecionar Restaurante";
            this.btnSelectRestaurante.UseVisualStyleBackColor = true;
            this.btnSelectRestaurante.Click += new System.EventHandler(this.btnSelectRestaurante_Click);
            // 
            // btnGesPedidos
            // 
            this.btnGesPedidos.Enabled = false;
            this.btnGesPedidos.Location = new System.Drawing.Point(86, 246);
            this.btnGesPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGesPedidos.Name = "btnGesPedidos";
            this.btnGesPedidos.Size = new System.Drawing.Size(172, 131);
            this.btnGesPedidos.TabIndex = 3;
            this.btnGesPedidos.Text = "Gerir Pedidos";
            this.btnGesPedidos.UseVisualStyleBackColor = true;
            this.btnGesPedidos.Click += new System.EventHandler(this.buttonGesPedidos_Click);
            // 
            // lblNomeRestaurante
            // 
            this.lblNomeRestaurante.AutoSize = true;
            this.lblNomeRestaurante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomeRestaurante.Location = new System.Drawing.Point(80, 117);
            this.lblNomeRestaurante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeRestaurante.Name = "lblNomeRestaurante";
            this.lblNomeRestaurante.Size = new System.Drawing.Size(403, 29);
            this.lblNomeRestaurante.TabIndex = 6;
            this.lblNomeRestaurante.Text = "Nome do Restaurante selecionado";
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
            this.TopBar.Location = new System.Drawing.Point(0, -2);
            this.TopBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(998, 48);
            this.TopBar.TabIndex = 8;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(910, 8);
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
            this.btnClose.Location = new System.Drawing.Point(950, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 31);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 622);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.lblNomeRestaurante);
            this.Controls.Add(this.btnGesMenu);
            this.Controls.Add(this.btnSelectRestaurante);
            this.Controls.Add(this.btnGesPedidos);
            this.Controls.Add(this.btnGesRestaurant);
            this.Controls.Add(this.btnGesClientes);
            this.Controls.Add(this.btnGesRestaurantGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGesRestaurantGlobal;
        private System.Windows.Forms.Button btnGesClientes;
        private System.Windows.Forms.Button btnGesRestaurant;
        private System.Windows.Forms.Button btnGesMenu;
        private System.Windows.Forms.Button btnSelectRestaurante;
        private System.Windows.Forms.Button btnGesPedidos;
        private System.Windows.Forms.Label lblNomeRestaurante;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}

