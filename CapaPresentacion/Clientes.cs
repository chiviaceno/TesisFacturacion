using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacionAdministracion
{
    public partial class Clientes : Form
    {
        private CNCliente objetoCN = new CNCliente();
        private CECliente objetoCE = new CECliente();
        private string IdCliente = null;
        private Boolean Editar = false;

        #region MANEJO DEL FORMULARIO
        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }
        private void MostrarCliente()
        {
            CNCliente objeto = new CNCliente();
            dataGridView1.DataSource = objeto.MostrarCliente();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERTAR EMPLEADO
            if (Editar == false)
            {
                try
                {
                    objetoCE.Nombre = txtNombre.Text;
                    objetoCE.Apellido = txtApellido.Text;
                    objetoCE.Cedula = txtCedula.Text;
                    objetoCE.Dirrecion = txtDireccion.Text;
                    objetoCE.Telefono = txtTelefono.Text;
                    objetoCE.Email = txtEmail.Text;
                    objetoCE.Fecha = dtmFecha.Text;
                    objetoCE.Estado = cbxEstado.Text;
                    objetoCN.InsertarCliente(objetoCE);
                    MessageBox.Show("Se Ingreso correctamente el Cliente");
                    MostrarCliente();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Ingresar el Cliente por  " + ex);
                }

                // EDITAR EMPLEADO
            }
            if (Editar == true)
            {
                {
                    try
                    {
                        objetoCE.Id = Convert.ToInt32(IdCliente);
                        objetoCE.Apellido = txtApellido.Text;
                        objetoCE.Cedula = txtCedula.Text;
                        objetoCE.Dirrecion = txtDireccion.Text;
                        objetoCE.Telefono = txtTelefono.Text;
                        objetoCE.Email = txtEmail.Text;
                        objetoCE.Fecha = dtmFecha.Text;
                        objetoCE.Estado = cbxEstado.Text;
                        objetoCN.EditarCliente(objetoCE);
                        MessageBox.Show("Se Editó correctamente el Cliente");
                        MostrarCliente();
                        LimpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede Editar el Cliente por  " + ex);
                    }

                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["CLI_NOMBRE"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["CLI_APLELLIDO"].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells["CLI_CEDULA"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["CLI_DIRECCION"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["CLI_TELEFONO"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["CLI_EMAIL"].Value.ToString();
                dtmFecha.Text = dataGridView1.CurrentRow.Cells["CLI_FECHA_REGISTRO"].Value.ToString();
                cbxEstado.Text = dataGridView1.CurrentRow.Cells["CLI_ESTADO"].Value.ToString();
                IdCliente = dataGridView1.CurrentRow.Cells["CLI_ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Cliente");
            }
        }
        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdCliente = dataGridView1.CurrentRow.Cells["CLI_ID"].Value.ToString();
                objetoCE.Id = Convert.ToInt32(IdCliente);
                objetoCN.EliminarCliente(objetoCE);
                MessageBox.Show("Se Eliminó correctamente el Cliente");
                MostrarCliente();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Cliente");
            }
        }

        
    }
}
