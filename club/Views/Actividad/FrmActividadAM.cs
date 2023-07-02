using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clubApp.Views
{  
    [Permiso(ClaseBaseForm = "Actividad", FuncionPermiso = "AltaActividad,ModificaActividad,ConsultaActividad", RolUsuario = "administrador,operadorSocio,operadorTurno,consulta,operador")]
    public partial class FrmActividadAM : FormBase
    {
      
        // Requerida override para poder agregarle un handler
        public override event FormEvent DoCompleteOperationForm;
        private Actividad _Actividad_modif = null;
        private string ActividadLog = "";

        public FrmActividadAM()
        {
            InitializeComponent();
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Actividad Actividad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            #region validaciones
            if (LegajoProfeTxt.Text == "")
            {
                MessageBox.Show("Falta Legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LegajoProfeTxt.Focus();
                return;
            }
            if (TipoActividadTxt.Text == "")
            {
                MessageBox.Show("Falta tipo Actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TipoActividadTxt.Focus();
                return;
            }
            if (FechaInicioTxt.Text == "")
            {
                MessageBox.Show("Falta fecha inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FechaInicioTxt.Focus();
                return;
            }
            if (FechaFinTxt.Text == "")
            {
                return;
            }

            #endregion

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                Actividad = new Actividad();
                operacionLog = "ALTA";

            }

            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                Actividad = _Actividad_modif;
                detalleLog = "OBJ-Antes:" + ActividadLog + " - OBJ-MOD";
            }
            if (OperacionForm == FrmOperacion.frmConsulta)
            {
                operacionLog = "CONSULTA";
            }


            Actividad.LegajoProfe = Convert.ToInt32(LegajoProfeTxt.Text);
            Actividad.CodTipoActividad = Convert.ToInt32(TipoActividadTxt.Text);
            Actividad.FechaDesde = Convert.ToDateTime(FechaInicioTxt.Text);
            Actividad.FechaHasta = null;

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(Actividad);

            try
            {
                Actividad.SaveObj();
                Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);
            }
            catch (Exception ex)
            {
                errMsj = "Error: " + ex.Message;
            }
          
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(Actividad, new EventArgDom { ObjProcess = Actividad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(Actividad, new EventArgDom { ObjProcess = Actividad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
        }
        private void FrmActividadAM_Load(object sender, EventArgs e)
        {

        }

        private void LegajoProfeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void TipoActividadTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaInicioTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaFinTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LegajoProfeLbl_Click(object sender, EventArgs e)
        {

        }

        private void TipoActividadLbl_Click(object sender, EventArgs e)
        {

        }

        private void FechaInicioLbl_Click(object sender, EventArgs e)
        {

        }

        private void FechaFinLbl_Click(object sender, EventArgs e)
        {

        }


        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        public override void ConfigurePermiso(PermisoAttribute perm)
        {
            if (perm != null)
            {
                this.GuardarBtn.Enabled = perm.HasAddPerm || perm.HasUpdPerm;
                if (!this.GuardarBtn.Enabled && perm.HasViewPerm)
                {
                    this.GuardarBtn.Visible = false;
                    FormBase.SoloConsulta(this);
                    OperacionForm = FrmOperacion.frmConsulta;
                }
            }
        }
   
        
        public override FrmOperacion OperacionForm
        {
            get
            {
                return base.OperacionForm;
            }
            set
            {
                base.OperacionForm = value;
               
                if (value == FrmOperacion.frmAlta)
                {
                    this.Text = "Ingreso de actividad nuevo";
                   
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizar datos de actividad";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de actividad";
                    this.GuardarBtn.Visible = false;
                }
            }
        }
      

        
        // Notificara al Invocador que recargue algun cambio de datos.
        public void ShowModificarActividad(FormBase Invoker, Actividad Pac_modif)
        {
            ShowInfoActividadInForm(Pac_modif, Invoker);
        }
        public void ShowModificarActividad(Actividad Pac_modif)
        {
            ShowInfoActividadInForm(Pac_modif, null);
        }
        private void ShowInfoActividadInForm(Actividad Cli_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Actividad_modif = Cli_modif;
            ActividadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Actividad_modif);
     
            FormBase.ShowDataFromModel(this, Cli_modif);
            this.InvokerForm = Invoker;
            this.CancelarBtn.Click += new EventHandler(CancelarBtn_Click);
            this.ShowDialog();
        }
        public void ShowIngresoActividad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }
        public void ShowIngresoActividad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void FrmActividadAM_Deactivate(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

    }
}
