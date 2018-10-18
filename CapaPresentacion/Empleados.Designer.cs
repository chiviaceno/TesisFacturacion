namespace CapaPresentacionAdministracion
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEmpresa = new System.Windows.Forms.ComboBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(141)))));
            this.BarraTitulo.Controls.Add(this.label8);
            this.BarraTitulo.Controls.Add(this.IconMinimizar);
            this.BarraTitulo.Controls.Add(this.IconCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1015, 35);
            this.BarraTitulo.TabIndex = 5;
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseMove);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "EMPLEADOS";
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(961, 3);
            this.IconMinimizar.Name = "IconMinimizar";
            this.IconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconMinimizar.TabIndex = 1;
            this.IconMinimizar.TabStop = false;
            this.IconMinimizar.Click += new System.EventHandler(this.IconMinimizar_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(987, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 323);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.cbxEmpresa);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxEstado);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(673, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 547);
            this.panel1.TabIndex = 7;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Activo",
            "Pasivo",
            "Inactivo"});
            this.cbxEstado.Location = new System.Drawing.Point(151, 426);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(179, 27);
            this.cbxEstado.TabIndex = 16;
            this.cbxEstado.Text = "Activo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 368);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(151, 311);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(179, 27);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(151, 255);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(179, 27);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(151, 199);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(179, 27);
            this.txtCedula.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 145);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(179, 27);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(179, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(47, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(47, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(47, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(47, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(47, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(47, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(47, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(78, 482);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 45);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(66, 523);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 45);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(389, 523);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(181, 45);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(47, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Empresa:";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.FormattingEnabled = true;
            this.cbxEmpresa.Location = new System.Drawing.Point(151, 35);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Size = new System.Drawing.Size(179, 27);
            this.cbxEmpresa.TabIndex = 18;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(1015, 600);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BarraTitulo);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel BarraTitulo;
        internal System.Windows.Forms.PictureBox IconMinimizar;
        internal System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cbxEmpresa;
        private System.Windows.Forms.Label label9;
    }
}