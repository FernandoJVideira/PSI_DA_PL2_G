namespace Projeto_Principal
{
    partial class GerirRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirRestaurante));
            this.listBoxTrabalhadores = new System.Windows.Forms.ListBox();
            this.txtRemove = new System.Windows.Forms.Button();
            this.txtAddCFicha = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddSFicha = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTrabalhadores
            // 
            this.listBoxTrabalhadores.FormattingEnabled = true;
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(532, 101);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(216, 290);
            this.listBoxTrabalhadores.TabIndex = 0;
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(532, 397);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(216, 23);
            this.txtRemove.TabIndex = 1;
            this.txtRemove.Text = "Remover";
            this.txtRemove.UseVisualStyleBackColor = true;
            // 
            // txtAddCFicha
            // 
            this.txtAddCFicha.Location = new System.Drawing.Point(298, 397);
            this.txtAddCFicha.Name = "txtAddCFicha";
            this.txtAddCFicha.Size = new System.Drawing.Size(216, 23);
            this.txtAddCFicha.TabIndex = 2;
            this.txtAddCFicha.Text = "Adicionar Trabalhador com ficha";
            this.txtAddCFicha.UseVisualStyleBackColor = true;
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(298, 154);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(216, 238);
            this.listBoxClientes.TabIndex = 3;
            // 
            // txtPosicao
            // 
            this.txtPosicao.Location = new System.Drawing.Point(271, 101);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(123, 20);
            this.txtPosicao.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Posição";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(271, 62);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(123, 20);
            this.txtSalario.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salario";
            // 
            // txtAddSFicha
            // 
            this.txtAddSFicha.Location = new System.Drawing.Point(49, 397);
            this.txtAddSFicha.Name = "txtAddSFicha";
            this.txtAddSFicha.Size = new System.Drawing.Size(216, 23);
            this.txtAddSFicha.TabIndex = 28;
            this.txtAddSFicha.Text = "Adicionar Trabalhador sem ficha";
            this.txtAddSFicha.UseVisualStyleBackColor = true;
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
            this.TopBar.Location = new System.Drawing.Point(-4, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(809, 31);
            this.TopBar.TabIndex = 38;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(741, 5);
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
            this.btnClose.Location = new System.Drawing.Point(767, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(142, 344);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Pais";
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(142, 305);
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(142, 258);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(142, 214);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Rua";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome";
            // 
            // GerirRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddSFicha);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.txtPosicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtAddCFicha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemove);
            this.Controls.Add(this.listBoxTrabalhadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerirRestaurante";
            this.Text = "Form2";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTrabalhadores;
        private System.Windows.Forms.Button txtRemove;
        private System.Windows.Forms.Button txtAddCFicha;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtAddSFicha;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
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
    }
}