using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.frmMantenimientos
{
    public partial class frmBuscarProducto : Form
    {
        int idProducto;

        public int IDProducto
        {
            get { return idProducto; }
        }

        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void frmProductoBusqueda_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.fAC_PRODUCTOTableAdapter.Fill(this.dSCombos.FAC_PRODUCTO);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void btnQuitaFiltros_Click(object sender, EventArgs e)
        {
            pRO_DESCRIPCIONToolStripTextBox.Text = string.Empty;
            pRO_NOTASToolStripTextBox.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idProducto = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvBusqueda.Rows.Count == 0)
            {
                idProducto = 0;
            }
            else if (dgvBusqueda.SelectedRows.Count != 0)
            {
                idProducto = (int)dgvBusqueda.SelectedRows[0].Cells[0].Value;
            }
            else
            {
                idProducto = (int)dgvBusqueda.Rows[0].Cells[0].Value;
            }
            this.Close();

        }

        private void AplicarFiltros()
        {
            string descripcion, notas;

            descripcion = "%" + pRO_DESCRIPCIONToolStripTextBox.Text + "%";
            notas = "%" + pRO_NOTASToolStripTextBox.Text + "%";

            try
            {
                this.fAC_PRODUCTOTableAdapter.FillBy(this.dSCombos.FAC_PRODUCTO, descripcion, notas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pRO_DESCRIPCIONToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void pRO_NOTASToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

    }
}
