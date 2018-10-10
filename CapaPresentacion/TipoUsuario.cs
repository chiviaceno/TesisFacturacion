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
    public partial class TipoUsuario : Form
    {
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

        private CNTUsuario objetoCN = new CNTUsuario();
        private CETUsuario objetoCE = new CETUsuario();
        private string IdTipoUsuario = null;
        private Boolean Editar = false;


        public TipoUsuario()
        {
            InitializeComponent();
        }
        private void TipoUsuario_Load(object sender, EventArgs e)
        {
            MostrarTipoUsuario();
        }

        private void MostrarTipoUsuario()
        {
            CNTUsuario objeto = new CNTUsuario();
            dataGridView1.DataSource = objeto.MostrarTipoUsuario();
        }

        private void LimpiarForm()
        {
            txtRol.Clear();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERTAR EMPLEADO
            if (Editar == false)
            {
                try
                {
                    objetoCE.Rol = txtRol.Text;
                    
                    objetoCN.InsertarTipoUsuario(objetoCE);
                    MessageBox.Show("Se Ingreso correctamente el Tipo de Usuario");
                    MostrarTipoUsuario();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Ingresar el Tipo de Usuario por  " + ex);
                }

                // EDITAR EMPLEADO
            }
            if (Editar == true)
            {
                {
                    try
                    {
                        objetoCE.Id = Convert.ToInt32(IdTipoUsuario);
                        objetoCE.Rol = txtRol.Text;
                        
                        objetoCN.EditarTipoUsuario(objetoCE);
                        MessageBox.Show("Se Editó correctamente el Tipo de Usuario");
                        MostrarTipoUsuario();
                        LimpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede Editar el Tipo de Usuario por  " + ex);
                    }

                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtRol.Text = dataGridView1.CurrentRow.Cells["TIP_ROL"].Value.ToString();

                IdTipoUsuario = dataGridView1.CurrentRow.Cells["TIP_ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Tipo de Usuario");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdTipoUsuario = dataGridView1.CurrentRow.Cells["TIP_ID"].Value.ToString();

                objetoCE.Id = Convert.ToInt32(IdTipoUsuario);

                objetoCN.EliminaTipoUsuario(objetoCE);
                MessageBox.Show("Se Eliminó correctamente el Tipo de Usuario");
                MostrarTipoUsuario();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Tipo de Usuario");
            }
        }
    }
}
