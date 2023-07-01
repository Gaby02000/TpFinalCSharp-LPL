namespace clubApp.Views
{
    partial class FrmProfesorBusq
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
            this.NombreChk = new System.Windows.Forms.CheckBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.LegajoChk = new System.Windows.Forms.CheckBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.LegajoTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(427, 83);
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
            this.BuscarBtn.Location = new System.Drawing.Point(317, 83);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 10;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // NombreChk
            // 
            this.NombreChk.AutoSize = true;
            this.NombreChk.Location = new System.Drawing.Point(283, 21);
            this.NombreChk.Name = "NombreChk";
            this.NombreChk.Size = new System.Drawing.Size(63, 17);
            this.NombreChk.TabIndex = 13;
            this.NombreChk.Text = "Nombre";
            this.NombreChk.UseVisualStyleBackColor = true;
            this.NombreChk.CheckedChanged += new System.EventHandler(this.NombreChk_CheckedChanged);
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(12, 21);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 14;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // LegajoChk
            // 
            this.LegajoChk.AutoSize = true;
            this.LegajoChk.Location = new System.Drawing.Point(12, 61);
            this.LegajoChk.Name = "LegajoChk";
            this.LegajoChk.Size = new System.Drawing.Size(58, 17);
            this.LegajoChk.TabIndex = 15;
            this.LegajoChk.Text = "Legajo";
            this.LegajoChk.UseVisualStyleBackColor = true;
            this.LegajoChk.CheckedChanged += new System.EventHandler(this.LegajoChk_CheckedChanged);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(81, 19);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(180, 20);
            this.ApellidoTxt.TabIndex = 16;
            // 
            // LegajoTxt
            // 
            this.LegajoTxt.Location = new System.Drawing.Point(81, 61);
            this.LegajoTxt.Name = "LegajoTxt";
            this.LegajoTxt.Size = new System.Drawing.Size(180, 20);
            this.LegajoTxt.TabIndex = 17;
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(352, 19);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(180, 20);
            this.NombreTxt.TabIndex = 18;
            // 
            // FrmProfesorBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 121);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.LegajoTxt);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.LegajoChk);
            this.Controls.Add(this.ApellidoChk);
            this.Controls.Add(this.NombreChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesorBusq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Profesores...";
            this.Load += new System.EventHandler(this.FrmProfesorBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox NombreChk;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.CheckBox LegajoChk;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.TextBox LegajoTxt;
        private System.Windows.Forms.TextBox NombreTxt;
    }
}