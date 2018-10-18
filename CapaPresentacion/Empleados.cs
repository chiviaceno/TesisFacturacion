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
    public partial class Empleados : Form
    {
        private CNEmpleado objetoCN = new CNEmpleado();
        private CEEmpleado objetoCE = new CEEmpleado();
        private string IdEmpleado = null;
        private Boolean Editar = false;

        public Empleados()
        {
            InitializeComponent();
        }

        #region MANEJO DE FORMULARIO

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void Empleados_Load(object sender, EventArgs e)
        {
            MostrarEmpleado();
            ListarEmpresas();
        }
        private void ListarEmpresas()
        {
            CNEmpleado _objetoCN = new CNEmpleado();
            cbxEmpresa.DataSource = _objetoCN.MostrarEmpresa();
            cbxEmpresa.DisplayMember = "RAZON SOCIAL";
            cbxEmpresa.ValueMember = "ID";
        }
        private void MostrarEmpleado()
        {
            CNEmpleado objeto = new CNEmpleado();
            dataGridView1.DataSource = objeto.MostrarEmpleado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERTAR EMPLEADO
            if (Editar == false)
            {
                try
                {
                    objetoCE.Id_Empl = Convert.ToInt32(cbxEmpresa.SelectedValue);
                    objetoCE.Nombre = txtNombre.Text;
                    objetoCE.Apellido = txtApellido.Text;
                    objetoCE.Cedula = txtCedula.Text;
                    objetoCE.Dirrecion = txtDireccion.Text;
                    objetoCE.Telefono = txtTelefono.Text;
                    objetoCE.Email = txtEmail.Text;
                    objetoCE.Estado = cbxEstado.Text;
                    objetoCN.InsertarEmpleado(objetoCE);
                    MessageBox.Show("Se Ingreso correctamente el Empleado");
                    MostrarEmpleado();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Ingresar el Empleado por  " + ex);
                }

                // EDITAR EMPLEADO
            }
            if (Editar == true)
            {
                {
                    try
                    {
                        objetoCE.Id = Convert.ToInt32(IdEmpleado);
                        objetoCE.Id_Empl = Convert.ToInt32(cbxEmpresa.SelectedValue);
                        objetoCE.Nombre = txtNombre.Text;
                        objetoCE.Apellido = txtApellido.Text;
                        objetoCE.Cedula = txtCedula.Text;
                        objetoCE.Dirrecion = txtDireccion.Text;
                        objetoCE.Telefono = txtTelefono.Text;
                        objetoCE.Email = txtEmail.Text;
                        objetoCE.Estado = cbxEstado.Text;
                        objetoCN.EditarEmpleado(objetoCE);
                        MessageBox.Show("Se Editó correctamente el Empleado");
                        MostrarEmpleado();
                        LimpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede Editar el Empleado por  " + ex);
                    }

                }

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                cbxEmpresa.Text = dataGridView1.CurrentRow.Cells["EMPRESA"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NOMBRES"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["APELLIDOS"].Value.ToString();
                txtCedula.Text = dataGridView1.CurrentRow.Cells["CEDULA"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["DIRECCION"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["TELEFONO"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["E-MAIL"].Value.ToString();
                cbxEstado.Text = dataGridView1.CurrentRow.Cells["ESTADO"].Value.ToString();
                IdEmpleado = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Empleado");
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
                IdEmpleado = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCE.Id = Convert.ToInt32(IdEmpleado);
                objetoCN.EliminarEmpleado(objetoCE);
                MessageBox.Show("Se Eliminó correctamente el Empleado");
                MostrarEmpleado();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Empleado");
            }
        }
    }
}
