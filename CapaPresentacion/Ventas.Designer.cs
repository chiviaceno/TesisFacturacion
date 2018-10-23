namespace CapaPresentacion
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.IconRestaurar = new System.Windows.Forms.PictureBox();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconMaximizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.btnSlim = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlim)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoScroll = true;
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelPrincipal.Controls.Add(this.panelContenedor);
            this.panelPrincipal.Controls.Add(this.BarraTitulo);
            this.panelPrincipal.Controls.Add(this.menuVertical);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1300, 700);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 665);
            this.panelContenedor.TabIndex = 4;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.BarraTitulo.Controls.Add(this.IconRestaurar);
            this.BarraTitulo.Controls.Add(this.IconMinimizar);
            this.BarraTitulo.Controls.Add(this.IconMaximizar);
            this.BarraTitulo.Controls.Add(this.IconCerrar);
            this.BarraTitulo.Controls.Add(this.btnSlim);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 35);
            this.BarraTitulo.TabIndex = 3;
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // IconRestaurar
            // 
            this.IconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("IconRestaurar.Image")));
            this.IconRestaurar.Location = new System.Drawing.Point(996, 3);
            this.IconRestaurar.Name = "IconRestaurar";
            this.IconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.IconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconRestaurar.TabIndex = 1;
            this.IconRestaurar.TabStop = false;
            this.IconRestaurar.Visible = false;
            this.IconRestaurar.Click += new System.EventHandler(this.IconRestaurar_Click);
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(970, 3);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 1;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconMaximizar
            // 
            this.IconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMaximizar.Image")));
            this.IconMaximizar.Location = new System.Drawing.Point(996, 3);
            this.IconMaximizar.Name = "IconMaximizar";
            this.IconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.IconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMaximizar.TabIndex = 1;
            this.IconMaximizar.TabStop = false;
            this.IconMaximizar.Click += new System.EventHandler(this.IconMaximizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(1022, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // btnSlim
            // 
            this.btnSlim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlim.Image = ((System.Drawing.Image)(resources.GetObject("btnSlim.Image")));
            this.btnSlim.Location = new System.Drawing.Point(6, 4);
            this.btnSlim.Name = "btnSlim";
            this.btnSlim.Size = new System.Drawing.Size(29, 26);
            this.btnSlim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSlim.TabIndex = 0;
            this.btnSlim.TabStop = false;
            this.btnSlim.Click += new System.EventHandler(this.btnSlim_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Controls.Add(this.btnReportes);
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.btnRegistrarVenta);
            this.menuVertical.Controls.Add(this.BtnMenu);
            this.menuVertical.Controls.Add(this.PictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 700);
            this.menuVertical.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 332);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(250, 45);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(-1, 442);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(250, 45);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 643);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(250, 45);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "       Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVenta.Image")));
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(0, 229);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(250, 45);
            this.btnRegistrarVenta.TabIndex = 1;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // BtnMenu
            // 
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.ForeColor = System.Drawing.Color.White;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu.Location = new System.Drawing.Point(0, 129);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(250, 45);
            this.BtnMenu.TabIndex = 1;
            this.BtnMenu.Text = "  Menú Ventas";
            this.BtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(0, 9);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(250, 70);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.panelPrincipal.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSlim)).EndInit();
            this.menuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panelPrincipal;
        internal System.Windows.Forms.Panel panelContenedor;
        internal System.Windows.Forms.Panel BarraTitulo;
        internal System.Windows.Forms.PictureBox IconRestaurar;
        internal System.Windows.Forms.PictureBox IconMinimizar;
        internal System.Windows.Forms.PictureBox IconMaximizar;
        internal System.Windows.Forms.PictureBox IconCerrar;
        internal System.Windows.Forms.PictureBox btnSlim;
        internal System.Windows.Forms.Panel menuVertical;
        internal System.Windows.Forms.Button btnClientes;
        internal System.Windows.Forms.Button btnReportes;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnRegistrarVenta;
        internal System.Windows.Forms.Button BtnMenu;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}