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
            this.CodigoPostalText = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.CodigoPostalChk = new System.Windows.Forms.CheckBox();
            this.CodPostalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CodigoPostalText
            // 
            this.CodigoPostalText.Location = new System.Drawing.Point(118, 25);
            this.CodigoPostalText.Name = "CodigoPostalText";
            this.CodigoPostalText.Size = new System.Drawing.Size(226, 20);
            this.CodigoPostalText.TabIndex = 1;
            this.CodigoPostalText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(284, 81);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 11;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(203, 81);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 10;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // CodigoPostalChk
            // 
            this.CodigoPostalChk.AutoSize = true;
            this.CodigoPostalChk.Location = new System.Drawing.Point(12, 27);
            this.CodigoPostalChk.Name = "CodigoPostalChk";
            this.CodigoPostalChk.Size = new System.Drawing.Size(15, 14);
            this.CodigoPostalChk.TabIndex = 12;
            this.CodigoPostalChk.UseVisualStyleBackColor = true;
            this.CodigoPostalChk.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CodPostalLabel
            // 
            this.CodPostalLabel.AutoSize = true;
            this.CodPostalLabel.Location = new System.Drawing.Point(33, 27);
            this.CodPostalLabel.Name = "CodPostalLabel";
            this.CodPostalLabel.Size = new System.Drawing.Size(72, 13);
            this.CodPostalLabel.TabIndex = 13;
            this.CodPostalLabel.Text = "Codigo Postal";
            // 
            // FrmLocalidadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 158);
            this.Controls.Add(this.CodPostalLabel);
            this.Controls.Add(this.CodigoPostalChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.CodigoPostalText);
            this.Name = "FrmLocalidadBusq";
            this.Text = "FrmLocalidadBusq";
            this.Load += new System.EventHandler(this.FrmLocalidadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodigoPostalText;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox CodigoPostalChk;
        private System.Windows.Forms.Label CodPostalLabel;
        private System.Windows.Forms.ComboBox LocalidadCbo;
    }
}