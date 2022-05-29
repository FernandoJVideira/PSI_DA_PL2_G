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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GesPedidos));
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxPayment = new System.Windows.Forms.ListBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.listBoxProcessing = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxMethods = new System.Windows.Forms.CheckedListBox();
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
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConcluir
            // 
            this.buttonConcluir.Location = new System.Drawing.Point(935, 545);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(245, 23);
            this.buttonConcluir.TabIndex = 0;
            this.buttonConcluir.Text = "Concluir / pagar Pedido";
            this.buttonConcluir.UseVisualStyleBackColor = true;
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
            this.TopBar.Size = new System.Drawing.Size(1223, 31);
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
            this.btnMinimize.Location = new System.Drawing.Point(1164, 5);
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
            this.btnClose.Location = new System.Drawing.Point(1190, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxPayment
            // 
            this.listBoxPayment.FormattingEnabled = true;
            this.listBoxPayment.Location = new System.Drawing.Point(935, 74);
            this.listBoxPayment.Name = "listBoxPayment";
            this.listBoxPayment.Size = new System.Drawing.Size(245, 264);
            this.listBoxPayment.TabIndex = 39;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(20, 74);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(284, 225);
            this.dataGridViewClientes.TabIndex = 41;
            // 
            // listBoxProcessing
            // 
            this.listBoxProcessing.FormattingEnabled = true;
            this.listBoxProcessing.Location = new System.Drawing.Point(639, 74);
            this.listBoxProcessing.Name = "listBoxProcessing";
            this.listBoxProcessing.Size = new System.Drawing.Size(245, 433);
            this.listBoxProcessing.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(935, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Metodo de pagamento:";
            // 
            // checkedListBoxMethods
            // 
            this.checkedListBoxMethods.FormattingEnabled = true;
            this.checkedListBoxMethods.Location = new System.Drawing.Point(935, 371);
            this.checkedListBoxMethods.Name = "checkedListBoxMethods";
            this.checkedListBoxMethods.Size = new System.Drawing.Size(245, 154);
            this.checkedListBoxMethods.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Prontos por pagar";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.Location = new System.Drawing.Point(639, 545);
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
            this.listBoxTrabalhadores.Location = new System.Drawing.Point(20, 327);
            this.listBoxTrabalhadores.Name = "listBoxTrabalhadores";
            this.listBoxTrabalhadores.Size = new System.Drawing.Size(284, 212);
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
            this.label5.Location = new System.Drawing.Point(17, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Trabalhador";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(639, 516);
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
            this.label6.Location = new System.Drawing.Point(636, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Em processamento";
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.Location = new System.Drawing.Point(344, 74);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(245, 212);
            this.listBoxMenu.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Menu do Restaurante";
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(344, 327);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(245, 212);
            this.listBoxItems.TabIndex = 56;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(20, 545);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(569, 23);
            this.buttonCreate.TabIndex = 57;
            this.buttonCreate.Text = "Criar Pedido";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(344, 292);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(245, 23);
            this.buttonAddItem.TabIndex = 58;
            this.buttonAddItem.Text = "Adicionar Item ao pedido";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // GesPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 594);
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
            this.Controls.Add(this.checkedListBoxMethods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProcessing);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.listBoxPayment);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.buttonConcluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GesPedidos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GesPedidos_Load);
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConcluir;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBoxProcessing;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.ListBox listBoxPayment;
        private System.Windows.Forms.CheckedListBox checkedListBoxMethods;
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
    }
}