namespace ProjetoDA
{
    partial class RestGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestGuest));
            this.FormRoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGesMenu = new System.Windows.Forms.Button();
            this.buttonSelectRestaurante = new System.Windows.Forms.Button();
            this.buttonGesPedidos = new System.Windows.Forms.Button();
            this.buttonGesRestaurant = new System.Windows.Forms.Button();
            this.buttonGesClientes = new System.Windows.Forms.Button();
            this.buttonGesRestaurantGlobal = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormRoundedBorders
            // 
            this.FormRoundedBorders.BorderRadius = 8;
            this.FormRoundedBorders.TargetControl = this;
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopBar.Controls.Add(this.btnMinimize);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Location = new System.Drawing.Point(0, -3);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(800, 33);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(742, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(768, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(69, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Restaurante selecionado";
            // 
            // buttonGesMenu
            // 
            this.buttonGesMenu.Location = new System.Drawing.Point(467, 160);
            this.buttonGesMenu.Name = "buttonGesMenu";
            this.buttonGesMenu.Size = new System.Drawing.Size(115, 85);
            this.buttonGesMenu.TabIndex = 12;
            this.buttonGesMenu.Text = "Menu do Restaurante";
            this.buttonGesMenu.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRestaurante
            // 
            this.buttonSelectRestaurante.Location = new System.Drawing.Point(262, 298);
            this.buttonSelectRestaurante.Name = "buttonSelectRestaurante";
            this.buttonSelectRestaurante.Size = new System.Drawing.Size(115, 85);
            this.buttonSelectRestaurante.TabIndex = 11;
            this.buttonSelectRestaurante.Text = "Selecionar Restaurante";
            this.buttonSelectRestaurante.UseVisualStyleBackColor = true;
            // 
            // buttonGesPedidos
            // 
            this.buttonGesPedidos.Location = new System.Drawing.Point(73, 160);
            this.buttonGesPedidos.Name = "buttonGesPedidos";
            this.buttonGesPedidos.Size = new System.Drawing.Size(115, 85);
            this.buttonGesPedidos.TabIndex = 10;
            this.buttonGesPedidos.Text = "Gestão Pedidos";
            this.buttonGesPedidos.UseVisualStyleBackColor = true;
            // 
            // buttonGesRestaurant
            // 
            this.buttonGesRestaurant.Location = new System.Drawing.Point(262, 160);
            this.buttonGesRestaurant.Name = "buttonGesRestaurant";
            this.buttonGesRestaurant.Size = new System.Drawing.Size(115, 85);
            this.buttonGesRestaurant.TabIndex = 9;
            this.buttonGesRestaurant.Text = "Gestão do Restaurante";
            this.buttonGesRestaurant.UseVisualStyleBackColor = true;
            // 
            // buttonGesClientes
            // 
            this.buttonGesClientes.Location = new System.Drawing.Point(467, 298);
            this.buttonGesClientes.Name = "buttonGesClientes";
            this.buttonGesClientes.Size = new System.Drawing.Size(115, 85);
            this.buttonGesClientes.TabIndex = 8;
            this.buttonGesClientes.Text = "Gestão Clientes";
            this.buttonGesClientes.UseVisualStyleBackColor = true;
            // 
            // buttonGesRestaurantGlobal
            // 
            this.buttonGesRestaurantGlobal.Location = new System.Drawing.Point(73, 298);
            this.buttonGesRestaurantGlobal.Name = "buttonGesRestaurantGlobal";
            this.buttonGesRestaurantGlobal.Size = new System.Drawing.Size(115, 85);
            this.buttonGesRestaurantGlobal.TabIndex = 7;
            this.buttonGesRestaurantGlobal.Text = "Gestão Global Restaurantes";
            this.buttonGesRestaurantGlobal.UseVisualStyleBackColor = true;
            // 
            // RestGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGesMenu);
            this.Controls.Add(this.buttonSelectRestaurante);
            this.Controls.Add(this.buttonGesPedidos);
            this.Controls.Add(this.buttonGesRestaurant);
            this.Controls.Add(this.buttonGesClientes);
            this.Controls.Add(this.buttonGesRestaurantGlobal);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestGuest";
            this.Text = "Form1";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormRoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGesMenu;
        private System.Windows.Forms.Button buttonSelectRestaurante;
        private System.Windows.Forms.Button buttonGesPedidos;
        private System.Windows.Forms.Button buttonGesRestaurant;
        private System.Windows.Forms.Button buttonGesClientes;
        private System.Windows.Forms.Button buttonGesRestaurantGlobal;
    }
}

