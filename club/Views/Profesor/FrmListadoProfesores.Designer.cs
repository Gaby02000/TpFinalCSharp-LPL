namespace clubApp.Views
{
    partial class FrmListadoProfesores
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
            this.ApellidoBox = new System.Windows.Forms.GroupBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoChk = new System.Windows.Forms.CheckBox();
            this.ProfesoresGrd = new System.Windows.Forms.DataGridView();
            this.LegajoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomicilioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(737, 19);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 7;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            this.FiltroBtn.Click += new System.EventHandler(this.FiltroBtn_Click);
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Controls.Add(this.ApellidoTxt);
            this.ApellidoBox.Controls.Add(this.ApellidoChk);
            this.ApellidoBox.Location = new System.Drawing.Point(9, 8);
            this.ApellidoBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Padding = new System.Windows.Forms.Padding(2);
            this.ApellidoBox.Size = new System.Drawing.Size(227, 42);
            this.ApellidoBox.TabIndex = 6;
            this.ApellidoBox.TabStop = false;
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Enabled = false;
            this.ApellidoTxt.Location = new System.Drawing.Point(71, 15);
            this.ApellidoTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(146, 20);
            this.ApellidoTxt.TabIndex = 1;
            // 
            // ApellidoChk
            // 
            this.ApellidoChk.AutoSize = true;
            this.ApellidoChk.Location = new System.Drawing.Point(4, 17);
            this.ApellidoChk.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoChk.Name = "ApellidoChk";
            this.ApellidoChk.Size = new System.Drawing.Size(63, 17);
            this.ApellidoChk.TabIndex = 0;
            this.ApellidoChk.Text = "Apellido";
            this.ApellidoChk.UseVisualStyleBackColor = true;
            this.ApellidoChk.CheckedChanged += new System.EventHandler(this.ApellidoChk_CheckedChanged);
            // 
            // ProfesoresGrd
            // 
            this.ProfesoresGrd.AllowUserToAddRows = false;
            this.ProfesoresGrd.AllowUserToDeleteRows = false;
            this.ProfesoresGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesoresGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LegajoCol,
            this.DniCol,
            this.ApellidoCol,
            this.NombreCol,
            this.DomicilioCol,
            this.TelefonoCol});
            this.ProfesoresGrd.Location = new System.Drawing.Point(9, 55);
            this.ProfesoresGrd.Margin = new System.Windows.Forms.Padding(2);
            this.ProfesoresGrd.MultiSelect = false;
            this.ProfesoresGrd.Name = "ProfesoresGrd";
            this.ProfesoresGrd.ReadOnly = true;
            this.ProfesoresGrd.RowTemplate.Height = 24;
            this.ProfesoresGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProfesoresGrd.Size = new System.Drawing.Size(826, 352);
            this.ProfesoresGrd.TabIndex = 5;
            this.ProfesoresGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfesoresGrd_CellContentClick_1);
            // 
            // LegajoCol
            // 
            this.LegajoCol.DataPropertyName = "Legajo";
            this.LegajoCol.HeaderText = "Legajo";
            this.LegajoCol.Name = "LegajoCol";
            this.LegajoCol.ReadOnly = true;
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "NroDocumento";
            this.DniCol.HeaderText = "Dni";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Apellido";
            this.ApellidoCol.HeaderText = "Apellido";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            this.NombreCol.DataPropertyName = "Nombres";
            this.NombreCol.HeaderText = "Nombres";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 150;
            // 
            // DomicilioCol
            // 
            this.DomicilioCol.DataPropertyName = "Domicilio";
            this.DomicilioCol.HeaderText = "Domicilio";
            this.DomicilioCol.Name = "DomicilioCol";
            this.DomicilioCol.ReadOnly = true;
            // 
            // TelefonoCol
            // 
            this.TelefonoCol.DataPropertyName = "Telefono";
            this.TelefonoCol.HeaderText = "Telefono";
            this.TelefonoCol.Name = "TelefonoCol";
            this.TelefonoCol.ReadOnly = true;
            // 
            // FrmListadoProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 417);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.ApellidoBox);
            this.Controls.Add(this.ProfesoresGrd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmListadoProfesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Profesores";
            this.ApellidoBox.ResumeLayout(false);
            this.ApellidoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesoresGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FiltroBtn;
        private System.Windows.Forms.GroupBox ApellidoBox;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.CheckBox ApellidoChk;
        private System.Windows.Forms.DataGridView ProfesoresGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn LegajoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomicilioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCol;
    }
}