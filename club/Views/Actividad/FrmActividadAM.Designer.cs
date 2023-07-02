namespace clubApp.Views
{
    partial class FrmActividadAM
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
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LegajoProfeTxt = new System.Windows.Forms.TextBox();
            this.LegajoProfeLbl = new System.Windows.Forms.Label();
            this.FechaInicioTxt = new System.Windows.Forms.TextBox();
            this.FechaInicioLbl = new System.Windows.Forms.Label();
            this.TipoActividadTxt = new System.Windows.Forms.TextBox();
            this.TipoActividadLbl = new System.Windows.Forms.Label();
            this.FechaFinLbl = new System.Windows.Forms.Label();
            this.FechaFinTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(244, 211);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(59, 27);
            this.CancelarBtn.TabIndex = 13;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(163, 211);
            this.GuardarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(59, 27);
            this.GuardarBtn.TabIndex = 12;
            this.GuardarBtn.Text = "&Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaFinTxt);
            this.groupBox1.Controls.Add(this.FechaFinLbl);
            this.groupBox1.Controls.Add(this.LegajoProfeTxt);
            this.groupBox1.Controls.Add(this.LegajoProfeLbl);
            this.groupBox1.Controls.Add(this.FechaInicioTxt);
            this.groupBox1.Controls.Add(this.FechaInicioLbl);
            this.groupBox1.Controls.Add(this.TipoActividadTxt);
            this.groupBox1.Controls.Add(this.TipoActividadLbl);
            this.groupBox1.Location = new System.Drawing.Point(29, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(274, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LegajoProfeTxt
            // 
            this.LegajoProfeTxt.Location = new System.Drawing.Point(95, 15);
            this.LegajoProfeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoProfeTxt.Name = "LegajoProfeTxt";
            this.LegajoProfeTxt.Size = new System.Drawing.Size(101, 20);
            this.LegajoProfeTxt.TabIndex = 3;
            this.LegajoProfeTxt.Tag = "Legajo";
            this.LegajoProfeTxt.TextChanged += new System.EventHandler(this.LegajoProfeTxt_TextChanged);
            // 
            // LegajoProfeLbl
            // 
            this.LegajoProfeLbl.AutoSize = true;
            this.LegajoProfeLbl.Location = new System.Drawing.Point(16, 18);
            this.LegajoProfeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LegajoProfeLbl.Name = "LegajoProfeLbl";
            this.LegajoProfeLbl.Size = new System.Drawing.Size(67, 13);
            this.LegajoProfeLbl.TabIndex = 4;
            this.LegajoProfeLbl.Text = "Legajo Profe";
            this.LegajoProfeLbl.Click += new System.EventHandler(this.LegajoProfeLbl_Click);
            // 
            // FechaInicioTxt
            // 
            this.FechaInicioTxt.Location = new System.Drawing.Point(95, 81);
            this.FechaInicioTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FechaInicioTxt.Name = "FechaInicioTxt";
            this.FechaInicioTxt.Size = new System.Drawing.Size(166, 20);
            this.FechaInicioTxt.TabIndex = 2;
            this.FechaInicioTxt.Tag = "FechaInicio";
            this.FechaInicioTxt.TextChanged += new System.EventHandler(this.FechaInicioTxt_TextChanged);
            // 
            // FechaInicioLbl
            // 
            this.FechaInicioLbl.AutoSize = true;
            this.FechaInicioLbl.Location = new System.Drawing.Point(16, 81);
            this.FechaInicioLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaInicioLbl.Name = "FechaInicioLbl";
            this.FechaInicioLbl.Size = new System.Drawing.Size(65, 13);
            this.FechaInicioLbl.TabIndex = 2;
            this.FechaInicioLbl.Text = "Fecha Inicio";
            this.FechaInicioLbl.Click += new System.EventHandler(this.FechaInicioLbl_Click);
            // 
            // TipoActividadTxt
            // 
            this.TipoActividadTxt.Location = new System.Drawing.Point(95, 47);
            this.TipoActividadTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActividadTxt.Name = "TipoActividadTxt";
            this.TipoActividadTxt.Size = new System.Drawing.Size(160, 20);
            this.TipoActividadTxt.TabIndex = 1;
            this.TipoActividadTxt.Tag = "TipoActividad";
            this.TipoActividadTxt.TextChanged += new System.EventHandler(this.TipoActividadTxt_TextChanged);
            // 
            // TipoActividadLbl
            // 
            this.TipoActividadLbl.AutoSize = true;
            this.TipoActividadLbl.Location = new System.Drawing.Point(16, 50);
            this.TipoActividadLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TipoActividadLbl.Name = "TipoActividadLbl";
            this.TipoActividadLbl.Size = new System.Drawing.Size(75, 13);
            this.TipoActividadLbl.TabIndex = 0;
            this.TipoActividadLbl.Text = "Tipo Actividad";
            this.TipoActividadLbl.Click += new System.EventHandler(this.TipoActividadLbl_Click);
            // 
            // FechaFinLbl
            // 
            this.FechaFinLbl.AutoSize = true;
            this.FechaFinLbl.Location = new System.Drawing.Point(16, 115);
            this.FechaFinLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaFinLbl.Name = "FechaFinLbl";
            this.FechaFinLbl.Size = new System.Drawing.Size(54, 13);
            this.FechaFinLbl.TabIndex = 16;
            this.FechaFinLbl.Text = "Fecha Fin";
            this.FechaFinLbl.Click += new System.EventHandler(this.FechaFinLbl_Click);
            // 
            // FechaFinTxt
            // 
            this.FechaFinTxt.Location = new System.Drawing.Point(95, 112);
            this.FechaFinTxt.Margin = new System.Windows.Forms.Padding(2);
            this.FechaFinTxt.Name = "FechaFinTxt";
            this.FechaFinTxt.Size = new System.Drawing.Size(166, 20);
            this.FechaFinTxt.TabIndex = 4;
            this.FechaFinTxt.Tag = "FechaFin";
            this.FechaFinTxt.TextChanged += new System.EventHandler(this.FechaFinTxt_TextChanged);
            // 
            // FrmActividadAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 280);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActividadAM";
            this.Text = "FrmActividadAM";
            this.Load += new System.EventHandler(this.FrmActividadAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LegajoProfeTxt;
        private System.Windows.Forms.Label LegajoProfeLbl;
        private System.Windows.Forms.TextBox FechaInicioTxt;
        private System.Windows.Forms.Label FechaInicioLbl;
        private System.Windows.Forms.TextBox TipoActividadTxt;
        private System.Windows.Forms.Label TipoActividadLbl;
        private System.Windows.Forms.TextBox FechaFinTxt;
        private System.Windows.Forms.Label FechaFinLbl;
    }
}