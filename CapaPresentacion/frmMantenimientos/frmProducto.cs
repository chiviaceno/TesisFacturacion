using System;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.frmMantenimientos
{
    public partial class frmProducto : Form
    {
        public frmProducto()
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

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.Bodega' Puede moverla o quitarla según sea necesario.
            this.bodegaTableAdapter.Fill(this.dSCombos.Bodega);
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_IVA' Puede moverla o quitarla según sea necesario.
            this.fAC_IVATableAdapter.Fill(this.dSCombos.FAC_IVA);
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_TIPO_ESTADOS' Puede moverla o quitarla según sea necesario.
            this.fAC_TIPO_ESTADOSTableAdapter.Fill(this.dSCombos.FAC_TIPO_ESTADOS);
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_TIPO_ESTADOS' Puede moverla o quitarla según sea necesario.
            this.fAC_TIPO_ESTADOSTableAdapter.Fill(this.dSCombos.FAC_TIPO_ESTADOS);

            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_TIPOS_MEDIDA' Puede moverla o quitarla según sea necesario.
            this.fAC_TIPOS_MEDIDATableAdapter.Fill(this.dSCombos.FAC_TIPOS_MEDIDA);
            // TODO: esta línea de código carga datos en la tabla 'dSCombos.FAC_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.fAC_PRODUCTOTableAdapter.Fill(this.dSCombos.FAC_PRODUCTO);
        }

        private void bindingNavigatorEdit_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            fAC_PRODUCTOBindingSource.AddNew();
            pRO_DESCRIPCIONTextBox.Focus();
        }

        private void bindingNavigatorCancelOpertation_Click(object sender, EventArgs e)
        {
            this.fAC_PRODUCTOBindingSource.CancelEdit();
            DeshabilitarCampos();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Estas seguro de borrar el código de barras?", "Confirmación",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No) return;
            fAC_PRODUCTOBindingSource.RemoveAt(fAC_PRODUCTOBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSCombos);
        }

        private string rutaInicial, rutaFinal = @"Imagenes\Productos\", direccionArchivo, nombreArchivo;
        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pRO_IMAGENTextBox.Text = openFileDialog1.SafeFileName;//Safe

            //COMMENT: Asignamos valores a las variables
            direccionArchivo = openFileDialog1.FileName;
            nombreArchivo = openFileDialog1.SafeFileName;
            rutaInicial = direccionArchivo.Substring(0, direccionArchivo.LastIndexOf("\\") + 1);

            CargarImagen();
        }

        #region "METODODS"
        private void HabilitarCampos()
        {
            // COMMENT: Habilitar y deshabilitar los menus
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorPositionItem.Enabled = false;
            bindingNavigatorCountItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorEdit.Enabled = false;
            bindingNavigatorCancelOpertation.Enabled = true;
            fAC_PRODUCTOBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorSearch.Enabled = false;

            // COMMENT: Habilitar los textos
            pRO_DESCRIPCIONTextBox.ReadOnly = false;
            pRO_PRECIOTextBox.ReadOnly = false;
            pRO_MEDIDATextBox.ReadOnly = false;
            pRO_IMAGENTextBox.ReadOnly = false;
            pRO_NOTASTextBox.ReadOnly = false;

            // COMMENT: Habilitar los combos y botones
            pRO_MEDIDAIDComboBox.Enabled = true;
            pRO_IVAIDComboBox.Enabled = true;
            pRO_ESTADOComboBox.Enabled = true;
            btnBuscarImagen.Enabled = true;
            btnAgregarBarra.Enabled = true;
            btnEliminarBarra.Enabled = true;
            btnAgregarBodega.Enabled = true;
            btnModificarBodega.Enabled = true;



            // COMMENT: Deshabilitar la tabla
            fAC_PRODUCTODataGridView.Enabled = false;
        }

        private void HabilitarCampos2()
        {
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            rutaInicial = string.Empty;
            direccionArchivo = string.Empty;
            nombreArchivo = string.Empty;

        }

        private void DeshabilitarCampos()
        {
            // COMMENT: Deshabilitar y habilitar los menus
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorPositionItem.Enabled = true;
            bindingNavigatorCountItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;

            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorEdit.Enabled = true;
            bindingNavigatorCancelOpertation.Enabled = false;
            fAC_PRODUCTOBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = true;
            bindingNavigatorSearch.Enabled = true;

            // COMMENT: Deshabilitar los textos
            pRO_DESCRIPCIONTextBox.ReadOnly = true;
            pRO_PRECIOTextBox.ReadOnly = true;
            pRO_MEDIDATextBox.ReadOnly = true;
            pRO_IMAGENTextBox.ReadOnly = true;
            pRO_NOTASTextBox.ReadOnly = true;


            // COMMENT: Deshabilitar los combos y botones
            pRO_MEDIDAIDComboBox.Enabled = false;
            pRO_IVAIDComboBox.Enabled = false;
            pRO_ESTADOComboBox.Enabled = false;
            btnBuscarImagen.Enabled = false;
            btnAgregarBarra.Enabled = false;
            btnEliminarBarra.Enabled = false;
            btnAgregarBodega.Enabled = false;
            btnModificarBodega.Enabled = false;

            // COMMENT: Deshabilitar la tabla
            fAC_PRODUCTODataGridView.Enabled = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(pRO_DESCRIPCIONTextBox.Text))
            {
                errorProvider1.SetError(pRO_DESCRIPCIONTextBox, "Este campo es requerido");
                pRO_DESCRIPCIONTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            decimal precio;
            if (!(decimal.TryParse(pRO_PRECIOTextBox.Text, out precio)))
            {
                errorProvider1.SetError(pRO_PRECIOTextBox, "Debe ingresar un valor númerico");
                pRO_PRECIOTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (precio <= 0)
            {
                errorProvider1.SetError(pRO_PRECIOTextBox, "Debe ingresar un valor númerico mayor a cero (0)");
                pRO_PRECIOTextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (pRO_IVAIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(pRO_IVAIDComboBox, "Debe Seleccionar un Item");
                pRO_IVAIDComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (pRO_MEDIDAIDComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(pRO_MEDIDAIDComboBox, "Debe Seleccionar un Item");
                pRO_MEDIDAIDComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            float medida;
            if (!(float.TryParse(pRO_MEDIDATextBox.Text, out medida)))
            {
                errorProvider1.SetError(pRO_MEDIDATextBox, "Debe ingresar un valor númerico");
                pRO_MEDIDATextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (medida <= 0)
            {
                errorProvider1.SetError(pRO_MEDIDATextBox, "Debe ingresar un valor númerico mayor a cero (0)");
                pRO_MEDIDATextBox.Focus();
                return false;
            }
            errorProvider1.Clear();


            if (pRO_ESTADOComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(pRO_ESTADOComboBox, "Debe Seleccionar un Item");
                pRO_ESTADOComboBox.Focus();
                return false;
            }
            errorProvider1.Clear();


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

            return true;
        }

        private void LlenarGrillas()
        {
            if (string.IsNullOrEmpty(pRO_IDTextBox.Text)) return;
            this.fAC_BARRATableAdapter.FillBy1(this.dSCombos1.FAC_BARRA, Convert.ToInt32(pRO_IDTextBox.Text));
            this.bodegaProductoTableAdapter.FillBy(this.dSCombos.BodegaProducto, Convert.ToInt32(pRO_IDTextBox.Text));
        }

        private void CargarImagen()
        {
            if (string.IsNullOrEmpty(pRO_IMAGENTextBox.Text))
            {
                pbxImagen.Image = null;
            }
            else
            {
                string ruta = rutaFinal + pRO_IMAGENTextBox.Text;
                if (File.Exists(ruta))
                {
                    pbxImagen.Load(ruta);
                }
                else
                {
                    pbxImagen.Image = null;
                }
            }
        }

        private bool GuardarImagen()
        {
            bool saveImage = false;
            if (!(Directory.Exists(rutaFinal))) //COMMENT: Verifica si no hay la carpeta Productos
            {
                Directory.CreateDirectory(rutaFinal);//COMMENT: Crea la carpeta llamada Productos
            }

            if (!File.Exists(rutaFinal + nombreArchivo))
            {
                File.Copy(rutaInicial + nombreArchivo, rutaFinal + nombreArchivo);
                saveImage = true;
            }
            else
            {
                DialogResult rta = MessageBox.Show("Ya existe una imagen con este nombre\nDesea reemplazar", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (rta == DialogResult.No)
                {
                    saveImage = false;
                }
                else
                {
                    try
                    {
                        string extension = Path.GetExtension(rutaInicial + nombreArchivo);
                        string newNombreArchivo = nombreArchivo.Substring(0, nombreArchivo.LastIndexOf("."));
                        string cambiaExtensionArchivo = newNombreArchivo+"_Copia"+extension;
                        File.Copy(rutaInicial + nombreArchivo, rutaFinal + cambiaExtensionArchivo);
                        saveImage = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se puede reemplazar por que la imagen ya esta asignada a un Producto", "Alerta");
                        saveImage = false;
                    }
                }

            }
            return saveImage;
        }
        #endregion

        private void bindingNavigatorSearch_Click(object sender, EventArgs e)
        {
            frmBuscarProducto miBusqueda = new frmBuscarProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDProducto == 0) return;
            int position = fAC_PRODUCTOBindingSource.Find("PRO_ID", miBusqueda.IDProducto);
            fAC_PRODUCTOBindingSource.Position = position;
        }

        private void fAC_PRODUCTOBindingSource_PositionChanged(object sender, EventArgs e)
        {
            HabilitarCampos2();
            LlenarGrillas();
            CargarImagen();
        }

        private void fAC_PRODUCTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (!GuardarImagen()) return;
            this.Validate();
            this.fAC_PRODUCTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCombos);
            DeshabilitarCampos();
        }
    }
}
