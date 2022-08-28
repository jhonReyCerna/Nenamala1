namespace WindowsFormsApplication2
{
    partial class FrmPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasajero));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label generoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.sqlfenixDataSet = new WindowsFormsApplication2.sqlfenixDataSet();
            this.pASAJEROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pASAJEROTableAdapter = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.PASAJEROTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.sqlfenixDataSetTableAdapters.TableAdapterManager();
            this.pASAJEROBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pASAJEROBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pASAJERODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.generoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJEROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJEROBindingNavigator)).BeginInit();
            this.pASAJEROBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJERODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlfenixDataSet
            // 
            this.sqlfenixDataSet.DataSetName = "sqlfenixDataSet";
            this.sqlfenixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pASAJEROBindingSource
            // 
            this.pASAJEROBindingSource.DataMember = "PASAJERO";
            this.pASAJEROBindingSource.DataSource = this.sqlfenixDataSet;
            // 
            // pASAJEROTableAdapter
            // 
            this.pASAJEROTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASEGURADORATableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOLETA_ENCOMIENDATableAdapter = null;
            this.tableAdapterManager.BOLETA_PASAJETableAdapter = null;
            this.tableAdapterManager.BUSTableAdapter = null;
            this.tableAdapterManager.CONSIGNADOTableAdapter = null;
            this.tableAdapterManager.ENCOMIENDA_DETALLETableAdapter = null;
            this.tableAdapterManager.GUIA_REMISION_REMITENTETableAdapter = null;
            this.tableAdapterManager.ITINERARIOTableAdapter = null;
            this.tableAdapterManager.MANTENIMIENTOTableAdapter = null;
            this.tableAdapterManager.MECANICOTableAdapter = null;
            this.tableAdapterManager.MENSAJEROTableAdapter = null;
            this.tableAdapterManager.MODULO_ATENCIONTableAdapter = null;
            this.tableAdapterManager.PASAJE_DETALLETableAdapter = null;
            this.tableAdapterManager.PASAJEROTableAdapter = this.pASAJEROTableAdapter;
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
            // pASAJEROBindingNavigator
            // 
            this.pASAJEROBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pASAJEROBindingNavigator.BindingSource = this.pASAJEROBindingSource;
            this.pASAJEROBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pASAJEROBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pASAJEROBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pASAJEROBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pASAJEROBindingNavigatorSaveItem});
            this.pASAJEROBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pASAJEROBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pASAJEROBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pASAJEROBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pASAJEROBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pASAJEROBindingNavigator.Name = "pASAJEROBindingNavigator";
            this.pASAJEROBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pASAJEROBindingNavigator.Size = new System.Drawing.Size(864, 27);
            this.pASAJEROBindingNavigator.TabIndex = 0;
            this.pASAJEROBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // pASAJEROBindingNavigatorSaveItem
            // 
            this.pASAJEROBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pASAJEROBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pASAJEROBindingNavigatorSaveItem.Image")));
            this.pASAJEROBindingNavigatorSaveItem.Name = "pASAJEROBindingNavigatorSaveItem";
            this.pASAJEROBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pASAJEROBindingNavigatorSaveItem.Text = "Guardar datos";
            this.pASAJEROBindingNavigatorSaveItem.Click += new System.EventHandler(this.pASAJEROBindingNavigatorSaveItem_Click);
            // 
            // pASAJERODataGridView
            // 
            this.pASAJERODataGridView.AutoGenerateColumns = false;
            this.pASAJERODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pASAJERODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.pASAJERODataGridView.DataSource = this.pASAJEROBindingSource;
            this.pASAJERODataGridView.Location = new System.Drawing.Point(0, 449);
            this.pASAJERODataGridView.Name = "pASAJERODataGridView";
            this.pASAJERODataGridView.RowTemplate.Height = 24;
            this.pASAJERODataGridView.Size = new System.Drawing.Size(844, 236);
            this.pASAJERODataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ApellidoPaterno";
            this.dataGridViewTextBoxColumn2.HeaderText = "ApellidoPaterno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApellidoMaterno";
            this.dataGridViewTextBoxColumn3.HeaderText = "ApellidoMaterno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn5.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Genero";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genero";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn8.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(264, 159);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(388, 156);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // apellidoPaternoLabel
            // 
            apellidoPaternoLabel.AutoSize = true;
            apellidoPaternoLabel.Location = new System.Drawing.Point(264, 187);
            apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            apellidoPaternoLabel.Size = new System.Drawing.Size(116, 17);
            apellidoPaternoLabel.TabIndex = 4;
            apellidoPaternoLabel.Text = "Apellido Paterno:";
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "ApellidoPaterno", true));
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(388, 184);
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidoPaternoTextBox.TabIndex = 5;
            // 
            // apellidoMaternoLabel
            // 
            apellidoMaternoLabel.AutoSize = true;
            apellidoMaternoLabel.Location = new System.Drawing.Point(264, 215);
            apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            apellidoMaternoLabel.Size = new System.Drawing.Size(118, 17);
            apellidoMaternoLabel.TabIndex = 6;
            apellidoMaternoLabel.Text = "Apellido Materno:";
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "ApellidoMaterno", true));
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(388, 212);
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(100, 22);
            this.apellidoMaternoTextBox.TabIndex = 7;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(264, 243);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(69, 17);
            nombresLabel.TabIndex = 8;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(388, 240);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 22);
            this.nombresTextBox.TabIndex = 9;
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Location = new System.Drawing.Point(264, 271);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(35, 17);
            dNILabel.TabIndex = 10;
            dNILabel.Text = "DNI:";
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(388, 268);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(100, 22);
            this.dNITextBox.TabIndex = 11;
            // 
            // generoLabel
            // 
            generoLabel.AutoSize = true;
            generoLabel.Location = new System.Drawing.Point(264, 299);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(60, 17);
            generoLabel.TabIndex = 12;
            generoLabel.Text = "Genero:";
            // 
            // generoTextBox
            // 
            this.generoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "Genero", true));
            this.generoTextBox.Location = new System.Drawing.Point(388, 296);
            this.generoTextBox.Name = "generoTextBox";
            this.generoTextBox.Size = new System.Drawing.Size(100, 22);
            this.generoTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(264, 327);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(388, 324);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 15;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(264, 355);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 16;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pASAJEROBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(388, 352);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefonoTextBox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Pasajeros";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 705);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(apellidoPaternoLabel);
            this.Controls.Add(this.apellidoPaternoTextBox);
            this.Controls.Add(apellidoMaternoLabel);
            this.Controls.Add(this.apellidoMaternoTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.pASAJERODataGridView);
            this.Controls.Add(this.pASAJEROBindingNavigator);
            this.Name = "FrmPasajero";
            this.Text = "FrmPasajero";
            this.Load += new System.EventHandler(this.FrmPasajero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlfenixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJEROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJEROBindingNavigator)).EndInit();
            this.pASAJEROBindingNavigator.ResumeLayout(false);
            this.pASAJEROBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pASAJERODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sqlfenixDataSet sqlfenixDataSet;
        private System.Windows.Forms.BindingSource pASAJEROBindingSource;
        private sqlfenixDataSetTableAdapters.PASAJEROTableAdapter pASAJEROTableAdapter;
        private sqlfenixDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pASAJEROBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pASAJEROBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pASAJERODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox generoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}