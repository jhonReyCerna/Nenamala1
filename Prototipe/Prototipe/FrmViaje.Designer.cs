namespace WindowsFormsApplication2
{
    partial class FrmViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViaje));
            System.Windows.Forms.Label idViajeLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label asientoLabel;
            System.Windows.Forms.Label desplazamientoLabel;
            System.Windows.Forms.Label idBusLabel;
            System.Windows.Forms.Label idPilotoLabel;
            System.Windows.Forms.Label idItinerarioLabel;
            System.Windows.Forms.Label idServicioLabel;
            this.sqlfenixDataSet = new WindowsFormsApplication2.sqlfenixDataSet();
            this.vIAJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vIAJETableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.VIAJETableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TableAdapterManager();
            this.vIAJEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vIAJEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vIAJEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.SERVICIOTableAdapter();
            this.sERVICIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTINERARIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTINERARIOTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.ITINERARIOTableAdapter();
            this.iTINERARIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bUSTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.BUSTableAdapter();
            this.bUSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pILOTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pILOTOTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.PILOTOTableAdapter();
            this.pILOTODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idViajeTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.asientoTextBox = new System.Windows.Forms.TextBox();
            this.desplazamientoTextBox = new System.Windows.Forms.TextBox();
            this.idBusTextBox = new System.Windows.Forms.TextBox();
            this.idPilotoTextBox = new System.Windows.Forms.TextBox();
            this.idItinerarioTextBox = new System.Windows.Forms.TextBox();
            this.idServicioTextBox = new System.Windows.Forms.TextBox();
            this.tERMINALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tERMINALTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TERMINALTableAdapter();
            this.tERMINALDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idViajeLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            asientoLabel = new System.Windows.Forms.Label();
            desplazamientoLabel = new System.Windows.Forms.Label();
            idBusLabel = new System.Windows.Forms.Label();
            idPilotoLabel = new System.Windows.Forms.Label();
            idItinerarioLabel = new System.Windows.Forms.Label();
            idServicioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingNavigator)).BeginInit();
            this.vIAJEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTINERARIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTINERARIODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTODataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlfenixDataSet
            // 
            this.sqlfenixDataSet.DataSetName = "sqlfenixDataSet";
            this.sqlfenixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vIAJEBindingSource
            // 
            this.vIAJEBindingSource.DataMember = "VIAJE";
            this.vIAJEBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // vIAJETableAdapter
            // 
            this.vIAJETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASEGURADORATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOLETA_ENCOMIENDATableAdapter = null;
            this.tableAdapterManager.BOLETA_PASAJETableAdapter = null;
            this.tableAdapterManager.BUSTableAdapter = this.bUSTableAdapter;
            this.tableAdapterManager.CONSIGNADOTableAdapter = null;
            this.tableAdapterManager.ENCOMIENDA_DETALLETableAdapter = null;
            this.tableAdapterManager.GUIA_REMISION_REMITENTETableAdapter = null;
            this.tableAdapterManager.ITINERARIOTableAdapter = this.iTINERARIOTableAdapter;
            this.tableAdapterManager.MANTENIMIENTOTableAdapter = null;
            this.tableAdapterManager.MECANICOTableAdapter = null;
            this.tableAdapterManager.MENSAJEROTableAdapter = null;
            this.tableAdapterManager.MODULO_ATENCIONTableAdapter = null;
            this.tableAdapterManager.PASAJE_DETALLETableAdapter = null;
            this.tableAdapterManager.PASAJEROTableAdapter = null;
            this.tableAdapterManager.PILOTOTableAdapter = this.pILOTOTableAdapter;
            this.tableAdapterManager.RECEPCIONISTATableAdapter = null;
            this.tableAdapterManager.REMISION_REMITENTE_DETALLETableAdapter = null;
            this.tableAdapterManager.REMITENTETableAdapter = null;
            this.tableAdapterManager.REPRESENTANTETableAdapter = null;
            this.tableAdapterManager.RUTATableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = this.sERVICIOTableAdapter;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TERMINALTableAdapter = this.tERMINALTableAdapter;
            this.tableAdapterManager.TRANSPORTISTATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            this.tableAdapterManager.VIAJETableAdapter = this.vIAJETableAdapter;
            // 
            // vIAJEBindingNavigator
            // 
            this.vIAJEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vIAJEBindingNavigator.BindingSource = this.vIAJEBindingSource;
            this.vIAJEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vIAJEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vIAJEBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vIAJEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.vIAJEBindingNavigatorSaveItem});
            this.vIAJEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vIAJEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vIAJEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vIAJEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vIAJEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vIAJEBindingNavigator.Name = "vIAJEBindingNavigator";
            this.vIAJEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vIAJEBindingNavigator.Size = new System.Drawing.Size(1924, 27);
            this.vIAJEBindingNavigator.TabIndex = 0;
            this.vIAJEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // vIAJEBindingNavigatorSaveItem
            // 
            this.vIAJEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vIAJEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vIAJEBindingNavigatorSaveItem.Image")));
            this.vIAJEBindingNavigatorSaveItem.Name = "vIAJEBindingNavigatorSaveItem";
            this.vIAJEBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.vIAJEBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vIAJEBindingNavigatorSaveItem.Click += new System.EventHandler(this.vIAJEBindingNavigatorSaveItem_Click);
            // 
            // vIAJEDataGridView
            // 
            this.vIAJEDataGridView.AutoGenerateColumns = false;
            this.vIAJEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vIAJEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vIAJEDataGridView.DataSource = this.vIAJEBindingSource;
            this.vIAJEDataGridView.Location = new System.Drawing.Point(0, 363);
            this.vIAJEDataGridView.Name = "vIAJEDataGridView";
            this.vIAJEDataGridView.RowTemplate.Height = 24;
            this.vIAJEDataGridView.Size = new System.Drawing.Size(884, 613);
            this.vIAJEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdViaje";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdViaje";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Asiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Asiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Desplazamiento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Desplazamiento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdBus";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdBus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdPiloto";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdPiloto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdItinerario";
            this.dataGridViewTextBoxColumn7.HeaderText = "IdItinerario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IdServicio";
            this.dataGridViewTextBoxColumn8.HeaderText = "IdServicio";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // sERVICIOTableAdapter
            // 
            this.sERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // sERVICIODataGridView
            // 
            this.sERVICIODataGridView.AutoGenerateColumns = false;
            this.sERVICIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERVICIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.sERVICIODataGridView.DataSource = this.sERVICIOBindingSource;
            this.sERVICIODataGridView.Location = new System.Drawing.Point(1467, 12);
            this.sERVICIODataGridView.Name = "sERVICIODataGridView";
            this.sERVICIODataGridView.RowTemplate.Height = 24;
            this.sERVICIODataGridView.Size = new System.Drawing.Size(445, 345);
            this.sERVICIODataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "IdServico";
            this.dataGridViewTextBoxColumn10.HeaderText = "IdServico";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TipoServicio";
            this.dataGridViewTextBoxColumn11.HeaderText = "TipoServicio";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PrecioAdicional";
            this.dataGridViewTextBoxColumn12.HeaderText = "PrecioAdicional";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // iTINERARIOBindingSource
            // 
            this.iTINERARIOBindingSource.DataMember = "ITINERARIO";
            this.iTINERARIOBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // iTINERARIOTableAdapter
            // 
            this.iTINERARIOTableAdapter.ClearBeforeFill = true;
            // 
            // iTINERARIODataGridView
            // 
            this.iTINERARIODataGridView.AutoGenerateColumns = false;
            this.iTINERARIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iTINERARIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            this.iTINERARIODataGridView.DataSource = this.iTINERARIOBindingSource;
            this.iTINERARIODataGridView.Location = new System.Drawing.Point(407, 12);
            this.iTINERARIODataGridView.Name = "iTINERARIODataGridView";
            this.iTINERARIODataGridView.RowTemplate.Height = 24;
            this.iTINERARIODataGridView.Size = new System.Drawing.Size(528, 345);
            this.iTINERARIODataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "IdEmbarque";
            this.dataGridViewTextBoxColumn14.HeaderText = "IdEmbarque";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "IdDesembarque";
            this.dataGridViewTextBoxColumn15.HeaderText = "IdDesembarque";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Habilitado";
            this.dataGridViewTextBoxColumn16.HeaderText = "Habilitado";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn17.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TurnoLlegada";
            this.dataGridViewTextBoxColumn18.HeaderText = "TurnoLlegada";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TurnoSalida";
            this.dataGridViewTextBoxColumn19.HeaderText = "TurnoSalida";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // bUSBindingSource
            // 
            this.bUSBindingSource.DataMember = "BUS";
            this.bUSBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // bUSTableAdapter
            // 
            this.bUSTableAdapter.ClearBeforeFill = true;
            // 
            // bUSDataGridView
            // 
            this.bUSDataGridView.AutoGenerateColumns = false;
            this.bUSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bUSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26});
            this.bUSDataGridView.DataSource = this.bUSBindingSource;
            this.bUSDataGridView.Location = new System.Drawing.Point(890, 363);
            this.bUSDataGridView.Name = "bUSDataGridView";
            this.bUSDataGridView.RowTemplate.Height = 24;
            this.bUSDataGridView.Size = new System.Drawing.Size(1022, 285);
            this.bUSDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "IdBus";
            this.dataGridViewTextBoxColumn20.HeaderText = "IdBus";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "FechaAdquisicion";
            this.dataGridViewTextBoxColumn21.HeaderText = "FechaAdquisicion";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "NroAsientos";
            this.dataGridViewTextBoxColumn22.HeaderText = "NroAsientos";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn23.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn24.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn25.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Infracciones";
            this.dataGridViewTextBoxColumn26.HeaderText = "Infracciones";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // pILOTOBindingSource
            // 
            this.pILOTOBindingSource.DataMember = "PILOTO";
            this.pILOTOBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // pILOTOTableAdapter
            // 
            this.pILOTOTableAdapter.ClearBeforeFill = true;
            // 
            // pILOTODataGridView
            // 
            this.pILOTODataGridView.AutoGenerateColumns = false;
            this.pILOTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pILOTODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33});
            this.pILOTODataGridView.DataSource = this.pILOTOBindingSource;
            this.pILOTODataGridView.Location = new System.Drawing.Point(890, 654);
            this.pILOTODataGridView.Name = "pILOTODataGridView";
            this.pILOTODataGridView.RowTemplate.Height = 24;
            this.pILOTODataGridView.Size = new System.Drawing.Size(1022, 322);
            this.pILOTODataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "IdConductor";
            this.dataGridViewTextBoxColumn27.HeaderText = "IdConductor";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn28.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "ApellidoPaterno";
            this.dataGridViewTextBoxColumn29.HeaderText = "ApellidoPaterno";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Licencia";
            this.dataGridViewTextBoxColumn30.HeaderText = "Licencia";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Vivienda";
            this.dataGridViewTextBoxColumn31.HeaderText = "Vivienda";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Nacimiento";
            this.dataGridViewTextBoxColumn32.HeaderText = "Nacimiento";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "ApellidoMaterno";
            this.dataGridViewTextBoxColumn33.HeaderText = "ApellidoMaterno";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // idViajeLabel
            // 
            idViajeLabel.AutoSize = true;
            idViajeLabel.Location = new System.Drawing.Point(31, 99);
            idViajeLabel.Name = "idViajeLabel";
            idViajeLabel.Size = new System.Drawing.Size(58, 17);
            idViajeLabel.TabIndex = 26;
            idViajeLabel.Text = "Id Viaje:";
            // 
            // idViajeTextBox
            // 
            this.idViajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "IdViaje", true));
            this.idViajeTextBox.Location = new System.Drawing.Point(150, 96);
            this.idViajeTextBox.Name = "idViajeTextBox";
            this.idViajeTextBox.Size = new System.Drawing.Size(200, 22);
            this.idViajeTextBox.TabIndex = 27;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(31, 128);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 28;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vIAJEBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(150, 124);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fechaDateTimePicker.TabIndex = 29;
            // 
            // asientoLabel
            // 
            asientoLabel.AutoSize = true;
            asientoLabel.Location = new System.Drawing.Point(31, 155);
            asientoLabel.Name = "asientoLabel";
            asientoLabel.Size = new System.Drawing.Size(59, 17);
            asientoLabel.TabIndex = 30;
            asientoLabel.Text = "Asiento:";
            // 
            // asientoTextBox
            // 
            this.asientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "Asiento", true));
            this.asientoTextBox.Location = new System.Drawing.Point(150, 152);
            this.asientoTextBox.Name = "asientoTextBox";
            this.asientoTextBox.Size = new System.Drawing.Size(200, 22);
            this.asientoTextBox.TabIndex = 31;
            // 
            // desplazamientoLabel
            // 
            desplazamientoLabel.AutoSize = true;
            desplazamientoLabel.Location = new System.Drawing.Point(31, 183);
            desplazamientoLabel.Name = "desplazamientoLabel";
            desplazamientoLabel.Size = new System.Drawing.Size(113, 17);
            desplazamientoLabel.TabIndex = 32;
            desplazamientoLabel.Text = "Desplazamiento:";
            // 
            // desplazamientoTextBox
            // 
            this.desplazamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "Desplazamiento", true));
            this.desplazamientoTextBox.Location = new System.Drawing.Point(150, 180);
            this.desplazamientoTextBox.Name = "desplazamientoTextBox";
            this.desplazamientoTextBox.Size = new System.Drawing.Size(200, 22);
            this.desplazamientoTextBox.TabIndex = 33;
            // 
            // idBusLabel
            // 
            idBusLabel.AutoSize = true;
            idBusLabel.Location = new System.Drawing.Point(31, 211);
            idBusLabel.Name = "idBusLabel";
            idBusLabel.Size = new System.Drawing.Size(51, 17);
            idBusLabel.TabIndex = 34;
            idBusLabel.Text = "Id Bus:";
            // 
            // idBusTextBox
            // 
            this.idBusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "IdBus", true));
            this.idBusTextBox.Location = new System.Drawing.Point(150, 208);
            this.idBusTextBox.Name = "idBusTextBox";
            this.idBusTextBox.Size = new System.Drawing.Size(200, 22);
            this.idBusTextBox.TabIndex = 35;
            // 
            // idPilotoLabel
            // 
            idPilotoLabel.AutoSize = true;
            idPilotoLabel.Location = new System.Drawing.Point(31, 239);
            idPilotoLabel.Name = "idPilotoLabel";
            idPilotoLabel.Size = new System.Drawing.Size(62, 17);
            idPilotoLabel.TabIndex = 36;
            idPilotoLabel.Text = "Id Piloto:";
            // 
            // idPilotoTextBox
            // 
            this.idPilotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "IdPiloto", true));
            this.idPilotoTextBox.Location = new System.Drawing.Point(150, 236);
            this.idPilotoTextBox.Name = "idPilotoTextBox";
            this.idPilotoTextBox.Size = new System.Drawing.Size(200, 22);
            this.idPilotoTextBox.TabIndex = 37;
            // 
            // idItinerarioLabel
            // 
            idItinerarioLabel.AutoSize = true;
            idItinerarioLabel.Location = new System.Drawing.Point(31, 267);
            idItinerarioLabel.Name = "idItinerarioLabel";
            idItinerarioLabel.Size = new System.Drawing.Size(82, 17);
            idItinerarioLabel.TabIndex = 38;
            idItinerarioLabel.Text = "Id Itinerario:";
            // 
            // idItinerarioTextBox
            // 
            this.idItinerarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "IdItinerario", true));
            this.idItinerarioTextBox.Location = new System.Drawing.Point(150, 264);
            this.idItinerarioTextBox.Name = "idItinerarioTextBox";
            this.idItinerarioTextBox.Size = new System.Drawing.Size(200, 22);
            this.idItinerarioTextBox.TabIndex = 39;
            // 
            // idServicioLabel
            // 
            idServicioLabel.AutoSize = true;
            idServicioLabel.Location = new System.Drawing.Point(31, 295);
            idServicioLabel.Name = "idServicioLabel";
            idServicioLabel.Size = new System.Drawing.Size(77, 17);
            idServicioLabel.TabIndex = 40;
            idServicioLabel.Text = "Id Servicio:";
            // 
            // idServicioTextBox
            // 
            this.idServicioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vIAJEBindingSource, "IdServicio", true));
            this.idServicioTextBox.Location = new System.Drawing.Point(150, 292);
            this.idServicioTextBox.Name = "idServicioTextBox";
            this.idServicioTextBox.Size = new System.Drawing.Size(200, 22);
            this.idServicioTextBox.TabIndex = 41;
            // 
            // tERMINALBindingSource
            // 
            this.tERMINALBindingSource.DataMember = "TERMINAL";
            this.tERMINALBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // tERMINALTableAdapter
            // 
            this.tERMINALTableAdapter.ClearBeforeFill = true;
            // 
            // tERMINALDataGridView
            // 
            this.tERMINALDataGridView.AutoGenerateColumns = false;
            this.tERMINALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tERMINALDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43});
            this.tERMINALDataGridView.DataSource = this.tERMINALBindingSource;
            this.tERMINALDataGridView.Location = new System.Drawing.Point(941, 12);
            this.tERMINALDataGridView.Name = "tERMINALDataGridView";
            this.tERMINALDataGridView.RowTemplate.Height = 24;
            this.tERMINALDataGridView.Size = new System.Drawing.Size(520, 345);
            this.tERMINALDataGridView.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn34.HeaderText = "Id";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn35.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Region";
            this.dataGridViewTextBoxColumn36.HeaderText = "Region";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn37.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn38.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "Celular";
            this.dataGridViewTextBoxColumn39.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "AperturaPasaje";
            this.dataGridViewTextBoxColumn40.HeaderText = "AperturaPasaje";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "AperturaEncomienda";
            this.dataGridViewTextBoxColumn41.HeaderText = "AperturaEncomienda";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "CierreEncomienda";
            this.dataGridViewTextBoxColumn42.HeaderText = "CierreEncomienda";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "CierrePasaje";
            this.dataGridViewTextBoxColumn43.HeaderText = "CierrePasaje";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            // 
            // FrmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1012);
            this.Controls.Add(this.tERMINALDataGridView);
            this.Controls.Add(idViajeLabel);
            this.Controls.Add(this.idViajeTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(asientoLabel);
            this.Controls.Add(this.asientoTextBox);
            this.Controls.Add(desplazamientoLabel);
            this.Controls.Add(this.desplazamientoTextBox);
            this.Controls.Add(idBusLabel);
            this.Controls.Add(this.idBusTextBox);
            this.Controls.Add(idPilotoLabel);
            this.Controls.Add(this.idPilotoTextBox);
            this.Controls.Add(idItinerarioLabel);
            this.Controls.Add(this.idItinerarioTextBox);
            this.Controls.Add(idServicioLabel);
            this.Controls.Add(this.idServicioTextBox);
            this.Controls.Add(this.pILOTODataGridView);
            this.Controls.Add(this.bUSDataGridView);
            this.Controls.Add(this.iTINERARIODataGridView);
            this.Controls.Add(this.sERVICIODataGridView);
            this.Controls.Add(this.vIAJEDataGridView);
            this.Controls.Add(this.vIAJEBindingNavigator);
            this.Name = "FrmViaje";
            this.Text = "FrmViaje";
            this.Load += new System.EventHandler(this.FrmViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEBindingNavigator)).EndInit();
            this.vIAJEBindingNavigator.ResumeLayout(false);
            this.vIAJEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIAJEDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTINERARIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTINERARIODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bUSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pILOTODataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tERMINALDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sqlfenixDataSet sqlfenixDataSet;
        private System.Windows.Forms.BindingSource vIAJEBindingSource;
        private sqlfenixDataSetTableAdapters.VIAJETableAdapter vIAJETableAdapter;
        private sqlfenixDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vIAJEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vIAJEBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vIAJEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private sqlfenixDataSetTableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private System.Windows.Forms.DataGridView sERVICIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private sqlfenixDataSetTableAdapters.ITINERARIOTableAdapter iTINERARIOTableAdapter;
        private System.Windows.Forms.BindingSource iTINERARIOBindingSource;
        private sqlfenixDataSetTableAdapters.BUSTableAdapter bUSTableAdapter;
        private System.Windows.Forms.DataGridView iTINERARIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.BindingSource bUSBindingSource;
        private sqlfenixDataSetTableAdapters.PILOTOTableAdapter pILOTOTableAdapter;
        private System.Windows.Forms.DataGridView bUSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.BindingSource pILOTOBindingSource;
        private System.Windows.Forms.DataGridView pILOTODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.TextBox idViajeTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox asientoTextBox;
        private System.Windows.Forms.TextBox desplazamientoTextBox;
        private System.Windows.Forms.TextBox idBusTextBox;
        private System.Windows.Forms.TextBox idPilotoTextBox;
        private System.Windows.Forms.TextBox idItinerarioTextBox;
        private System.Windows.Forms.TextBox idServicioTextBox;
        private sqlfenixDataSetTableAdapters.TERMINALTableAdapter tERMINALTableAdapter;
        private System.Windows.Forms.BindingSource tERMINALBindingSource;
        private System.Windows.Forms.DataGridView tERMINALDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
    }
}