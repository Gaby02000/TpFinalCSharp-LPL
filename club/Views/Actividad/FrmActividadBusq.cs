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
    public partial class FrmActividadBusq : FormBase
    {
        public FrmActividadBusq()
        {
            InitializeComponent();
        }

       
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.           
            string criterio = null;
            if (this.LegajoProfeChk.Checked)
            {
                
                criterio = String.Format("legajo_profe={0}", LegajoProfeTxt.Text);
            }

            if (this.CodTipoActividadChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("cod_tipo_act={0}", CodTipoActTxt.Text);
                else
                    criterio += String.Format("and cod_tipo_act={0}", CodTipoActTxt.Text);
            }
            if (this.FechaDesdeChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("fecha_desde like '%{0}%'", dateTimePicker1.Text);
                else
                    criterio += String.Format(" and fecha_desde like '%{0}%'", dateTimePicker2.Text);
            }
            if (this.FechaHastaChk.Checked)
            {
                if (criterio == null)
                    criterio = String.Format("fecha_fin like '%{0}%'", FechaHastaChk.Text);
                else
                    criterio += String.Format(" and fecha_fin like '%{0}%'", FechaHastaChk.Text);
            }

            try
            {
                var lista = Actividad.FindAllStatic(criterio, (p1, p2) => (p1.LegajoProfe).CompareTo(p2.LegajoProfe));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmActividadList frm = new FrmActividadList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LegajoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LegajoProfeTxt.Enabled = this.LegajoProfeChk.Checked;
        }

        private void CodActividadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodTipoActTxt.Enabled = this.CodTipoActividadChk.Checked;
        }

        private void FechaDesdeChk_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = this.FechaDesdeChk.Checked;
        }
        private void FechaHastaChk_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker2.Enabled = this.FechaHastaChk.Checked;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmActividadBusq_Load(object sender, EventArgs e)
        {

        }

        private void FrmActividadBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void FechaDesdeTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
