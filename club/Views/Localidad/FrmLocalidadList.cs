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
    public partial class FrmLocalidadList : FormBase
    {
        private List<Localidad> _listado;
        private string _criterio = null;
        public void ShowListado(List<Localidad> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.dataGridView1.AutoGenerateColumns = false;
            var bindingList = new BindingList<Localidad>(listado);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }
        public FrmLocalidadList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmLocalidadList_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
     
        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = dataGridView1.SelectedRows[0].Index;
                this.dataGridView1.DataSource = Localidad.FindAllStatic(_criterio, (e1, e2) => e1.Id.CompareTo(e2.Id));
                dataGridView1.Rows[selAnt].Selected = true;
                MessageBox.Show("localidad actualizada", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
                if (this.dataGridView1.SelectedRows.Count > 0)
                            {

                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmLocalidadAM frm = new FrmLocalidadAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarLocalidad(this, (this.dataGridView1.SelectedRows[0].DataBoundItem as Localidad));
            }
        }
    }
}
