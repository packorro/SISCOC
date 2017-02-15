namespace SISCOC_FEL
{
    partial class FrmObra
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
            System.Windows.Forms.Label descripcionObraLabel;
            System.Windows.Forms.Label idObraLabel;
            System.Windows.Forms.Label montoEstimadoLabel;
            System.Windows.Forms.Label nombreObraLabel;
            System.Windows.Forms.Label zonaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObra));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsObra", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdObra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreObra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionObra", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIni");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoEstimado");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clsObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.grpBxDetalleObra = new System.Windows.Forms.GroupBox();
            this.clsListaZonaComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasZonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionObraTextBox = new System.Windows.Forms.TextBox();
            this.idObraTextBox = new System.Windows.Forms.TextBox();
            this.montoEstimadoTextBox = new System.Windows.Forms.TextBox();
            this.nombreObraTextBox = new System.Windows.Forms.TextBox();
            this.grpBxListaObra = new System.Windows.Forms.GroupBox();
            this.uGridObras = new Infragistics.Win.UltraWinGrid.UltraGrid();
            descripcionObraLabel = new System.Windows.Forms.Label();
            idObraLabel = new System.Windows.Forms.Label();
            montoEstimadoLabel = new System.Windows.Forms.Label();
            nombreObraLabel = new System.Windows.Forms.Label();
            zonaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsObraBindingSource)).BeginInit();
            this.grpBxDetalleObra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).BeginInit();
            this.grpBxListaObra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridObras)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionObraLabel
            // 
            descripcionObraLabel.AutoSize = true;
            descripcionObraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionObraLabel.Location = new System.Drawing.Point(50, 72);
            descripcionObraLabel.Name = "descripcionObraLabel";
            descripcionObraLabel.Size = new System.Drawing.Size(139, 16);
            descripcionObraLabel.TabIndex = 0;
            descripcionObraLabel.Text = "Descripcion Vivienda:";
            // 
            // idObraLabel
            // 
            idObraLabel.AutoSize = true;
            idObraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idObraLabel.Location = new System.Drawing.Point(50, 20);
            idObraLabel.Name = "idObraLabel";
            idObraLabel.Size = new System.Drawing.Size(81, 17);
            idObraLabel.TabIndex = 6;
            idObraLabel.Text = "Id Vivienda:";
            // 
            // montoEstimadoLabel
            // 
            montoEstimadoLabel.AutoSize = true;
            montoEstimadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoEstimadoLabel.Location = new System.Drawing.Point(50, 100);
            montoEstimadoLabel.Name = "montoEstimadoLabel";
            montoEstimadoLabel.Size = new System.Drawing.Size(108, 16);
            montoEstimadoLabel.TabIndex = 8;
            montoEstimadoLabel.Text = "Monto Estimado:";
            // 
            // nombreObraLabel
            // 
            nombreObraLabel.AutoSize = true;
            nombreObraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreObraLabel.Location = new System.Drawing.Point(50, 46);
            nombreObraLabel.Name = "nombreObraLabel";
            nombreObraLabel.Size = new System.Drawing.Size(116, 16);
            nombreObraLabel.TabIndex = 10;
            nombreObraLabel.Text = "Nombre Vivienda:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zonaLabel.Location = new System.Drawing.Point(50, 128);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new System.Drawing.Size(42, 16);
            zonaLabel.TabIndex = 14;
            zonaLabel.Text = "Zona:";
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigator.BackgroundImage = global::SISCOC_FEL.Properties.Resources.cuadro21;
            this.BindingNavigator.BindingSource = this.clsObraBindingSource;
            this.BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.BindingNavigator.DeleteItem = null;
            this.BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.BindingNavigatorDeleteItem,
            this.BindingNavigatorSaveItem,
            this.cancelToolStripButton,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.toolStripTextBoxSearch,
            this.toolStripLabel2});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(953, 25);
            this.BindingNavigator.TabIndex = 32;
            this.BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar Nuevo";
            this.bindingNavigatorAddNewItem.ToolTipText = "F2: Agregar Nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // clsObraBindingSource
            // 
            this.clsObraBindingSource.DataSource = typeof(SISCOC_BL.ClsObra);
            this.clsObraBindingSource.PositionChanged += new System.EventHandler(this.clsObraBindingSource_PositionChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total de Datos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Posiciona en el Primer Registro";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Inicio (Home): Posiciona en el Primer Registro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Posiciona en el Registro Anterior";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Flecha Izquierda: Posiciona en el Registro Anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Window;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.ReadOnly = true;
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posicion Actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Posiciona en el siguente Registro";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Flecha Derecha: Posiciona en el siguente Registro";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Posiciona en el Ultimo Registro";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Fin(End): Posiciona en el Ultiomo Registro";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BindingNavigatorDeleteItem
            // 
            this.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorDeleteItem.Image")));
            this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
            this.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.BindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorDeleteItem.Text = "Eliminar";
            this.BindingNavigatorDeleteItem.ToolTipText = "Supr(Del): Eliminar";
            this.BindingNavigatorDeleteItem.Click += new System.EventHandler(this.BindingNavigatorDeleteItem_Click);
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorSaveItem.Image")));
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.BindingNavigatorSaveItem.Text = "Guardar los Datos";
            this.BindingNavigatorSaveItem.ToolTipText = "F4: Guardar los Datos";
            this.BindingNavigatorSaveItem.Click += new System.EventHandler(this.BindingNavigatorSaveItem_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cancelToolStripButton.Text = "toolStripButton1";
            this.cancelToolStripButton.ToolTipText = "F6:  Cancelar Accion de Agregado";
            this.cancelToolStripButton.Click += new System.EventHandler(this.cancelToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel3.Text = "(Alias)";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxSearch.ToolTipText = "F3: Filtra Registros";
            this.toolStripTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearch_KeyUp);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel2.Text = "Busca:   ";
            // 
            // grpBxDetalleObra
            // 
            this.grpBxDetalleObra.Controls.Add(this.clsListaZonaComboBox);
            this.grpBxDetalleObra.Controls.Add(descripcionObraLabel);
            this.grpBxDetalleObra.Controls.Add(this.descripcionObraTextBox);
            this.grpBxDetalleObra.Controls.Add(idObraLabel);
            this.grpBxDetalleObra.Controls.Add(this.idObraTextBox);
            this.grpBxDetalleObra.Controls.Add(montoEstimadoLabel);
            this.grpBxDetalleObra.Controls.Add(this.montoEstimadoTextBox);
            this.grpBxDetalleObra.Controls.Add(nombreObraLabel);
            this.grpBxDetalleObra.Controls.Add(this.nombreObraTextBox);
            this.grpBxDetalleObra.Controls.Add(zonaLabel);
            this.grpBxDetalleObra.Location = new System.Drawing.Point(12, 28);
            this.grpBxDetalleObra.Name = "grpBxDetalleObra";
            this.grpBxDetalleObra.Size = new System.Drawing.Size(933, 157);
            this.grpBxDetalleObra.TabIndex = 0;
            this.grpBxDetalleObra.TabStop = false;
            this.grpBxDetalleObra.Text = "Detalle Vivienda:";
            // 
            // clsListaZonaComboBox
            // 
            this.clsListaZonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsObraBindingSource, "Zona", true));
            this.clsListaZonaComboBox.DataSource = this.clsListasZonaBindingSource;
            this.clsListaZonaComboBox.DisplayMember = "text";
            this.clsListaZonaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListaZonaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsListaZonaComboBox.Location = new System.Drawing.Point(190, 125);
            this.clsListaZonaComboBox.Name = "clsListaZonaComboBox";
            this.clsListaZonaComboBox.Size = new System.Drawing.Size(114, 24);
            this.clsListaZonaComboBox.TabIndex = 7;
            this.clsListaZonaComboBox.ValueMember = "value";
            // 
            // clsListasZonaBindingSource
            // 
            this.clsListasZonaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // descripcionObraTextBox
            // 
            this.descripcionObraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.descripcionObraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "DescripcionObra", true));
            this.descripcionObraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionObraTextBox.Location = new System.Drawing.Point(190, 69);
            this.descripcionObraTextBox.MaxLength = 70;
            this.descripcionObraTextBox.Name = "descripcionObraTextBox";
            this.descripcionObraTextBox.Size = new System.Drawing.Size(493, 22);
            this.descripcionObraTextBox.TabIndex = 3;
            this.descripcionObraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descripcionObraTextBox_KeyDown);
            // 
            // idObraTextBox
            // 
            this.idObraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "IdObra", true));
            this.idObraTextBox.Enabled = false;
            this.idObraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idObraTextBox.Location = new System.Drawing.Point(190, 17);
            this.idObraTextBox.Name = "idObraTextBox";
            this.idObraTextBox.Size = new System.Drawing.Size(114, 22);
            this.idObraTextBox.TabIndex = 1;
            // 
            // montoEstimadoTextBox
            // 
            this.montoEstimadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "MontoEstimado", true));
            this.montoEstimadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoEstimadoTextBox.Location = new System.Drawing.Point(190, 97);
            this.montoEstimadoTextBox.MaxLength = 15;
            this.montoEstimadoTextBox.Name = "montoEstimadoTextBox";
            this.montoEstimadoTextBox.Size = new System.Drawing.Size(114, 22);
            this.montoEstimadoTextBox.TabIndex = 6;
            this.montoEstimadoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoEstimadoTextBox_KeyPress);
            // 
            // nombreObraTextBox
            // 
            this.nombreObraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreObraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "NombreObra", true));
            this.nombreObraTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreObraTextBox.Location = new System.Drawing.Point(190, 43);
            this.nombreObraTextBox.MaxLength = 30;
            this.nombreObraTextBox.Name = "nombreObraTextBox";
            this.nombreObraTextBox.Size = new System.Drawing.Size(493, 22);
            this.nombreObraTextBox.TabIndex = 2;
            this.nombreObraTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreObraTextBox_KeyDown);
            // 
            // grpBxListaObra
            // 
            this.grpBxListaObra.Controls.Add(this.uGridObras);
            this.grpBxListaObra.Location = new System.Drawing.Point(12, 191);
            this.grpBxListaObra.Name = "grpBxListaObra";
            this.grpBxListaObra.Size = new System.Drawing.Size(933, 364);
            this.grpBxListaObra.TabIndex = 8;
            this.grpBxListaObra.TabStop = false;
            this.grpBxListaObra.Text = "Lista de Vivienda:";
            // 
            // uGridObras
            // 
            this.uGridObras.DataSource = this.clsObraBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridObras.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "IdVivienda";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 75;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "NombreVivienda";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 228;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "DescripcionVivienda";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 390;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn4.Width = 90;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn5.Width = 90;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn6.CellAppearance = appearance2;
            ultraGridColumn6.Format = "##,###,##0.00";
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Width = 112;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            this.uGridObras.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridObras.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            this.uGridObras.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridObras.DisplayLayout.MaxRowScrollRegions = 1;
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.uGridObras.DisplayLayout.Override.ActiveCellAppearance = appearance3;
            appearance4.BackColor = System.Drawing.Color.White;
            appearance4.BackColor2 = System.Drawing.Color.Silver;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance4.ForeColor = System.Drawing.Color.Black;
            this.uGridObras.DisplayLayout.Override.ActiveRowAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.Transparent;
            this.uGridObras.DisplayLayout.Override.CardAreaAppearance = appearance5;
            this.uGridObras.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.FontData.BoldAsString = "True";
            appearance6.FontData.Name = "Arial";
            appearance6.FontData.SizeInPoints = 10F;
            appearance6.ForeColor = System.Drawing.Color.White;
            appearance6.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridObras.DisplayLayout.Override.HeaderAppearance = appearance6;
            this.uGridObras.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridObras.DisplayLayout.Override.RowSelectorAppearance = appearance7;
            appearance8.ForeColor = System.Drawing.Color.Black;
            this.uGridObras.DisplayLayout.Override.SelectedCellAppearance = appearance8;
            appearance9.BackColor = System.Drawing.Color.White;
            appearance9.BackColor2 = System.Drawing.Color.Silver;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.Color.Black;
            this.uGridObras.DisplayLayout.Override.SelectedRowAppearance = appearance9;
            this.uGridObras.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.uGridObras.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.uGridObras.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.uGridObras.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridObras.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridObras.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridObras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridObras.Location = new System.Drawing.Point(6, 19);
            this.uGridObras.Name = "uGridObras";
            this.uGridObras.Size = new System.Drawing.Size(921, 299);
            this.uGridObras.TabIndex = 9;
            // 
            // FrmObra
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 560);
            this.Controls.Add(this.grpBxListaObra);
            this.Controls.Add(this.grpBxDetalleObra);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmObra";
            this.Text = "Catalogo de Viviendas";
            this.Load += new System.EventHandler(this.FrmObra_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmObra_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsObraBindingSource)).EndInit();
            this.grpBxDetalleObra.ResumeLayout(false);
            this.grpBxDetalleObra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).EndInit();
            this.grpBxListaObra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGridObras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton BindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.GroupBox grpBxDetalleObra;
        private System.Windows.Forms.GroupBox grpBxListaObra;
        private System.Windows.Forms.TextBox descripcionObraTextBox;
        private System.Windows.Forms.BindingSource clsObraBindingSource;
        private System.Windows.Forms.TextBox idObraTextBox;
        private System.Windows.Forms.TextBox montoEstimadoTextBox;
        private System.Windows.Forms.TextBox nombreObraTextBox;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridObras;
        private System.Windows.Forms.ComboBox clsListaZonaComboBox;
        private System.Windows.Forms.BindingSource clsListasZonaBindingSource;
    }
}