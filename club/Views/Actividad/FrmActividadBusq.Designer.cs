namespace clubApp.Views
{
    partial class FrmActividadBusq
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
            this.FechaHastaChk = new System.Windows.Forms.CheckBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.FechaDesdeChk = new System.Windows.Forms.CheckBox();
            this.CodTipoActTxt = new System.Windows.Forms.TextBox();
            this.CodTipoActividadChk = new System.Windows.Forms.CheckBox();
            this.LegajoProfeTxt = new System.Windows.Forms.TextBox();
            this.LegajoProfeChk = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // FechaHastaChk
            // 
            this.FechaHastaChk.AutoSize = true;
            this.FechaHastaChk.Location = new System.Drawing.Point(17, 133);
            this.FechaHastaChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaHastaChk.Name = "FechaHastaChk";
            this.FechaHastaChk.Size = new System.Drawing.Size(87, 17);
            this.FechaHastaChk.TabIndex = 20;
            this.FechaHastaChk.Text = "Fecha Hasta";
            this.FechaHastaChk.UseVisualStyleBackColor = true;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(275, 192);
            this.CancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(58, 27);
            this.CancelarBtn.TabIndex = 19;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(188, 192);
            this.BuscarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(58, 27);
            this.BuscarBtn.TabIndex = 18;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // FechaDesdeChk
            // 
            this.FechaDesdeChk.AutoSize = true;
            this.FechaDesdeChk.Location = new System.Drawing.Point(17, 95);
            this.FechaDesdeChk.Margin = new System.Windows.Forms.Padding(2);
            this.FechaDesdeChk.Name = "FechaDesdeChk";
            this.FechaDesdeChk.Size = new System.Drawing.Size(90, 17);
            this.FechaDesdeChk.TabIndex = 16;
            this.FechaDesdeChk.Text = "Fecha Desde";
            this.FechaDesdeChk.UseVisualStyleBackColor = true;
            // 
            // CodTipoActTxt
            // 
            this.CodTipoActTxt.Location = new System.Drawing.Point(178, 56);
            this.CodTipoActTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodTipoActTxt.Name = "CodTipoActTxt";
            this.CodTipoActTxt.Size = new System.Drawing.Size(155, 20);
            this.CodTipoActTxt.TabIndex = 15;
            // 
            // CodTipoActividadChk
            // 
            this.CodTipoActividadChk.AutoSize = true;
            this.CodTipoActividadChk.Location = new System.Drawing.Point(17, 59);
            this.CodTipoActividadChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodTipoActividadChk.Name = "CodTipoActividadChk";
            this.CodTipoActividadChk.Size = new System.Drawing.Size(130, 17);
            this.CodTipoActividadChk.TabIndex = 14;
            this.CodTipoActividadChk.Text = "Codigo Tipo Actividad";
            this.CodTipoActividadChk.UseVisualStyleBackColor = true;
            // 
            // LegajoProfeTxt
            // 
            this.LegajoProfeTxt.Location = new System.Drawing.Point(151, 18);
            this.LegajoProfeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoProfeTxt.Name = "LegajoProfeTxt";
            this.LegajoProfeTxt.Size = new System.Drawing.Size(182, 20);
            this.LegajoProfeTxt.TabIndex = 13;
            // 
            // LegajoProfeChk
            // 
            this.LegajoProfeChk.AutoSize = true;
            this.LegajoProfeChk.Location = new System.Drawing.Point(17, 20);
            this.LegajoProfeChk.Margin = new System.Windows.Forms.Padding(2);
            this.LegajoProfeChk.Name = "LegajoProfeChk";
            this.LegajoProfeChk.Size = new System.Drawing.Size(100, 17);
            this.LegajoProfeChk.TabIndex = 12;
            this.LegajoProfeChk.Text = "Legajo Profesor";
            this.LegajoProfeChk.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 95);
            this.dateTimePicker1.MaxDate = new System.DateTime(2070, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(133, 130);
            this.dateTimePicker2.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // FrmActividadBusq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 263);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.FechaHastaChk);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.FechaDesdeChk);
            this.Controls.Add(this.CodTipoActTxt);
            this.Controls.Add(this.CodTipoActividadChk);
            this.Controls.Add(this.LegajoProfeTxt);
            this.Controls.Add(this.LegajoProfeChk);
            this.Name = "FrmActividadBusq";
            this.Text = "FrmActividadBusq";
            this.Load += new System.EventHandler(this.FrmActividadBusq_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox FechaHastaChk;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.CheckBox FechaDesdeChk;
        private System.Windows.Forms.TextBox CodTipoActTxt;
        private System.Windows.Forms.CheckBox CodTipoActividadChk;
        private System.Windows.Forms.TextBox LegajoProfeTxt;
        private System.Windows.Forms.CheckBox LegajoProfeChk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}