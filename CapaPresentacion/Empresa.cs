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
    public partial class Empresa : Form
    {
        private CNEmpresas objetoCN = new CNEmpresas();
        private CEEmpresas objetoCE = new CEEmpresas();
        private string IdCliente = null;
        private Boolean Editar = false;

        #region MANEJO DEL FORMULARIO
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
        public Empresa()
        {
            InitializeComponent();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            MostrarEmpresa();
        }
        #region CARGAR IMAGEN EN FORMULARIO

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                this.ofdImagen.ShowDialog();
                if (this.ofdImagen.FileName.Equals("") == false)
                {
                    ptbLogo.Load(this.ofdImagen.FileName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.ToString());
            } 
            #endregion
        }

        private void MostrarEmpresa()
        {
            CNEmpresas objeto = new CNEmpresas();
            dataGridView1.DataSource = objeto.MostrarEmpresa();
        }

        private void LimpiarForm()
        {
            txtRazonSocial.Clear();
            txtNombreFantasia.Clear();
            txtRuc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERTAR EMPLEADO
            if (Editar == false)
            {
                try
                {
                    

                    objetoCE.RazonSocial = txtRazonSocial.Text;
                    objetoCE.NombreFantasia = txtNombreFantasia.Text;
                    objetoCE.Ruc = txtRuc.Text;
                    objetoCE.Dirrecion = txtDireccion.Text;
                    objetoCE.Telefono = txtTelefono.Text;
                    objetoCE.Email = txtEmail.Text;
                    objetoCE.Logo = ptbLogo;
                    
                    objetoCN.InsertarEmpresa(objetoCE);
                    MessageBox.Show("Se Ingreso correctamente el Cliente");
                    MostrarEmpresa();
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
                        objetoCE.RazonSocial = txtRazonSocial.Text;
                        objetoCE.NombreFantasia = txtNombreFantasia.Text;
                        objetoCE.Ruc = txtRuc.Text;
                        objetoCE.Dirrecion = txtDireccion.Text;
                        objetoCE.Telefono = txtTelefono.Text;
                        objetoCE.Email = txtEmail.Text;
                        objetoCE.Logo = ptbLogo;
                        
                        objetoCN.EditarEmpresa(objetoCE);
                        MessageBox.Show("Se Editó correctamente el Cliente");
                        MostrarEmpresa();
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
                txtRazonSocial.Text = dataGridView1.CurrentRow.Cells["EMP_RAZON_SOCIAL"].Value.ToString();
                txtNombreFantasia.Text = dataGridView1.CurrentRow.Cells["EMP_NOMBRE_FANTASIA"].Value.ToString();
                txtRuc.Text = dataGridView1.CurrentRow.Cells["EMP_RUC"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["EMP_DIRECCION"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["EMP_TELEFONO"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["EMP_EMAIL"].Value.ToString();
                ptbLogo.Text = dataGridView1.CurrentRow.Cells["EMP_LOGO"].Value.ToString();
               
                IdCliente = dataGridView1.CurrentRow.Cells["EMP_ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Cliente");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdCliente = dataGridView1.CurrentRow.Cells["EMP_ID"].Value.ToString();
                objetoCE.Id = Convert.ToInt32(IdCliente);
                objetoCN.EliminarEmpresa(objetoCE);
                MessageBox.Show("Se Eliminó correctamente el Cliente");
                MostrarEmpresa();
            }
            else 
            {
                MessageBox.Show("No ha seleccionado ningun Cliente");
            }
        }
    }
}
