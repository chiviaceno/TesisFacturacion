using CapaDatos;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {

        public frmProductos()
        {
            InitializeComponent();
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.fAC_PRODUCTOTableAdapter.Fill(this.dSCombos.FAC_PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.fAC_PRODUCTOTableAdapter.Fill(this.dSCombos.FAC_PRODUCTO);

        }




        //private void DeshabilitarCampos()
        //{
        //    // COMMENT: Habilitar y deshabilitar los menus
        //    tsbEditar.Enabled = false;
        //    tsbNuevo.Enabled = true;
        //    tsbEliminar.Enabled = false;
        //    tsbGuardar.Enabled = false;
        //    tsbCancelar.Enabled = false;
        //    tsbBuscar.Enabled = true;

        //    // COMMENT: Deshabilitar los textos
        //    txtCodigo.ReadOnly = true;
        //    txtStock.ReadOnly = true;
        //    txtDescripcion.ReadOnly = true;
        //    txtEnvase.ReadOnly = true;
        //    txtPrecioCompra.ReadOnly = true;
        //    txtPrecioVenta.ReadOnly = true;

        //    // COMMENT: Deshabilitar los combos
        //    cmbUnidadMedida.Enabled = false;
        //    cmbIva.Enabled = false;
        //    cmbEstado.Enabled = false;

        //    // COMMENT: Habilitar la tabla
        //    dgvDatos.Enabled = true;
        //}

        //private void LimpiarCampos()
        //{
        //    txtId.Text = "";
        //    txtCodigo.Text = "";
        //    txtStock.Text = "";
        //    txtDescripcion.Text = "";
        //    txtEnvase.Text = "";
        //    txtPrecioCompra.Text = "";
        //    txtPrecioVenta.Text = "";
        //    //dtpAniversario.Value = DateTime.Now;
        //    cmbUnidadMedida.SelectedIndex = -1;
        //    cmbIva.SelectedIndex = -1;
        //    cmbEstado.SelectedIndex = -1;
        //}

        //private bool ValidarCampos()
        //{
        //    //Utilidades util = new Utilidades();

        //    if (string.IsNullOrEmpty(txtCodigo.Text))
        //    {
        //        errorProvider1.SetError(txtCodigo, "Este campo es requerido");
        //        txtCodigo.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (string.IsNullOrEmpty(txtStock.Text))
        //    {
        //        errorProvider1.SetError(txtStock, "Este campo es requerido");
        //        txtStock.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (string.IsNullOrEmpty(txtEnvase.Text))
        //    {
        //        errorProvider1.SetError(txtEnvase, "Este campo es requerido");
        //        txtEnvase.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (cmbUnidadMedida.SelectedIndex == -1)
        //    {
        //        errorProvider1.SetError(cmbUnidadMedida, "Debe Seleccionar un Item");
        //        cmbUnidadMedida.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (string.IsNullOrEmpty(txtDescripcion.Text))
        //    {
        //        errorProvider1.SetError(txtDescripcion, "Este campo es requerido");
        //        txtDescripcion.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (string.IsNullOrEmpty(txtPrecioCompra.Text))
        //    {
        //        errorProvider1.SetError(txtPrecioCompra, "Este campo es requerido");
        //        txtPrecioCompra.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (cmbIva.SelectedIndex == -1)
        //    {
        //        errorProvider1.SetError(cmbIva, "Debe Seleccionar un Item");
        //        cmbIva.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (string.IsNullOrEmpty(txtPrecioVenta.Text))
        //    {
        //        errorProvider1.SetError(txtPrecioVenta, "Este campo es requerido");
        //        txtPrecioVenta.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();

        //    if (cmbEstado.SelectedIndex == -1)
        //    {
        //        errorProvider1.SetError(cmbEstado, "Debe Seleccionar un Item");
        //        cmbEstado.Focus();
        //        return false;
        //    }
        //    errorProvider1.Clear();


        //    //if (Convert.ToString(cmbTipoDocumento.SelectedValue) == "1")
        //    //{
        //    //    bool statusCedula = util.CedulaBienEscrita(txtDocumento.Text);
        //    //    if (statusCedula == false)
        //    //    {
        //    //        errorProvider1.SetError(txtDocumento, "Debe ingresar un número de documento válido");
        //    //        txtDocumento.Focus();
        //    //        return false;
        //    //    }
        //    //    errorProvider1.Clear();
        //    //}
        //    //errorProvider1.Clear();
            
        //    return true;
        //}

        //private void HabilitarCampos2()
        //{
        //    tsbEditar.Enabled = true;
        //    tsbEliminar.Enabled = true;
        //}

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
