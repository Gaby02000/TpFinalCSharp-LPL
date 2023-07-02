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
    public partial class FrmActividadList : FormBase
    {
        private List<Actividad> _listado;
        private string _criterio = null;
        public FrmActividadList()
        {
            InitializeComponent();
        }

        private void ActividadGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ActividadGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.ActividadGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmActividadAM frm = new FrmActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarActividad(this, (this.ActividadGrd.SelectedRows[0].DataBoundItem as Actividad));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = ActividadGrd.SelectedRows[0].Index;
                this.ActividadGrd.DataSource = Actividad.FindAllStatic(_criterio, (e1, e2) => e1.Id.CompareTo(e2.Id));
                ActividadGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Actividad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

  
        public void ShowListado(List<Actividad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ActividadGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Actividad>(listado);
            var source = new BindingSource(bindingList, null);
            this.ActividadGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }


        private void FrmLocalidadList_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ActividadGrd.SelectedRows.Count > 0)
            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmActividadAM frm = new FrmActividadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarActividad(this, (this.ActividadGrd.SelectedRows[0].DataBoundItem as Actividad));
            }
        }
        private void ActividadesGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < this.ActividadGrd.Rows.Count; ++i)
            {
                DataGridViewRow item = this.ActividadGrd.Rows[i];
                item.Cells[1].Value = (item.DataBoundItem as Actividad).ProfesorActividad.Nombres;
                item.Cells[1].Value += " ";
                item.Cells[1].Value += (item.DataBoundItem as Actividad).ProfesorActividad.Apellido;
                item.Cells[2].Value = (item.DataBoundItem as Actividad).TipoActividadActividad.Nombre;
       
            }
            
        }
        private void CerrarBtn_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmActividadList_Load(object sender, EventArgs e)
        {

        }
    } 
}
    

