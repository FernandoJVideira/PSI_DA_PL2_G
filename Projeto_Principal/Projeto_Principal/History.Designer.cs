namespace Projeto_Principal
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.TopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.comboBoxEstados = new System.Windows.Forms.ComboBox();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(35, 67);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(373, 342);
            this.listBoxHistory.TabIndex = 0;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(35, 415);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(373, 23);
            this.buttonView.TabIndex = 2;
            this.buttonView.Text = "Visualizar Pedido";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "labelTipo";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(355, 42);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(53, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "labelTotal";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(417, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(19, 20);
            this.btnClose.TabIndex = 22;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(390, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(19, 20);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopBar.Controls.Add(this.btnMinimize);
            this.TopBar.Controls.Add(this.btnClose);
            this.TopBar.Location = new System.Drawing.Point(-1, -1);
            this.TopBar.Name = "TopBar";
            this.TopBar.ShadowDecoration.Parent = this.TopBar;
            this.TopBar.Size = new System.Drawing.Size(450, 31);
            this.TopBar.TabIndex = 23;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // comboBoxEstados
            // 
            this.comboBoxEstados.FormattingEnabled = true;
            this.comboBoxEstados.Items.AddRange(new object[] {
            "Todos"});
            this.comboBoxEstados.Location = new System.Drawing.Point(287, 39);
            this.comboBoxEstados.Name = "comboBoxEstados";
            this.comboBoxEstados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstados.TabIndex = 24;
            this.comboBoxEstados.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstados_SelectedIndexChanged);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.comboBoxEstados);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.listBoxHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.History_Load);
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistory;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private Guna.UI2.WinForms.Guna2Panel TopBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ComboBox comboBoxEstados;
    }
}