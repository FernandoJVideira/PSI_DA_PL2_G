namespace Projeto_Principal
{
    partial class Form1
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
            this.buttonGesRestaurantGlobal = new System.Windows.Forms.Button();
            this.buttonGesClientes = new System.Windows.Forms.Button();
            this.buttonGesRestaurant = new System.Windows.Forms.Button();
            this.buttonGesMenu = new System.Windows.Forms.Button();
            this.buttonSelectRestaurante = new System.Windows.Forms.Button();
            this.buttonGesPedidos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGesRestaurantGlobal
            // 
            this.buttonGesRestaurantGlobal.Location = new System.Drawing.Point(57, 270);
            this.buttonGesRestaurantGlobal.Name = "buttonGesRestaurantGlobal";
            this.buttonGesRestaurantGlobal.Size = new System.Drawing.Size(115, 85);
            this.buttonGesRestaurantGlobal.TabIndex = 0;
            this.buttonGesRestaurantGlobal.Text = "Gestão Global Restaurantes";
            this.buttonGesRestaurantGlobal.UseVisualStyleBackColor = true;
            this.buttonGesRestaurantGlobal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGesClientes
            // 
            this.buttonGesClientes.Location = new System.Drawing.Point(481, 270);
            this.buttonGesClientes.Name = "buttonGesClientes";
            this.buttonGesClientes.Size = new System.Drawing.Size(115, 85);
            this.buttonGesClientes.TabIndex = 1;
            this.buttonGesClientes.Text = "Gestão Clientes";
            this.buttonGesClientes.UseVisualStyleBackColor = true;
            this.buttonGesClientes.Click += new System.EventHandler(this.buttonGesClientes_Click);
            // 
            // buttonGesRestaurant
            // 
            this.buttonGesRestaurant.Location = new System.Drawing.Point(276, 160);
            this.buttonGesRestaurant.Name = "buttonGesRestaurant";
            this.buttonGesRestaurant.Size = new System.Drawing.Size(115, 85);
            this.buttonGesRestaurant.TabIndex = 2;
            this.buttonGesRestaurant.Text = "Gestão do Restaurante";
            this.buttonGesRestaurant.UseVisualStyleBackColor = true;
            this.buttonGesRestaurant.Click += new System.EventHandler(this.buttonGesRestaurant_Click);
            // 
            // buttonGesMenu
            // 
            this.buttonGesMenu.Location = new System.Drawing.Point(481, 160);
            this.buttonGesMenu.Name = "buttonGesMenu";
            this.buttonGesMenu.Size = new System.Drawing.Size(115, 85);
            this.buttonGesMenu.TabIndex = 5;
            this.buttonGesMenu.Text = "Menu do Restaurante";
            this.buttonGesMenu.UseVisualStyleBackColor = true;
            this.buttonGesMenu.Click += new System.EventHandler(this.buttonGesMenu_Click);
            // 
            // buttonSelectRestaurante
            // 
            this.buttonSelectRestaurante.Location = new System.Drawing.Point(276, 270);
            this.buttonSelectRestaurante.Name = "buttonSelectRestaurante";
            this.buttonSelectRestaurante.Size = new System.Drawing.Size(115, 85);
            this.buttonSelectRestaurante.TabIndex = 4;
            this.buttonSelectRestaurante.Text = "Selecionar Restaurante";
            this.buttonSelectRestaurante.UseVisualStyleBackColor = true;
            this.buttonSelectRestaurante.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonGesPedidos
            // 
            this.buttonGesPedidos.Location = new System.Drawing.Point(57, 160);
            this.buttonGesPedidos.Name = "buttonGesPedidos";
            this.buttonGesPedidos.Size = new System.Drawing.Size(115, 85);
            this.buttonGesPedidos.TabIndex = 3;
            this.buttonGesPedidos.Text = "Gestão Pedidos";
            this.buttonGesPedidos.UseVisualStyleBackColor = true;
            this.buttonGesPedidos.Click += new System.EventHandler(this.buttonGesPedidos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(133, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Restaurante selecionado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGesMenu);
            this.Controls.Add(this.buttonSelectRestaurante);
            this.Controls.Add(this.buttonGesPedidos);
            this.Controls.Add(this.buttonGesRestaurant);
            this.Controls.Add(this.buttonGesClientes);
            this.Controls.Add(this.buttonGesRestaurantGlobal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGesRestaurantGlobal;
        private System.Windows.Forms.Button buttonGesClientes;
        private System.Windows.Forms.Button buttonGesRestaurant;
        private System.Windows.Forms.Button buttonGesMenu;
        private System.Windows.Forms.Button buttonSelectRestaurante;
        private System.Windows.Forms.Button buttonGesPedidos;
        private System.Windows.Forms.Label label1;
    }
}

