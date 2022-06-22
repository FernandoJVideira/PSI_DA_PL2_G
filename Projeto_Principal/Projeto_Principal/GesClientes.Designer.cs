namespace Projeto_Principal
{
    partial class GesClientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistarCliente = new System.Windows.Forms.Button();
            this.btnApagarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridViewCliente = new System.Windows.Forms.DataGridView();
            this.btnEditCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTelemovel = new System.Windows.Forms.MaskedTextBox();
            this.txtNumCont = new System.Windows.Forms.MaskedTextBox();
            this.txtPostalCod = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(137, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telemovel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(137, 226);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(137, 182);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Rua";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(137, 312);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pais";
            // 
            // btnRegistarCliente
            // 
            this.btnRegistarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistarCliente.Location = new System.Drawing.Point(33, 427);
            this.btnRegistarCliente.Name = "btnRegistarCliente";
            this.btnRegistarCliente.Size = new System.Drawing.Size(110, 23);
            this.btnRegistarCliente.TabIndex = 16;
            this.btnRegistarCliente.Text = "Registar Cliente";
            this.btnRegistarCliente.UseVisualStyleBackColor = true;
            this.btnRegistarCliente.Click += new System.EventHandler(this.btnRegistarCliente_Click);
            // 
            // btnApagarCliente
            // 
            this.btnApagarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagarCliente.Location = new System.Drawing.Point(33, 473);
            this.btnApagarCliente.Name = "btnApagarCliente";
            this.btnApagarCliente.Size = new System.Drawing.Size(110, 23);
            this.btnApagarCliente.TabIndex = 19;
            this.btnApagarCliente.Text = "Apagar Cliente";
            this.btnApagarCliente.UseVisualStyleBackColor = true;
            this.btnApagarCliente.Click += new System.EventHandler(this.btnApagarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Num Contribuinte";
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // dataGridViewCliente
            // 
            this.dataGridViewCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCliente.Location = new System.Drawing.Point(303, 65);
            this.dataGridViewCliente.MultiSelect = false;
            this.dataGridViewCliente.Name = "dataGridViewCliente";
            this.dataGridViewCliente.RowHeadersWidth = 62;
            this.dataGridViewCliente.Size = new System.Drawing.Size(662, 405);
            this.dataGridViewCliente.TabIndex = 23;
            this.dataGridViewCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellClick);
            this.dataGridViewCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCliente_CellContentClick);
            // 
            // btnEditCliente
            // 
            this.btnEditCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditCliente.Location = new System.Drawing.Point(163, 427);
            this.btnEditCliente.Name = "btnEditCliente";
            this.btnEditCliente.Size = new System.Drawing.Size(108, 23);
            this.btnEditCliente.TabIndex = 24;
            this.btnEditCliente.Text = "Salvar Alterações ";
            this.btnEditCliente.UseVisualStyleBackColor = true;
            this.btnEditCliente.Click += new System.EventHandler(this.btnEditCliente_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(163, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Consultar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(137, 106);
            this.txtTelemovel.Mask = "990000000";
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(123, 20);
            this.txtTelemovel.TabIndex = 26;
            // 
            // txtNumCont
            // 
            this.txtNumCont.Location = new System.Drawing.Point(137, 145);
            this.txtNumCont.Mask = "000000000";
            this.txtNumCont.Name = "txtNumCont";
            this.txtNumCont.Size = new System.Drawing.Size(123, 20);
            this.txtNumCont.TabIndex = 27;
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(137, 269);
            this.txtPostalCod.Mask = "0000-999";
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 28;
            // 
            // GesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.txtNumCont);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditCliente);
            this.Controls.Add(this.dataGridViewCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApagarCliente);
            this.Controls.Add(this.btnRegistarCliente);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesClientes";
            this.Text = "Gerir Clientes";
            this.Load += new System.EventHandler(this.GesClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistarCliente;
        private System.Windows.Forms.Button btnApagarCliente;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.DataGridView dataGridViewCliente;
        private System.Windows.Forms.Button btnEditCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtPostalCod;
        private System.Windows.Forms.MaskedTextBox txtNumCont;
        private System.Windows.Forms.MaskedTextBox txtTelemovel;
    }
}