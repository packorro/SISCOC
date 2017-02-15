namespace SISCOC_FEL
{
    partial class FrmProveedor
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
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label coloniaLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedor));
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
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
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
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.grpBxdetProveedor = new System.Windows.Forms.GroupBox();
            this.chckBxMuestraInf = new System.Windows.Forms.CheckBox();
            this.rFCTextBox = new System.Windows.Forms.TextBox();
            this.grpBxInfExtra = new System.Windows.Forms.GroupBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.coloniaTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idProveedorTextBox = new System.Windows.Forms.TextBox();
            this.grpBxListaProveedor = new System.Windows.Forms.GroupBox();
            this.uGridProveedor = new Infragistics.Win.UltraWinGrid.UltraGrid();
            idProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rFCLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            coloniaLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).BeginInit();
            this.grpBxdetProveedor.SuspendLayout();
            this.grpBxInfExtra.SuspendLayout();
            this.grpBxListaProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Location = new System.Drawing.Point(19, 22);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(71, 13);
            idProveedorLabel.TabIndex = 0;
            idProveedorLabel.Text = "Id Proveedor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(19, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Location = new System.Drawing.Point(19, 74);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(31, 13);
            rFCLabel.TabIndex = 5;
            rFCLabel.Text = "RFC:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(13, 22);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 48);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Location = new System.Drawing.Point(13, 74);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(52, 13);
            domicilioLabel.TabIndex = 9;
            domicilioLabel.Text = "Domicilio:";
            // 
            // coloniaLabel
            // 
            coloniaLabel.AutoSize = true;
            coloniaLabel.Location = new System.Drawing.Point(15, 100);
            coloniaLabel.Name = "coloniaLabel";
            coloniaLabel.Size = new System.Drawing.Size(45, 13);
            coloniaLabel.TabIndex = 10;
            coloniaLabel.Text = "Colonia:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(17, 126);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 11;
            ciudadLabel.Text = "Ciudad:";
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
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.toolStripTextBoxSearch,
            this.toolStripLabel3});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(946, 25);
            this.BindingNavigator.TabIndex = 34;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
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
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel2.Text = "Busca:   ";
            // 
            // toolStripTextBoxSearch
            // 
            this.toolStripTextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.toolStripTextBoxSearch.Name = "toolStripTextBoxSearch";
            this.toolStripTextBoxSearch.Size = new System.Drawing.Size(200, 25);
            this.toolStripTextBoxSearch.ToolTipText = "F3: Filtra Registros";
            this.toolStripTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearch_KeyUp);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel3.Text = "(Alias)";
            // 
            // grpBxdetProveedor
            // 
            this.grpBxdetProveedor.Controls.Add(this.chckBxMuestraInf);
            this.grpBxdetProveedor.Controls.Add(rFCLabel);
            this.grpBxdetProveedor.Controls.Add(this.rFCTextBox);
            this.grpBxdetProveedor.Controls.Add(this.grpBxInfExtra);
            this.grpBxdetProveedor.Controls.Add(nombreLabel);
            this.grpBxdetProveedor.Controls.Add(this.nombreTextBox);
            this.grpBxdetProveedor.Controls.Add(idProveedorLabel);
            this.grpBxdetProveedor.Controls.Add(this.idProveedorTextBox);
            this.grpBxdetProveedor.Location = new System.Drawing.Point(12, 28);
            this.grpBxdetProveedor.Name = "grpBxdetProveedor";
            this.grpBxdetProveedor.Size = new System.Drawing.Size(920, 166);
            this.grpBxdetProveedor.TabIndex = 0;
            this.grpBxdetProveedor.TabStop = false;
            this.grpBxdetProveedor.Text = "Detalle Proveedor:";
            // 
            // chckBxMuestraInf
            // 
            this.chckBxMuestraInf.AutoSize = true;
            this.chckBxMuestraInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxMuestraInf.Location = new System.Drawing.Point(22, 95);
            this.chckBxMuestraInf.Name = "chckBxMuestraInf";
            this.chckBxMuestraInf.Size = new System.Drawing.Size(152, 17);
            this.chckBxMuestraInf.TabIndex = 4;
            this.chckBxMuestraInf.Text = "Ver Informacion Extra:";
            this.chckBxMuestraInf.UseVisualStyleBackColor = true;
            this.chckBxMuestraInf.CheckedChanged += new System.EventHandler(this.chckBxMuestraInf_CheckedChanged);
            // 
            // rFCTextBox
            // 
            this.rFCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rFCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "RFC", true));
            this.rFCTextBox.Location = new System.Drawing.Point(96, 71);
            this.rFCTextBox.MaxLength = 13;
            this.rFCTextBox.Name = "rFCTextBox";
            this.rFCTextBox.Size = new System.Drawing.Size(100, 20);
            this.rFCTextBox.TabIndex = 3;
            // 
            // grpBxInfExtra
            // 
            this.grpBxInfExtra.Controls.Add(ciudadLabel);
            this.grpBxInfExtra.Controls.Add(this.ciudadTextBox);
            this.grpBxInfExtra.Controls.Add(coloniaLabel);
            this.grpBxInfExtra.Controls.Add(this.coloniaTextBox);
            this.grpBxInfExtra.Controls.Add(domicilioLabel);
            this.grpBxInfExtra.Controls.Add(this.domicilioTextBox);
            this.grpBxInfExtra.Controls.Add(emailLabel);
            this.grpBxInfExtra.Controls.Add(this.emailTextBox);
            this.grpBxInfExtra.Controls.Add(telefonoLabel);
            this.grpBxInfExtra.Controls.Add(this.telefonoTextBox);
            this.grpBxInfExtra.Location = new System.Drawing.Point(469, 11);
            this.grpBxInfExtra.Name = "grpBxInfExtra";
            this.grpBxInfExtra.Size = new System.Drawing.Size(431, 149);
            this.grpBxInfExtra.TabIndex = 5;
            this.grpBxInfExtra.TabStop = false;
            this.grpBxInfExtra.Text = "Inf. Extra:";
            this.grpBxInfExtra.Enter += new System.EventHandler(this.grpBxInfExtra_Enter);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(90, 123);
            this.ciudadTextBox.MaxLength = 20;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(261, 20);
            this.ciudadTextBox.TabIndex = 10;
            // 
            // coloniaTextBox
            // 
            this.coloniaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.coloniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Colonia", true));
            this.coloniaTextBox.Location = new System.Drawing.Point(90, 97);
            this.coloniaTextBox.MaxLength = 30;
            this.coloniaTextBox.Name = "coloniaTextBox";
            this.coloniaTextBox.Size = new System.Drawing.Size(261, 20);
            this.coloniaTextBox.TabIndex = 9;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Domicilio", true));
            this.domicilioTextBox.Location = new System.Drawing.Point(90, 71);
            this.domicilioTextBox.MaxLength = 150;
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(261, 20);
            this.domicilioTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(90, 45);
            this.emailTextBox.MaxLength = 70;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(261, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(90, 19);
            this.telefonoTextBox.MaxLength = 12;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 6;
            this.telefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTextBox_KeyPress);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(96, 45);
            this.nombreTextBox.MaxLength = 150;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(261, 20);
            this.nombreTextBox.TabIndex = 2;
            // 
            // idProveedorTextBox
            // 
            this.idProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsProveedorBindingSource, "IdProveedor", true));
            this.idProveedorTextBox.Enabled = false;
            this.idProveedorTextBox.Location = new System.Drawing.Point(96, 19);
            this.idProveedorTextBox.Name = "idProveedorTextBox";
            this.idProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.idProveedorTextBox.TabIndex = 1;
            // 
            // grpBxListaProveedor
            // 
            this.grpBxListaProveedor.Controls.Add(this.uGridProveedor);
            this.grpBxListaProveedor.Location = new System.Drawing.Point(12, 200);
            this.grpBxListaProveedor.Name = "grpBxListaProveedor";
            this.grpBxListaProveedor.Size = new System.Drawing.Size(920, 393);
            this.grpBxListaProveedor.TabIndex = 11;
            this.grpBxListaProveedor.TabStop = false;
            this.grpBxListaProveedor.Text = "Lista Proveedor:";
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
            ultraGridColumn5.Width = 647;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Hidden = true;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.Hidden = true;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.Header.VisiblePosition = 8;
            ultraGridColumn9.Hidden = true;
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
            appearance2.BackColor = System.Drawing.Color.White;
            appearance2.BackColor2 = System.Drawing.Color.LightGray;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.ForeColor = System.Drawing.Color.Black;
            this.uGridProveedor.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.Color.White;
            appearance3.BackColor2 = System.Drawing.Color.LightGray;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProveedor.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.uGridProveedor.DisplayLayout.Override.CardAreaAppearance = appearance4;
            this.uGridProveedor.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.FontData.BoldAsString = "True";
            appearance5.FontData.Name = "Arial";
            appearance5.FontData.SizeInPoints = 10F;
            appearance5.ForeColor = System.Drawing.Color.White;
            appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridProveedor.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.uGridProveedor.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProveedor.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridProveedor.DisplayLayout.Override.SelectedRowAppearance = appearance7;
            this.uGridProveedor.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridProveedor.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridProveedor.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridProveedor.Location = new System.Drawing.Point(6, 17);
            this.uGridProveedor.Name = "uGridProveedor";
            this.uGridProveedor.Size = new System.Drawing.Size(894, 370);
            this.uGridProveedor.TabIndex = 12;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(946, 605);
            this.Controls.Add(this.grpBxListaProveedor);
            this.Controls.Add(this.grpBxdetProveedor);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProveedor_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).EndInit();
            this.grpBxdetProveedor.ResumeLayout(false);
            this.grpBxdetProveedor.PerformLayout();
            this.grpBxInfExtra.ResumeLayout(false);
            this.grpBxInfExtra.PerformLayout();
            this.grpBxListaProveedor.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpBxdetProveedor;
        private System.Windows.Forms.GroupBox grpBxListaProveedor;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.BindingSource clsProveedorBindingSource;
        private System.Windows.Forms.TextBox idProveedorTextBox;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridProveedor;
        private System.Windows.Forms.GroupBox grpBxInfExtra;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox rFCTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox coloniaTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.CheckBox chckBxMuestraInf;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}