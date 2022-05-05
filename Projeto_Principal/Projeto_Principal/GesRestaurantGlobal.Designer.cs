namespace Projeto_Principal
{
    partial class GesRestaurantGlobal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GesRestaurantGlobal));
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPostalCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(37, 375);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(159, 23);
            this.btnRegistar.TabIndex = 34;
            this.btnRegistar.Text = "Registar Restaurante";
            this.btnRegistar.UseVisualStyleBackColor = true;
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(128, 277);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pais";
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(128, 238);
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(128, 191);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(128, 147);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rua";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(128, 101);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(325, 53);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(244, 303);
            this.listBoxRestaurantes.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(325, 375);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(244, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Apagar / demolir restaurante";
            this.btnRemover.UseVisualStyleBackColor = true;
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
            this.TopBar.Location = new System.Drawing.Point(-3, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(666, 31);
            this.TopBar.TabIndex = 35;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(550, 5);
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
            this.btnClose.Location = new System.Drawing.Point(576, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GesRestaurantGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.listBoxRestaurantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesRestaurantGlobal";
            this.Text = "Form2";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPostalCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.Button btnRemover;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
    }
}