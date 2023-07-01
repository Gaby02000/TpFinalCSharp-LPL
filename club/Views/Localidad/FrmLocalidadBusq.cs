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
    public partial class FrmLocalidadBusq : FormBase
    {
        public FrmLocalidadBusq()
        {
            InitializeComponent();
        }

        private void FrmLocalidadBusq_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            

            MainView.Instance.Cursor = Cursors.WaitCursor;
            string criterio = null;
            if (this.CodigoPostalChk.Checked)
            {
                criterio = String.Format("cod_postal={0} ", CodigoPostalText.Text);
            }
            
            try
            {
                var lista = Localidad.FindAllStatic(criterio, (p1, p2) => (p1.Id).CompareTo(p2.Id));
                MainView.Instance.Cursor = Cursors.Default;

                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados con criterio ingresado", "Sin resultados...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // invocar Formulario de Listado.
                FrmLocalidadList frm = new FrmLocalidadList();
                frm.ShowListado(lista, this,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.CodPostalLabel.Enabled = this.CodigoPostalChk.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

