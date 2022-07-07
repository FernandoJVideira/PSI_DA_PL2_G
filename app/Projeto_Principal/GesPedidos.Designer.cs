namespace Projeto_Principal
{
    partial class GesPedidos
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
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listBoxPayment = new System.Windows.Forms.ListBox();
            this.listBoxProcessing = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.listBoxTrabalhadores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.listBoxMetodosUsados = new System.Windows.Forms.ListBox();
            this.buttonRemMetodo = new System.Windows.Forms.Button();
            this.buttonValor = new System.Windows.Forms.Button();
            this.labelinfo = new System.Windows.Forms.Label();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.textBoxValor = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxValor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConcluir
            // 
            this.buttonConcluir.Location = new System.Drawing.Point(786, 478);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(166, 23);
            this.buttonConcluir.TabIndex = 0;
            this.buttonConcluir.Text = "Concluir";
            this.buttonConcluir.UseVisualStyleBackColor = true;
            this.buttonConcluir.Click += new System.EventHandler(this.buttonConcluir_Click);
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // listBoxPayment
            // 
            this.listBoxPayment.FormattingEnabled = true;
            this.listBoxPayment.Location = new System.Drawing.Point(786, 59);
            this.listBoxPayment.Name = "listBoxPayment";
            this.listBoxPayment.Size = new System.Drawing.Size(166, 173);
            this.listBoxPayment.TabIndex = 39;
            this.listBoxPayment.SelectedIndexChanged += new System.EventHandler(this.listBoxPayment_SelectedIndexChanged);
            // 
            // listBoxProcessing
            // 
            this.listBoxProcessing.FormattingEnabled = true;
            this.listBoxProcessing.Location = new System.Drawing.Point(453, 68);
            this.listBoxProcessing.Name = "listBoxProcessing";
            this.listBoxProcessing.Size = new System.Drawing.Size(245, 212);
            this.listBoxProcessing.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Metodo de pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Prontos por pagar";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(453, 331);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(245, 23);
            this.buttonFinalizar.TabIndex = 48;
            this.buttonFinalizar.Text = "Finalizar Pedido";
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // listBoxTrabalhadores
            // 
            this.listBoxTrabalhadores.FormattingEnabled = true;
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(20, 305);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(164, 186);
            this.listBoxTrabalhadores.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Trabalhador";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(453, 291);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(245, 23);
            this.buttonCancel.TabIndex = 52;
            this.buttonCancel.Text = "Cancelar Pedido";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Em processamento";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(228, 71);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(144, 212);
            this.listBoxMenu.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Menu do Restaurante";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(228, 318);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(144, 173);
            this.listBoxItems.TabIndex = 56;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(20, 504);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(352, 23);
            this.buttonCreate.TabIndex = 57;
            this.buttonCreate.Text = "Criar Pedido";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(228, 289);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(144, 23);
            this.buttonAddItem.TabIndex = 58;
            this.buttonAddItem.Text = "Adicionar Item ao pedido";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(786, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(783, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Valor Restante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(905, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "€";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(869, 297);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(30, 13);
            this.labelValor.TabIndex = 64;
            this.labelValor.Text = "valor";
            // 
            // listBoxMetodosUsados
            // 
            this.listBoxMetodosUsados.FormattingEnabled = true;
            this.listBoxMetodosUsados.Location = new System.Drawing.Point(786, 383);
            this.listBoxMetodosUsados.Name = "listBoxMetodosUsados";
            this.listBoxMetodosUsados.Size = new System.Drawing.Size(166, 82);
            this.listBoxMetodosUsados.TabIndex = 65;
            // 
            // buttonRemMetodo
            // 
            this.buttonRemMetodo.Location = new System.Drawing.Point(786, 510);
            this.buttonRemMetodo.Name = "buttonRemMetodo";
            this.buttonRemMetodo.Size = new System.Drawing.Size(166, 23);
            this.buttonRemMetodo.TabIndex = 66;
            this.buttonRemMetodo.Text = "Remover Metodo";
            this.buttonRemMetodo.UseVisualStyleBackColor = true;
            this.buttonRemMetodo.Click += new System.EventHandler(this.buttonRemMetodo_Click);
            // 
            // buttonValor
            // 
            this.buttonValor.Location = new System.Drawing.Point(786, 341);
            this.buttonValor.Name = "buttonValor";
            this.buttonValor.Size = new System.Drawing.Size(157, 23);
            this.buttonValor.TabIndex = 67;
            this.buttonValor.Text = "Adicionar Valor";
            this.buttonValor.UseVisualStyleBackColor = true;
            this.buttonValor.Click += new System.EventHandler(this.buttonValor_Click);
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.Location = new System.Drawing.Point(796, 129);
            this.labelinfo.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(147, 26);
            this.labelinfo.TabIndex = 68;
            this.labelinfo.Text = "Termine o Pagamento para poder selecionar outro pedido";
            this.labelinfo.Visible = false;
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(476, 431);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(200, 60);
            this.buttonHistory.TabIndex = 69;
            this.buttonHistory.Text = "Consultar Histórico de Pedidos";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(20, 74);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(149, 199);
            this.listBoxClientes.TabIndex = 70;
            // 
            // textBoxValor
            // 
            this.textBoxValor.DecimalPlaces = 2;
            this.textBoxValor.Location = new System.Drawing.Point(786, 315);
            this.textBoxValor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(72, 20);
            this.textBoxValor.TabIndex = 71;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValor.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(772, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Não existem métodos de pagamento ativos";
            this.label8.Visible = false;
            // 
            // GesPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.labelinfo);
            this.Controls.Add(this.buttonValor);
            this.Controls.Add(this.buttonRemMetodo);
            this.Controls.Add(this.listBoxMetodosUsados);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxTrabalhadores);
            this.Controls.Add(this.buttonFinalizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProcessing);
            this.Controls.Add(this.listBoxPayment);
            this.Controls.Add(this.buttonConcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesPedidos";
            this.Text = "Gestão de Pedidos";
            this.Load += new System.EventHandler(this.GesPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConcluir;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.ListBox listBoxProcessing;
        private System.Windows.Forms.ListBox listBoxPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTrabalhadores;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonValor;
        private System.Windows.Forms.Button buttonRemMetodo;
        private System.Windows.Forms.ListBox listBoxMetodosUsados;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.NumericUpDown textBoxValor;
        private System.Windows.Forms.Label label8;
    }
}