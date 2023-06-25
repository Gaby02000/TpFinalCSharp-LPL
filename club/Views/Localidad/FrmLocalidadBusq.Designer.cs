namespace clubApp.Views
{
    partial class FrmLocalidadBusq
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
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CodPostal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(157, 117);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(69, 117);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 10;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Location = new System.Drawing.Point(113, 48);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(188, 20);
            this.CodPostalTxt.TabIndex = 13;
            this.CodPostalTxt.TextChanged += new System.EventHandler(this.CodPostalTxt_TextChanged);
            // 
            // CodPostal
            // 
            this.CodPostal.AutoSize = true;
            this.CodPostal.Location = new System.Drawing.Point(24, 51);
            this.CodPostal.Name = "CodPostal";
            this.CodPostal.Size = new System.Drawing.Size(72, 13);
            this.CodPostal.TabIndex = 14;
            this.CodPostal.Text = "Codigo Postal";
            this.CodPostal.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmLocalidadBusq
            // 
            this.ClientSize = new System.Drawing.Size(315, 184);
            this.Controls.Add(this.CodPostal);
            this.Controls.Add(this.CodPostalTxt);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Name = "FrmLocalidadBusq";
            this.Load += new System.EventHandler(this.FrmLocalidadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.Label CodPostal;
    }
}