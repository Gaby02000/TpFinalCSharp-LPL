namespace clubApp.Views
{
    partial class FrmLocalidadAM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CodigoPostalLabel = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTxt);
            this.groupBox1.Controls.Add(this.CodPostalTxt);
            this.groupBox1.Controls.Add(this.NombreLabel);
            this.groupBox1.Controls.Add(this.CodigoPostalLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(66, 80);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(163, 20);
            this.NombreTxt.TabIndex = 1;
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Location = new System.Drawing.Point(95, 24);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(134, 20);
            this.CodPostalTxt.TabIndex = 2;
            this.CodPostalTxt.TextChanged += new System.EventHandler(this.CodPostalTxt_TextChanged);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(6, 83);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(44, 13);
            this.NombreLabel.TabIndex = 2;
            this.NombreLabel.Text = "Nombre";
            this.NombreLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CodigoPostalLabel
            // 
            this.CodigoPostalLabel.AutoSize = true;
            this.CodigoPostalLabel.Location = new System.Drawing.Point(6, 27);
            this.CodigoPostalLabel.Name = "CodigoPostalLabel";
            this.CodigoPostalLabel.Size = new System.Drawing.Size(72, 13);
            this.CodigoPostalLabel.TabIndex = 1;
            this.CodigoPostalLabel.Text = "Codigo Postal";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(203, 198);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(121, 198);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 11;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmLocalidadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 267);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmLocalidadAM";
            this.Text = "FrmLocalidadAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CodigoPostalLabel;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
    }
}