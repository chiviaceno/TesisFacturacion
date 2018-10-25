namespace CapaPresentacion
{
    partial class frmProductos
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
            this.fACTIPOSMEDIDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dSCombosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCombos = new CapaPresentacion.DSCombos();
            this.fAC_TIPOS_MEDIDATableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_TIPOS_MEDIDATableAdapter();
            this.fAC_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAC_PRODUCTOTableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_PRODUCTOTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DSCombosTableAdapters.TableAdapterManager();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAC_PRODUCTODataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOSMEDIDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fACTIPOSMEDIDABindingSource
            // 
            this.fACTIPOSMEDIDABindingSource.DataMember = "FAC_TIPOS_MEDIDA";
            this.fACTIPOSMEDIDABindingSource.DataSource = this.dSCombosBindingSource;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dSCombosBindingSource
            // 
            this.dSCombosBindingSource.DataSource = this.dSCombos;
            this.dSCombosBindingSource.Position = 0;
            // 
            // dSCombos
            // 
            this.dSCombos.DataSetName = "DSCombos";
            this.dSCombos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAC_TIPOS_MEDIDATableAdapter
            // 
            this.fAC_TIPOS_MEDIDATableAdapter.ClearBeforeFill = true;
            // 
            // fAC_PRODUCTOBindingSource
            // 
            this.fAC_PRODUCTOBindingSource.DataMember = "FAC_PRODUCTO";
            this.fAC_PRODUCTOBindingSource.DataSource = this.dSCombos;
            // 
            // fAC_PRODUCTOTableAdapter
            // 
            this.fAC_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FAC_CABECERA_FACTURATableAdapter = null;
            this.tableAdapterManager.FAC_CLIENTETableAdapter = null;
            this.tableAdapterManager.FAC_DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FAC_EMPLEADOTableAdapter = null;
            this.tableAdapterManager.FAC_EMPRESATableAdapter = null;
            this.tableAdapterManager.FAC_PRODUCTOTableAdapter = this.fAC_PRODUCTOTableAdapter;
            this.tableAdapterManager.FAC_TIPOS_MEDIDATableAdapter = null;
            this.tableAdapterManager.FAC_USUARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.DSCombosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "PRO_ACTIVO";
            this.dataGridViewCheckBoxColumn2.HeaderText = "PRO_ACTIVO";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PRO_PRECIO_VENTA";
            this.dataGridViewTextBoxColumn8.HeaderText = "PRO_PRECIO_VENTA";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "PRO_TIENE_IVA";
            this.dataGridViewCheckBoxColumn1.HeaderText = "PRO_TIENE_IVA";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRO_PRECIO_COMPRA";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRO_PRECIO_COMPRA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRO_UNIDAD_MEDIDA";
            this.dataGridViewTextBoxColumn6.HeaderText = "PRO_UNIDAD_MEDIDA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRO_ENVASES";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRO_ENVASES";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRO_DESCRIPCION";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRO_DESCRIPCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRO_STOCKS";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRO_STOCKS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRO_CODIGO";
            this.dataGridViewTextBoxColumn2.HeaderText = "PRO_CODIGO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRO_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRO_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fAC_PRODUCTODataGridView
            // 
            this.fAC_PRODUCTODataGridView.AutoGenerateColumns = false;
            this.fAC_PRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fAC_PRODUCTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn2});
            this.fAC_PRODUCTODataGridView.DataSource = this.fAC_PRODUCTOBindingSource;
            this.fAC_PRODUCTODataGridView.Location = new System.Drawing.Point(0, 274);
            this.fAC_PRODUCTODataGridView.Name = "fAC_PRODUCTODataGridView";
            this.fAC_PRODUCTODataGridView.Size = new System.Drawing.Size(300, 220);
            this.fAC_PRODUCTODataGridView.TabIndex = 0;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(983, 558);
            this.Controls.Add(this.fAC_PRODUCTODataGridView);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOSMEDIDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTODataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dSCombosBindingSource;
        private DSCombos dSCombos;
        private System.Windows.Forms.BindingSource fACTIPOSMEDIDABindingSource;
        private DSCombosTableAdapters.FAC_TIPOS_MEDIDATableAdapter fAC_TIPOS_MEDIDATableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource fAC_PRODUCTOBindingSource;
        private DSCombosTableAdapters.FAC_PRODUCTOTableAdapter fAC_PRODUCTOTableAdapter;
        private DSCombosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fAC_PRODUCTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    }
}