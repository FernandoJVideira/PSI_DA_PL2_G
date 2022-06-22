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
            this.btnRegistar = new System.Windows.Forms.Button();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverRestaurante = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRegistarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.cbDisponibilidadeCategoria = new System.Windows.Forms.ComboBox();
            this.cbDisponibilidadeMetodoPagamento = new System.Windows.Forms.ComboBox();
            this.btnRegistarMetodoPagamento = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNomeMetodoPagamento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoverMetodoPagamento = new System.Windows.Forms.Button();
            this.btnSalvarRestaurante = new System.Windows.Forms.Button();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.btnSalvarMetodoPagamento = new System.Windows.Forms.Button();
            this.txtPostalCod = new System.Windows.Forms.MaskedTextBox();
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.listBoxMetodosPag = new System.Windows.Forms.ListBox();
            this.listBoxCat = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistar
            // 
            this.btnRegistar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistar.Location = new System.Drawing.Point(36, 397);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(129, 37);
            this.btnRegistar.TabIndex = 34;
            this.btnRegistar.Text = "Registar Restaurante";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(117, 227);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(117, 149);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(117, 110);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rua";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 71);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(123, 20);
            this.txtNome.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome";
            // 
            // btnRemoverRestaurante
            // 
            this.btnRemoverRestaurante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverRestaurante.Location = new System.Drawing.Point(281, 418);
            this.btnRemoverRestaurante.Name = "btnRemoverRestaurante";
            this.btnRemoverRestaurante.Size = new System.Drawing.Size(157, 36);
            this.btnRemoverRestaurante.TabIndex = 1;
            this.btnRemoverRestaurante.Text = "Remover Restaurante";
            this.btnRemoverRestaurante.UseVisualStyleBackColor = true;
            this.btnRemoverRestaurante.Click += new System.EventHandler(this.btnRemoverRestaurante_Click);
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // btnRegistarCategoria
            // 
            this.btnRegistarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistarCategoria.Location = new System.Drawing.Point(587, 439);
            this.btnRegistarCategoria.Name = "btnRegistarCategoria";
            this.btnRegistarCategoria.Size = new System.Drawing.Size(123, 28);
            this.btnRegistarCategoria.TabIndex = 42;
            this.btnRegistarCategoria.Text = "Registar Categoria";
            this.btnRegistarCategoria.UseVisualStyleBackColor = true;
            this.btnRegistarCategoria.Click += new System.EventHandler(this.btnRegistarCategoria_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Disponibilidade";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(668, 337);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(123, 20);
            this.txtNomeCategoria.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nome";
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverCategoria.Location = new System.Drawing.Point(775, 454);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(152, 38);
            this.btnRemoverCategoria.TabIndex = 37;
            this.btnRemoverCategoria.Text = "Remover Categoria";
            this.btnRemoverCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // cbDisponibilidadeCategoria
            // 
            this.cbDisponibilidadeCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisponibilidadeCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisponibilidadeCategoria.FormattingEnabled = true;
            this.cbDisponibilidadeCategoria.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cbDisponibilidadeCategoria.Location = new System.Drawing.Point(668, 374);
            this.cbDisponibilidadeCategoria.Name = "cbDisponibilidadeCategoria";
            this.cbDisponibilidadeCategoria.Size = new System.Drawing.Size(123, 21);
            this.cbDisponibilidadeCategoria.TabIndex = 44;
            // 
            // cbDisponibilidadeMetodoPagamento
            // 
            this.cbDisponibilidadeMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDisponibilidadeMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisponibilidadeMetodoPagamento.FormattingEnabled = true;
            this.cbDisponibilidadeMetodoPagamento.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cbDisponibilidadeMetodoPagamento.Location = new System.Drawing.Point(668, 106);
            this.cbDisponibilidadeMetodoPagamento.Name = "cbDisponibilidadeMetodoPagamento";
            this.cbDisponibilidadeMetodoPagamento.Size = new System.Drawing.Size(123, 21);
            this.cbDisponibilidadeMetodoPagamento.TabIndex = 51;
            // 
            // btnRegistarMetodoPagamento
            // 
            this.btnRegistarMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistarMetodoPagamento.Location = new System.Drawing.Point(595, 181);
            this.btnRegistarMetodoPagamento.Name = "btnRegistarMetodoPagamento";
            this.btnRegistarMetodoPagamento.Size = new System.Drawing.Size(153, 35);
            this.btnRegistarMetodoPagamento.TabIndex = 49;
            this.btnRegistarMetodoPagamento.Text = "Registar Metodo Pagamento";
            this.btnRegistarMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRegistarMetodoPagamento.Click += new System.EventHandler(this.btnRegistarMetodoPagamento_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Disponibilidade";
            // 
            // txtNomeMetodoPagamento
            // 
            this.txtNomeMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeMetodoPagamento.Location = new System.Drawing.Point(668, 64);
            this.txtNomeMetodoPagamento.Name = "txtNomeMetodoPagamento";
            this.txtNomeMetodoPagamento.Size = new System.Drawing.Size(123, 20);
            this.txtNomeMetodoPagamento.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nome";
            // 
            // btnRemoverMetodoPagamento
            // 
            this.btnRemoverMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverMetodoPagamento.Location = new System.Drawing.Point(764, 195);
            this.btnRemoverMetodoPagamento.Name = "btnRemoverMetodoPagamento";
            this.btnRemoverMetodoPagamento.Size = new System.Drawing.Size(163, 35);
            this.btnRemoverMetodoPagamento.TabIndex = 45;
            this.btnRemoverMetodoPagamento.Text = "Remover Metodo Pagamento";
            this.btnRemoverMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRemoverMetodoPagamento.Click += new System.EventHandler(this.btnRemoverMetodoPagamento_Click);
            // 
            // btnSalvarRestaurante
            // 
            this.btnSalvarRestaurante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarRestaurante.Location = new System.Drawing.Point(36, 446);
            this.btnSalvarRestaurante.Name = "btnSalvarRestaurante";
            this.btnSalvarRestaurante.Size = new System.Drawing.Size(129, 37);
            this.btnSalvarRestaurante.TabIndex = 55;
            this.btnSalvarRestaurante.Text = "Salvar alterações";
            this.btnSalvarRestaurante.UseVisualStyleBackColor = true;
            this.btnSalvarRestaurante.Click += new System.EventHandler(this.btnSalvarRestaurante_Click);
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarCategoria.Location = new System.Drawing.Point(587, 473);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(123, 28);
            this.btnSalvarCategoria.TabIndex = 56;
            this.btnSalvarCategoria.Text = "Salvar alterações";
            this.btnSalvarCategoria.UseVisualStyleBackColor = true;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // btnSalvarMetodoPagamento
            // 
            this.btnSalvarMetodoPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarMetodoPagamento.Location = new System.Drawing.Point(595, 222);
            this.btnSalvarMetodoPagamento.Name = "btnSalvarMetodoPagamento";
            this.btnSalvarMetodoPagamento.Size = new System.Drawing.Size(153, 33);
            this.btnSalvarMetodoPagamento.TabIndex = 57;
            this.btnSalvarMetodoPagamento.Text = "Salvar alterações";
            this.btnSalvarMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnSalvarMetodoPagamento.Click += new System.EventHandler(this.btnSalvarMetodoPagamento_Click);
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(117, 192);
            this.txtPostalCod.Mask = "0000-999";
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 58;
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(281, 71);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(210, 238);
            this.listBoxRestaurantes.TabIndex = 59;
            this.listBoxRestaurantes.SelectedIndexChanged += new System.EventHandler(this.listBoxRestaurantes_SelectedIndexChanged);
            // 
            // listBoxMetodosPag
            // 
            this.listBoxMetodosPag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMetodosPag.FormattingEnabled = true;
            this.listBoxMetodosPag.Location = new System.Drawing.Point(807, 64);
            this.listBoxMetodosPag.Name = "listBoxMetodosPag";
            this.listBoxMetodosPag.Size = new System.Drawing.Size(120, 108);
            this.listBoxMetodosPag.TabIndex = 61;
            this.listBoxMetodosPag.SelectedIndexChanged += new System.EventHandler(this.listBoxMetodosPag_SelectedIndexChanged);
            // 
            // listBoxCat
            // 
            this.listBoxCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCat.FormattingEnabled = true;
            this.listBoxCat.Location = new System.Drawing.Point(807, 313);
            this.listBoxCat.Name = "listBoxCat";
            this.listBoxCat.Size = new System.Drawing.Size(120, 121);
            this.listBoxCat.TabIndex = 60;
            this.listBoxCat.SelectedIndexChanged += new System.EventHandler(this.listBoxCat_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(42, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 22);
            this.label10.TabIndex = 62;
            this.label10.Text = "Registar Restaurante";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(583, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 22);
            this.label12.TabIndex = 63;
            this.label12.Text = "Registar Método de Pagamento";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label13.Location = new System.Drawing.Point(583, 292);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 22);
            this.label13.TabIndex = 64;
            this.label13.Text = "Registar Categoria";
            // 
            // GesRestaurantGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxCat);
            this.Controls.Add(this.listBoxMetodosPag);
            this.Controls.Add(this.btnRemoverCategoria);
            this.Controls.Add(this.listBoxRestaurantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoverMetodoPagamento);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoverRestaurante);
            this.Controls.Add(this.txtNomeMetodoPagamento);
            this.Controls.Add(this.cbDisponibilidadeCategoria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegistarCategoria);
            this.Controls.Add(this.btnSalvarMetodoPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistarMetodoPagamento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cbDisponibilidadeMetodoPagamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvarRestaurante);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesRestaurantGlobal";
            this.Text = "Registos";
            this.Load += new System.EventHandler(this.GesRestaurantGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoverRestaurante;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.ComboBox cbDisponibilidadeMetodoPagamento;
        private System.Windows.Forms.Button btnRegistarMetodoPagamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNomeMetodoPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemoverMetodoPagamento;
        private System.Windows.Forms.ComboBox cbDisponibilidadeCategoria;
        private System.Windows.Forms.Button btnRegistarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemoverCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSalvarRestaurante;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.Button btnSalvarMetodoPagamento;
        private System.Windows.Forms.MaskedTextBox txtPostalCod;
        private System.Windows.Forms.ListBox listBoxMetodosPag;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
        private System.Windows.Forms.ListBox listBoxCat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
    }
}