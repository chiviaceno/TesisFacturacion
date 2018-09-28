using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaPresentacionAdministracion;

namespace CapaPresentacion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam,int lparam);

        private void btnSlim_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width== 250)
            {
                menuVertical.Width = 60;
            }
            else
            {
                menuVertical.Width = 250;

            }
        }


        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012, 0);
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnAdmin.Visible = true;
            btnVentas.Visible = true;
            btnInventario.Visible = true;
            btnReportes.Visible = true;
        }

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Administracion _administracion = new Administracion();
            _administracion.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login _login = new Login();
            _login.Show();
        }
    }
}
