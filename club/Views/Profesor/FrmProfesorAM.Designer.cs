﻿namespace clubApp.Views
{
    partial class FrmProfesorAM
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
            this.CamposGbo = new System.Windows.Forms.GroupBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.LegajoTxt = new System.Windows.Forms.TextBox();
            this.LegajoLbl = new System.Windows.Forms.Label();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CamposGbo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CamposGbo
            // 
            this.CamposGbo.Controls.Add(this.DniTxt);
            this.CamposGbo.Controls.Add(this.DniLbl);
            this.CamposGbo.Controls.Add(this.TelefonoTxt);
            this.CamposGbo.Controls.Add(this.TelefonoLbl);
            this.CamposGbo.Controls.Add(this.DomicilioTxt);
            this.CamposGbo.Controls.Add(this.DomicilioLbl);
            this.CamposGbo.Controls.Add(this.LegajoTxt);
            this.CamposGbo.Controls.Add(this.LegajoLbl);
            this.CamposGbo.Controls.Add(this.NombresTxt);
            this.CamposGbo.Controls.Add(this.NombresLbl);
            this.CamposGbo.Controls.Add(this.ApellidoTxt);
            this.CamposGbo.Controls.Add(this.ApellidoLbl);
            this.CamposGbo.Location = new System.Drawing.Point(24, 19);
            this.CamposGbo.Margin = new System.Windows.Forms.Padding(2);
            this.CamposGbo.Name = "CamposGbo";
            this.CamposGbo.Padding = new System.Windows.Forms.Padding(2);
            this.CamposGbo.Size = new System.Drawing.Size(274, 223);
            this.CamposGbo.TabIndex = 2;
            this.CamposGbo.TabStop = false;
            // 
            // DniTxt
            // 
            this.DniTxt.Location = new System.Drawing.Point(74, 105);
            this.DniTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Size = new System.Drawing.Size(80, 20);
            this.DniTxt.TabIndex = 4;
            this.DniTxt.Tag = "NroDocumento";
            // 
            // DniLbl
            // 
            this.DniLbl.AutoSize = true;
            this.DniLbl.Location = new System.Drawing.Point(16, 108);
            this.DniLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DniLbl.Name = "DniLbl";
            this.DniLbl.Size = new System.Drawing.Size(50, 13);
            this.DniLbl.TabIndex = 16;
            this.DniLbl.Text = "&Nro.Doc.";
            // 
            // TelefonoTxt
            // 
            this.TelefonoTxt.Location = new System.Drawing.Point(74, 169);
            this.TelefonoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Size = new System.Drawing.Size(166, 20);
            this.TelefonoTxt.TabIndex = 6;
            this.TelefonoTxt.Tag = "Telefono";
            // 
            // TelefonoLbl
            // 
            this.TelefonoLbl.AutoSize = true;
            this.TelefonoLbl.Location = new System.Drawing.Point(17, 169);
            this.TelefonoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelefonoLbl.Name = "TelefonoLbl";
            this.TelefonoLbl.Size = new System.Drawing.Size(49, 13);
            this.TelefonoLbl.TabIndex = 10;
            this.TelefonoLbl.Text = "&Telefono";
            // 
            // DomicilioTxt
            // 
            this.DomicilioTxt.Location = new System.Drawing.Point(74, 138);
            this.DomicilioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Size = new System.Drawing.Size(166, 20);
            this.DomicilioTxt.TabIndex = 5;
            this.DomicilioTxt.Tag = "Domicilio";
            // 
            // DomicilioLbl
            // 
            this.DomicilioLbl.AutoSize = true;
            this.DomicilioLbl.Location = new System.Drawing.Point(17, 141);
            this.DomicilioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DomicilioLbl.Name = "DomicilioLbl";
            this.DomicilioLbl.Size = new System.Drawing.Size(49, 13);
            this.DomicilioLbl.TabIndex = 8;
            this.DomicilioLbl.Text = "Dom&icilio";
            this.DomicilioLbl.Click += new System.EventHandler(this.DomicilioLbl_Click);
            // 
            // LegajoTxt
            // 
            this.LegajoTxt.Location = new System.Drawing.Point(74, 15);
            this.LegajoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoTxt.Name = "LegajoTxt";
            this.LegajoTxt.Size = new System.Drawing.Size(80, 20);
            this.LegajoTxt.TabIndex = 3;
            this.LegajoTxt.Tag = "Legajo";
            // 
            // LegajoLbl
            // 
            this.LegajoLbl.AutoSize = true;
            this.LegajoLbl.Location = new System.Drawing.Point(16, 18);
            this.LegajoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LegajoLbl.Name = "LegajoLbl";
            this.LegajoLbl.Size = new System.Drawing.Size(39, 13);
            this.LegajoLbl.TabIndex = 4;
            this.LegajoLbl.Text = "Legajo";
            // 
            // NombresTxt
            // 
            this.NombresTxt.Location = new System.Drawing.Point(74, 74);
            this.NombresTxt.Margin = new System.Windows.Forms.Padding(2);
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Size = new System.Drawing.Size(166, 20);
            this.NombresTxt.TabIndex = 2;
            this.NombresTxt.Tag = "Nombres";
            // 
            // NombresLbl
            // 
            this.NombresLbl.AutoSize = true;
            this.NombresLbl.Location = new System.Drawing.Point(17, 77);
            this.NombresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NombresLbl.Name = "NombresLbl";
            this.NombresLbl.Size = new System.Drawing.Size(49, 13);
            this.NombresLbl.TabIndex = 2;
            this.NombresLbl.Text = "No&mbres";
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(74, 46);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(160, 20);
            this.ApellidoTxt.TabIndex = 1;
            this.ApellidoTxt.Tag = "Apellido";
            // 
            // ApellidoLbl
            // 
            this.ApellidoLbl.AutoSize = true;
            this.ApellidoLbl.Location = new System.Drawing.Point(16, 47);
            this.ApellidoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApellidoLbl.Name = "ApellidoLbl";
            this.ApellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.ApellidoLbl.TabIndex = 0;
            this.ApellidoLbl.Text = "&Apellido";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(254, 262);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 10;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(172, 262);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 9;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // FrmProfesorAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 315);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CamposGbo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfesorAM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProfesorAM_Load);
            this.CamposGbo.ResumeLayout(false);
            this.CamposGbo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CamposGbo;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox LegajoTxt;
        private System.Windows.Forms.Label LegajoLbl;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;

    }
}