namespace clubApp.Views
{
    partial class FrmListadoActividad
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
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoActTxt = new System.Windows.Forms.TextBox();
            this.TipoActChk = new System.Windows.Forms.CheckBox();
            this.ActividadesGrd = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(761, 19);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 10;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoActTxt);
            this.groupBox1.Controls.Add(this.TipoActChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(287, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // TipoActTxt
            // 
            this.TipoActTxt.Location = new System.Drawing.Point(133, 17);
            this.TipoActTxt.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActTxt.Name = "TipoActTxt";
            this.TipoActTxt.Size = new System.Drawing.Size(146, 20);
            this.TipoActTxt.TabIndex = 1;
            // 
            // TipoActChk
            // 
            this.TipoActChk.AutoSize = true;
            this.TipoActChk.Location = new System.Drawing.Point(4, 17);
            this.TipoActChk.Margin = new System.Windows.Forms.Padding(2);
            this.TipoActChk.Name = "TipoActChk";
            this.TipoActChk.Size = new System.Drawing.Size(130, 17);
            this.TipoActChk.TabIndex = 0;
            this.TipoActChk.Text = "Codigo Tipo Actividad";
            this.TipoActChk.UseVisualStyleBackColor = true;
            // 
            // ActividadesGrd
            // 
            this.ActividadesGrd.AllowUserToAddRows = false;
            this.ActividadesGrd.AllowUserToDeleteRows = false;
            this.ActividadesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadesGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Profesor,
            this.tipoAct,
            this.NombreCol,
            this.FechaHasta});
            this.ActividadesGrd.Location = new System.Drawing.Point(11, 73);
            this.ActividadesGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ActividadesGrd.MultiSelect = false;
            this.ActividadesGrd.Name = "ActividadesGrd";
            this.ActividadesGrd.ReadOnly = true;
            this.ActividadesGrd.RowTemplate.Height = 24;
            this.ActividadesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadesGrd.Size = new System.Drawing.Size(826, 352);
            this.ActividadesGrd.TabIndex = 8;
            this.ActividadesGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ActividadesGrd_DataBindingComplete);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Id";
            this.Legajo.HeaderText = "Codigo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Profesor
            // 
            this.Profesor.DataPropertyName = "Profesor";
            this.Profesor.HeaderText = "Legajo Profe";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 190;
            // 
            // tipoAct
            // 
            this.tipoAct.DataPropertyName = "TipoActividad";
            this.tipoAct.HeaderText = "Tipo Actividad";
            this.tipoAct.Name = "tipoAct";
            this.tipoAct.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "FechaDesde";
            this.NombreCol.HeaderText = "Fecha Desde";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 190;
            // 
            // FechaHasta
            // 
            this.FechaHasta.DataPropertyName = "fechaHasta";
            this.FechaHasta.HeaderText = "Fecha Hasta";
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            // 
            // FrmListadoActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActividadesGrd);
            this.Name = "FrmListadoActividad";
            this.Text = "FrmListadoActividad";
            this.Load += new System.EventHandler(this.FrmListadoActividad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadesGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TipoActTxt;
        private System.Windows.Forms.CheckBox TipoActChk;
        private System.Windows.Forms.DataGridView ActividadesGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
    }
}