namespace clubApp.Views
{
    partial class FrmListadoLocalidad
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
            this.CodPostalTxt = new System.Windows.Forms.TextBox();
            this.CodPostalChk = new System.Windows.Forms.CheckBox();
            this.LocalidadGrd = new System.Windows.Forms.DataGridView();
            this.DniCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CodPostalTxt);
            this.groupBox1.Controls.Add(this.CodPostalChk);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(258, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // CodPostalTxt
            // 
            this.CodPostalTxt.Enabled = false;
            this.CodPostalTxt.Location = new System.Drawing.Point(99, 14);
            this.CodPostalTxt.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalTxt.Name = "CodPostalTxt";
            this.CodPostalTxt.Size = new System.Drawing.Size(146, 20);
            this.CodPostalTxt.TabIndex = 1;
            // 
            // CodPostalChk
            // 
            this.CodPostalChk.AutoSize = true;
            this.CodPostalChk.Location = new System.Drawing.Point(4, 17);
            this.CodPostalChk.Margin = new System.Windows.Forms.Padding(2);
            this.CodPostalChk.Name = "CodPostalChk";
            this.CodPostalChk.Size = new System.Drawing.Size(91, 17);
            this.CodPostalChk.TabIndex = 0;
            this.CodPostalChk.Text = "Codigo Postal";
            this.CodPostalChk.UseVisualStyleBackColor = true;
            // 
            // LocalidadGrd
            // 
            this.LocalidadGrd.AllowUserToAddRows = false;
            this.LocalidadGrd.AllowUserToDeleteRows = false;
            this.LocalidadGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalidadGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DniCol,
            this.ApellidoCol});
            this.LocalidadGrd.Location = new System.Drawing.Point(11, 63);
            this.LocalidadGrd.Margin = new System.Windows.Forms.Padding(2);
            this.LocalidadGrd.MultiSelect = false;
            this.LocalidadGrd.Name = "LocalidadGrd";
            this.LocalidadGrd.ReadOnly = true;
            this.LocalidadGrd.RowTemplate.Height = 24;
            this.LocalidadGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalidadGrd.ShowEditingIcon = false;
            this.LocalidadGrd.Size = new System.Drawing.Size(468, 384);
            this.LocalidadGrd.TabIndex = 2;
            this.LocalidadGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SociosGrd_CellContentClick);
            // 
            // DniCol
            // 
            this.DniCol.DataPropertyName = "Nombre";
            this.DniCol.HeaderText = "Nombre";
            this.DniCol.Name = "DniCol";
            this.DniCol.ReadOnly = true;
            // 
            // ApellidoCol
            // 
            this.ApellidoCol.DataPropertyName = "Id";
            this.ApellidoCol.HeaderText = "Codigo Postal";
            this.ApellidoCol.Name = "ApellidoCol";
            this.ApellidoCol.ReadOnly = true;
            this.ApellidoCol.Width = 150;
            // 
            // FiltroBtn
            // 
            this.FiltroBtn.Location = new System.Drawing.Point(366, 18);
            this.FiltroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FiltroBtn.Name = "FiltroBtn";
            this.FiltroBtn.Size = new System.Drawing.Size(76, 32);
            this.FiltroBtn.TabIndex = 4;
            this.FiltroBtn.Text = "Filtrar";
            this.FiltroBtn.UseVisualStyleBackColor = true;
            // 
            // FrmListadoLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 483);
            this.Controls.Add(this.FiltroBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LocalidadGrd);
            this.Name = "FrmListadoLocalidad";
            this.Text = "FrmListadoLocalidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalidadGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CodPostalTxt;
        private System.Windows.Forms.CheckBox CodPostalChk;
        private System.Windows.Forms.DataGridView LocalidadGrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCol;
        private System.Windows.Forms.Button FiltroBtn;
    }
}