using CapaNegocio;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }


        //metodo para mover el formulario
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CNLogin objLogin = new CNLogin();
            SqlDataReader Loguear;
            objLogin.Usuario = txtUser.Text;
            objLogin.Contraseña = txtPass.Text;

            if (objLogin.Usuario == txtUser.Text)
            {
                lblErrorUsuario.Visible = false;

                if (objLogin.Contraseña == txtPass.Text)
                {
                    lblErrorPass.Visible = false;
                    Loguear = objLogin.IniciarSesion();

                    if (Loguear.Read() == true)
                    {

                        this.Hide();
                        LoginCarga _loginCarga = new LoginCarga();
                        _loginCarga.Show();
                        //try
                        //{
                        //    Program.Cargo = Loguear["TIP_ID"].ToString();

                        //}
                        //catch (Exception w)
                        //{

                        //}
                    }
                    else
                    {
                        lblErrorLogin.Text = "Usuario o Contraseña invalidas, intente de nuevo";
                        lblErrorLogin.Visible = true;
                        txtPass.Text = "";
                        txtPass_Leave(null, e);
                        txtUser.Focus();
                    }
                }
                else
                {
                    lblErrorPass.Text = objLogin.Contraseña;
                    lblErrorPass.Visible = true;
                }
            }
            else
            {
                lblErrorUsuario.Text = objLogin.Usuario;
                lblErrorUsuario.Visible = true;
            }
        }

        // COMMENT: Este boton esta oculto detras del btnLogin_Click
        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
