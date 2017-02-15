namespace SISCOC_FEL
{
    partial class FrmProspecto
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
            System.Windows.Forms.Label cURPLabel;
            System.Windows.Forms.Label fechaNacLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label montoLabel;
            System.Windows.Forms.Label montoBrutoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nSSLabel;
            System.Windows.Forms.Label rFCLabel;
            System.Windows.Forms.Label subsidioLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            System.Windows.Forms.Label zonaLabel;
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsCliente", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdCliente");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoPersona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Pat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Mat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("RFC");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CURP");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NSS");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaNac");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Monto");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Subsidio");
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoBruto");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProspecto));
            this.grpBxDetCliente = new System.Windows.Forms.GroupBox();
            this.pnlApellidos = new System.Windows.Forms.Panel();
            this.apell_PatTextBox = new System.Windows.Forms.TextBox();
            this.clsClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apell_MatTextBox = new System.Windows.Forms.TextBox();
            this.clsListasTipoPersonaComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasTipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsListasComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasZonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cURPTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.montoTextBox = new System.Windows.Forms.TextBox();
            this.montoBrutoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nSSTextBox = new System.Windows.Forms.TextBox();
            this.rFCTextBox = new System.Windows.Forms.TextBox();
            this.subsidioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uGridCliente = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraCalcManager1 = new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(this.components);
            this.grpBxFiltro = new System.Windows.Forms.GroupBox();
            this.txtBxBusqueda = new System.Windows.Forms.TextBox();
            this.clsListasFiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.clsListasFiltrobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.CteDirtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clsListasStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            apell_MatLabel = new System.Windows.Forms.Label();
            apell_PatLabel = new System.Windows.Forms.Label();
            cURPLabel = new System.Windows.Forms.Label();
            fechaNacLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            montoLabel = new System.Windows.Forms.Label();
            montoBrutoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nSSLabel = new System.Windows.Forms.Label();
            rFCLabel = new System.Windows.Forms.Label();
            subsidioLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            zonaLabel = new System.Windows.Forms.Label();
            this.grpBxDetCliente.SuspendLayout();
            this.pnlApellidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apell_MatLabel
            // 
            apell_MatLabel.AutoSize = true;
            apell_MatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_MatLabel.Location = new System.Drawing.Point(10, 34);
            apell_MatLabel.Name = "apell_MatLabel";
            apell_MatLabel.Size = new System.Drawing.Size(113, 16);
            apell_MatLabel.TabIndex = 0;
            apell_MatLabel.Text = "Apellido Materno:";
            // 
            // apell_PatLabel
            // 
            apell_PatLabel.AutoSize = true;
            apell_PatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_PatLabel.Location = new System.Drawing.Point(10, 9);
            apell_PatLabel.Name = "apell_PatLabel";
            apell_PatLabel.Size = new System.Drawing.Size(111, 16);
            apell_PatLabel.TabIndex = 2;
            apell_PatLabel.Text = "Apellido Paterno:";
            // 
            // cURPLabel
            // 
            cURPLabel.AutoSize = true;
            cURPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cURPLabel.Location = new System.Drawing.Point(455, 153);
            cURPLabel.Name = "cURPLabel";
            cURPLabel.Size = new System.Drawing.Size(49, 16);
            cURPLabel.TabIndex = 4;
            cURPLabel.Text = "CURP:";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacLabel.Location = new System.Drawing.Point(18, 153);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new System.Drawing.Size(77, 16);
            fechaNacLabel.TabIndex = 6;
            fechaNacLabel.Text = "Fecha Nac:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClienteLabel.Location = new System.Drawing.Point(18, 22);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(87, 16);
            idClienteLabel.TabIndex = 8;
            idClienteLabel.Text = "Id Prospecto:";
            // 
            // montoLabel
            // 
            montoLabel.AutoSize = true;
            montoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoLabel.Location = new System.Drawing.Point(643, 51);
            montoLabel.Name = "montoLabel";
            montoLabel.Size = new System.Drawing.Size(48, 16);
            montoLabel.TabIndex = 10;
            montoLabel.Text = "Monto:";
            // 
            // montoBrutoLabel
            // 
            montoBrutoLabel.AutoSize = true;
            montoBrutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montoBrutoLabel.Location = new System.Drawing.Point(643, 77);
            montoBrutoLabel.Name = "montoBrutoLabel";
            montoBrutoLabel.Size = new System.Drawing.Size(82, 16);
            montoBrutoLabel.TabIndex = 12;
            montoBrutoLabel.Text = "Monto Bruto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(18, 126);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 14;
            nombreLabel.Text = "Nombre:";
            // 
            // nSSLabel
            // 
            nSSLabel.AutoSize = true;
            nSSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nSSLabel.Location = new System.Drawing.Point(644, 153);
            nSSLabel.Name = "nSSLabel";
            nSSLabel.Size = new System.Drawing.Size(39, 16);
            nSSLabel.TabIndex = 16;
            nSSLabel.Text = "NSS:";
            // 
            // rFCLabel
            // 
            rFCLabel.AutoSize = true;
            rFCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rFCLabel.Location = new System.Drawing.Point(260, 152);
            rFCLabel.Name = "rFCLabel";
            rFCLabel.Size = new System.Drawing.Size(38, 16);
            rFCLabel.TabIndex = 18;
            rFCLabel.Text = "RFC:";
            // 
            // subsidioLabel
            // 
            subsidioLabel.AutoSize = true;
            subsidioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            subsidioLabel.Location = new System.Drawing.Point(643, 26);
            subsidioLabel.Name = "subsidioLabel";
            subsidioLabel.Size = new System.Drawing.Size(64, 16);
            subsidioLabel.TabIndex = 22;
            subsidioLabel.Text = "Subsidio:";
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoPersonaLabel.Location = new System.Drawing.Point(18, 48);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(93, 16);
            tipoPersonaLabel.TabIndex = 24;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            zonaLabel.Location = new System.Drawing.Point(643, 106);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new System.Drawing.Size(42, 16);
            zonaLabel.TabIndex = 26;
            zonaLabel.Text = "Zona:";
            // 
            // grpBxDetCliente
            // 
            this.grpBxDetCliente.Controls.Add(this.pnlApellidos);
            this.grpBxDetCliente.Controls.Add(this.clsListasTipoPersonaComboBox);
            this.grpBxDetCliente.Controls.Add(this.clsListasComboBox);
            this.grpBxDetCliente.Controls.Add(cURPLabel);
            this.grpBxDetCliente.Controls.Add(this.cURPTextBox);
            this.grpBxDetCliente.Controls.Add(fechaNacLabel);
            this.grpBxDetCliente.Controls.Add(this.fechaNacDateTimePicker);
            this.grpBxDetCliente.Controls.Add(idClienteLabel);
            this.grpBxDetCliente.Controls.Add(this.idClienteTextBox);
            this.grpBxDetCliente.Controls.Add(montoLabel);
            this.grpBxDetCliente.Controls.Add(this.montoTextBox);
            this.grpBxDetCliente.Controls.Add(montoBrutoLabel);
            this.grpBxDetCliente.Controls.Add(this.montoBrutoTextBox);
            this.grpBxDetCliente.Controls.Add(nombreLabel);
            this.grpBxDetCliente.Controls.Add(this.nombreTextBox);
            this.grpBxDetCliente.Controls.Add(nSSLabel);
            this.grpBxDetCliente.Controls.Add(this.nSSTextBox);
            this.grpBxDetCliente.Controls.Add(rFCLabel);
            this.grpBxDetCliente.Controls.Add(this.rFCTextBox);
            this.grpBxDetCliente.Controls.Add(subsidioLabel);
            this.grpBxDetCliente.Controls.Add(this.subsidioTextBox);
            this.grpBxDetCliente.Controls.Add(tipoPersonaLabel);
            this.grpBxDetCliente.Controls.Add(zonaLabel);
            this.grpBxDetCliente.Location = new System.Drawing.Point(12, 73);
            this.grpBxDetCliente.Name = "grpBxDetCliente";
            this.grpBxDetCliente.Size = new System.Drawing.Size(972, 182);
            this.grpBxDetCliente.TabIndex = 3;
            this.grpBxDetCliente.TabStop = false;
            this.grpBxDetCliente.Text = "Detalle Prospecto:";
            // 
            // pnlApellidos
            // 
            this.pnlApellidos.Controls.Add(this.apell_PatTextBox);
            this.pnlApellidos.Controls.Add(apell_PatLabel);
            this.pnlApellidos.Controls.Add(this.apell_MatTextBox);
            this.pnlApellidos.Controls.Add(apell_MatLabel);
            this.pnlApellidos.Location = new System.Drawing.Point(6, 69);
            this.pnlApellidos.Name = "pnlApellidos";
            this.pnlApellidos.Size = new System.Drawing.Size(526, 55);
            this.pnlApellidos.TabIndex = 6;
            // 
            // apell_PatTextBox
            // 
            this.apell_PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_PatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "Apell_Pat", true));
            this.apell_PatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_PatTextBox.Location = new System.Drawing.Point(119, 3);
            this.apell_PatTextBox.MaxLength = 70;
            this.apell_PatTextBox.Name = "apell_PatTextBox";
            this.apell_PatTextBox.Size = new System.Drawing.Size(389, 22);
            this.apell_PatTextBox.TabIndex = 7;
            this.apell_PatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apell_PatTextBox_KeyDown);
            // 
            // clsClienteBindingSource
            // 
            this.clsClienteBindingSource.DataSource = typeof(SISCOC_BL.ClsCliente);
            this.clsClienteBindingSource.BindingComplete += new System.Windows.Forms.BindingCompleteEventHandler(this.clsClienteBindingSource_BindingComplete);
            this.clsClienteBindingSource.PositionChanged += new System.EventHandler(this.clsClienteBindingSource_PositionChanged);
            // 
            // apell_MatTextBox
            // 
            this.apell_MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_MatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "Apell_Mat", true));
            this.apell_MatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apell_MatTextBox.Location = new System.Drawing.Point(119, 28);
            this.apell_MatTextBox.MaxLength = 70;
            this.apell_MatTextBox.Name = "apell_MatTextBox";
            this.apell_MatTextBox.Size = new System.Drawing.Size(389, 22);
            this.apell_MatTextBox.TabIndex = 8;
            this.apell_MatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apell_MatTextBox_KeyDown);
            // 
            // clsListasTipoPersonaComboBox
            // 
            this.clsListasTipoPersonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsClienteBindingSource, "TipoPersona", true));
            this.clsListasTipoPersonaComboBox.DataSource = this.clsListasTipoPersonaBindingSource;
            this.clsListasTipoPersonaComboBox.DisplayMember = "text";
            this.clsListasTipoPersonaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasTipoPersonaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsListasTipoPersonaComboBox.Location = new System.Drawing.Point(125, 45);
            this.clsListasTipoPersonaComboBox.Name = "clsListasTipoPersonaComboBox";
            this.clsListasTipoPersonaComboBox.Size = new System.Drawing.Size(126, 24);
            this.clsListasTipoPersonaComboBox.TabIndex = 5;
            this.clsListasTipoPersonaComboBox.ValueMember = "value";
            this.clsListasTipoPersonaComboBox.SelectedIndexChanged += new System.EventHandler(this.clsListasTipoPersonaComboBox_SelectedIndexChanged_1);
            this.clsListasTipoPersonaComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clsListasTipoPersonaComboBox_KeyDown);
            // 
            // clsListasTipoPersonaBindingSource
            // 
            this.clsListasTipoPersonaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // clsListasComboBox
            // 
            this.clsListasComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsClienteBindingSource, "Zona", true));
            this.clsListasComboBox.DataSource = this.clsListasZonaBindingSource;
            this.clsListasComboBox.DisplayMember = "text";
            this.clsListasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsListasComboBox.Location = new System.Drawing.Point(725, 100);
            this.clsListasComboBox.Name = "clsListasComboBox";
            this.clsListasComboBox.Size = new System.Drawing.Size(127, 24);
            this.clsListasComboBox.TabIndex = 17;
            this.clsListasComboBox.ValueMember = "value";
            this.clsListasComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clsListasComboBox_KeyDown);
            // 
            // clsListasZonaBindingSource
            // 
            this.clsListasZonaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // cURPTextBox
            // 
            this.cURPTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cURPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "CURP", true));
            this.cURPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cURPTextBox.Location = new System.Drawing.Point(510, 149);
            this.cURPTextBox.MaxLength = 18;
            this.cURPTextBox.Name = "cURPTextBox";
            this.cURPTextBox.Size = new System.Drawing.Size(126, 22);
            this.cURPTextBox.TabIndex = 12;
            this.cURPTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cURPTextBox_KeyDown);
            // 
            // fechaNacDateTimePicker
            // 
            this.fechaNacDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clsClienteBindingSource, "FechaNac", true));
            this.fechaNacDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaNacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNacDateTimePicker.Location = new System.Drawing.Point(125, 149);
            this.fechaNacDateTimePicker.Name = "fechaNacDateTimePicker";
            this.fechaNacDateTimePicker.Size = new System.Drawing.Size(126, 22);
            this.fechaNacDateTimePicker.TabIndex = 10;
            this.fechaNacDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaNacDateTimePicker_KeyDown);
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "IdCliente", true));
            this.idClienteTextBox.Enabled = false;
            this.idClienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteTextBox.Location = new System.Drawing.Point(125, 19);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(126, 22);
            this.idClienteTextBox.TabIndex = 4;
            // 
            // montoTextBox
            // 
            this.montoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "Monto", true));
            this.montoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoTextBox.Location = new System.Drawing.Point(726, 48);
            this.montoTextBox.MaxLength = 15;
            this.montoTextBox.Name = "montoTextBox";
            this.montoTextBox.Size = new System.Drawing.Size(126, 22);
            this.montoTextBox.TabIndex = 15;
            this.montoTextBox.Text = "0.00";
            this.montoTextBox.TextChanged += new System.EventHandler(this.montoTextBox_TextChanged);
            this.montoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoTextBox_KeyDown);
            this.montoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoTextBox_KeyPress);
            // 
            // montoBrutoTextBox
            // 
            this.ultraCalcManager1.SetCalcSettings(this.montoBrutoTextBox, new Infragistics.Win.UltraWinCalcManager.CalcSettings(null, null, "", "Text", Infragistics.Win.UltraWinCalcManager.CalcErrorIconAlignment.Default, null));
            this.montoBrutoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoBrutoTextBox.Location = new System.Drawing.Point(726, 74);
            this.montoBrutoTextBox.MaxLength = 20;
            this.montoBrutoTextBox.Name = "montoBrutoTextBox";
            this.montoBrutoTextBox.ReadOnly = true;
            this.montoBrutoTextBox.Size = new System.Drawing.Size(126, 22);
            this.montoBrutoTextBox.TabIndex = 16;
            this.montoBrutoTextBox.Text = "0.00";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(125, 126);
            this.nombreTextBox.MaxLength = 150;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(389, 22);
            this.nombreTextBox.TabIndex = 9;
            this.nombreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreTextBox_KeyDown);
            // 
            // nSSTextBox
            // 
            this.nSSTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nSSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "NSS", true));
            this.nSSTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSSTextBox.Location = new System.Drawing.Point(725, 149);
            this.nSSTextBox.MaxLength = 11;
            this.nSSTextBox.Name = "nSSTextBox";
            this.nSSTextBox.Size = new System.Drawing.Size(126, 22);
            this.nSSTextBox.TabIndex = 13;
            this.nSSTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nSSTextBox_KeyDown);
            // 
            // rFCTextBox
            // 
            this.rFCTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.rFCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "RFC", true));
            this.rFCTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rFCTextBox.Location = new System.Drawing.Point(304, 150);
            this.rFCTextBox.MaxLength = 13;
            this.rFCTextBox.Name = "rFCTextBox";
            this.rFCTextBox.Size = new System.Drawing.Size(126, 22);
            this.rFCTextBox.TabIndex = 11;
            this.rFCTextBox.TextChanged += new System.EventHandler(this.rFCTextBox_TextChanged);
            this.rFCTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rFCTextBox_KeyDown);
            // 
            // subsidioTextBox
            // 
            this.subsidioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsClienteBindingSource, "Subsidio", true));
            this.subsidioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subsidioTextBox.Location = new System.Drawing.Point(726, 19);
            this.subsidioTextBox.MaxLength = 15;
            this.subsidioTextBox.Name = "subsidioTextBox";
            this.subsidioTextBox.Size = new System.Drawing.Size(126, 22);
            this.subsidioTextBox.TabIndex = 14;
            this.subsidioTextBox.Text = "0.00";
            this.subsidioTextBox.TextChanged += new System.EventHandler(this.subsidioTextBox_TextChanged);
            this.subsidioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.subsidioTextBox_KeyDown);
            this.subsidioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subsidioTextBox_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uGridCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 356);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Prospectos:";
            // 
            // uGridCliente
            // 
            this.uGridCliente.CalcManager = this.ultraCalcManager1;
            this.uGridCliente.DataSource = this.clsClienteBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridCliente.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "IdProstecto";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 66;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 97;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 109;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 6;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 7;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 8;
            ultraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn9.Header.VisiblePosition = 5;
            ultraGridColumn10.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance2.TextHAlignAsString = "Right";
            ultraGridColumn10.CellAppearance = appearance2;
            ultraGridColumn10.Format = "##,###,##0.00";
            ultraGridColumn10.Header.VisiblePosition = 10;
            ultraGridColumn11.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance3.TextHAlignAsString = "Right";
            ultraGridColumn11.CellAppearance = appearance3;
            ultraGridColumn11.Format = "##,###,##0.00";
            ultraGridColumn11.Header.VisiblePosition = 9;
            ultraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            appearance4.TextHAlignAsString = "Right";
            ultraGridColumn12.CellAppearance = appearance4;
            ultraGridColumn12.Format = "##,###,##0.00";
            ultraGridColumn12.Formula = "sum( [Monto] , [Subsidio] )";
            ultraGridColumn12.Header.VisiblePosition = 11;
            ultraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn13.Header.VisiblePosition = 12;
            ultraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn14.Header.VisiblePosition = 13;
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
            ultraGridColumn12,
            ultraGridColumn13,
            ultraGridColumn14});
            this.uGridCliente.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridCliente.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            this.uGridCliente.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridCliente.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.ForeColor = System.Drawing.Color.Black;
            this.uGridCliente.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.Color.White;
            appearance6.BackColor2 = System.Drawing.Color.Silver;
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.uGridCliente.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.Transparent;
            this.uGridCliente.DisplayLayout.Override.CardAreaAppearance = appearance7;
            this.uGridCliente.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.FontData.BoldAsString = "True";
            appearance8.FontData.Name = "Arial";
            appearance8.FontData.SizeInPoints = 10F;
            appearance8.ForeColor = System.Drawing.Color.White;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridCliente.DisplayLayout.Override.HeaderAppearance = appearance8;
            this.uGridCliente.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance9.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance9.ForeColor = System.Drawing.Color.Black;
            this.uGridCliente.DisplayLayout.Override.RowSelectorAppearance = appearance9;
            appearance10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance10.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridCliente.DisplayLayout.Override.SelectedRowAppearance = appearance10;
            this.uGridCliente.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridCliente.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridCliente.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridCliente.Location = new System.Drawing.Point(6, 19);
            this.uGridCliente.Name = "uGridCliente";
            this.uGridCliente.Size = new System.Drawing.Size(960, 333);
            this.uGridCliente.TabIndex = 19;
            this.uGridCliente.BeforeRowActivate += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.uGridCliente_BeforeRowActivate);
            // 
            // ultraCalcManager1
            // 
            this.ultraCalcManager1.ContainingControl = this;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.txtBxBusqueda);
            this.grpBxFiltro.Controls.Add(this.clsListasFiltrocomboBox);
            this.grpBxFiltro.Location = new System.Drawing.Point(12, 29);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(972, 38);
            this.grpBxFiltro.TabIndex = 0;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtrar Por:";
            // 
            // txtBxBusqueda
            // 
            this.txtBxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxBusqueda.Location = new System.Drawing.Point(415, 10);
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
            this.clsListasFiltrocomboBox.Location = new System.Drawing.Point(125, 10);
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
            // BindingNavigator
            // 
            this.BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.BindingNavigator.BackgroundImage = global::SISCOC_FEL.Properties.Resources.cuadro21;
            this.BindingNavigator.BindingSource = this.clsClienteBindingSource;
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
            this.CteDirtoolStripButton,
            this.toolStripSeparator4});
            this.BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BindingNavigator.Name = "BindingNavigator";
            this.BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.BindingNavigator.Size = new System.Drawing.Size(996, 25);
            this.BindingNavigator.TabIndex = 32;
            this.BindingNavigator.Text = "bindingNavigator";
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
            // CteDirtoolStripButton
            // 
            this.CteDirtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CteDirtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CteDirtoolStripButton.Image")));
            this.CteDirtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CteDirtoolStripButton.Name = "CteDirtoolStripButton";
            this.CteDirtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CteDirtoolStripButton.ToolTipText = "Direccion del Prospecto";
            this.CteDirtoolStripButton.Click += new System.EventHandler(this.CteDirtoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // clsListasStatusBindingSource
            // 
            this.clsListasStatusBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // FrmProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 621);
            this.Controls.Add(this.grpBxFiltro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpBxDetCliente);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmProspecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Prospectos";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCliente_KeyUp);
            this.grpBxDetCliente.ResumeLayout(false);
            this.grpBxDetCliente.PerformLayout();
            this.pnlApellidos.ResumeLayout(false);
            this.pnlApellidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraCalcManager1)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasStatusBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton CteDirtoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.GroupBox grpBxDetCliente;
        private System.Windows.Forms.TextBox apell_MatTextBox;
        private System.Windows.Forms.BindingSource clsClienteBindingSource;
        private System.Windows.Forms.TextBox apell_PatTextBox;
        private System.Windows.Forms.TextBox cURPTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacDateTimePicker;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox montoTextBox;
        private System.Windows.Forms.TextBox montoBrutoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nSSTextBox;
        private System.Windows.Forms.TextBox rFCTextBox;
        private System.Windows.Forms.TextBox subsidioTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridCliente;
        private System.Windows.Forms.BindingSource clsListasStatusBindingSource;
        private System.Windows.Forms.ComboBox clsListasComboBox;
        private System.Windows.Forms.BindingSource clsListasZonaBindingSource;
        private System.Windows.Forms.ComboBox clsListasTipoPersonaComboBox;
        private System.Windows.Forms.BindingSource clsListasTipoPersonaBindingSource;
        private Infragistics.Win.UltraWinCalcManager.UltraCalcManager ultraCalcManager1;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.TextBox txtBxBusqueda;
        private System.Windows.Forms.ComboBox clsListasFiltrocomboBox;
        private System.Windows.Forms.BindingSource clsListasFiltrobindingSource;
        private System.Windows.Forms.Panel pnlApellidos;
    }
}