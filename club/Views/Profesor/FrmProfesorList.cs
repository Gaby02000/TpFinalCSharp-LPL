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
    public partial class FrmProfesorList : FormBase
    {
        private string _criterio = null;
        private List<Profesor> _listado;

        public FrmProfesorList()
        {
            InitializeComponent();
        }

        private void FrmProfesorList_Load(object sender, EventArgs e)
        {
            //this.ProfesoresGrd.DataBindingComplete += ProfesoresGrd_DataBindingComplete;
        }

        public void ShowListado(List<Profesor> listado, FormBase Invoker, string criterio)
        {
            this.InvokerForm = Invoker;
            _listado = listado;
            _criterio = criterio;
            this.ProfesoresGrd.AutoGenerateColumns = false;
            var bindingList = new BindingList<Profesor>(listado);
            var source = new BindingSource(bindingList, null);
            this.ProfesoresGrd.DataSource = source;
            InvokerForm.Close();
            this.MdiParent = MainView.Instance;
            this.Show();
        }

        /*private void ProfesoresGrd_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow rw in this.ProfesoresGrd.Rows)
            {
                rw.Cells[0].Value = (rw.DataBoundItem as Profesor).Legajo;
                rw.Cells[1].Value = (rw.DataBoundItem as Profesor).NroDocumento;
                rw.Cells[2].Value = (rw.DataBoundItem as Profesor).Apellido;
                rw.Cells[3].Value = (rw.DataBoundItem as Profesor).Nombres;
                rw.Cells[4].Value = (rw.DataBoundItem as Profesor).Domicilio;
                rw.Cells[5].Value = (rw.DataBoundItem as Profesor).Telefono;
            }
        }*/

        private void ProfesoresGrd_DoubleClick(object sender, EventArgs e)
        {
            if (this.ProfesoresGrd.SelectedRows.Count > 0)
            {
                MainView.Instance.Cursor = Cursors.WaitCursor;
                FrmProfesorAM frm = new FrmProfesorAM();
                frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
                frm.ShowModificarProfesor(this, (this.ProfesoresGrd.SelectedRows[0].DataBoundItem as Profesor));
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            this.Cursor = Cursors.Default;
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                var selAnt = ProfesoresGrd.SelectedRows[0].Index;
                this.ProfesoresGrd.DataSource = Profesor.FindAllStatic(_criterio, (e1, e2) => e1.NroDocumento.CompareTo(e2.NroDocumento));
                ProfesoresGrd.Rows[selAnt].Selected = true;
                MessageBox.Show("Profesor actualizado", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProfesoresGrd_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = ProfesoresGrd.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = ProfesoresGrd.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    ProfesoresGrd.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            ProfesoresGrd.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoGbo_Enter(object sender, EventArgs e)
        {

        }

        private void ProfesoresGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
