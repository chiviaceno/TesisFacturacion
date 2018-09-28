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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }
        private void Administracion_Load(object sender, EventArgs e)
        {

        }
        #region FUNCIONALIDADES DEL FORMULARIO

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
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

        private void btnSlim_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 60;
            }
            else
            {
                menuVertical.Width = 250;

            }
        }


        private void IconCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Capturar posicion y tamaño antes de maximiza para restaurar 
        int lx, ly;
        int sw, sh;

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;


            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);

            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }
        #endregion
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            //busca en a coleccion  el formulario
            formulario = panelContenedor.Controls.OfType<Forms>().FirstOrDefault();

            //si el formulario/instancia no existe, creamos nueva instancia y mostramos
            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();

                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);               
            }
            else
            {

                //si la Formulario/instancia existe, lo traemos a frente
                formulario.BringToFront();

                //Si la instancia esta minimizada mostramos
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }

            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Clientes"] == null)
                btnClientes.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Empleados"] == null)
                btnEmpleados.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Empresa"] == null)
                btnEmpresas.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Usuarios"] == null)
                btnUsuarios.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["TipoUsuario"] == null)
                btnTipoUser.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Empleados>();
            btnEmpleados.BackColor = Color.FromArgb(12, 61, 93);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Empresa>();
            btnEmpresas.BackColor = Color.FromArgb(12, 61, 93);
        }
    

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Usuarios>();
            btnUsuarios.BackColor = Color.FromArgb(12, 61, 93);
    }


        private void btnTipoUser_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<TipoUsuario>();
            btnTipoUser.BackColor = Color.FromArgb(12, 61, 93);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel<Clientes>();
            btnClientes.BackColor = Color.FromArgb(12, 61, 93);
        }

        
    }
}
