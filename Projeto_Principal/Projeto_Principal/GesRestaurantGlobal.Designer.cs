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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoverRestaurante = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.dgvRestaurantes = new System.Windows.Forms.DataGridView();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.dgvMetodosPagamento = new System.Windows.Forms.DataGridView();
            this.btnSalvarRestaurante = new System.Windows.Forms.Button();
            this.btnSalvarCategoria = new System.Windows.Forms.Button();
            this.btnSalvarMetodoPagamento = new System.Windows.Forms.Button();
            this.txtPostalCod = new System.Windows.Forms.MaskedTextBox();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(109, 293);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(123, 23);
            this.btnRegistar.TabIndex = 34;
            this.btnRegistar.Text = "Registar Restaurante";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(109, 253);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(123, 20);
            this.txtPais.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Pais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Cod. Postal";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(109, 175);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(123, 20);
            this.txtCidade.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(109, 136);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(123, 20);
            this.txtRua.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rua";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 97);
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
            // btnRemoverRestaurante
            // 
            this.btnRemoverRestaurante.Location = new System.Drawing.Point(301, 293);
            this.btnRemoverRestaurante.Name = "btnRemoverRestaurante";
            this.btnRemoverRestaurante.Size = new System.Drawing.Size(152, 23);
            this.btnRemoverRestaurante.TabIndex = 1;
            this.btnRemoverRestaurante.Text = "Remover Restaurante";
            this.btnRemoverRestaurante.UseVisualStyleBackColor = true;
            this.btnRemoverRestaurante.Click += new System.EventHandler(this.btnRemoverRestaurante_Click);
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
            this.TopBar.Size = new System.Drawing.Size(1339, 31);
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
            this.btnMinimize.Location = new System.Drawing.Point(1259, 3);
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
            this.btnClose.Location = new System.Drawing.Point(1285, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegistarCategoria
            // 
            this.btnRegistarCategoria.Location = new System.Drawing.Point(567, 293);
            this.btnRegistarCategoria.Name = "btnRegistarCategoria";
            this.btnRegistarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnRegistarCategoria.TabIndex = 42;
            this.btnRegistarCategoria.Text = "Registar Categoria";
            this.btnRegistarCategoria.UseVisualStyleBackColor = true;
            this.btnRegistarCategoria.Click += new System.EventHandler(this.btnRegistarCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Disponibilidade";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(567, 97);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(123, 20);
            this.txtNomeCategoria.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nome";
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Location = new System.Drawing.Point(711, 293);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(152, 23);
            this.btnRemoverCategoria.TabIndex = 37;
            this.btnRemoverCategoria.Text = "Remover Categoria";
            this.btnRemoverCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // cbDisponibilidadeCategoria
            // 
            this.cbDisponibilidadeCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisponibilidadeCategoria.FormattingEnabled = true;
            this.cbDisponibilidadeCategoria.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cbDisponibilidadeCategoria.Location = new System.Drawing.Point(567, 139);
            this.cbDisponibilidadeCategoria.Name = "cbDisponibilidadeCategoria";
            this.cbDisponibilidadeCategoria.Size = new System.Drawing.Size(123, 21);
            this.cbDisponibilidadeCategoria.TabIndex = 44;
            // 
            // cbDisponibilidadeMetodoPagamento
            // 
            this.cbDisponibilidadeMetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisponibilidadeMetodoPagamento.FormattingEnabled = true;
            this.cbDisponibilidadeMetodoPagamento.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cbDisponibilidadeMetodoPagamento.Location = new System.Drawing.Point(985, 139);
            this.cbDisponibilidadeMetodoPagamento.Name = "cbDisponibilidadeMetodoPagamento";
            this.cbDisponibilidadeMetodoPagamento.Size = new System.Drawing.Size(123, 21);
            this.cbDisponibilidadeMetodoPagamento.TabIndex = 51;
            // 
            // btnRegistarMetodoPagamento
            // 
            this.btnRegistarMetodoPagamento.Location = new System.Drawing.Point(955, 293);
            this.btnRegistarMetodoPagamento.Name = "btnRegistarMetodoPagamento";
            this.btnRegistarMetodoPagamento.Size = new System.Drawing.Size(153, 23);
            this.btnRegistarMetodoPagamento.TabIndex = 49;
            this.btnRegistarMetodoPagamento.Text = "Registar Metodo Pagamento";
            this.btnRegistarMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRegistarMetodoPagamento.Click += new System.EventHandler(this.btnRegistarMetodoPagamento_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(901, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Disponibilidade";
            // 
            // txtNomeMetodoPagamento
            // 
            this.txtNomeMetodoPagamento.Location = new System.Drawing.Point(985, 97);
            this.txtNomeMetodoPagamento.Name = "txtNomeMetodoPagamento";
            this.txtNomeMetodoPagamento.Size = new System.Drawing.Size(123, 20);
            this.txtNomeMetodoPagamento.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(901, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nome";
            // 
            // btnRemoverMetodoPagamento
            // 
            this.btnRemoverMetodoPagamento.Location = new System.Drawing.Point(1124, 293);
            this.btnRemoverMetodoPagamento.Name = "btnRemoverMetodoPagamento";
            this.btnRemoverMetodoPagamento.Size = new System.Drawing.Size(163, 23);
            this.btnRemoverMetodoPagamento.TabIndex = 45;
            this.btnRemoverMetodoPagamento.Text = "Remover Metodo Pagamento";
            this.btnRemoverMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnRemoverMetodoPagamento.Click += new System.EventHandler(this.btnRemoverMetodoPagamento_Click);
            // 
            // dgvRestaurantes
            // 
            this.dgvRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurantes.Location = new System.Drawing.Point(301, 97);
            this.dgvRestaurantes.MultiSelect = false;
            this.dgvRestaurantes.Name = "dgvRestaurantes";
            this.dgvRestaurantes.RowHeadersWidth = 62;
            this.dgvRestaurantes.Size = new System.Drawing.Size(152, 150);
            this.dgvRestaurantes.TabIndex = 52;
            this.dgvRestaurantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestaurantes_CellClick);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(711, 97);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 62;
            this.dgvCategorias.Size = new System.Drawing.Size(152, 150);
            this.dgvCategorias.TabIndex = 53;
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // dgvMetodosPagamento
            // 
            this.dgvMetodosPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetodosPagamento.Location = new System.Drawing.Point(1124, 97);
            this.dgvMetodosPagamento.MultiSelect = false;
            this.dgvMetodosPagamento.Name = "dgvMetodosPagamento";
            this.dgvMetodosPagamento.RowHeadersWidth = 62;
            this.dgvMetodosPagamento.Size = new System.Drawing.Size(163, 150);
            this.dgvMetodosPagamento.TabIndex = 54;
            this.dgvMetodosPagamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetodosPagamento_CellClick);
            // 
            // btnSalvarRestaurante
            // 
            this.btnSalvarRestaurante.Location = new System.Drawing.Point(109, 322);
            this.btnSalvarRestaurante.Name = "btnSalvarRestaurante";
            this.btnSalvarRestaurante.Size = new System.Drawing.Size(123, 23);
            this.btnSalvarRestaurante.TabIndex = 55;
            this.btnSalvarRestaurante.Text = "Salvar alterações";
            this.btnSalvarRestaurante.UseVisualStyleBackColor = true;
            this.btnSalvarRestaurante.Click += new System.EventHandler(this.btnSalvarRestaurante_Click);
            // 
            // btnSalvarCategoria
            // 
            this.btnSalvarCategoria.Location = new System.Drawing.Point(567, 322);
            this.btnSalvarCategoria.Name = "btnSalvarCategoria";
            this.btnSalvarCategoria.Size = new System.Drawing.Size(123, 23);
            this.btnSalvarCategoria.TabIndex = 56;
            this.btnSalvarCategoria.Text = "Salvar alterações";
            this.btnSalvarCategoria.UseVisualStyleBackColor = true;
            this.btnSalvarCategoria.Click += new System.EventHandler(this.btnSalvarCategoria_Click);
            // 
            // btnSalvarMetodoPagamento
            // 
            this.btnSalvarMetodoPagamento.Location = new System.Drawing.Point(955, 322);
            this.btnSalvarMetodoPagamento.Name = "btnSalvarMetodoPagamento";
            this.btnSalvarMetodoPagamento.Size = new System.Drawing.Size(153, 23);
            this.btnSalvarMetodoPagamento.TabIndex = 57;
            this.btnSalvarMetodoPagamento.Text = "Salvar alterações";
            this.btnSalvarMetodoPagamento.UseVisualStyleBackColor = true;
            this.btnSalvarMetodoPagamento.Click += new System.EventHandler(this.btnSalvarMetodoPagamento_Click);
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.Location = new System.Drawing.Point(109, 218);
            this.txtPostalCod.Mask = "0000-999";
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(123, 20);
            this.txtPostalCod.TabIndex = 58;
            // 
            // GesRestaurantGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 371);
            this.Controls.Add(this.txtPostalCod);
            this.Controls.Add(this.btnSalvarMetodoPagamento);
            this.Controls.Add(this.btnSalvarCategoria);
            this.Controls.Add(this.btnSalvarRestaurante);
            this.Controls.Add(this.dgvMetodosPagamento);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.dgvRestaurantes);
            this.Controls.Add(this.cbDisponibilidadeMetodoPagamento);
            this.Controls.Add(this.btnRegistarMetodoPagamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNomeMetodoPagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemoverMetodoPagamento);
            this.Controls.Add(this.cbDisponibilidadeCategoria);
            this.Controls.Add(this.btnRegistarCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoverCategoria);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoverRestaurante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesRestaurantGlobal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GesRestaurantGlobal_Load);
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetodosPagamento)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.DataGridView dgvRestaurantes;
        private System.Windows.Forms.DataGridView dgvMetodosPagamento;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnSalvarRestaurante;
        private System.Windows.Forms.Button btnSalvarCategoria;
        private System.Windows.Forms.Button btnSalvarMetodoPagamento;
        private System.Windows.Forms.MaskedTextBox txtPostalCod;
    }
}