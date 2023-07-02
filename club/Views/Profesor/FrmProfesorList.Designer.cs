namespace clubApp.Views
{
    partial class FrmProfesorList
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
            this.ListadoGbo = new System.Windows.Forms.GroupBox();
            this.ProfesoresGrd = new System.Windows.Forms.DataGridView();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.LegajoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListadoGbo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoGbo
            // 
            this.ListadoGbo.Controls.Add(this.ProfesoresGrd);
            this.ListadoGbo.Location = new System.Drawing.Point(12, 12);
            this.ListadoGbo.Name = "ListadoGbo";
            this.ListadoGbo.Size = new System.Drawing.Size(776, 264);
            this.ListadoGbo.TabIndex = 0;
            this.ListadoGbo.TabStop = false;
            this.ListadoGbo.Text = "Listado...";
            this.ListadoGbo.Enter += new System.EventHandler(this.ListadoGbo_Enter);
            // 
            // ProfesoresGrd
            // 
            this.ProfesoresGrd.AutoGenerateColumns = false;
            this.ProfesoresGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesoresGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LegajoCol,
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol,
            this.DomicilioCol,
            this.TelefonoCol});
            this.ProfesoresGrd.DataSource = this.profesorBindingSource;
            this.ProfesoresGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfesoresGrd.Location = new System.Drawing.Point(3, 16);
            this.ProfesoresGrd.Name = "ProfesoresGrd";
            this.ProfesoresGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProfesoresGrd.Size = new System.Drawing.Size(770, 245);
            this.ProfesoresGrd.TabIndex = 0;
            this.ProfesoresGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfesoresGrd_CellContentClick);
            this.ProfesoresGrd.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProfesoresGrd_ColumnHeaderMouseClick);
            //this.ProfesoresGrd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ProfesoresGrd_DataBindingComplete);
            this.ProfesoresGrd.DoubleClick += new System.EventHandler(this.ProfesoresGrd_DoubleClick);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(clubApp.db.Profesor);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Location = new System.Drawing.Point(722, 285);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 1;
            this.CerrarBtn.Text = "Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // LegajoCol
            // 
            this.LegajoCol.DataPropertyName = "Legajo";
            this.LegajoCol.HeaderText = "Legajo";
            this.LegajoCol.Name = "LegajoCol";
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombre";
            this.NombreCol.Name = "NombreCol";
            // 
            // DomicilioCol
            // 
            this.DomicilioCol.DataPropertyName = "Domicilio";
            this.DomicilioCol.HeaderText = "Domicilio";
            this.DomicilioCol.Name = "DomicilioCol";
            // 
            // TelefonoCol
            // 
            this.TelefonoCol.DataPropertyName = "Telefono";
            this.TelefonoCol.HeaderText = "Telefono";
            this.TelefonoCol.Name = "TelefonoCol";
            // 
            // FrmProfesorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 320);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.ListadoGbo);
            this.Name = "FrmProfesorList";
            this.Text = "FrmProfesorList";
            this.Load += new System.EventHandler(this.FrmProfesorList_Load);
            this.ListadoGbo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListadoGbo;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.DataGridView ProfesoresGrd;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCol;
    }
}
 