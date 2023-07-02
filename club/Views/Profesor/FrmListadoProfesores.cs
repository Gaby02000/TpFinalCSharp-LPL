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
    public partial class FrmListadoProfesores : FormBase
    {
        public FrmListadoProfesores()
        {
            InitializeComponent();
        }

        private void ApellidoChk_CheckedChanged(object sender, EventArgs e)
        {
            this.ApellidoTxt.Enabled = this.ApellidoChk.Checked;
        }

        private void FrmListadoProfesors_Load(object sender, EventArgs e)
        {
            this.ProfesoresGrd.AutoGenerateColumns = false;
            //this.ProfesoresGrd.DataSource = ORMDB<Profesor>.FindAll(null);
            this.ProfesoresGrd.DataSource = Profesor.FindAllStatic(null, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
        }
                
        private void FiltroBtn_Click(object sender, EventArgs e)
        {
            string criterio = null;

            if (this.ApellidoChk.Checked && !string.IsNullOrEmpty(this.ApellidoTxt.Text))
            {
                if (criterio != null)
                {
                    criterio = String.Format(" and apellido like '%{0}%' ", ApellidoTxt.Text);
                }
                else
                    criterio = String.Format(" apellido like '%{0}%' ", ApellidoTxt.Text);
            }

            this.ProfesoresGrd.AutoGenerateColumns = false;
            //this.ProfesoresGrd.DataSource = ORMDB<Profesor>.FindAll(criterio);
            this.ProfesoresGrd.DataSource = Profesor.FindAllStatic(criterio, (p1, p2) => (p1.Apellido + p1.Nombres).CompareTo(p2.Apellido + p2.Nombres));
        }

        /*private void ProfesoresGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ProfesoresGrd.Rows)
            {
                rw.Cells[2].Value = (rw.DataBoundItem as Profesor).Apellido;
            }
        }*/

        public void ShowListar()
        {
            this.Show();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfesoresGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*private void ProfesoresGrd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}
