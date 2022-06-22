namespace Projeto_Principal
{
    partial class SelectRestaurant
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
            this.btnGerir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RoundedBorders = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.listBoxRestaurantes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGerir
            // 
            this.btnGerir.Location = new System.Drawing.Point(161, 168);
            this.btnGerir.Name = "btnGerir";
            this.btnGerir.Size = new System.Drawing.Size(141, 51);
            this.btnGerir.TabIndex = 1;
            this.btnGerir.Text = "Gerir";
            this.btnGerir.UseVisualStyleBackColor = true;
            this.btnGerir.Click += new System.EventHandler(this.btnGerir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(53, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione o Restaurante a gerir";
            // 
            // RoundedBorders
            // 
            this.RoundedBorders.TargetControl = this;
            // 
            // listBoxRestaurantes
            // 
            this.listBoxRestaurantes.FormattingEnabled = true;
            this.listBoxRestaurantes.Location = new System.Drawing.Point(531, 64);
            this.listBoxRestaurantes.Name = "listBoxRestaurantes";
            this.listBoxRestaurantes.Size = new System.Drawing.Size(380, 420);
            this.listBoxRestaurantes.TabIndex = 0;
            // 
            // SelectRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 545);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerir);
            this.Controls.Add(this.listBoxRestaurantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectRestaurant";
            this.Text = "Selecionar Restaurante";
            this.Load += new System.EventHandler(this.SelectRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerir;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse RoundedBorders;
        private System.Windows.Forms.ListBox listBoxRestaurantes;
    }
}