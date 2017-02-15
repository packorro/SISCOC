namespace SISCOC_FEL
{
    partial class FrmProveedor1
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
            System.Windows.Forms.Label apell_MatLabel;
            System.Windows.Forms.Label apell_PatLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor1));
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsProveedor", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Pat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Mat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RFC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telefono");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Domicilio");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Colonia");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Ciudad");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clsProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.ContactoProvtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.txtBxBusqueda = new System.Windows.Forms.TextBox();
            this.clsListasFiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.clsListasFiltrobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBxDetProv = new System.Windows.Forms.GroupBox();
            this.pnlApellidos = new System.Windows.Forms.Panel();
            this.apell_PatTextBox = new System.Windows.Forms.TextBox();
            this.apell_MatTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.coloniaTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.idProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rFCTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.clsListasTipoPersonaComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasTipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBxListprov = new System.Windows.Forms.GroupBox();
            this.uGridProveedor = new Infragistics.Win.UltraWinGrid.UltraGrid();
            apell_MatLabel = new System.Windows.Forms.Label();
            apell_PatLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rFCLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).BeginInit();
            this.grpBxDetProv.SuspendLayout();
            this.pnlApellidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoPersonaBindingSource)).BeginInit();
            this.grpBxListprov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // apell_MatLabel
            // 
            apell_MatLabel.AutoSize = true;
            apell_MatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_MatLabel.Location = new System.Drawing.Point(3, 32);
            apell_MatLabel.Name = "apell_MatLabel";
            apell_MatLabel.Size = new System.Drawing.Size(113, 16);
            apell_MatLabel.TabIndex = 0;
            apell_MatLabel.Text = "Apellido Materno:";
            // 
            // apell_PatLabel
            // 
            apell_PatLabel.AutoSize = true;
            apell_PatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_PatLabel.Location = new System.Drawing.Point(5, 6);
            apell_PatLabel.Name = "apell_PatLabel";
            apell_PatLabel.Size = new System.Drawing.Size(111, 16);
            apell_PatLabel.TabIndex = 2;
            apell_PatLabel.Text = "Apellido Paterno:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(497, 124);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(54, 16);
            ciudadLabel.TabIndex = 4;
            ciudadLabel.Text = "Ciudad:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coloniaLabel.Location = new System.Drawing.Point(497, 98);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(57, 16);
            coloniaLabel.TabIndex = 6;
            coloniaLabel.Text = "Colonia:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            domicilioLabel.Location = new System.Drawing.Point(497, 75);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(67, 16);
            domicilioLabel.TabIndex = 8;
            domicilioLabel.Text = "Domicilio:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(497, 49);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(45, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProveedorLabel.Location = new System.Drawing.Point(11, 20);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(89, 16);
            idProveedorLabel.TabIndex = 12;
            idProveedorLabel.Text = "Id Proveedor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(11, 106);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 14;
            nombreLabel.Text = "Nombre:";
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rFCLabel.Location = new System.Drawing.Point(11, 132);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(38, 16);
            rFCLabel.TabIndex = 16;
            rFCLabel.Text = "RFC:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(497, 23);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(65, 16);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoPersonaLabel.Location = new System.Drawing.Point(11, 49);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(93, 16);
            tipoPersonaLabel.TabIndex = 22;
            tipoPersonaLabel.Text = "Tipo Persona:";
            tipoPersonaLabel.Visible = false;
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigator.BackgroundImage = global::SISCOC_FEL.Properties.Resources.cuadro21;
            this.BindingNavigator.BindingSource = this.clsProveedorBindingSource;
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
            this.ContactoProvtoolStripButton,
            this.toolStripSeparator4});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(971, 25);
            this.BindingNavigator.TabIndex = 33;
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
            // clsProveedorBindingSource
            // 
            this.clsProveedorBindingSource.DataSource = typeof(SISCOC_BL.ClsProveedor);
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
            this.bindingNavigatorMoveLastItem.Text = "Posiciona en el Ultiomo Registro";
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
            // ContactoProvtoolStripButton
            // 
            this.ContactoProvtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ContactoProvtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactoProvtoolStripButton.Image")));
            this.ContactoProvtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContactoProvtoolStripButton.Name = "ContactoProvtoolStripButton";
            this.ContactoProvtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ContactoProvtoolStripButton.ToolTipText = "Contacto Proveedor";
            this.ContactoProvtoolStripButton.Click += new System.EventHandler(this.ContactoProvtoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.txtBxBusqueda);
            this.grpBxFiltro.Controls.Add(this.clsListasFiltrocomboBox);
            this.grpBxFiltro.Location = new System.Drawing.Point(12, 28);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(946, 38);
            this.grpBxFiltro.TabIndex = 0;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtrar Por:";
            // 
            // txtBxBusqueda
            // 
            this.txtBxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxBusqueda.Location = new System.Drawing.Point(356, 10);
            this.txtBxBusqueda.Name = "txtBxBusqueda";
            this.txtBxBusqueda.Size = new System.Drawing.Size(437, 20);
            this.txtBxBusqueda.TabIndex = 2;
            this.txtBxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxBusqueda_KeyUp);
            // 
            // clsListasFiltrocomboBox
            // 
            this.clsListasFiltrocomboBox.DataSource = this.clsListasFiltrobindingSource;
            this.clsListasFiltrocomboBox.DisplayMember = "text";
            this.clsListasFiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasFiltrocomboBox.Location = new System.Drawing.Point(97, 10);
            this.clsListasFiltrocomboBox.Name = "clsListasFiltrocomboBox";
            this.clsListasFiltrocomboBox.Size = new System.Drawing.Size(238, 21);
            this.clsListasFiltrocomboBox.TabIndex = 1;
            this.clsListasFiltrocomboBox.ValueMember = "value";
            this.clsListasFiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.clsListasFiltrocomboBox_SelectedIndexChanged);
            // 
            // clsListasFiltrobindingSource
            // 
            this.clsListasFiltrobindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // grpBxDetProv
            // 
            this.grpBxDetProv.Controls.Add(this.pnlApellidos);
            this.grpBxDetProv.Controls.Add(ciudadLabel);
            this.grpBxDetProv.Controls.Add(this.ciudadTextBox);
            this.grpBxDetProv.Controls.Add(coloniaLabel);
            this.grpBxDetProv.Controls.Add(this.coloniaTextBox);
            this.grpBxDetProv.Controls.Add(domicilioLabel);
            this.grpBxDetProv.Controls.Add(this.domicilioTextBox);
            this.grpBxDetProv.Controls.Add(emailLabel);
            this.grpBxDetProv.Controls.Add(this.emailTextBox);
            this.grpBxDetProv.Controls.Add(idProveedorLabel);
            this.grpBxDetProv.Controls.Add(this.idProveedorTextBox);
            this.grpBxDetProv.Controls.Add(nombreLabel);
            this.grpBxDetProv.Controls.Add(this.nombreTextBox);
            this.grpBxDetProv.Controls.Add(rFCLabel);
            this.grpBxDetProv.Controls.Add(this.rFCTextBox);
            this.grpBxDetProv.Controls.Add(telefonoLabel);
            this.grpBxDetProv.Controls.Add(this.telefonoTextBox);
            this.grpBxDetProv.Controls.Add(tipoPersonaLabel);
            this.grpBxDetProv.Controls.Add(this.clsListasTipoPersonaComboBox);
            this.grpBxDetProv.Location = new System.Drawing.Point(12, 72);
            this.grpBxDetProv.Name = "grpBxDetProv";
            this.grpBxDetProv.Size = new System.Drawing.Size(946, 157);
            this.grpBxDetProv.TabIndex = 3;
            this.grpBxDetProv.TabStop = false;
            this.grpBxDetProv.Text = "Detalle Proveedor:";
            // 
            // pnlApellidos
            // 
            this.pnlApellidos.Controls.Add(this.apell_PatTextBox);
            this.pnlApellidos.Controls.Add(apell_PatLabel);
            this.pnlApellidos.Controls.Add(this.apell_MatTextBox);
            this.pnlApellidos.Controls.Add(apell_MatLabel);
            this.pnlApellidos.Location = new System.Drawing.Point(6, 45);
            this.pnlApellidos.Name = "pnlApellidos";
            this.pnlApellidos.Size = new System.Drawing.Size(485, 58);
            this.pnlApellidos.TabIndex = 6;
            // 
            // apell_PatTextBox
            // 
            this.apell_PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_PatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Apell_Pat", true));
            this.apell_PatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_PatTextBox.Location = new System.Drawing.Point(115, 3);
            this.apell_PatTextBox.MaxLength = 70;
            this.apell_PatTextBox.Name = "apell_PatTextBox";
            this.apell_PatTextBox.Size = new System.Drawing.Size(362, 22);
            this.apell_PatTextBox.TabIndex = 7;
            // 
            // apell_MatTextBox
            // 
            this.apell_MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_MatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Apell_Mat", true));
            this.apell_MatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_MatTextBox.Location = new System.Drawing.Point(115, 29);
            this.apell_MatTextBox.MaxLength = 70;
            this.apell_MatTextBox.Name = "apell_MatTextBox";
            this.apell_MatTextBox.Size = new System.Drawing.Size(362, 22);
            this.apell_MatTextBox.TabIndex = 8;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Ciudad", true));
            this.ciudadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.Location = new System.Drawing.Point(568, 121);
            this.ciudadTextBox.MaxLength = 20;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(149, 22);
            this.ciudadTextBox.TabIndex = 15;
            // 
            // coloniaTextBox
            // 
            this.coloniaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.coloniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Colonia", true));
            this.coloniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coloniaTextBox.Location = new System.Drawing.Point(568, 95);
            this.coloniaTextBox.MaxLength = 30;
            this.coloniaTextBox.Name = "coloniaTextBox";
            this.coloniaTextBox.Size = new System.Drawing.Size(149, 22);
            this.coloniaTextBox.TabIndex = 14;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Domicilio", true));
            this.domicilioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domicilioTextBox.Location = new System.Drawing.Point(568, 72);
            this.domicilioTextBox.MaxLength = 150;
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(361, 22);
            this.domicilioTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(568, 46);
            this.emailTextBox.MaxLength = 70;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(361, 22);
            this.emailTextBox.TabIndex = 12;
            // 
            // idProveedorTextBox
            // 
            this.idProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "IdProveedor", true));
            this.idProveedorTextBox.Enabled = false;
            this.idProveedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProveedorTextBox.Location = new System.Drawing.Point(121, 17);
            this.idProveedorTextBox.Name = "idProveedorTextBox";
            this.idProveedorTextBox.Size = new System.Drawing.Size(149, 22);
            this.idProveedorTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(121, 103);
            this.nombreTextBox.MaxLength = 150;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(361, 22);
            this.nombreTextBox.TabIndex = 9;
            // 
            // rFCTextBox
            // 
            this.rFCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rFCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "RFC", true));
            this.rFCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFCTextBox.Location = new System.Drawing.Point(121, 129);
            this.rFCTextBox.MaxLength = 13;
            this.rFCTextBox.Name = "rFCTextBox";
            this.rFCTextBox.Size = new System.Drawing.Size(149, 22);
            this.rFCTextBox.TabIndex = 10;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(568, 20);
            this.telefonoTextBox.MaxLength = 12;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(149, 22);
            this.telefonoTextBox.TabIndex = 11;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // clsListasTipoPersonaComboBox
            // 
            this.clsListasTipoPersonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsProveedorBindingSource, "TipoPersona", true));
            this.clsListasTipoPersonaComboBox.DataSource = this.clsListasTipoPersonaBindingSource;
            this.clsListasTipoPersonaComboBox.DisplayMember = "text";
            this.clsListasTipoPersonaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasTipoPersonaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsListasTipoPersonaComboBox.Location = new System.Drawing.Point(121, 45);
            this.clsListasTipoPersonaComboBox.Name = "clsListasTipoPersonaComboBox";
            this.clsListasTipoPersonaComboBox.Size = new System.Drawing.Size(149, 24);
            this.clsListasTipoPersonaComboBox.TabIndex = 5;
            this.clsListasTipoPersonaComboBox.ValueMember = "value";
            this.clsListasTipoPersonaComboBox.Visible = false;
            // 
            // clsListasTipoPersonaBindingSource
            // 
            this.clsListasTipoPersonaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // grpBxListprov
            // 
            this.grpBxListprov.Controls.Add(this.uGridProveedor);
            this.grpBxListprov.Location = new System.Drawing.Point(12, 229);
            this.grpBxListprov.Name = "grpBxListprov";
            this.grpBxListprov.Size = new System.Drawing.Size(946, 350);
            this.grpBxListprov.TabIndex = 16;
            this.grpBxListprov.TabStop = false;
            this.grpBxListprov.Text = "Lista de Proveedores:";
            // 
            // uGridProveedor
            // 
            this.uGridProveedor.DataSource = this.clsProveedorBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridProveedor.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 74;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Hidden = true;
            ultraGridColumn2.Width = 97;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Hidden = true;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 346;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Width = 258;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn10.Header.VisiblePosition = 9;
            ultraGridColumn10.Hidden = true;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn11.Header.VisiblePosition = 10;
            ultraGridColumn11.Hidden = true;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn12.Hidden = true;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8,
            ultraGridColumn9,
            ultraGridColumn10,
            ultraGridColumn11,
            ultraGridColumn12});
            this.uGridProveedor.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridProveedor.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            this.uGridProveedor.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridProveedor.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.uGridProveedor.DisplayLayout.Override.CardAreaAppearance = appearance2;
            this.uGridProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.FontData.BoldAsString = "True";
            appearance3.FontData.Name = "Arial";
            appearance3.FontData.SizeInPoints = 10F;
            appearance3.ForeColor = System.Drawing.Color.White;
            appearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridProveedor.DisplayLayout.Override.HeaderAppearance = appearance3;
            this.uGridProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProveedor.DisplayLayout.Override.RowSelectorAppearance = appearance4;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProveedor.DisplayLayout.Override.SelectedRowAppearance = appearance5;
            this.uGridProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridProveedor.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridProveedor.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridProveedor.Location = new System.Drawing.Point(8, 19);
            this.uGridProveedor.Name = "uGridProveedor";
            this.uGridProveedor.Size = new System.Drawing.Size(932, 325);
            this.uGridProveedor.TabIndex = 17;
            // 
            // FrmProveedor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 591);
            this.Controls.Add(this.grpBxListprov);
            this.Controls.Add(this.grpBxDetProv);
            this.Controls.Add(this.grpBxFiltro);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmProveedor1";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProveedor_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).EndInit();
            this.grpBxDetProv.ResumeLayout(false);
            this.grpBxDetProv.PerformLayout();
            this.pnlApellidos.ResumeLayout(false);
            this.pnlApellidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoPersonaBindingSource)).EndInit();
            this.grpBxListprov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGridProveedor)).EndInit();
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
        private System.Windows.Forms.ToolStripButton ContactoProvtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.TextBox txtBxBusqueda;
        private System.Windows.Forms.ComboBox clsListasFiltrocomboBox;
        private System.Windows.Forms.GroupBox grpBxDetProv;
        private System.Windows.Forms.GroupBox grpBxListprov;
        private System.Windows.Forms.TextBox apell_MatTextBox;
        private System.Windows.Forms.BindingSource clsProveedorBindingSource;
        private System.Windows.Forms.TextBox apell_PatTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox coloniaTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idProveedorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox rFCTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Panel pnlApellidos;
        private System.Windows.Forms.BindingSource clsListasFiltrobindingSource;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridProveedor;
        private System.Windows.Forms.BindingSource clsListasTipoPersonaBindingSource;
        private System.Windows.Forms.ComboBox clsListasTipoPersonaComboBox;
    }
}