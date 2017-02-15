namespace SISCOC_FEL
{
    partial class FrmUsuario
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
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label tipoUsuarioLabel;
            System.Windows.Forms.Label label1;
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsUsuario", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Pat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Apell_Mat");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Nombre", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Usuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Contrasena");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TipoUsuario");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.grpBxDetusuario = new System.Windows.Forms.GroupBox();
            this.RepContrasenatextBox = new System.Windows.Forms.TextBox();
            this.clsUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsListasTipoUsuaComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasTipoUsuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apell_MatTextBox = new System.Windows.Forms.TextBox();
            this.apell_PatTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.grpBxListUsuario = new System.Windows.Forms.GroupBox();
            this.uGridUsuario = new Infragistics.Win.UltraWinGrid.UltraGrid();
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
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            apell_MatLabel = new System.Windows.Forms.Label();
            apell_PatLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.grpBxDetusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoUsuaBindingSource)).BeginInit();
            this.grpBxListUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGridUsuario)).BeginInit();
            this.grpBxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).BeginInit();
            this.BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // apell_MatLabel
            // 
            apell_MatLabel.AutoSize = true;
            apell_MatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_MatLabel.Location = new System.Drawing.Point(38, 74);
            apell_MatLabel.Name = "apell_MatLabel";
            apell_MatLabel.Size = new System.Drawing.Size(113, 16);
            apell_MatLabel.TabIndex = 0;
            apell_MatLabel.Text = "Apellido Materno:";
            // 
            // apell_PatLabel
            // 
            apell_PatLabel.AutoSize = true;
            apell_PatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apell_PatLabel.Location = new System.Drawing.Point(40, 48);
            apell_PatLabel.Name = "apell_PatLabel";
            apell_PatLabel.Size = new System.Drawing.Size(111, 16);
            apell_PatLabel.TabIndex = 2;
            apell_PatLabel.Text = "Apellido Paterno:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(52, 152);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(80, 16);
            contrasenaLabel.TabIndex = 4;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUsuarioLabel.Location = new System.Drawing.Point(69, 22);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(72, 16);
            idUsuarioLabel.TabIndex = 6;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(69, 100);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(75, 16);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre(s):";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(73, 126);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(58, 16);
            usuarioLabel.TabIndex = 12;
            usuarioLabel.Text = "Usuario:";
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioLabel.Location = new System.Drawing.Point(46, 202);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(89, 16);
            tipoUsuarioLabel.TabIndex = 15;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(13, 178);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 16);
            label1.TabIndex = 16;
            label1.Text = "Repite Contraseña:";
            // 
            // grpBxDetusuario
            // 
            this.grpBxDetusuario.Controls.Add(this.RepContrasenatextBox);
            this.grpBxDetusuario.Controls.Add(label1);
            this.grpBxDetusuario.Controls.Add(this.clsListasTipoUsuaComboBox);
            this.grpBxDetusuario.Controls.Add(tipoUsuarioLabel);
            this.grpBxDetusuario.Controls.Add(apell_MatLabel);
            this.grpBxDetusuario.Controls.Add(this.apell_MatTextBox);
            this.grpBxDetusuario.Controls.Add(apell_PatLabel);
            this.grpBxDetusuario.Controls.Add(this.apell_PatTextBox);
            this.grpBxDetusuario.Controls.Add(contrasenaLabel);
            this.grpBxDetusuario.Controls.Add(this.contrasenaTextBox);
            this.grpBxDetusuario.Controls.Add(idUsuarioLabel);
            this.grpBxDetusuario.Controls.Add(this.idUsuarioTextBox);
            this.grpBxDetusuario.Controls.Add(nombreLabel);
            this.grpBxDetusuario.Controls.Add(this.nombreTextBox);
            this.grpBxDetusuario.Controls.Add(usuarioLabel);
            this.grpBxDetusuario.Controls.Add(this.usuarioTextBox);
            this.grpBxDetusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxDetusuario.Location = new System.Drawing.Point(12, 65);
            this.grpBxDetusuario.Name = "grpBxDetusuario";
            this.grpBxDetusuario.Size = new System.Drawing.Size(808, 224);
            this.grpBxDetusuario.TabIndex = 3;
            this.grpBxDetusuario.TabStop = false;
            this.grpBxDetusuario.Text = "Detalle Usuario:";
            // 
            // RepContrasenatextBox
            // 
            this.RepContrasenatextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Contrasena", true));
            this.RepContrasenatextBox.Location = new System.Drawing.Point(152, 175);
            this.RepContrasenatextBox.MaxLength = 20;
            this.RepContrasenatextBox.Name = "RepContrasenatextBox";
            this.RepContrasenatextBox.PasswordChar = '|';
            this.RepContrasenatextBox.Size = new System.Drawing.Size(206, 20);
            this.RepContrasenatextBox.TabIndex = 10;
            this.RepContrasenatextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RepContrasenatextBox_KeyDown);
            // 
            // clsUsuarioBindingSource
            // 
            this.clsUsuarioBindingSource.DataSource = typeof(SISCOC_BL.ClsUsuario);
            // 
            // clsListasTipoUsuaComboBox
            // 
            this.clsListasTipoUsuaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsUsuarioBindingSource, "TipoUsuario", true));
            this.clsListasTipoUsuaComboBox.DataSource = this.clsListasTipoUsuaBindingSource;
            this.clsListasTipoUsuaComboBox.DisplayMember = "text";
            this.clsListasTipoUsuaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasTipoUsuaComboBox.Location = new System.Drawing.Point(152, 199);
            this.clsListasTipoUsuaComboBox.Name = "clsListasTipoUsuaComboBox";
            this.clsListasTipoUsuaComboBox.Size = new System.Drawing.Size(206, 21);
            this.clsListasTipoUsuaComboBox.TabIndex = 11;
            this.clsListasTipoUsuaComboBox.ValueMember = "value";
            // 
            // clsListasTipoUsuaBindingSource
            // 
            this.clsListasTipoUsuaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // apell_MatTextBox
            // 
            this.apell_MatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_MatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Apell_Mat", true));
            this.apell_MatTextBox.Location = new System.Drawing.Point(152, 71);
            this.apell_MatTextBox.MaxLength = 70;
            this.apell_MatTextBox.Name = "apell_MatTextBox";
            this.apell_MatTextBox.Size = new System.Drawing.Size(431, 20);
            this.apell_MatTextBox.TabIndex = 6;
            this.apell_MatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apell_MatTextBox_KeyDown);
            // 
            // apell_PatTextBox
            // 
            this.apell_PatTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apell_PatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Apell_Pat", true));
            this.apell_PatTextBox.Location = new System.Drawing.Point(152, 45);
            this.apell_PatTextBox.MaxLength = 70;
            this.apell_PatTextBox.Name = "apell_PatTextBox";
            this.apell_PatTextBox.Size = new System.Drawing.Size(431, 20);
            this.apell_PatTextBox.TabIndex = 5;
            this.apell_PatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.apell_PatTextBox_KeyDown);
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Contrasena", true));
            this.contrasenaTextBox.Location = new System.Drawing.Point(152, 149);
            this.contrasenaTextBox.MaxLength = 20;
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.PasswordChar = '|';
            this.contrasenaTextBox.Size = new System.Drawing.Size(206, 20);
            this.contrasenaTextBox.TabIndex = 9;
            this.contrasenaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contrasenaTextBox_KeyDown);
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Enabled = false;
            this.idUsuarioTextBox.Location = new System.Drawing.Point(152, 19);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUsuarioTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(152, 97);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(206, 20);
            this.nombreTextBox.TabIndex = 7;
            this.nombreTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreTextBox_KeyDown);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsUsuarioBindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(152, 123);
            this.usuarioTextBox.MaxLength = 50;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(206, 20);
            this.usuarioTextBox.TabIndex = 8;
            this.usuarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuarioTextBox_KeyDown);
            // 
            // grpBxListUsuario
            // 
            this.grpBxListUsuario.Controls.Add(this.uGridUsuario);
            this.grpBxListUsuario.Location = new System.Drawing.Point(12, 291);
            this.grpBxListUsuario.Name = "grpBxListUsuario";
            this.grpBxListUsuario.Size = new System.Drawing.Size(806, 263);
            this.grpBxListUsuario.TabIndex = 12;
            this.grpBxListUsuario.TabStop = false;
            this.grpBxListUsuario.Text = "Lista de Usuarios:";
            // 
            // uGridUsuario
            // 
            this.uGridUsuario.DataSource = this.clsUsuarioBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            this.uGridUsuario.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 62;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "Apellido Paterno";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 139;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "Apellido Materno";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 141;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.Caption = "Nombre(s)";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Width = 184;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Width = 97;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn6.Hidden = true;
            ultraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn7.Width = 89;
            ultraGridColumn8.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            this.uGridUsuario.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGridUsuario.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            this.uGridUsuario.DisplayLayout.MaxColScrollRegions = 1;
            this.uGridUsuario.DisplayLayout.MaxRowScrollRegions = 1;
            appearance2.BackColor = System.Drawing.Color.White;
            appearance2.BackColor2 = System.Drawing.Color.Silver;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.ForeColor = System.Drawing.Color.Black;
            this.uGridUsuario.DisplayLayout.Override.ActiveCellAppearance = appearance2;
            appearance3.BackColor = System.Drawing.Color.White;
            appearance3.BackColor2 = System.Drawing.Color.Silver;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance3.ForeColor = System.Drawing.Color.Black;
            this.uGridUsuario.DisplayLayout.Override.ActiveRowAppearance = appearance3;
            appearance4.BackColor = System.Drawing.Color.Transparent;
            this.uGridUsuario.DisplayLayout.Override.CardAreaAppearance = appearance4;
            this.uGridUsuario.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance5.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.FontData.BoldAsString = "True";
            appearance5.FontData.Name = "Arial";
            appearance5.FontData.SizeInPoints = 10F;
            appearance5.ForeColor = System.Drawing.Color.White;
            appearance5.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGridUsuario.DisplayLayout.Override.HeaderAppearance = appearance5;
            this.uGridUsuario.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            appearance6.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(150)))));
            appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance6.ForeColor = System.Drawing.Color.Black;
            this.uGridUsuario.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            appearance7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(148)))));
            appearance7.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(149)))), ((int)(((byte)(21)))));
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.uGridUsuario.DisplayLayout.Override.SelectedRowAppearance = appearance7;
            this.uGridUsuario.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGridUsuario.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGridUsuario.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGridUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGridUsuario.Location = new System.Drawing.Point(6, 19);
            this.uGridUsuario.Name = "uGridUsuario";
            this.uGridUsuario.Size = new System.Drawing.Size(794, 238);
            this.uGridUsuario.TabIndex = 13;
            // 
            // grpBxFiltro
            // 
            this.grpBxFiltro.Controls.Add(this.txtBxBusqueda);
            this.grpBxFiltro.Controls.Add(this.clsListasFiltrocomboBox);
            this.grpBxFiltro.Location = new System.Drawing.Point(12, 28);
            this.grpBxFiltro.Name = "grpBxFiltro";
            this.grpBxFiltro.Size = new System.Drawing.Size(808, 38);
            this.grpBxFiltro.TabIndex = 0;
            this.grpBxFiltro.TabStop = false;
            this.grpBxFiltro.Text = "Filtrar Por:";
            // 
            // txtBxBusqueda
            // 
            this.txtBxBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxBusqueda.Location = new System.Drawing.Point(318, 10);
            this.txtBxBusqueda.Name = "txtBxBusqueda";
            this.txtBxBusqueda.Size = new System.Drawing.Size(273, 22);
            this.txtBxBusqueda.TabIndex = 2;
            this.txtBxBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxBusqueda_KeyUp);
            // 
            // clsListasFiltrocomboBox
            // 
            this.clsListasFiltrocomboBox.DataSource = this.clsListasFiltrobindingSource;
            this.clsListasFiltrocomboBox.DisplayMember = "text";
            this.clsListasFiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasFiltrocomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsListasFiltrocomboBox.Location = new System.Drawing.Point(61, 10);
            this.clsListasFiltrocomboBox.Name = "clsListasFiltrocomboBox";
            this.clsListasFiltrocomboBox.Size = new System.Drawing.Size(238, 24);
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
            this.BindingNavigator.BindingSource = this.clsUsuarioBindingSource;
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
            this.BindingNavigator.Size = new System.Drawing.Size(830, 25);
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
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 606);
            this.Controls.Add(this.grpBxFiltro);
            this.Controls.Add(this.grpBxListUsuario);
            this.Controls.Add(this.grpBxDetusuario);
            this.Controls.Add(this.BindingNavigator);
            this.Name = "FrmUsuario";
            this.Text = "Catalogo de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmUsuario_KeyUp);
            this.grpBxDetusuario.ResumeLayout(false);
            this.grpBxDetusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasTipoUsuaBindingSource)).EndInit();
            this.grpBxListUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGridUsuario)).EndInit();
            this.grpBxFiltro.ResumeLayout(false);
            this.grpBxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasFiltrobindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator)).EndInit();
            this.BindingNavigator.ResumeLayout(false);
            this.BindingNavigator.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBxDetusuario;
        private System.Windows.Forms.GroupBox grpBxListUsuario;
        private System.Windows.Forms.TextBox apell_MatTextBox;
        private System.Windows.Forms.BindingSource clsUsuarioBindingSource;
        private System.Windows.Forms.TextBox apell_PatTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGridUsuario;
        private System.Windows.Forms.ComboBox clsListasTipoUsuaComboBox;
        private System.Windows.Forms.BindingSource clsListasTipoUsuaBindingSource;
        private System.Windows.Forms.TextBox RepContrasenatextBox;
        private System.Windows.Forms.GroupBox grpBxFiltro;
        private System.Windows.Forms.TextBox txtBxBusqueda;
        private System.Windows.Forms.ComboBox clsListasFiltrocomboBox;
        private System.Windows.Forms.BindingSource clsListasFiltrobindingSource;
    }
}