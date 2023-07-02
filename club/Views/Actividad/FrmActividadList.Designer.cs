namespace clubApp.Views
{
    partial class FrmActividadList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActividadGrd = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(704, 311);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(54, 27);
            this.CerrarBtn.TabIndex = 9;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ActividadGrd);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(752, 284);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado...";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ActividadGrd
            // 
            this.ActividadGrd.AllowUserToAddRows = false;
            this.ActividadGrd.AllowUserToDeleteRows = false;
            this.ActividadGrd.AllowUserToResizeColumns = false;
            this.ActividadGrd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ActividadGrd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ActividadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActividadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Legajo,
            this.CodActividad,
            this.FechaDesde,
            this.FechHasta});
            this.ActividadGrd.Location = new System.Drawing.Point(16, 25);
            this.ActividadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ActividadGrd.MultiSelect = false;
            this.ActividadGrd.Name = "ActividadGrd";
            this.ActividadGrd.ReadOnly = true;
            this.ActividadGrd.RowTemplate.Height = 24;
            this.ActividadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActividadGrd.Size = new System.Drawing.Size(718, 255);
            this.ActividadGrd.TabIndex = 0;
            this.ActividadGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActividadGrd_CellContentClick);
            this.ActividadGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ActividadesGrd_DataBindingComplete);
            this.ActividadGrd.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Codigo.Width = 130;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Profesor";
            this.Legajo.HeaderText = "Profesor";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // CodActividad
            // 
            this.CodActividad.DataPropertyName = "TipoActividad";
            this.CodActividad.HeaderText = "Tipo Actividad";
            this.CodActividad.Name = "CodActividad";
            this.CodActividad.ReadOnly = true;
            this.CodActividad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CodActividad.Width = 130;
            // 
            // FechaDesde
            // 
            this.FechaDesde.DataPropertyName = "FechaDesde";
            this.FechaDesde.HeaderText = "Fecha Desde";
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ReadOnly = true;
            this.FechaDesde.Width = 80;
            // 
            // FechHasta
            // 
            this.FechHasta.DataPropertyName = "FechaHasta";
            this.FechHasta.HeaderText = "Fecha Hasta";
            this.FechHasta.Name = "FechHasta";
            this.FechHasta.ReadOnly = true;
            this.FechHasta.Width = 150;
            // 
            // FrmActividadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 346);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmActividadList";
            this.Text = "FrmActividadList";
            this.Load += new System.EventHandler(this.FrmActividadList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActividadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ActividadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechHasta;
    }
}