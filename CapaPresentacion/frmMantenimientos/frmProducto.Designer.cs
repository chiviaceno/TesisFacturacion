namespace CapaPresentacion.frmMantenimientos
{
    partial class frmProducto
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
            System.Windows.Forms.Label pRO_IDLabel;
            System.Windows.Forms.Label pRO_DESCRIPCIONLabel;
            System.Windows.Forms.Label pRO_ESTADOLabel;
            System.Windows.Forms.Label pRO_IVAIDLabel;
            System.Windows.Forms.Label pRO_MEDIDALabel;
            System.Windows.Forms.Label pRO_NOTASLabel;
            System.Windows.Forms.Label pRO_IMAGENLabel;
            System.Windows.Forms.Label pRO_PRECIOLabel;
            System.Windows.Forms.Label pRO_MEDIDAIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.IconMinimizar = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.dSCombos = new CapaPresentacion.DSCombos();
            this.fAC_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAC_PRODUCTOTableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_PRODUCTOTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DSCombosTableAdapters.TableAdapterManager();
            this.fAC_TIPOS_MEDIDATableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_TIPOS_MEDIDATableAdapter();
            this.fAC_PRODUCTOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEdit = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelOpertation = new System.Windows.Forms.ToolStripButton();
            this.fAC_PRODUCTOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearch = new System.Windows.Forms.ToolStripButton();
            this.fAC_PRODUCTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_IVAID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fACIVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRO_PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_NOTAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_IMAGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRO_MEDIDAID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fACTIPOSMEDIDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PRO_MEDIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fACTIPOESTADOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRO_IDTextBox = new System.Windows.Forms.TextBox();
            this.pRO_DESCRIPCIONTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fAC_TIPO_ESTADOSTableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_TIPO_ESTADOSTableAdapter();
            this.pRO_ESTADOComboBox = new System.Windows.Forms.ComboBox();
            this.fAC_IVATableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_IVATableAdapter();
            this.pRO_IVAIDComboBox = new System.Windows.Forms.ComboBox();
            this.pRO_MEDIDATextBox = new System.Windows.Forms.TextBox();
            this.pRO_NOTASTextBox = new System.Windows.Forms.TextBox();
            this.pRO_IMAGENTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarImagen = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.pRO_PRECIOTextBox = new System.Windows.Forms.TextBox();
            this.pRO_MEDIDAIDComboBox = new System.Windows.Forms.ComboBox();
            this.gbxBarras = new System.Windows.Forms.GroupBox();
            this.btnEliminarBarra = new System.Windows.Forms.Button();
            this.btnAgregarBarra = new System.Windows.Forms.Button();
            this.BARRASDataGridView = new System.Windows.Forms.DataGridView();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACBARRABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSCombos1 = new CapaPresentacion.DSCombos();
            this.gbxParametros = new System.Windows.Forms.GroupBox();
            this.btnModificarBodega = new System.Windows.Forms.Button();
            this.btnAgregarBodega = new System.Windows.Forms.Button();
            this.BARRASPRODUCTODataGridView = new System.Windows.Forms.DataGridView();
            this.iDBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasReposicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodegaProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAC_BARRATableAdapter = new CapaPresentacion.DSCombosTableAdapters.FAC_BARRATableAdapter();
            this.bodegaProductoTableAdapter = new CapaPresentacion.DSCombosTableAdapters.BodegaProductoTableAdapter();
            this.bodegaTableAdapter = new CapaPresentacion.DSCombosTableAdapters.BodegaTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            pRO_IDLabel = new System.Windows.Forms.Label();
            pRO_DESCRIPCIONLabel = new System.Windows.Forms.Label();
            pRO_ESTADOLabel = new System.Windows.Forms.Label();
            pRO_IVAIDLabel = new System.Windows.Forms.Label();
            pRO_MEDIDALabel = new System.Windows.Forms.Label();
            pRO_NOTASLabel = new System.Windows.Forms.Label();
            pRO_IMAGENLabel = new System.Windows.Forms.Label();
            pRO_PRECIOLabel = new System.Windows.Forms.Label();
            pRO_MEDIDAIDLabel = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingNavigator)).BeginInit();
            this.fAC_PRODUCTOBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACIVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOSMEDIDABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOESTADOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.gbxBarras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BARRASDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACBARRABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos1)).BeginInit();
            this.gbxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BARRASPRODUCTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pRO_IDLabel
            // 
            pRO_IDLabel.AutoSize = true;
            pRO_IDLabel.ForeColor = System.Drawing.Color.White;
            pRO_IDLabel.Location = new System.Drawing.Point(97, 77);
            pRO_IDLabel.Name = "pRO_IDLabel";
            pRO_IDLabel.Size = new System.Drawing.Size(21, 13);
            pRO_IDLabel.TabIndex = 1;
            pRO_IDLabel.Text = "ID:";
            // 
            // pRO_DESCRIPCIONLabel
            // 
            pRO_DESCRIPCIONLabel.AutoSize = true;
            pRO_DESCRIPCIONLabel.ForeColor = System.Drawing.Color.White;
            pRO_DESCRIPCIONLabel.Location = new System.Drawing.Point(35, 103);
            pRO_DESCRIPCIONLabel.Name = "pRO_DESCRIPCIONLabel";
            pRO_DESCRIPCIONLabel.Size = new System.Drawing.Size(83, 13);
            pRO_DESCRIPCIONLabel.TabIndex = 3;
            pRO_DESCRIPCIONLabel.Text = "DESCRIPCION:";
            // 
            // pRO_ESTADOLabel
            // 
            pRO_ESTADOLabel.AutoSize = true;
            pRO_ESTADOLabel.ForeColor = System.Drawing.Color.White;
            pRO_ESTADOLabel.Location = new System.Drawing.Point(64, 182);
            pRO_ESTADOLabel.Name = "pRO_ESTADOLabel";
            pRO_ESTADOLabel.Size = new System.Drawing.Size(54, 13);
            pRO_ESTADOLabel.TabIndex = 13;
            pRO_ESTADOLabel.Text = "ESTADO:";
            // 
            // pRO_IVAIDLabel
            // 
            pRO_IVAIDLabel.AutoSize = true;
            pRO_IVAIDLabel.ForeColor = System.Drawing.Color.White;
            pRO_IVAIDLabel.Location = new System.Drawing.Point(436, 129);
            pRO_IVAIDLabel.Name = "pRO_IVAIDLabel";
            pRO_IVAIDLabel.Size = new System.Drawing.Size(27, 13);
            pRO_IVAIDLabel.TabIndex = 7;
            pRO_IVAIDLabel.Text = "IVA:";
            // 
            // pRO_MEDIDALabel
            // 
            pRO_MEDIDALabel.AutoSize = true;
            pRO_MEDIDALabel.ForeColor = System.Drawing.Color.White;
            pRO_MEDIDALabel.Location = new System.Drawing.Point(411, 155);
            pRO_MEDIDALabel.Name = "pRO_MEDIDALabel";
            pRO_MEDIDALabel.Size = new System.Drawing.Size(52, 13);
            pRO_MEDIDALabel.TabIndex = 11;
            pRO_MEDIDALabel.Text = "MEDIDA:";
            // 
            // pRO_NOTASLabel
            // 
            pRO_NOTASLabel.AutoSize = true;
            pRO_NOTASLabel.ForeColor = System.Drawing.Color.White;
            pRO_NOTASLabel.Location = new System.Drawing.Point(71, 209);
            pRO_NOTASLabel.Name = "pRO_NOTASLabel";
            pRO_NOTASLabel.Size = new System.Drawing.Size(47, 13);
            pRO_NOTASLabel.TabIndex = 18;
            pRO_NOTASLabel.Text = "NOTAS:";
            // 
            // pRO_IMAGENLabel
            // 
            pRO_IMAGENLabel.AutoSize = true;
            pRO_IMAGENLabel.ForeColor = System.Drawing.Color.White;
            pRO_IMAGENLabel.Location = new System.Drawing.Point(411, 182);
            pRO_IMAGENLabel.Name = "pRO_IMAGENLabel";
            pRO_IMAGENLabel.Size = new System.Drawing.Size(52, 13);
            pRO_IMAGENLabel.TabIndex = 15;
            pRO_IMAGENLabel.Text = "IMAGEN:";
            // 
            // pRO_PRECIOLabel
            // 
            pRO_PRECIOLabel.AutoSize = true;
            pRO_PRECIOLabel.ForeColor = System.Drawing.Color.White;
            pRO_PRECIOLabel.Location = new System.Drawing.Point(68, 129);
            pRO_PRECIOLabel.Name = "pRO_PRECIOLabel";
            pRO_PRECIOLabel.Size = new System.Drawing.Size(50, 13);
            pRO_PRECIOLabel.TabIndex = 5;
            pRO_PRECIOLabel.Text = "PRECIO:";
            // 
            // pRO_MEDIDAIDLabel
            // 
            pRO_MEDIDAIDLabel.AutoSize = true;
            pRO_MEDIDAIDLabel.ForeColor = System.Drawing.Color.White;
            pRO_MEDIDAIDLabel.Location = new System.Drawing.Point(21, 156);
            pRO_MEDIDAIDLabel.Name = "pRO_MEDIDAIDLabel";
            pRO_MEDIDAIDLabel.Size = new System.Drawing.Size(97, 13);
            pRO_MEDIDAIDLabel.TabIndex = 9;
            pRO_MEDIDAIDLabel.Text = "UNIDAD MEDIDA:";
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
            this.BarraTitulo.Size = new System.Drawing.Size(914, 35);
            this.BarraTitulo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "PRODUCTOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IconMinimizar
            // 
            this.IconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("IconMinimizar.Image")));
            this.IconMinimizar.Location = new System.Drawing.Point(860, 3);
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
            this.IconCerrar.Location = new System.Drawing.Point(886, 3);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(20, 20);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // dSCombos
            // 
            this.dSCombos.DataSetName = "DSCombos";
            this.dSCombos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAC_PRODUCTOBindingSource
            // 
            this.fAC_PRODUCTOBindingSource.DataMember = "FAC_PRODUCTO";
            this.fAC_PRODUCTOBindingSource.DataSource = this.dSCombos;
            this.fAC_PRODUCTOBindingSource.PositionChanged += new System.EventHandler(this.fAC_PRODUCTOBindingSource_PositionChanged);
            // 
            // fAC_PRODUCTOTableAdapter
            // 
            this.fAC_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BodegaProductoTableAdapter = null;
            this.tableAdapterManager.BodegaTableAdapter = null;
            this.tableAdapterManager.FAC_BARRATableAdapter = null;
            this.tableAdapterManager.FAC_CABECERA_FACTURATableAdapter = null;
            this.tableAdapterManager.FAC_CLIENTETableAdapter = null;
            this.tableAdapterManager.FAC_DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FAC_EMPLEADOTableAdapter = null;
            this.tableAdapterManager.FAC_EMPRESATableAdapter = null;
            this.tableAdapterManager.FAC_IVATableAdapter = null;
            this.tableAdapterManager.FAC_PRODUCTOTableAdapter = this.fAC_PRODUCTOTableAdapter;
            this.tableAdapterManager.FAC_TIPO_ESTADOSTableAdapter = null;
            this.tableAdapterManager.FAC_TIPOS_MEDIDATableAdapter = this.fAC_TIPOS_MEDIDATableAdapter;
            this.tableAdapterManager.FAC_USUARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.DSCombosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fAC_TIPOS_MEDIDATableAdapter
            // 
            this.fAC_TIPOS_MEDIDATableAdapter.ClearBeforeFill = true;
            // 
            // fAC_PRODUCTOBindingNavigator
            // 
            this.fAC_PRODUCTOBindingNavigator.AddNewItem = null;
            this.fAC_PRODUCTOBindingNavigator.BindingSource = this.fAC_PRODUCTOBindingSource;
            this.fAC_PRODUCTOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fAC_PRODUCTOBindingNavigator.DeleteItem = null;
            this.fAC_PRODUCTOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorEdit,
            this.bindingNavigatorCancelOpertation,
            this.fAC_PRODUCTOBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSearch});
            this.fAC_PRODUCTOBindingNavigator.Location = new System.Drawing.Point(0, 35);
            this.fAC_PRODUCTOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fAC_PRODUCTOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fAC_PRODUCTOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fAC_PRODUCTOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fAC_PRODUCTOBindingNavigator.Name = "fAC_PRODUCTOBindingNavigator";
            this.fAC_PRODUCTOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fAC_PRODUCTOBindingNavigator.Size = new System.Drawing.Size(914, 25);
            this.fAC_PRODUCTOBindingNavigator.TabIndex = 0;
            this.fAC_PRODUCTOBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo registro";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorEdit
            // 
            this.bindingNavigatorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorEdit.Enabled = false;
            this.bindingNavigatorEdit.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEdit.Image")));
            this.bindingNavigatorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEdit.Name = "bindingNavigatorEdit";
            this.bindingNavigatorEdit.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorEdit.Text = "Modifica registro actual";
            this.bindingNavigatorEdit.Click += new System.EventHandler(this.bindingNavigatorEdit_Click);
            // 
            // bindingNavigatorCancelOpertation
            // 
            this.bindingNavigatorCancelOpertation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorCancelOpertation.Enabled = false;
            this.bindingNavigatorCancelOpertation.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCancelOpertation.Image")));
            this.bindingNavigatorCancelOpertation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelOpertation.Name = "bindingNavigatorCancelOpertation";
            this.bindingNavigatorCancelOpertation.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorCancelOpertation.Text = "Cancela la operación";
            this.bindingNavigatorCancelOpertation.Click += new System.EventHandler(this.bindingNavigatorCancelOpertation_Click);
            // 
            // fAC_PRODUCTOBindingNavigatorSaveItem
            // 
            this.fAC_PRODUCTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Enabled = false;
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fAC_PRODUCTOBindingNavigatorSaveItem.Image")));
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Name = "fAC_PRODUCTOBindingNavigatorSaveItem";
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Text = "Guardar datos";
            this.fAC_PRODUCTOBindingNavigatorSaveItem.Click += new System.EventHandler(this.fAC_PRODUCTOBindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Elimina registro actual";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSearch
            // 
            this.bindingNavigatorSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSearch.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearch.Image")));
            this.bindingNavigatorSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearch.Name = "bindingNavigatorSearch";
            this.bindingNavigatorSearch.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorSearch.Text = "Busca registros";
            this.bindingNavigatorSearch.Click += new System.EventHandler(this.bindingNavigatorSearch_Click);
            // 
            // fAC_PRODUCTODataGridView
            // 
            this.fAC_PRODUCTODataGridView.AllowUserToAddRows = false;
            this.fAC_PRODUCTODataGridView.AllowUserToDeleteRows = false;
            this.fAC_PRODUCTODataGridView.AllowUserToOrderColumns = true;
            this.fAC_PRODUCTODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fAC_PRODUCTODataGridView.AutoGenerateColumns = false;
            this.fAC_PRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fAC_PRODUCTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.PRO_IVAID,
            this.PRO_PRECIO,
            this.PRO_NOTAS,
            this.PRO_IMAGEN,
            this.PRO_MEDIDAID,
            this.PRO_MEDIDA,
            this.ESTADO});
            this.fAC_PRODUCTODataGridView.DataSource = this.fAC_PRODUCTOBindingSource;
            this.fAC_PRODUCTODataGridView.Location = new System.Drawing.Point(0, 462);
            this.fAC_PRODUCTODataGridView.Name = "fAC_PRODUCTODataGridView";
            this.fAC_PRODUCTODataGridView.ReadOnly = true;
            this.fAC_PRODUCTODataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fAC_PRODUCTODataGridView.Size = new System.Drawing.Size(906, 86);
            this.fAC_PRODUCTODataGridView.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRO_ID";
            dataGridViewCellStyle10.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn1.FillWeight = 203.9802F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRO_DESCRIPCION";
            this.dataGridViewTextBoxColumn4.FillWeight = 84.91084F;
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPCION";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 117;
            // 
            // PRO_IVAID
            // 
            this.PRO_IVAID.DataPropertyName = "PRO_IVAID";
            this.PRO_IVAID.DataSource = this.fACIVABindingSource;
            this.PRO_IVAID.DisplayMember = "IVA_DESCRIPCION";
            this.PRO_IVAID.FillWeight = 85.79849F;
            this.PRO_IVAID.HeaderText = "IVA";
            this.PRO_IVAID.Name = "PRO_IVAID";
            this.PRO_IVAID.ReadOnly = true;
            this.PRO_IVAID.ValueMember = "IVA_CODGO";
            this.PRO_IVAID.Width = 118;
            // 
            // fACIVABindingSource
            // 
            this.fACIVABindingSource.DataMember = "FAC_IVA";
            this.fACIVABindingSource.DataSource = this.dSCombos;
            // 
            // PRO_PRECIO
            // 
            this.PRO_PRECIO.DataPropertyName = "PRO_PRECIO";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.PRO_PRECIO.DefaultCellStyle = dataGridViewCellStyle11;
            this.PRO_PRECIO.FillWeight = 85.79849F;
            this.PRO_PRECIO.HeaderText = "PRECIO";
            this.PRO_PRECIO.Name = "PRO_PRECIO";
            this.PRO_PRECIO.ReadOnly = true;
            this.PRO_PRECIO.Width = 117;
            // 
            // PRO_NOTAS
            // 
            this.PRO_NOTAS.DataPropertyName = "PRO_NOTAS";
            this.PRO_NOTAS.FillWeight = 85.79849F;
            this.PRO_NOTAS.HeaderText = "NOTAS";
            this.PRO_NOTAS.Name = "PRO_NOTAS";
            this.PRO_NOTAS.ReadOnly = true;
            this.PRO_NOTAS.Width = 117;
            // 
            // PRO_IMAGEN
            // 
            this.PRO_IMAGEN.DataPropertyName = "PRO_IMAGEN";
            this.PRO_IMAGEN.HeaderText = "IMAGEN";
            this.PRO_IMAGEN.Name = "PRO_IMAGEN";
            this.PRO_IMAGEN.ReadOnly = true;
            this.PRO_IMAGEN.Visible = false;
            // 
            // PRO_MEDIDAID
            // 
            this.PRO_MEDIDAID.DataPropertyName = "PRO_MEDIDAID";
            this.PRO_MEDIDAID.DataSource = this.fACTIPOSMEDIDABindingSource;
            this.PRO_MEDIDAID.DisplayMember = "descripcion";
            this.PRO_MEDIDAID.FillWeight = 85.79849F;
            this.PRO_MEDIDAID.HeaderText = "UN MEDIDA";
            this.PRO_MEDIDAID.Name = "PRO_MEDIDAID";
            this.PRO_MEDIDAID.ReadOnly = true;
            this.PRO_MEDIDAID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PRO_MEDIDAID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PRO_MEDIDAID.ValueMember = "codigo";
            this.PRO_MEDIDAID.Width = 118;
            // 
            // fACTIPOSMEDIDABindingSource
            // 
            this.fACTIPOSMEDIDABindingSource.DataMember = "FAC_TIPOS_MEDIDA";
            this.fACTIPOSMEDIDABindingSource.DataSource = this.dSCombos;
            // 
            // PRO_MEDIDA
            // 
            this.PRO_MEDIDA.DataPropertyName = "PRO_MEDIDA";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.PRO_MEDIDA.DefaultCellStyle = dataGridViewCellStyle12;
            this.PRO_MEDIDA.FillWeight = 85.79849F;
            this.PRO_MEDIDA.HeaderText = "MEDIDA";
            this.PRO_MEDIDA.Name = "PRO_MEDIDA";
            this.PRO_MEDIDA.ReadOnly = true;
            this.PRO_MEDIDA.Width = 117;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "PRO_ESTADO";
            this.ESTADO.DataSource = this.fACTIPOESTADOSBindingSource;
            this.ESTADO.DisplayMember = "tipo_descripcion";
            this.ESTADO.FillWeight = 85.79849F;
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.ValueMember = "tipo_codigo";
            this.ESTADO.Width = 117;
            // 
            // fACTIPOESTADOSBindingSource
            // 
            this.fACTIPOESTADOSBindingSource.DataMember = "FAC_TIPO_ESTADOS";
            this.fACTIPOESTADOSBindingSource.DataSource = this.dSCombos;
            // 
            // pRO_IDTextBox
            // 
            this.pRO_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_ID", true));
            this.pRO_IDTextBox.Location = new System.Drawing.Point(124, 74);
            this.pRO_IDTextBox.Name = "pRO_IDTextBox";
            this.pRO_IDTextBox.ReadOnly = true;
            this.pRO_IDTextBox.Size = new System.Drawing.Size(240, 20);
            this.pRO_IDTextBox.TabIndex = 2;
            // 
            // pRO_DESCRIPCIONTextBox
            // 
            this.pRO_DESCRIPCIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_DESCRIPCION", true));
            this.pRO_DESCRIPCIONTextBox.Location = new System.Drawing.Point(124, 100);
            this.pRO_DESCRIPCIONTextBox.Name = "pRO_DESCRIPCIONTextBox";
            this.pRO_DESCRIPCIONTextBox.ReadOnly = true;
            this.pRO_DESCRIPCIONTextBox.Size = new System.Drawing.Size(585, 20);
            this.pRO_DESCRIPCIONTextBox.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fAC_TIPO_ESTADOSTableAdapter
            // 
            this.fAC_TIPO_ESTADOSTableAdapter.ClearBeforeFill = true;
            // 
            // pRO_ESTADOComboBox
            // 
            this.pRO_ESTADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fAC_PRODUCTOBindingSource, "PRO_ESTADO", true));
            this.pRO_ESTADOComboBox.DataSource = this.fACTIPOESTADOSBindingSource;
            this.pRO_ESTADOComboBox.DisplayMember = "tipo_descripcion";
            this.pRO_ESTADOComboBox.Enabled = false;
            this.pRO_ESTADOComboBox.FormattingEnabled = true;
            this.pRO_ESTADOComboBox.Location = new System.Drawing.Point(124, 179);
            this.pRO_ESTADOComboBox.Name = "pRO_ESTADOComboBox";
            this.pRO_ESTADOComboBox.Size = new System.Drawing.Size(240, 21);
            this.pRO_ESTADOComboBox.TabIndex = 14;
            this.pRO_ESTADOComboBox.ValueMember = "tipo_codigo";
            // 
            // fAC_IVATableAdapter
            // 
            this.fAC_IVATableAdapter.ClearBeforeFill = true;
            // 
            // pRO_IVAIDComboBox
            // 
            this.pRO_IVAIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fAC_PRODUCTOBindingSource, "PRO_IVAID", true));
            this.pRO_IVAIDComboBox.DataSource = this.fACIVABindingSource;
            this.pRO_IVAIDComboBox.DisplayMember = "IVA_DESCRIPCION";
            this.pRO_IVAIDComboBox.Enabled = false;
            this.pRO_IVAIDComboBox.FormattingEnabled = true;
            this.pRO_IVAIDComboBox.Location = new System.Drawing.Point(469, 126);
            this.pRO_IVAIDComboBox.Name = "pRO_IVAIDComboBox";
            this.pRO_IVAIDComboBox.Size = new System.Drawing.Size(240, 21);
            this.pRO_IVAIDComboBox.TabIndex = 8;
            this.pRO_IVAIDComboBox.ValueMember = "IVA_CODGO";
            // 
            // pRO_MEDIDATextBox
            // 
            this.pRO_MEDIDATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_MEDIDA", true));
            this.pRO_MEDIDATextBox.Location = new System.Drawing.Point(469, 153);
            this.pRO_MEDIDATextBox.Name = "pRO_MEDIDATextBox";
            this.pRO_MEDIDATextBox.ReadOnly = true;
            this.pRO_MEDIDATextBox.Size = new System.Drawing.Size(240, 20);
            this.pRO_MEDIDATextBox.TabIndex = 12;
            // 
            // pRO_NOTASTextBox
            // 
            this.pRO_NOTASTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_NOTAS", true));
            this.pRO_NOTASTextBox.Location = new System.Drawing.Point(124, 206);
            this.pRO_NOTASTextBox.Multiline = true;
            this.pRO_NOTASTextBox.Name = "pRO_NOTASTextBox";
            this.pRO_NOTASTextBox.ReadOnly = true;
            this.pRO_NOTASTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pRO_NOTASTextBox.Size = new System.Drawing.Size(585, 78);
            this.pRO_NOTASTextBox.TabIndex = 19;
            // 
            // pRO_IMAGENTextBox
            // 
            this.pRO_IMAGENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_IMAGEN", true));
            this.pRO_IMAGENTextBox.Location = new System.Drawing.Point(468, 180);
            this.pRO_IMAGENTextBox.Name = "pRO_IMAGENTextBox";
            this.pRO_IMAGENTextBox.ReadOnly = true;
            this.pRO_IMAGENTextBox.Size = new System.Drawing.Size(208, 20);
            this.pRO_IMAGENTextBox.TabIndex = 16;
            // 
            // btnBuscarImagen
            // 
            this.btnBuscarImagen.Enabled = false;
            this.btnBuscarImagen.Location = new System.Drawing.Point(682, 178);
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarImagen.TabIndex = 17;
            this.btnBuscarImagen.Text = "...";
            this.btnBuscarImagen.UseVisualStyleBackColor = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.btnBuscarImagen_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagen.Location = new System.Drawing.Point(739, 100);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(167, 184);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 23;
            this.pbxImagen.TabStop = false;
            // 
            // pRO_PRECIOTextBox
            // 
            this.pRO_PRECIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAC_PRODUCTOBindingSource, "PRO_PRECIO", true));
            this.pRO_PRECIOTextBox.Location = new System.Drawing.Point(124, 126);
            this.pRO_PRECIOTextBox.Name = "pRO_PRECIOTextBox";
            this.pRO_PRECIOTextBox.ReadOnly = true;
            this.pRO_PRECIOTextBox.Size = new System.Drawing.Size(240, 20);
            this.pRO_PRECIOTextBox.TabIndex = 6;
            // 
            // pRO_MEDIDAIDComboBox
            // 
            this.pRO_MEDIDAIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fAC_PRODUCTOBindingSource, "PRO_MEDIDAID", true));
            this.pRO_MEDIDAIDComboBox.DataSource = this.fACTIPOSMEDIDABindingSource;
            this.pRO_MEDIDAIDComboBox.DisplayMember = "descripcion";
            this.pRO_MEDIDAIDComboBox.Enabled = false;
            this.pRO_MEDIDAIDComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pRO_MEDIDAIDComboBox.FormattingEnabled = true;
            this.pRO_MEDIDAIDComboBox.Location = new System.Drawing.Point(124, 153);
            this.pRO_MEDIDAIDComboBox.Name = "pRO_MEDIDAIDComboBox";
            this.pRO_MEDIDAIDComboBox.Size = new System.Drawing.Size(240, 21);
            this.pRO_MEDIDAIDComboBox.TabIndex = 10;
            this.pRO_MEDIDAIDComboBox.ValueMember = "codigo";
            // 
            // gbxBarras
            // 
            this.gbxBarras.Controls.Add(this.btnEliminarBarra);
            this.gbxBarras.Controls.Add(this.btnAgregarBarra);
            this.gbxBarras.Controls.Add(this.BARRASDataGridView);
            this.gbxBarras.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxBarras.Location = new System.Drawing.Point(12, 291);
            this.gbxBarras.Name = "gbxBarras";
            this.gbxBarras.Size = new System.Drawing.Size(257, 165);
            this.gbxBarras.TabIndex = 20;
            this.gbxBarras.TabStop = false;
            this.gbxBarras.Text = "Códigos de Barra";
            // 
            // btnEliminarBarra
            // 
            this.btnEliminarBarra.Enabled = false;
            this.btnEliminarBarra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnEliminarBarra.Location = new System.Drawing.Point(177, 12);
            this.btnEliminarBarra.Name = "btnEliminarBarra";
            this.btnEliminarBarra.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarBarra.TabIndex = 1;
            this.btnEliminarBarra.Text = "Eliminar";
            this.btnEliminarBarra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBarra
            // 
            this.btnAgregarBarra.Enabled = false;
            this.btnAgregarBarra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarBarra.Location = new System.Drawing.Point(96, 12);
            this.btnAgregarBarra.Name = "btnAgregarBarra";
            this.btnAgregarBarra.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarBarra.TabIndex = 0;
            this.btnAgregarBarra.Text = "Agregar";
            this.btnAgregarBarra.UseVisualStyleBackColor = true;
            // 
            // BARRASDataGridView
            // 
            this.BARRASDataGridView.AllowUserToAddRows = false;
            this.BARRASDataGridView.AllowUserToDeleteRows = false;
            this.BARRASDataGridView.AllowUserToOrderColumns = true;
            this.BARRASDataGridView.AutoGenerateColumns = false;
            this.BARRASDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BARRASDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductoDataGridViewTextBoxColumn,
            this.barraDataGridViewTextBoxColumn});
            this.BARRASDataGridView.DataSource = this.fACBARRABindingSource;
            this.BARRASDataGridView.Location = new System.Drawing.Point(6, 38);
            this.BARRASDataGridView.Name = "BARRASDataGridView";
            this.BARRASDataGridView.ReadOnly = true;
            this.BARRASDataGridView.Size = new System.Drawing.Size(245, 121);
            this.BARRASDataGridView.TabIndex = 2;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // barraDataGridViewTextBoxColumn
            // 
            this.barraDataGridViewTextBoxColumn.DataPropertyName = "Barra";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.barraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.barraDataGridViewTextBoxColumn.HeaderText = "Barra";
            this.barraDataGridViewTextBoxColumn.Name = "barraDataGridViewTextBoxColumn";
            this.barraDataGridViewTextBoxColumn.ReadOnly = true;
            this.barraDataGridViewTextBoxColumn.Width = 150;
            // 
            // fACBARRABindingSource
            // 
            this.fACBARRABindingSource.DataMember = "FAC_BARRA";
            this.fACBARRABindingSource.DataSource = this.dSCombos1;
            // 
            // dSCombos1
            // 
            this.dSCombos1.DataSetName = "DSCombos";
            this.dSCombos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxParametros
            // 
            this.gbxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxParametros.Controls.Add(this.btnModificarBodega);
            this.gbxParametros.Controls.Add(this.btnAgregarBodega);
            this.gbxParametros.Controls.Add(this.BARRASPRODUCTODataGridView);
            this.gbxParametros.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbxParametros.Location = new System.Drawing.Point(275, 291);
            this.gbxParametros.Name = "gbxParametros";
            this.gbxParametros.Size = new System.Drawing.Size(631, 165);
            this.gbxParametros.TabIndex = 21;
            this.gbxParametros.TabStop = false;
            this.gbxParametros.Text = "Párametros de Bodega";
            // 
            // btnModificarBodega
            // 
            this.btnModificarBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarBodega.Enabled = false;
            this.btnModificarBodega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnModificarBodega.Location = new System.Drawing.Point(550, 9);
            this.btnModificarBodega.Name = "btnModificarBodega";
            this.btnModificarBodega.Size = new System.Drawing.Size(75, 23);
            this.btnModificarBodega.TabIndex = 1;
            this.btnModificarBodega.Text = "Modificar";
            this.btnModificarBodega.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBodega
            // 
            this.btnAgregarBodega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarBodega.Enabled = false;
            this.btnAgregarBodega.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAgregarBodega.Location = new System.Drawing.Point(469, 9);
            this.btnAgregarBodega.Name = "btnAgregarBodega";
            this.btnAgregarBodega.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarBodega.TabIndex = 0;
            this.btnAgregarBodega.Text = "Agregar";
            this.btnAgregarBodega.UseVisualStyleBackColor = true;
            // 
            // BARRASPRODUCTODataGridView
            // 
            this.BARRASPRODUCTODataGridView.AllowUserToAddRows = false;
            this.BARRASPRODUCTODataGridView.AllowUserToDeleteRows = false;
            this.BARRASPRODUCTODataGridView.AllowUserToOrderColumns = true;
            this.BARRASPRODUCTODataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BARRASPRODUCTODataGridView.AutoGenerateColumns = false;
            this.BARRASPRODUCTODataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BARRASPRODUCTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BARRASPRODUCTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBodegaDataGridViewTextBoxColumn,
            this.iDProductoDataGridViewTextBoxColumn1,
            this.stockDataGridViewTextBoxColumn,
            this.minimoDataGridViewTextBoxColumn,
            this.maximoDataGridViewTextBoxColumn,
            this.diasReposicionDataGridViewTextBoxColumn,
            this.cantidadMinimaDataGridViewTextBoxColumn});
            this.BARRASPRODUCTODataGridView.DataSource = this.bodegaProductoBindingSource;
            this.BARRASPRODUCTODataGridView.Location = new System.Drawing.Point(6, 38);
            this.BARRASPRODUCTODataGridView.Name = "BARRASPRODUCTODataGridView";
            this.BARRASPRODUCTODataGridView.ReadOnly = true;
            this.BARRASPRODUCTODataGridView.Size = new System.Drawing.Size(619, 121);
            this.BARRASPRODUCTODataGridView.TabIndex = 2;
            // 
            // iDBodegaDataGridViewTextBoxColumn
            // 
            this.iDBodegaDataGridViewTextBoxColumn.DataPropertyName = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.DataSource = this.bodegaBindingSource;
            this.iDBodegaDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDBodegaDataGridViewTextBoxColumn.FillWeight = 213.6947F;
            this.iDBodegaDataGridViewTextBoxColumn.HeaderText = "Bodega";
            this.iDBodegaDataGridViewTextBoxColumn.Name = "iDBodegaDataGridViewTextBoxColumn";
            this.iDBodegaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDBodegaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDBodegaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDBodegaDataGridViewTextBoxColumn.ValueMember = "IDBodega";
            this.iDBodegaDataGridViewTextBoxColumn.Width = 69;
            // 
            // bodegaBindingSource
            // 
            this.bodegaBindingSource.DataMember = "Bodega";
            this.bodegaBindingSource.DataSource = this.dSCombos;
            // 
            // iDProductoDataGridViewTextBoxColumn1
            // 
            this.iDProductoDataGridViewTextBoxColumn1.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.HeaderText = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn1.Name = "iDProductoDataGridViewTextBoxColumn1";
            this.iDProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDProductoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.stockDataGridViewTextBoxColumn.FillWeight = 76.14207F;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 60;
            // 
            // minimoDataGridViewTextBoxColumn
            // 
            this.minimoDataGridViewTextBoxColumn.DataPropertyName = "Minimo";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            this.minimoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.minimoDataGridViewTextBoxColumn.FillWeight = 77.54067F;
            this.minimoDataGridViewTextBoxColumn.HeaderText = "Mínimo";
            this.minimoDataGridViewTextBoxColumn.Name = "minimoDataGridViewTextBoxColumn";
            this.minimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.minimoDataGridViewTextBoxColumn.Width = 67;
            // 
            // maximoDataGridViewTextBoxColumn
            // 
            this.maximoDataGridViewTextBoxColumn.DataPropertyName = "Maximo";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.maximoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.maximoDataGridViewTextBoxColumn.FillWeight = 77.54067F;
            this.maximoDataGridViewTextBoxColumn.HeaderText = "Máximo";
            this.maximoDataGridViewTextBoxColumn.Name = "maximoDataGridViewTextBoxColumn";
            this.maximoDataGridViewTextBoxColumn.ReadOnly = true;
            this.maximoDataGridViewTextBoxColumn.Width = 68;
            // 
            // diasReposicionDataGridViewTextBoxColumn
            // 
            this.diasReposicionDataGridViewTextBoxColumn.DataPropertyName = "DiasReposicion";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.diasReposicionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.diasReposicionDataGridViewTextBoxColumn.FillWeight = 77.54067F;
            this.diasReposicionDataGridViewTextBoxColumn.HeaderText = "Días Reposición";
            this.diasReposicionDataGridViewTextBoxColumn.Name = "diasReposicionDataGridViewTextBoxColumn";
            this.diasReposicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasReposicionDataGridViewTextBoxColumn.Width = 102;
            // 
            // cantidadMinimaDataGridViewTextBoxColumn
            // 
            this.cantidadMinimaDataGridViewTextBoxColumn.DataPropertyName = "CantidadMinima";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N2";
            this.cantidadMinimaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.cantidadMinimaDataGridViewTextBoxColumn.FillWeight = 77.54067F;
            this.cantidadMinimaDataGridViewTextBoxColumn.HeaderText = "Cantidad Mínima";
            this.cantidadMinimaDataGridViewTextBoxColumn.Name = "cantidadMinimaDataGridViewTextBoxColumn";
            this.cantidadMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadMinimaDataGridViewTextBoxColumn.Width = 103;
            // 
            // bodegaProductoBindingSource
            // 
            this.bodegaProductoBindingSource.DataMember = "BodegaProducto";
            this.bodegaProductoBindingSource.DataSource = this.dSCombos;
            // 
            // fAC_BARRATableAdapter
            // 
            this.fAC_BARRATableAdapter.ClearBeforeFill = true;
            // 
            // bodegaProductoTableAdapter
            // 
            this.bodegaProductoTableAdapter.ClearBeforeFill = true;
            // 
            // bodegaTableAdapter
            // 
            this.bodegaTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(57)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(914, 560);
            this.Controls.Add(this.gbxParametros);
            this.Controls.Add(this.gbxBarras);
            this.Controls.Add(pRO_MEDIDAIDLabel);
            this.Controls.Add(this.pRO_MEDIDAIDComboBox);
            this.Controls.Add(pRO_PRECIOLabel);
            this.Controls.Add(this.pRO_PRECIOTextBox);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(pRO_IMAGENLabel);
            this.Controls.Add(this.pRO_IMAGENTextBox);
            this.Controls.Add(pRO_NOTASLabel);
            this.Controls.Add(this.pRO_NOTASTextBox);
            this.Controls.Add(pRO_MEDIDALabel);
            this.Controls.Add(this.pRO_MEDIDATextBox);
            this.Controls.Add(pRO_IVAIDLabel);
            this.Controls.Add(this.pRO_IVAIDComboBox);
            this.Controls.Add(pRO_ESTADOLabel);
            this.Controls.Add(this.pRO_ESTADOComboBox);
            this.Controls.Add(pRO_DESCRIPCIONLabel);
            this.Controls.Add(this.pRO_DESCRIPCIONTextBox);
            this.Controls.Add(pRO_IDLabel);
            this.Controls.Add(this.pRO_IDTextBox);
            this.Controls.Add(this.fAC_PRODUCTODataGridView);
            this.Controls.Add(this.fAC_PRODUCTOBindingNavigator);
            this.Controls.Add(this.BarraTitulo);
            this.MinimizeBox = false;
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTOBindingNavigator)).EndInit();
            this.fAC_PRODUCTOBindingNavigator.ResumeLayout(false);
            this.fAC_PRODUCTOBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fAC_PRODUCTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACIVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOSMEDIDABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTIPOESTADOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.gbxBarras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BARRASDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACBARRABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSCombos1)).EndInit();
            this.gbxParametros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BARRASPRODUCTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodegaProductoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.PictureBox IconMinimizar;
        internal System.Windows.Forms.PictureBox IconCerrar;
        private DSCombos dSCombos;
        private System.Windows.Forms.BindingSource fAC_PRODUCTOBindingSource;
        private DSCombosTableAdapters.FAC_PRODUCTOTableAdapter fAC_PRODUCTOTableAdapter;
        private DSCombosTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fAC_PRODUCTOBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton fAC_PRODUCTOBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fAC_PRODUCTODataGridView;
        private System.Windows.Forms.TextBox pRO_IDTextBox;
        private System.Windows.Forms.TextBox pRO_DESCRIPCIONTextBox;
        private DSCombosTableAdapters.FAC_TIPOS_MEDIDATableAdapter fAC_TIPOS_MEDIDATableAdapter;
        private System.Windows.Forms.BindingSource fACTIPOSMEDIDABindingSource;
        private System.Windows.Forms.ToolStripButton bindingNavigatorEdit;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelOpertation;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource fACTIPOESTADOSBindingSource;
        private DSCombosTableAdapters.FAC_TIPO_ESTADOSTableAdapter fAC_TIPO_ESTADOSTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ComboBox pRO_ESTADOComboBox;
        private System.Windows.Forms.BindingSource fACIVABindingSource;
        private DSCombosTableAdapters.FAC_IVATableAdapter fAC_IVATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ComboBox pRO_IVAIDComboBox;
        private System.Windows.Forms.Button btnBuscarImagen;
        private System.Windows.Forms.TextBox pRO_IMAGENTextBox;
        private System.Windows.Forms.TextBox pRO_NOTASTextBox;
        private System.Windows.Forms.TextBox pRO_MEDIDATextBox;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.TextBox pRO_PRECIOTextBox;
        private System.Windows.Forms.ComboBox pRO_MEDIDAIDComboBox;
        private System.Windows.Forms.GroupBox gbxParametros;
        private System.Windows.Forms.Button btnModificarBodega;
        private System.Windows.Forms.Button btnAgregarBodega;
        private System.Windows.Forms.DataGridView BARRASPRODUCTODataGridView;
        private System.Windows.Forms.GroupBox gbxBarras;
        private System.Windows.Forms.Button btnEliminarBarra;
        private System.Windows.Forms.Button btnAgregarBarra;
        private System.Windows.Forms.DataGridView BARRASDataGridView;
        private DSCombos dSCombos1;
        private System.Windows.Forms.BindingSource fACBARRABindingSource;
        private DSCombosTableAdapters.FAC_BARRATableAdapter fAC_BARRATableAdapter;
        private System.Windows.Forms.BindingSource bodegaProductoBindingSource;
        private DSCombosTableAdapters.BodegaProductoTableAdapter bodegaProductoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barraDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bodegaBindingSource;
        private DSCombosTableAdapters.BodegaTableAdapter bodegaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn PRO_IVAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_NOTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_IMAGEN;
        private System.Windows.Forms.DataGridViewComboBoxColumn PRO_MEDIDAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRO_MEDIDA;
        private System.Windows.Forms.DataGridViewComboBoxColumn ESTADO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maximoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasReposicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMinimaDataGridViewTextBoxColumn;
    }
}