namespace CapaPresentacion.frmMantenimientos
{
    partial class frmBuscarProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProducto));
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.pROIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROIVAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRONOTASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROIMAGENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROMEDIDAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROMEDIDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROESTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCombos = new CapaPresentacion.DSCombos();
            this.fAC_PRODUCTOTableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_PRODUCTOTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.pRO_DESCRIPCIONToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pRO_DESCRIPCIONToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.pRO_NOTASToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.pRO_NOTASToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuitaFiltros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.AllowUserToAddRows = false;
            this.dgvBusqueda.AllowUserToDeleteRows = false;
            this.dgvBusqueda.AllowUserToOrderColumns = true;
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.AutoGenerateColumns = false;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pROIDDataGridViewTextBoxColumn,
            this.pRODESCRIPCIONDataGridViewTextBoxColumn,
            this.pROIVAIDDataGridViewTextBoxColumn,
            this.pROPRECIODataGridViewTextBoxColumn,
            this.pRONOTASDataGridViewTextBoxColumn,
            this.pROIMAGENDataGridViewTextBoxColumn,
            this.pROMEDIDAIDDataGridViewTextBoxColumn,
            this.pROMEDIDADataGridViewTextBoxColumn,
            this.pROESTADODataGridViewTextBoxColumn});
            this.dgvBusqueda.DataSource = this.fACPRODUCTOBindingSource;
            this.dgvBusqueda.Location = new System.Drawing.Point(0, 114);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusqueda.Size = new System.Drawing.Size(822, 353);
            this.dgvBusqueda.TabIndex = 2;
            // 
            // pROIDDataGridViewTextBoxColumn
            // 
            this.pROIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_ID";
            this.pROIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pROIDDataGridViewTextBoxColumn.Name = "pROIDDataGridViewTextBoxColumn";
            this.pROIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.pRODESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "PRO_DESCRIPCION";
            this.pRODESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.pRODESCRIPCIONDataGridViewTextBoxColumn.Name = "pRODESCRIPCIONDataGridViewTextBoxColumn";
            this.pRODESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROIVAIDDataGridViewTextBoxColumn
            // 
            this.pROIVAIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_IVAID";
            this.pROIVAIDDataGridViewTextBoxColumn.HeaderText = "IVA";
            this.pROIVAIDDataGridViewTextBoxColumn.Name = "pROIVAIDDataGridViewTextBoxColumn";
            this.pROIVAIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROPRECIODataGridViewTextBoxColumn
            // 
            this.pROPRECIODataGridViewTextBoxColumn.DataPropertyName = "PRO_PRECIO";
            this.pROPRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pROPRECIODataGridViewTextBoxColumn.Name = "pROPRECIODataGridViewTextBoxColumn";
            this.pROPRECIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRONOTASDataGridViewTextBoxColumn
            // 
            this.pRONOTASDataGridViewTextBoxColumn.DataPropertyName = "PRO_NOTAS";
            this.pRONOTASDataGridViewTextBoxColumn.HeaderText = "NOTAS";
            this.pRONOTASDataGridViewTextBoxColumn.Name = "pRONOTASDataGridViewTextBoxColumn";
            this.pRONOTASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROIMAGENDataGridViewTextBoxColumn
            // 
            this.pROIMAGENDataGridViewTextBoxColumn.DataPropertyName = "PRO_IMAGEN";
            this.pROIMAGENDataGridViewTextBoxColumn.HeaderText = "IMAGEN";
            this.pROIMAGENDataGridViewTextBoxColumn.Name = "pROIMAGENDataGridViewTextBoxColumn";
            this.pROIMAGENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROMEDIDAIDDataGridViewTextBoxColumn
            // 
            this.pROMEDIDAIDDataGridViewTextBoxColumn.DataPropertyName = "PRO_MEDIDAID";
            this.pROMEDIDAIDDataGridViewTextBoxColumn.HeaderText = "MEDIDA";
            this.pROMEDIDAIDDataGridViewTextBoxColumn.Name = "pROMEDIDAIDDataGridViewTextBoxColumn";
            this.pROMEDIDAIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROMEDIDADataGridViewTextBoxColumn
            // 
            this.pROMEDIDADataGridViewTextBoxColumn.DataPropertyName = "PRO_MEDIDA";
            this.pROMEDIDADataGridViewTextBoxColumn.HeaderText = "MEDIDA";
            this.pROMEDIDADataGridViewTextBoxColumn.Name = "pROMEDIDADataGridViewTextBoxColumn";
            this.pROMEDIDADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROESTADODataGridViewTextBoxColumn
            // 
            this.pROESTADODataGridViewTextBoxColumn.DataPropertyName = "PRO_ESTADO";
            this.pROESTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.pROESTADODataGridViewTextBoxColumn.Name = "pROESTADODataGridViewTextBoxColumn";
            this.pROESTADODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fACPRODUCTOBindingSource
            // 
            this.fACPRODUCTOBindingSource.DataMember = "FAC_PRODUCTO";
            this.fACPRODUCTOBindingSource.DataSource = this.dSCombos;
            // 
            // dSCombos
            // 
            this.dSCombos.DataSetName = "DSCombos";
            this.dSCombos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAC_PRODUCTOTableAdapter
            // 
            this.fAC_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.AutoSize = false;
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pRO_DESCRIPCIONToolStripLabel,
            this.pRO_DESCRIPCIONToolStripTextBox,
            this.pRO_NOTASToolStripLabel,
            this.pRO_NOTASToolStripTextBox});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 79);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(709, 32);
            this.fillByToolStrip.TabIndex = 0;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // pRO_DESCRIPCIONToolStripLabel
            // 
            this.pRO_DESCRIPCIONToolStripLabel.Name = "pRO_DESCRIPCIONToolStripLabel";
            this.pRO_DESCRIPCIONToolStripLabel.Size = new System.Drawing.Size(84, 29);
            this.pRO_DESCRIPCIONToolStripLabel.Text = "DESCRIPCION:";
            // 
            // pRO_DESCRIPCIONToolStripTextBox
            // 
            this.pRO_DESCRIPCIONToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRO_DESCRIPCIONToolStripTextBox.Name = "pRO_DESCRIPCIONToolStripTextBox";
            this.pRO_DESCRIPCIONToolStripTextBox.Size = new System.Drawing.Size(270, 32);
            this.pRO_DESCRIPCIONToolStripTextBox.TextChanged += new System.EventHandler(this.pRO_DESCRIPCIONToolStripTextBox_TextChanged);
            // 
            // pRO_NOTASToolStripLabel
            // 
            this.pRO_NOTASToolStripLabel.Name = "pRO_NOTASToolStripLabel";
            this.pRO_NOTASToolStripLabel.Size = new System.Drawing.Size(47, 29);
            this.pRO_NOTASToolStripLabel.Text = "NOTAS:";
            // 
            // pRO_NOTASToolStripTextBox
            // 
            this.pRO_NOTASToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRO_NOTASToolStripTextBox.Name = "pRO_NOTASToolStripTextBox";
            this.pRO_NOTASToolStripTextBox.Size = new System.Drawing.Size(270, 32);
            this.pRO_NOTASToolStripTextBox.TextChanged += new System.EventHandler(this.pRO_NOTASToolStripTextBox_TextChanged);
            // 
            // btnQuitaFiltros
            // 
            this.btnQuitaFiltros.Location = new System.Drawing.Point(715, 86);
            this.btnQuitaFiltros.Name = "btnQuitaFiltros";
            this.btnQuitaFiltros.Size = new System.Drawing.Size(95, 22);
            this.btnQuitaFiltros.TabIndex = 4;
            this.btnQuitaFiltros.Text = "Quitar Filtros";
            this.btnQuitaFiltros.UseVisualStyleBackColor = true;
            this.btnQuitaFiltros.Click += new System.EventHandler(this.btnQuitaFiltros_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(684, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(750, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "LISTA DE PRODUCTOS";
            // 
            // frmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(821, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnQuitaFiltros);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvBusqueda);
            this.Name = "frmBuscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.frmProductoBusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private DSCombos dSCombos;
        private System.Windows.Forms.BindingSource fACPRODUCTOBindingSource;
        private DSCombosTableAdapters.FAC_PRODUCTOTableAdapter fAC_PRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIVAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRONOTASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROIMAGENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROMEDIDAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROMEDIDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROESTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel pRO_DESCRIPCIONToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pRO_DESCRIPCIONToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel pRO_NOTASToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox pRO_NOTASToolStripTextBox;
        private System.Windows.Forms.Button btnQuitaFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}