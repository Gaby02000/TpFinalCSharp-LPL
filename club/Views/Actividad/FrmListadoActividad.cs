using clubApp.db;
using System;
using System.CodeDom;
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
    public partial class FrmListadoActividad : FormBase
    {
        public FrmListadoActividad()
        {
            InitializeComponent();
        }

        private void FrmListadoActividad_Load(object sender, EventArgs e)
        {

        }

   

            private void TipoActChk_CheckedChanged(object sender, EventArgs e)
            {
                this.TipoActTxt.Enabled = this.TipoActChk.Checked;
            }

            private void FrmListActividad_Load(object sender, EventArgs e)
            {

                this.ActividadesGrd.AutoGenerateColumns = false;
                this.ActividadesGrd.DataSource = Actividad.FindAllStatic(null, (p1, p2) => (p1.CodTipoActividad).CompareTo(p2.CodTipoActividad));
            }
            private void FiltroBtn_Click_1(object sender, EventArgs e)
            {
            string criterio = null;
            if (this.TipoActChk.Checked)
            {
                if (criterio == null) 
                    criterio = String.Format("cod_tipo_act={0}", TipoActTxt.Text);
                else
                    criterio += String.Format("and cod_tipo_act={0}", TipoActTxt.Text);
            }

            this.ActividadesGrd.DataSource = Actividad.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id));
            }

           

        

            private void ActividadesGrd_DoubleClick(object sender, EventArgs e)
            {
                FrmActividadAM frmpac = new FrmActividadAM();
                Actividad pac = (this.ActividadesGrd.SelectedRows[0].DataBoundItem as Actividad);
                frmpac.ShowModificarActividad(pac);
            }

            private void ExportarBtn_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Implementar funcionalidad...!", "falta...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        private void ActividadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.ActividadesGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadesGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as Actividad).ProfesorActividad.Nombres;
                item.Cells[1].Value += " ";
                item.Cells[1].Value += (item.DataBoundItem as Actividad).ProfesorActividad.Apellido;
                item.Cells[2].Value = (item.DataBoundItem as Actividad).TipoActividadActividad.Nombre;

            }

        }

    }
}
