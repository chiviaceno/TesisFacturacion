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
    public partial class Usuarios : Form
    {
        private CNUsuarios objetoCN = new CNUsuarios();
        private CEUsuarios objetoCE = new CEUsuarios();
        private string IdUsuario = null;
        private Boolean Editar = false;

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

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
            
            MostrarUsuario();
        }

        private void MostrarUsuario()
        {
            CNUsuarios objeto = new CNUsuarios();
            dataGridView1.DataSource = objeto.MostrarUsuario();
        }

        private void LimpiarForm()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            

        }
        private void ListarEmpleados()
        {
             CNUsuarios _objetoCN = new CNUsuarios();
            cmbEmpleado.DataSource = _objetoCN.MostrarEmpleado();
            cmbEmpleado.DisplayMember= "EMPLEADO";
            cmbEmpleado.ValueMember = "EMPL_ID";
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {


                    objetoCE.Tipo = cmbRol.Text;
                    objetoCE.Empl_Id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    objetoCE.Usuario = txtUsuario.Text;
                    objetoCE.Password = txtPassword.Text;
                    
                    objetoCN.InsertarUsuario(objetoCE);
                    MessageBox.Show("Se Ingreso correctamente el Usuario");
                    MostrarUsuario();
                    LimpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Ingresar el Usuario por  " + ex);
                }

                // EDITAR USUARRIO
            }
            if (Editar == true)
            {
                {
                    try
                    {
                        objetoCE.Id = Convert.ToInt32(IdUsuario);
                        objetoCE.Tipo = cmbRol.Text;
                        objetoCE.Empl_Id = Convert.ToInt32(cmbEmpleado.SelectedValue);
                        objetoCE.Usuario = txtUsuario.Text;
                        objetoCE.Password = txtPassword.Text;

                        objetoCN.EditarUsuario(objetoCE);
                        MessageBox.Show("Se Editó correctamente el Usuario");
                        MostrarUsuario();
                        LimpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede Editar el Usuario por  " + ex);
                    }

                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                cmbEmpleado.Text = dataGridView1.CurrentRow.Cells["APELLIDO"].Value.ToString();
                cmbRol.Text = dataGridView1.CurrentRow.Cells["ROL"].Value.ToString();
                txtUsuario.Text = dataGridView1.CurrentRow.Cells["USUARIO"].Value.ToString();
                txtPassword.Text = dataGridView1.CurrentRow.Cells["PASSWORD"].Value.ToString();
                

                IdUsuario = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun Usuario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    IdUsuario = dataGridView1.CurrentRow.Cells["USE_ID"].Value.ToString();
                    objetoCE.Id = Convert.ToInt32(IdUsuario);
                    objetoCN.EliminarUsuario(objetoCE);
                    MessageBox.Show("Se Eliminó correctamente el Usuario");
                    MostrarUsuario();
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun Usuario");
                }
        }

        
    }
}
