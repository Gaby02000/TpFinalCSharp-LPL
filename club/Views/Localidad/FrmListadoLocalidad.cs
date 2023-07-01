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
    public partial class FrmListadoLocalidad : Form
    {
        public FrmListadoLocalidad()
        {
            InitializeComponent();
        }
        private void FrmListadoLocalidad_Load(object sender, EventArgs e)
        {
            this.LocalidadGrd.AutoGenerateColumns = false;
            this.LocalidadGrd.DataSource = Localidad.FindAllStatic(null, (p1, p2) => ( p1.Id).CompareTo( p2.Id));
        }
        private void SociosGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LocalidadChk_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalTxt.Enabled = this.CodPostalChk.Checked;
        }
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            //
            string criterio = null;

            this.LocalidadGrd.DataSource = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Id ).CompareTo( p2.Id));
        }
        private void LocalidadGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.LocalidadGrd.Rows)
            {
                rw.Cells[3].Value = (rw.DataBoundItem as Localidad).Nombre;
            }
        }
        private void LocalidadGrd_DoubleClick(object sender, EventArgs e)
        {
            FrmLocalidadAM frmpac = new FrmLocalidadAM();
            Localidad pac = (this.LocalidadGrd.SelectedRows[0].DataBoundItem as Localidad);
            frmpac.ShowModificarLocalidad(pac);
        }
    }
}
