namespace clubApp.Views
{
    partial class FrmSocioAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocioAM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObservacionesTxt = new System.Windows.Forms.TextBox();
            this.DniTxt = new System.Windows.Forms.TextBox();
            this.DniLbl = new System.Windows.Forms.Label();
            this.LocalidadCbo = new System.Windows.Forms.ComboBox();
            this.LocalidadLbl = new System.Windows.Forms.Label();
            this.TelefonoTxt = new System.Windows.Forms.TextBox();
            this.TelefonoLbl = new System.Windows.Forms.Label();
            this.DomicilioTxt = new System.Windows.Forms.TextBox();
            this.DomicilioLbl = new System.Windows.Forms.Label();
            this.NombresTxt = new System.Windows.Forms.TextBox();
            this.NombresLbl = new System.Windows.Forms.Label();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.ApellidoLbl = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ErrorValidaSocio = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActividadesBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaSocio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ObservacionesTxt);
            this.groupBox1.Controls.Add(this.DniTxt);
            this.groupBox1.Controls.Add(this.DniLbl);
            this.groupBox1.Controls.Add(this.LocalidadCbo);
            this.groupBox1.Controls.Add(this.LocalidadLbl);
            this.groupBox1.Controls.Add(this.TelefonoTxt);
            this.groupBox1.Controls.Add(this.TelefonoLbl);
            this.groupBox1.Controls.Add(this.DomicilioTxt);
            this.groupBox1.Controls.Add(this.DomicilioLbl);
            this.groupBox1.Controls.Add(this.NombresTxt);
            this.groupBox1.Controls.Add(this.NombresLbl);
            this.groupBox1.Controls.Add(this.ApellidoTxt);
            this.groupBox1.Controls.Add(this.ApellidoLbl);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // ObservacionesTxt
            // 
            resources.ApplyResources(this.ObservacionesTxt, "ObservacionesTxt");
            this.ObservacionesTxt.Name = "ObservacionesTxt";
            this.ObservacionesTxt.Tag = "Observaciones";
            // 
            // DniTxt
            // 
            resources.ApplyResources(this.DniTxt, "DniTxt");
            this.DniTxt.Name = "DniTxt";
            this.DniTxt.Tag = "NroDocumento";
            this.DniTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DniTxt_KeyPress);
            // 
            // DniLbl
            // 
            resources.ApplyResources(this.DniLbl, "DniLbl");
            this.DniLbl.Name = "DniLbl";
            // 
            // LocalidadCbo
            // 
            this.LocalidadCbo.DisplayMember = "Nombre";
            this.LocalidadCbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadCbo.FormattingEnabled = true;
            resources.ApplyResources(this.LocalidadCbo, "LocalidadCbo");
            this.LocalidadCbo.Name = "LocalidadCbo";
            this.LocalidadCbo.Tag = "CodPostal";
            this.LocalidadCbo.ValueMember = "Id";
            // 
            // LocalidadLbl
            // 
            resources.ApplyResources(this.LocalidadLbl, "LocalidadLbl");
            this.LocalidadLbl.Name = "LocalidadLbl";
            // 
            // TelefonoTxt
            // 
            resources.ApplyResources(this.TelefonoTxt, "TelefonoTxt");
            this.TelefonoTxt.Name = "TelefonoTxt";
            this.TelefonoTxt.Tag = "Telefono";
            this.TelefonoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTxt_KeyPress);
            // 
            // TelefonoLbl
            // 
            resources.ApplyResources(this.TelefonoLbl, "TelefonoLbl");
            this.TelefonoLbl.Name = "TelefonoLbl";
            // 
            // DomicilioTxt
            // 
            resources.ApplyResources(this.DomicilioTxt, "DomicilioTxt");
            this.DomicilioTxt.Name = "DomicilioTxt";
            this.DomicilioTxt.Tag = "Domicilio";
            // 
            // DomicilioLbl
            // 
            resources.ApplyResources(this.DomicilioLbl, "DomicilioLbl");
            this.DomicilioLbl.Name = "DomicilioLbl";
            // 
            // NombresTxt
            // 
            resources.ApplyResources(this.NombresTxt, "NombresTxt");
            this.NombresTxt.Name = "NombresTxt";
            this.NombresTxt.Tag = "Nombres";
            this.NombresTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTxt_KeyPress);
            // 
            // NombresLbl
            // 
            resources.ApplyResources(this.NombresLbl, "NombresLbl");
            this.NombresLbl.Name = "NombresLbl";
            // 
            // ApellidoTxt
            // 
            resources.ApplyResources(this.ApellidoTxt, "ApellidoTxt");
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Tag = "Apellido";
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTxt_KeyPress);
            // 
            // ApellidoLbl
            // 
            resources.ApplyResources(this.ApellidoLbl, "ApellidoLbl");
            this.ApellidoLbl.Name = "ApellidoLbl";
            // 
            // CancelarBtn
            // 
            resources.ApplyResources(this.CancelarBtn, "CancelarBtn");
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // GuardarBtn
            // 
            resources.ApplyResources(this.GuardarBtn, "GuardarBtn");
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ErrorValidaSocio
            // 
            this.ErrorValidaSocio.ContainerControl = this;
            // 
            // ActividadesBtn
            // 
            resources.ApplyResources(this.ActividadesBtn, "ActividadesBtn");
            this.ActividadesBtn.Name = "ActividadesBtn";
            this.ActividadesBtn.UseVisualStyleBackColor = true;
            this.ActividadesBtn.Click += new System.EventHandler(this.ActividadesBtn_Click);
            // 
            // FrmSocioAM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ActividadesBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSocioAM";
            this.Deactivate += new System.EventHandler(this.FrmSocioAM_Deactivate);
            this.Load += new System.EventHandler(this.FrmpSocioAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorValidaSocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.Label ApellidoLbl;
        private System.Windows.Forms.TextBox NombresTxt;
        private System.Windows.Forms.Label NombresLbl;
        private System.Windows.Forms.ComboBox LocalidadCbo;
        private System.Windows.Forms.Label LocalidadLbl;
        private System.Windows.Forms.TextBox TelefonoTxt;
        private System.Windows.Forms.Label TelefonoLbl;
        private System.Windows.Forms.TextBox DomicilioTxt;
        private System.Windows.Forms.Label DomicilioLbl;
        private System.Windows.Forms.TextBox DniTxt;
        private System.Windows.Forms.Label DniLbl;
        private System.Windows.Forms.TextBox ObservacionesTxt;
        private System.Windows.Forms.ErrorProvider ErrorValidaSocio;
        private System.Windows.Forms.Button ActividadesBtn;
    }
}