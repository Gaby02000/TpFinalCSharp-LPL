using clubApp.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace clubApp.Views
{
    [Permiso(ClaseBaseForm = "Localidad", FuncionPermiso = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad", RolUsuario = "administrador,operadorProfesor,consulta,operador")]

    public partial class FrmLocalidadAM : FormBase
    {
        public override event FormEvent DoCompleteOperationForm;
        private Localidad _Localidad_modif = null;
        private string LocalidadLog = "";
        public FrmLocalidadAM()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Localidad localidad = null;
            string errMsj = "";
            string operacionLog = "";
            string detalleLog = "";
            MainView.Instance.Cursor = Cursors.WaitCursor;

            if (OperacionForm == FrmOperacion.frmAlta)
            {
                localidad = new Localidad();
                operacionLog = "ALTA";
                // cargar la info de la Localidad antes de dar de alta.
            }
            if (OperacionForm == FrmOperacion.frmModificacion)
            {
                operacionLog = "MODIFICACION";
                localidad = _Localidad_modif;
                detalleLog = "OBJ-Antes:" + LocalidadLog + " - OBJ-MOD";
            }

            if (NombreTxt.Text == "")
            {
                MessageBox.Show("Ingrese nombre", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                NombreTxt.Focus();
                return;
            }

            if (CodPostalTxt.Text == "")
            {
                MessageBox.Show("Ingrese codigo postal", "Dato(s) faltante(s)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CodPostalTxt.Focus();
                return;
            }


            localidad = new Localidad();
            localidad.Nombre = NombreTxt.Text;
            localidad.Id = Int32.Parse(CodPostalTxt.Text);
          

            detalleLog += Newtonsoft.Json.JsonConvert.SerializeObject(localidad);
            // intentar guardar en la Base de datos.
            try
            {
                    localidad.SaveObj();
                    Logger.SaveLog(operacionLog, this.getPermisoObj.ClaseBaseForm, detalleLog);

            }
            catch (Exception ex)
            {
                if (Localidad.ExisteLocalidad(localidad.Id))       // TODO excepción "backend sent unrecognized response type r"
                {
                    errMsj = "ya se encuentra registrado una localidad con el codigo postal ingresado";
                }
                else
                {
                    errMsj = "Error: " + ex.Message;
                }
            }
            // si esta configurado, al form invoker enviarle evento de operacion completa
            if (DoCompleteOperationForm != null)
            {
                if (errMsj == "")
                    DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad, Status = TipoOperacionStatus.stOK });
                else
                    DoCompleteOperationForm(localidad, new EventArgDom { ObjProcess = localidad, Mensaje = errMsj, Status = TipoOperacionStatus.stError });
            }

            if (this.InvokerForm != null)
            {
                InvokerForm.Reload();
            }
            MainView.Instance.Cursor = Cursors.Default;
            this.Close();
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
                    this.Text = "Ingreso de nuevo Localidad...";
                }
                if (value == FrmOperacion.frmModificacion)
                {
                    this.Text = "Actualizacion de datos de Localidad...";
                }
                if (value == FrmOperacion.frmConsulta)
                {
                    this.Text = "Consulta de datos de Localidad...";
                    this.GuardarBtn.Visible = false;
                }

            }
        }

        private void CodPostalTxt_TextChanged(object sender, EventArgs e)
        {

        }
        public void ShowIngresoLocalidad(FormBase Invoker)
        {
            this.InvokerForm = Invoker;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        public void ShowIngresoLocalidad()
        {
            this.InvokerForm = null;
            this.OperacionForm = FrmOperacion.frmAlta;
            this.ShowDialog();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ShowModificarLocalidad(FormBase Invoker, Localidad Localidad_modif)
        {
            ShowInfoLocalidadInForm(Localidad_modif, Invoker);
        }

        public void ShowModificarLocalidad(Localidad Localidad_modif)
        {
            ShowInfoLocalidadInForm(Localidad_modif, null);
        }

        private void ShowInfoLocalidadInForm(Localidad Localidad_modif, FormBase Invoker)
        {
            this.OperacionForm = FrmOperacion.frmModificacion;
            _Localidad_modif = Localidad_modif;
            LocalidadLog = Newtonsoft.Json.JsonConvert.SerializeObject(_Localidad_modif);
            // cargar cada control con informacion de la Localidad....
            FormBase.ShowDataFromModel(this, Localidad_modif);
            this.InvokerForm = Invoker;
            this.ShowDialog();

        }
        private void CodPostalTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
