namespace WindowsFormsApplication2
{
    partial class FrmGenerarBoleta
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
            System.Windows.Forms.Label fechaEmisionLabel;
            System.Windows.Forms.Label horaEmisionLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label regionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label importeTotalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarBoleta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlfenixDataSet = new WindowsFormsApplication2.sqlfenixDataSet();
            this.tableAdapterManager = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TableAdapterManager();
            this.sP_REPORTE_REGISTROSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_REPORTE_REGISTROSTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.SP_REPORTE_REGISTROSTableAdapter();
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
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sP_REPORTE_REGISTROSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.SP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.nroBoletaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nroBoletaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sP_GENERAR_BOLETA_PASAJEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GENERAR_BOLETA_PASAJETableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.SP_GENERAR_BOLETA_PASAJETableAdapter();
            this.fillToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.nroBoletaToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.nroBoletaToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fechaEmisionLabel1 = new System.Windows.Forms.Label();
            this.horaEmisionLabel1 = new System.Windows.Forms.Label();
            this.apellidoMaternoLabel1 = new System.Windows.Forms.Label();
            this.nombresLabel1 = new System.Windows.Forms.Label();
            this.dNILabel1 = new System.Windows.Forms.Label();
            this.direccionLabel1 = new System.Windows.Forms.Label();
            this.ciudadLabel1 = new System.Windows.Forms.Label();
            this.regionLabel1 = new System.Windows.Forms.Label();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.importeTotalLabel1 = new System.Windows.Forms.Label();
            this.apellidoPaternoLabel2 = new System.Windows.Forms.Label();
            fechaEmisionLabel = new System.Windows.Forms.Label();
            horaEmisionLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            regionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            importeTotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORTE_REGISTROSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORTE_REGISTROSBindingNavigator)).BeginInit();
            this.sP_REPORTE_REGISTROSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJEBindingSource)).BeginInit();
            this.fillToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaEmisionLabel
            // 
            fechaEmisionLabel.AutoSize = true;
            fechaEmisionLabel.Location = new System.Drawing.Point(738, 212);
            fechaEmisionLabel.Name = "fechaEmisionLabel";
            fechaEmisionLabel.Size = new System.Drawing.Size(117, 17);
            fechaEmisionLabel.TabIndex = 15;
            fechaEmisionLabel.Text = "FECHA EMISION:";
            // 
            // horaEmisionLabel
            // 
            horaEmisionLabel.AutoSize = true;
            horaEmisionLabel.Location = new System.Drawing.Point(742, 247);
            horaEmisionLabel.Name = "horaEmisionLabel";
            horaEmisionLabel.Size = new System.Drawing.Size(112, 17);
            horaEmisionLabel.TabIndex = 16;
            horaEmisionLabel.Text = "HORA EMISION:";
            // 
            // apellidoPaternoLabel
            // 
            apellidoPaternoLabel.AutoSize = true;
            apellidoPaternoLabel.Location = new System.Drawing.Point(18, 369);
            apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            apellidoPaternoLabel.Size = new System.Drawing.Size(116, 17);
            apellidoPaternoLabel.TabIndex = 17;
            apellidoPaternoLabel.Text = "Apellido Paterno:";
            // 
            // apellidoMaternoLabel
            // 
            apellidoMaternoLabel.AutoSize = true;
            apellidoMaternoLabel.Location = new System.Drawing.Point(16, 396);
            apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            apellidoMaternoLabel.Size = new System.Drawing.Size(118, 17);
            apellidoMaternoLabel.TabIndex = 18;
            apellidoMaternoLabel.Text = "Apellido Materno:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(18, 428);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(69, 17);
            nombresLabel.TabIndex = 20;
            nombresLabel.Text = "Nombres:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(420, 369);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(35, 17);
            dNILabel.TabIndex = 22;
            dNILabel.Text = "DNI:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(18, 296);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(71, 17);
            direccionLabel.TabIndex = 24;
            direccionLabel.Text = "Direccion:";
            direccionLabel.Click += new System.EventHandler(this.direccionLabel_Click);
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(419, 275);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(56, 17);
            ciudadLabel.TabIndex = 26;
            ciudadLabel.Text = "Ciudad:";
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Location = new System.Drawing.Point(420, 315);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new System.Drawing.Size(57, 17);
            regionLabel.TabIndex = 28;
            regionLabel.Text = "Region:";
            regionLabel.Click += new System.EventHandler(this.regionLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(16, 649);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 30;
            nombreLabel.Text = "Nombre:";
            // 
            // importeTotalLabel
            // 
            importeTotalLabel.AutoSize = true;
            importeTotalLabel.Location = new System.Drawing.Point(700, 648);
            importeTotalLabel.Name = "importeTotalLabel";
            importeTotalLabel.Size = new System.Drawing.Size(124, 17);
            importeTotalLabel.TabIndex = 32;
            importeTotalLabel.Text = "IMPORTE TOTAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "- DATOS DEL USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "R.U.C N° 20133605291";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "BOLETA DE VENTA ELECTRONICA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(775, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 121);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "- PUNTO DE EMISION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 150);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "- ATENDIDO POR";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sqlfenixDataSet
            // 
            this.sqlfenixDataSet.DataSetName = "sqlfenixDataSet";
            this.sqlfenixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASEGURADORATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOLETA_ENCOMIENDATableAdapter = null;
            this.tableAdapterManager.BOLETA_PASAJETableAdapter = null;
            this.tableAdapterManager.BUSTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CONSIGNADOTableAdapter = null;
            this.tableAdapterManager.ENCOMIENDA_DETALLETableAdapter = null;
            this.tableAdapterManager.GUIA_REMISION_REMITENTETableAdapter = null;
            this.tableAdapterManager.ITINERARIOTableAdapter = null;
            this.tableAdapterManager.MANTENIMIENTOTableAdapter = null;
            this.tableAdapterManager.MECANICOTableAdapter = null;
            this.tableAdapterManager.MENSAJEROTableAdapter = null;
            this.tableAdapterManager.MODULO_ATENCIONTableAdapter = null;
            this.tableAdapterManager.PASAJE_DETALLETableAdapter = null;
            this.tableAdapterManager.PASAJEROTableAdapter = null;
            this.tableAdapterManager.PILOTOTableAdapter = null;
            this.tableAdapterManager.RECEPCIONISTATableAdapter = null;
            this.tableAdapterManager.REMISION_REMITENTE_DETALLETableAdapter = null;
            this.tableAdapterManager.REMITENTETableAdapter = null;
            this.tableAdapterManager.REPRESENTANTETableAdapter = null;
            this.tableAdapterManager.RUTATableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = null;
            this.tableAdapterManager.sysdiagramsTableAdapter = null;
            this.tableAdapterManager.TERMINALTableAdapter = null;
            this.tableAdapterManager.TRANSPORTISTATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VEHICULOTableAdapter = null;
            this.tableAdapterManager.VIAJETableAdapter = null;
            // 
            // sP_REPORTE_REGISTROSBindingSource
            // 
            this.sP_REPORTE_REGISTROSBindingSource.DataMember = "SP_REPORTE_REGISTROS";
            this.sP_REPORTE_REGISTROSBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // sP_REPORTE_REGISTROSTableAdapter
            // 
            this.sP_REPORTE_REGISTROSTableAdapter.ClearBeforeFill = true;
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
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
            // sP_REPORTE_REGISTROSBindingNavigatorSaveItem
            // 
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Enabled = false;
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Image")));
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Name = "sP_REPORTE_REGISTROSBindingNavigatorSaveItem";
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // sP_REPORTE_REGISTROSBindingNavigator
            // 
            this.sP_REPORTE_REGISTROSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.BindingSource = this.sP_REPORTE_REGISTROSBindingSource;
            this.sP_REPORTE_REGISTROSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sP_REPORTE_REGISTROSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sP_REPORTE_REGISTROSBindingNavigatorSaveItem});
            this.sP_REPORTE_REGISTROSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sP_REPORTE_REGISTROSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.Name = "sP_REPORTE_REGISTROSBindingNavigator";
            this.sP_REPORTE_REGISTROSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sP_REPORTE_REGISTROSBindingNavigator.Size = new System.Drawing.Size(1161, 27);
            this.sP_REPORTE_REGISTROSBindingNavigator.TabIndex = 1;
            this.sP_REPORTE_REGISTROSBindingNavigator.Text = "bindingNavigator1";
            // 
            // sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource
            // 
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource.DataMember = "SP_GENERAR_BOLETA_PASAJE_DETALLES";
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter
            // 
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nroBoletaToolStripLabel,
            this.nroBoletaToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 27);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1161, 27);
            this.fillToolStrip.TabIndex = 12;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // nroBoletaToolStripLabel
            // 
            this.nroBoletaToolStripLabel.Name = "nroBoletaToolStripLabel";
            this.nroBoletaToolStripLabel.Size = new System.Drawing.Size(80, 24);
            this.nroBoletaToolStripLabel.Text = "NroBoleta:";
            // 
            // nroBoletaToolStripTextBox
            // 
            this.nroBoletaToolStripTextBox.Name = "nroBoletaToolStripTextBox";
            this.nroBoletaToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click_2);
            // 
            // sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView
            // 
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.DataSource = this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.Location = new System.Drawing.Point(15, 454);
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.Name = "sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView";
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.RowTemplate.Height = 24;
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.Size = new System.Drawing.Size(1126, 145);
            this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Unidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Unidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Desembarque";
            this.dataGridViewTextBoxColumn4.HeaderText = "Desembarque";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Embarque";
            this.dataGridViewTextBoxColumn5.HeaderText = "Embarque";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Turno de Salida";
            this.dataGridViewTextBoxColumn6.HeaderText = "Turno de Salida";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Turno de Llegada";
            this.dataGridViewTextBoxColumn7.HeaderText = "Turno de Llegada";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // sP_GENERAR_BOLETA_PASAJEBindingSource
            // 
            this.sP_GENERAR_BOLETA_PASAJEBindingSource.DataMember = "SP_GENERAR_BOLETA_PASAJE";
            this.sP_GENERAR_BOLETA_PASAJEBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // sP_GENERAR_BOLETA_PASAJETableAdapter
            // 
            this.sP_GENERAR_BOLETA_PASAJETableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip1
            // 
            this.fillToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nroBoletaToolStripLabel1,
            this.nroBoletaToolStripTextBox1,
            this.fillToolStripButton1});
            this.fillToolStrip1.Location = new System.Drawing.Point(0, 54);
            this.fillToolStrip1.Name = "fillToolStrip1";
            this.fillToolStrip1.Size = new System.Drawing.Size(1161, 27);
            this.fillToolStrip1.TabIndex = 13;
            this.fillToolStrip1.Text = "fillToolStrip1";
            // 
            // nroBoletaToolStripLabel1
            // 
            this.nroBoletaToolStripLabel1.Name = "nroBoletaToolStripLabel1";
            this.nroBoletaToolStripLabel1.Size = new System.Drawing.Size(80, 24);
            this.nroBoletaToolStripLabel1.Text = "NroBoleta:";
            // 
            // nroBoletaToolStripTextBox1
            // 
            this.nroBoletaToolStripTextBox1.Name = "nroBoletaToolStripTextBox1";
            this.nroBoletaToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // fillToolStripButton1
            // 
            this.fillToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton1.Name = "fillToolStripButton1";
            this.fillToolStripButton1.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton1.Text = "Fill";
            this.fillToolStripButton1.Click += new System.EventHandler(this.fillToolStripButton1_Click_1);
            // 
            // fechaEmisionLabel1
            // 
            this.fechaEmisionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "FechaEmision", true));
            this.fechaEmisionLabel1.Location = new System.Drawing.Point(861, 212);
            this.fechaEmisionLabel1.Name = "fechaEmisionLabel1";
            this.fechaEmisionLabel1.Size = new System.Drawing.Size(156, 23);
            this.fechaEmisionLabel1.TabIndex = 16;
            // 
            // horaEmisionLabel1
            // 
            this.horaEmisionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "HoraEmision", true));
            this.horaEmisionLabel1.Location = new System.Drawing.Point(861, 247);
            this.horaEmisionLabel1.Name = "horaEmisionLabel1";
            this.horaEmisionLabel1.Size = new System.Drawing.Size(156, 23);
            this.horaEmisionLabel1.TabIndex = 17;
            // 
            // apellidoMaternoLabel1
            // 
            this.apellidoMaternoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "ApellidoMaterno", true));
            this.apellidoMaternoLabel1.Location = new System.Drawing.Point(138, 396);
            this.apellidoMaternoLabel1.Name = "apellidoMaternoLabel1";
            this.apellidoMaternoLabel1.Size = new System.Drawing.Size(236, 23);
            this.apellidoMaternoLabel1.TabIndex = 19;
            // 
            // nombresLabel1
            // 
            this.nombresLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "Nombres", true));
            this.nombresLabel1.Location = new System.Drawing.Point(120, 428);
            this.nombresLabel1.Name = "nombresLabel1";
            this.nombresLabel1.Size = new System.Drawing.Size(198, 23);
            this.nombresLabel1.TabIndex = 21;
            // 
            // dNILabel1
            // 
            this.dNILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "DNI", true));
            this.dNILabel1.Location = new System.Drawing.Point(502, 363);
            this.dNILabel1.Name = "dNILabel1";
            this.dNILabel1.Size = new System.Drawing.Size(158, 23);
            this.dNILabel1.TabIndex = 23;
            // 
            // direccionLabel1
            // 
            this.direccionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "Direccion", true));
            this.direccionLabel1.Location = new System.Drawing.Point(109, 296);
            this.direccionLabel1.Name = "direccionLabel1";
            this.direccionLabel1.Size = new System.Drawing.Size(237, 23);
            this.direccionLabel1.TabIndex = 25;
            this.direccionLabel1.Click += new System.EventHandler(this.direccionLabel1_Click);
            // 
            // ciudadLabel1
            // 
            this.ciudadLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "Ciudad", true));
            this.ciudadLabel1.Location = new System.Drawing.Point(481, 275);
            this.ciudadLabel1.Name = "ciudadLabel1";
            this.ciudadLabel1.Size = new System.Drawing.Size(179, 23);
            this.ciudadLabel1.TabIndex = 27;
            // 
            // regionLabel1
            // 
            this.regionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "Region", true));
            this.regionLabel1.Location = new System.Drawing.Point(483, 315);
            this.regionLabel1.Name = "regionLabel1";
            this.regionLabel1.Size = new System.Drawing.Size(166, 23);
            this.regionLabel1.TabIndex = 29;
            this.regionLabel1.Click += new System.EventHandler(this.regionLabel1_Click);
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "Nombre", true));
            this.nombreLabel1.Location = new System.Drawing.Point(109, 649);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(295, 23);
            this.nombreLabel1.TabIndex = 31;
            // 
            // importeTotalLabel1
            // 
            this.importeTotalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "ImporteTotal", true));
            this.importeTotalLabel1.Location = new System.Drawing.Point(831, 648);
            this.importeTotalLabel1.Name = "importeTotalLabel1";
            this.importeTotalLabel1.Size = new System.Drawing.Size(182, 23);
            this.importeTotalLabel1.TabIndex = 33;
            // 
            // apellidoPaternoLabel2
            // 
            this.apellidoPaternoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_GENERAR_BOLETA_PASAJEBindingSource, "ApellidoPaterno", true));
            this.apellidoPaternoLabel2.Location = new System.Drawing.Point(140, 369);
            this.apellidoPaternoLabel2.Name = "apellidoPaternoLabel2";
            this.apellidoPaternoLabel2.Size = new System.Drawing.Size(167, 23);
            this.apellidoPaternoLabel2.TabIndex = 34;
            // 
            // FrmGenerarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1161, 692);
            this.Controls.Add(this.apellidoPaternoLabel2);
            this.Controls.Add(importeTotalLabel);
            this.Controls.Add(this.importeTotalLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(regionLabel);
            this.Controls.Add(this.regionLabel1);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadLabel1);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionLabel1);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNILabel1);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresLabel1);
            this.Controls.Add(apellidoMaternoLabel);
            this.Controls.Add(this.apellidoMaternoLabel1);
            this.Controls.Add(apellidoPaternoLabel);
            this.Controls.Add(horaEmisionLabel);
            this.Controls.Add(this.horaEmisionLabel1);
            this.Controls.Add(fechaEmisionLabel);
            this.Controls.Add(this.fechaEmisionLabel1);
            this.Controls.Add(this.fillToolStrip1);
            this.Controls.Add(this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sP_REPORTE_REGISTROSBindingNavigator);
            this.Name = "FrmGenerarBoleta";
            this.Text = "FrmGenerarBoleta";
            this.Load += new System.EventHandler(this.FrmGenerarBoleta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORTE_REGISTROSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORTE_REGISTROSBindingNavigator)).EndInit();
            this.sP_REPORTE_REGISTROSBindingNavigator.ResumeLayout(false);
            this.sP_REPORTE_REGISTROSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GENERAR_BOLETA_PASAJEBindingSource)).EndInit();
            this.fillToolStrip1.ResumeLayout(false);
            this.fillToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private sqlfenixDataSet sqlfenixDataSet;
        private sqlfenixDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource sP_REPORTE_REGISTROSBindingSource;
        private sqlfenixDataSetTableAdapters.SP_REPORTE_REGISTROSTableAdapter sP_REPORTE_REGISTROSTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton sP_REPORTE_REGISTROSBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator sP_REPORTE_REGISTROSBindingNavigator;
        private System.Windows.Forms.BindingSource sP_GENERAR_BOLETA_PASAJE_DETALLESBindingSource;
        private sqlfenixDataSetTableAdapters.SP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter sP_GENERAR_BOLETA_PASAJE_DETALLESTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel nroBoletaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nroBoletaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView sP_GENERAR_BOLETA_PASAJE_DETALLESDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource sP_GENERAR_BOLETA_PASAJEBindingSource;
        private sqlfenixDataSetTableAdapters.SP_GENERAR_BOLETA_PASAJETableAdapter sP_GENERAR_BOLETA_PASAJETableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip1;
        private System.Windows.Forms.ToolStripLabel nroBoletaToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox nroBoletaToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillToolStripButton1;
        private System.Windows.Forms.Label fechaEmisionLabel1;
        private System.Windows.Forms.Label horaEmisionLabel1;
        private System.Windows.Forms.Label apellidoMaternoLabel1;
        private System.Windows.Forms.Label nombresLabel1;
        private System.Windows.Forms.Label dNILabel1;
        private System.Windows.Forms.Label direccionLabel1;
        private System.Windows.Forms.Label ciudadLabel1;
        private System.Windows.Forms.Label regionLabel1;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.Label importeTotalLabel1;
        private System.Windows.Forms.Label apellidoPaternoLabel2;
    }
}