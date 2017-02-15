namespace SISCOC_FEL
{
    partial class FrmContactoProveedor
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label extensionLabel;
            System.Windows.Forms.Label idContactoProveedorLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telCasaLabel;
            System.Windows.Forms.Label telCelLabel;
            System.Windows.Forms.Label telEmpresaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContactoProveedor));
            Infragistics.Win.Appearance appearance26 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsContactoProveedor", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdContactoProveedor", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdProveedor");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Pat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Mat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Email");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelCel");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelCasa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TelEmpresa");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Extension");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance27 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance28 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance29 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance30 = new Infragistics.Win.Appearance();
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clsContactoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.txtBxBusqueda = new System.Windows.Forms.TextBox();
            this.clsListasFiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.clsListasFiltrobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBxDetContactoProv = new System.Windows.Forms.GroupBox();
            this.clsProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.clsProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apell_MatTextBox = new System.Windows.Forms.TextBox();
            this.apell_PatTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.idContactoProveedorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telCasaTextBox = new System.Windows.Forms.TextBox();
            this.telCelTextBox = new System.Windows.Forms.TextBox();
            this.telEmpresaTextBox = new System.Windows.Forms.TextBox();
            this.grpBxListContactoProv = new System.Windows.Forms.GroupBox();
            this.uGridContactoProv = new Infragistics.Win.UltraWinGrid.UltraGrid();
            apell_MatLabel = new System.Windows.Forms.Label();
            apell_PatLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            extensionLabel = new System.Windows.Forms.Label();
            idContactoProveedorLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telCasaLabel = new System.Windows.Forms.Label();
            telCelLabel = new System.Windows.Forms.Label();
            telEmpresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsContactoProveedorBindingSource)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).BeginInit();
            this.grpBxDetContactoProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).BeginInit();
            this.grpBxListContactoProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridContactoProv)).BeginInit();
            this.SuspendLayout();
            // 
            // apell_MatLabel
            // 
            apell_MatLabel.AutoSize = true;
            apell_MatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_MatLabel.Location = new System.Drawing.Point(19, 98);
            apell_MatLabel.Name = "apell_MatLabel";
            apell_MatLabel.Size = new System.Drawing.Size(113, 16);
            apell_MatLabel.TabIndex = 0;
            apell_MatLabel.Text = "Apellido Materno:";
            // 
            // apell_PatLabel
            // 
            apell_PatLabel.AutoSize = true;
            apell_PatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_PatLabel.Location = new System.Drawing.Point(19, 72);
            apell_PatLabel.Name = "apell_PatLabel";
            apell_PatLabel.Size = new System.Drawing.Size(111, 16);
            apell_PatLabel.TabIndex = 2;
            apell_PatLabel.Text = "Apellido Paterno:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(542, 20);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 16);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Correo:";
            // 
            // extensionLabel
            // 
            extensionLabel.AutoSize = true;
            extensionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            extensionLabel.Location = new System.Drawing.Point(542, 124);
            extensionLabel.Name = "extensionLabel";
            extensionLabel.Size = new System.Drawing.Size(69, 16);
            extensionLabel.TabIndex = 6;
            extensionLabel.Text = "Extension:";
            // 
            // idContactoProveedorLabel
            // 
            idContactoProveedorLabel.AutoSize = true;
            idContactoProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idContactoProveedorLabel.Location = new System.Drawing.Point(19, 20);
            idContactoProveedorLabel.Name = "idContactoProveedorLabel";
            idContactoProveedorLabel.Size = new System.Drawing.Size(78, 16);
            idContactoProveedorLabel.TabIndex = 8;
            idContactoProveedorLabel.Text = "Id Contacto:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProveedorLabel.Location = new System.Drawing.Point(19, 46);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(75, 16);
            idProveedorLabel.TabIndex = 10;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(19, 124);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(75, 16);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre(s):";
            // 
            // telCasaLabel
            // 
            telCasaLabel.AutoSize = true;
            telCasaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telCasaLabel.Location = new System.Drawing.Point(542, 46);
            telCasaLabel.Name = "telCasaLabel";
            telCasaLabel.Size = new System.Drawing.Size(66, 16);
            telCasaLabel.TabIndex = 16;
            telCasaLabel.Text = "Tel Casa:";
            // 
            // telCelLabel
            // 
            telCelLabel.AutoSize = true;
            telCelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telCelLabel.Location = new System.Drawing.Point(542, 72);
            telCelLabel.Name = "telCelLabel";
            telCelLabel.Size = new System.Drawing.Size(76, 16);
            telCelLabel.TabIndex = 18;
            telCelLabel.Text = "Tel Celular:";
            // 
            // telEmpresaLabel
            // 
            telEmpresaLabel.AutoSize = true;
            telEmpresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telEmpresaLabel.Location = new System.Drawing.Point(542, 98);
            telEmpresaLabel.Name = "telEmpresaLabel";
            telEmpresaLabel.Size = new System.Drawing.Size(89, 16);
            telEmpresaLabel.TabIndex = 20;
            telEmpresaLabel.Text = "Tel Empresa:";
            // 
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigator.BackgroundImage = global::SISCOC_FEL.Properties.Resources.cuadro21;
            this.BindingNavigator.BindingSource = this.clsContactoProveedorBindingSource;
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
            this.toolStripSeparator4});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(981, 25);
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
            // clsContactoProveedorBindingSource
            // 
            this.clsContactoProveedorBindingSource.DataSource = typeof(SISCOC_BL.ClsContactoProveedor);
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
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.txtBxBusqueda);
            this.grpBxFiltro.Controls.Add(this.clsListasFiltrocomboBox);
            this.grpBxFiltro.Location = new System.Drawing.Point(3, 26);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(973, 38);
            this.grpBxFiltro.TabIndex = 0;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtrar Por:";
            // 
            // txtBxBusqueda
            // 
            this.txtBxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxBusqueda.Location = new System.Drawing.Point(465, 11);
            this.txtBxBusqueda.Name = "txtBxBusqueda";
            this.txtBxBusqueda.Size = new System.Drawing.Size(354, 20);
            this.txtBxBusqueda.TabIndex = 2;
            this.txtBxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxBusqueda_KeyUp);
            // 
            // clsListasFiltrocomboBox
            // 
            this.clsListasFiltrocomboBox.DataSource = this.clsListasFiltrobindingSource;
            this.clsListasFiltrocomboBox.DisplayMember = "text";
            this.clsListasFiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasFiltrocomboBox.Location = new System.Drawing.Point(142, 11);
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
            // grpBxDetContactoProv
            // 
            this.grpBxDetContactoProv.Controls.Add(this.clsProveedorComboBox);
            this.grpBxDetContactoProv.Controls.Add(apell_MatLabel);
            this.grpBxDetContactoProv.Controls.Add(this.apell_MatTextBox);
            this.grpBxDetContactoProv.Controls.Add(apell_PatLabel);
            this.grpBxDetContactoProv.Controls.Add(this.apell_PatTextBox);
            this.grpBxDetContactoProv.Controls.Add(emailLabel);
            this.grpBxDetContactoProv.Controls.Add(this.emailTextBox);
            this.grpBxDetContactoProv.Controls.Add(extensionLabel);
            this.grpBxDetContactoProv.Controls.Add(this.extensionTextBox);
            this.grpBxDetContactoProv.Controls.Add(idContactoProveedorLabel);
            this.grpBxDetContactoProv.Controls.Add(this.idContactoProveedorTextBox);
            this.grpBxDetContactoProv.Controls.Add(idProveedorLabel);
            this.grpBxDetContactoProv.Controls.Add(nombreLabel);
            this.grpBxDetContactoProv.Controls.Add(this.nombreTextBox);
            this.grpBxDetContactoProv.Controls.Add(telCasaLabel);
            this.grpBxDetContactoProv.Controls.Add(this.telCasaTextBox);
            this.grpBxDetContactoProv.Controls.Add(telCelLabel);
            this.grpBxDetContactoProv.Controls.Add(this.telCelTextBox);
            this.grpBxDetContactoProv.Controls.Add(telEmpresaLabel);
            this.grpBxDetContactoProv.Controls.Add(this.telEmpresaTextBox);
            this.grpBxDetContactoProv.Location = new System.Drawing.Point(3, 66);
            this.grpBxDetContactoProv.Name = "grpBxDetContactoProv";
            this.grpBxDetContactoProv.Size = new System.Drawing.Size(973, 151);
            this.grpBxDetContactoProv.TabIndex = 3;
            this.grpBxDetContactoProv.TabStop = false;
            this.grpBxDetContactoProv.Text = "Detalle Contacto Proveedor:";
            // 
            // clsProveedorComboBox
            // 
            this.clsProveedorComboBox.DataSource = this.clsProveedorBindingSource;
            this.clsProveedorComboBox.DisplayMember = "Nombre";
            this.clsProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsProveedorComboBox.Enabled = false;
            this.clsProveedorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsProveedorComboBox.Location = new System.Drawing.Point(142, 43);
            this.clsProveedorComboBox.Name = "clsProveedorComboBox";
            this.clsProveedorComboBox.Size = new System.Drawing.Size(286, 24);
            this.clsProveedorComboBox.TabIndex = 5;
            this.clsProveedorComboBox.ValueMember = "IdProveedor";
            // 
            // clsProveedorBindingSource
            // 
            this.clsProveedorBindingSource.DataSource = typeof(SISCOC_BL.ClsProveedor);
            // 
            // apell_MatTextBox
            // 
            this.apell_MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_MatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "Apell_Mat", true));
            this.apell_MatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_MatTextBox.Location = new System.Drawing.Point(142, 95);
            this.apell_MatTextBox.MaxLength = 70;
            this.apell_MatTextBox.Name = "apell_MatTextBox";
            this.apell_MatTextBox.Size = new System.Drawing.Size(286, 22);
            this.apell_MatTextBox.TabIndex = 7;
            // 
            // apell_PatTextBox
            // 
            this.apell_PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_PatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "Apell_Pat", true));
            this.apell_PatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_PatTextBox.Location = new System.Drawing.Point(142, 69);
            this.apell_PatTextBox.MaxLength = 70;
            this.apell_PatTextBox.Name = "apell_PatTextBox";
            this.apell_PatTextBox.Size = new System.Drawing.Size(286, 22);
            this.apell_PatTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(631, 17);
            this.emailTextBox.MaxLength = 70;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(257, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // extensionTextBox
            // 
            this.extensionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.extensionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "Extension", true));
            this.extensionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionTextBox.Location = new System.Drawing.Point(631, 121);
            this.extensionTextBox.MaxLength = 10;
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.Size = new System.Drawing.Size(122, 22);
            this.extensionTextBox.TabIndex = 13;
            this.extensionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.extensionTextBox_KeyPress);
            // 
            // idContactoProveedorTextBox
            // 
            this.idContactoProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "IdContactoProveedor", true));
            this.idContactoProveedorTextBox.Enabled = false;
            this.idContactoProveedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idContactoProveedorTextBox.Location = new System.Drawing.Point(142, 17);
            this.idContactoProveedorTextBox.Name = "idContactoProveedorTextBox";
            this.idContactoProveedorTextBox.Size = new System.Drawing.Size(120, 22);
            this.idContactoProveedorTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(142, 121);
            this.nombreTextBox.MaxLength = 150;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(286, 22);
            this.nombreTextBox.TabIndex = 8;
            // 
            // telCasaTextBox
            // 
            this.telCasaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telCasaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "TelCasa", true));
            this.telCasaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telCasaTextBox.Location = new System.Drawing.Point(631, 43);
            this.telCasaTextBox.MaxLength = 12;
            this.telCasaTextBox.Name = "telCasaTextBox";
            this.telCasaTextBox.Size = new System.Drawing.Size(122, 22);
            this.telCasaTextBox.TabIndex = 10;
            this.telCasaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telCasaTextBox_KeyPress);
            // 
            // telCelTextBox
            // 
            this.telCelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telCelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "TelCel", true));
            this.telCelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telCelTextBox.Location = new System.Drawing.Point(631, 69);
            this.telCelTextBox.MaxLength = 12;
            this.telCelTextBox.Name = "telCelTextBox";
            this.telCelTextBox.Size = new System.Drawing.Size(122, 22);
            this.telCelTextBox.TabIndex = 11;
            this.telCelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telCelTextBox_KeyPress);
            // 
            // telEmpresaTextBox
            // 
            this.telEmpresaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telEmpresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsContactoProveedorBindingSource, "TelEmpresa", true));
            this.telEmpresaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telEmpresaTextBox.Location = new System.Drawing.Point(631, 95);
            this.telEmpresaTextBox.MaxLength = 12;
            this.telEmpresaTextBox.Name = "telEmpresaTextBox";
            this.telEmpresaTextBox.Size = new System.Drawing.Size(122, 22);
            this.telEmpresaTextBox.TabIndex = 12;
            this.telEmpresaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telEmpresaTextBox_KeyPress);
            // 
            // grpBxListContactoProv
            // 
            this.grpBxListContactoProv.Controls.Add(this.uGridContactoProv);
            this.grpBxListContactoProv.Location = new System.Drawing.Point(3, 223);
            this.grpBxListContactoProv.Name = "grpBxListContactoProv";
            this.grpBxListContactoProv.Size = new System.Drawing.Size(973, 304);
            this.grpBxListContactoProv.TabIndex = 14;
            this.grpBxListContactoProv.TabStop = false;
            this.grpBxListContactoProv.Text = "Lista de Contactos Proveedor:";
            // 
            // uGridContactoProv
            // 
            this.uGridContactoProv.DataSource = this.clsContactoProveedorBindingSource;
            appearance26.BackColor = System.Drawing.Color.White;
            this.uGridContactoProv.DisplayLayout.Appearance = appearance26;
            ultraGridColumn56.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn56.Header.Caption = "IdContacto";
            ultraGridColumn56.Header.VisiblePosition = 0;
            ultraGridColumn56.Width = 75;
            ultraGridColumn57.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn57.Header.VisiblePosition = 1;
            ultraGridColumn57.Width = 93;
            ultraGridColumn58.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn58.Header.VisiblePosition = 2;
            ultraGridColumn58.Width = 152;
            ultraGridColumn59.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn59.Header.VisiblePosition = 3;
            ultraGridColumn59.Width = 145;
            ultraGridColumn60.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn60.Header.VisiblePosition = 4;
            ultraGridColumn60.Width = 185;
            ultraGridColumn61.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn61.Header.VisiblePosition = 5;
            ultraGridColumn61.Width = 136;
            ultraGridColumn62.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn62.Header.VisiblePosition = 6;
            ultraGridColumn63.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn63.Header.VisiblePosition = 7;
            ultraGridColumn64.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn64.Header.VisiblePosition = 8;
            ultraGridColumn65.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn65.Header.VisiblePosition = 9;
            ultraGridColumn66.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn66.Header.VisiblePosition = 10;
            ultraGridBand6.Columns.AddRange(new object[] {
            ultraGridColumn56,
            ultraGridColumn57,
            ultraGridColumn58,
            ultraGridColumn59,
            ultraGridColumn60,
            ultraGridColumn61,
            ultraGridColumn62,
            ultraGridColumn63,
            ultraGridColumn64,
            ultraGridColumn65,
            ultraGridColumn66});
            this.uGridContactoProv.DisplayLayout.BandsSerializer.Add(ultraGridBand6);
            this.uGridContactoProv.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            this.uGridContactoProv.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridContactoProv.DisplayLayout.MaxRowScrollRegions = 1;
            appearance27.BackColor = System.Drawing.Color.Transparent;
            this.uGridContactoProv.DisplayLayout.Override.CardAreaAppearance = appearance27;
            this.uGridContactoProv.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance28.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance28.FontData.BoldAsString = "True";
            appearance28.FontData.Name = "Arial";
            appearance28.FontData.SizeInPoints = 10F;
            appearance28.ForeColor = System.Drawing.Color.White;
            appearance28.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridContactoProv.DisplayLayout.Override.HeaderAppearance = appearance28;
            this.uGridContactoProv.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance29.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance29.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridContactoProv.DisplayLayout.Override.RowSelectorAppearance = appearance29;
            appearance30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance30.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance30.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridContactoProv.DisplayLayout.Override.SelectedRowAppearance = appearance30;
            this.uGridContactoProv.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridContactoProv.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridContactoProv.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridContactoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridContactoProv.Location = new System.Drawing.Point(9, 19);
            this.uGridContactoProv.Name = "uGridContactoProv";
            this.uGridContactoProv.Size = new System.Drawing.Size(957, 279);
            this.uGridContactoProv.TabIndex = 15;
            // 
            // FrmContactoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 554);
            this.Controls.Add(this.grpBxListContactoProv);
            this.Controls.Add(this.grpBxDetContactoProv);
            this.Controls.Add(this.grpBxFiltro);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmContactoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmContactoProveedor";
            this.Load += new System.EventHandler(this.FrmContactoProveedor_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmContactoProveedor_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsContactoProveedorBindingSource)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).EndInit();
            this.grpBxDetContactoProv.ResumeLayout(false);
            this.grpBxDetContactoProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorBindingSource)).EndInit();
            this.grpBxListContactoProv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGridContactoProv)).EndInit();
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
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.TextBox txtBxBusqueda;
        private System.Windows.Forms.ComboBox clsListasFiltrocomboBox;
        private System.Windows.Forms.GroupBox grpBxDetContactoProv;
        private System.Windows.Forms.GroupBox grpBxListContactoProv;
        private System.Windows.Forms.TextBox apell_MatTextBox;
        private System.Windows.Forms.BindingSource clsContactoProveedorBindingSource;
        private System.Windows.Forms.TextBox apell_PatTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.TextBox idContactoProveedorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telCasaTextBox;
        private System.Windows.Forms.TextBox telCelTextBox;
        private System.Windows.Forms.TextBox telEmpresaTextBox;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridContactoProv;
        private System.Windows.Forms.ComboBox clsProveedorComboBox;
        private System.Windows.Forms.BindingSource clsProveedorBindingSource;
        private System.Windows.Forms.BindingSource clsListasFiltrobindingSource;
    }
}