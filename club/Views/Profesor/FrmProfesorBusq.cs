using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clubApp.db;

namespace clubApp.Views
{
    public partial class FrmProfesorBusq : FormBase
    {
        public FrmProfesorBusq()
        {
            InitializeComponent();
        }
        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowBuscar()
        {
            this.Show();
        }

        private void FrmProfesorBusq_Load(object sender, EventArgs e)
        {

        }

        private void FrmProfesorBusq_Activated(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Default;
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void NombreChk_CheckedChanged(object sender, EventArgs e)
        {
            this.NombreTxt.Enabled = this.NombreChk.Checked;
        }

        private void LegajoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.LegajoTxt.Enabled = this.LegajoChk.Checked;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            // verificar si hay multiples opciones a usar como filtro que elija alguna, si son dos campos, no hace falta.            
            string criterio = null;
            if (this.ApellidoChk.Checked)
            {
                criterio = String.Format(" apellido like '%{0}%' ", ApellidoTxt.Text);
            }

            if (this.NombreChk.Checked)
            {
                criterio = String.Format(" nombre like '%{0}%' ", NombreTxt.Text);
                /*if (criterio == null)
                    criterio = String.Format(" nombre like '%{0}%' ", NombreTxt.Text);
                else
                    criterio += String.Format(" and nombre like '%{0}%' ", NombreTxt.Text);*/
            }

            if (this.LegajoChk.Checked)
            {
                criterio = String.Format(" legajo = {0} ", LegajoTxt.Text);
                /*if (criterio == null)
                    criterio = String.Format(" legajo = {0} ", LegajoTxt.Text);
                else
                    criterio += String.Format(" and legajo = {0} ", LegajoTxt.Text);*/
            }

            try
            {
                var lista = Profesor.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmProfesorList frm = new FrmProfesorList();
                frm.ShowListado(lista, this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en la busqueda: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
