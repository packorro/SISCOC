namespace SISCOC_FEL
{
    partial class FrmBuscaObra
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("ClsObra", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("IdObra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NombreObra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DescripcionObra");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaIni");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaFin");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("MontoEstimado");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Zona");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Status");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevaBusqueda = new System.Windows.Forms.Button();
            this.w = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdBtnDescripcion = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uGrdObra = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.clsObrasBuscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uGrdObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsObrasBuscarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevaBusqueda);
            this.groupBox1.Controls.Add(this.w);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda:";
            // 
            // btnNuevaBusqueda
            // 
            this.btnNuevaBusqueda.Location = new System.Drawing.Point(115, 264);
            this.btnNuevaBusqueda.Name = "btnNuevaBusqueda";
            this.btnNuevaBusqueda.Size = new System.Drawing.Size(122, 23);
            this.btnNuevaBusqueda.TabIndex = 11;
            this.btnNuevaBusqueda.Text = "Nueva Busqueda";
            this.btnNuevaBusqueda.UseVisualStyleBackColor = true;
            this.btnNuevaBusqueda.Click += new System.EventHandler(this.btnNuevaBusqueda_Click);
            // 
            // w
            // 
            this.w.Location = new System.Drawing.Point(10, 264);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(99, 23);
            this.w.TabIndex = 10;
            this.w.Text = "Buscar";
            this.w.UseVisualStyleBackColor = true;
            this.w.Click += new System.EventHandler(this.w_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtfrase);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "En los Campos";
            // 
            // txtfrase
            // 
            this.txtfrase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfrase.Location = new System.Drawing.Point(54, 20);
            this.txtfrase.MaxLength = 20;
            this.txtfrase.Name = "txtfrase";
            this.txtfrase.Size = new System.Drawing.Size(194, 20);
            this.txtfrase.TabIndex = 2;
            this.txtfrase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfrase_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frase:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdBtnDescripcion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 165);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "En los Campos";
            // 
            // rdBtnDescripcion
            // 
            this.rdBtnDescripcion.AutoSize = true;
            this.rdBtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDescripcion.Location = new System.Drawing.Point(9, 19);
            this.rdBtnDescripcion.Name = "rdBtnDescripcion";
            this.rdBtnDescripcion.Size = new System.Drawing.Size(68, 17);
            this.rdBtnDescripcion.TabIndex = 4;
            this.rdBtnDescripcion.TabStop = true;
            this.rdBtnDescripcion.Text = "Nombre";
            this.rdBtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uGrdObra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(268, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 293);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados de la Busqueda";
            // 
            // uGrdObra
            // 
            this.uGrdObra.DataSource = this.clsObrasBuscarBindingSource;
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BackColor2 = System.Drawing.Color.LightGray;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance1.BorderColor = System.Drawing.Color.Silver;
            this.uGrdObra.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.Header.Caption = "IdVivienda";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Width = 80;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "NombreVivienda";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 191;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "DescripcionVivienda";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 244;
            ultraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn4.Hidden = true;
            ultraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn5.Hidden = true;
            ultraGridColumn6.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn6.Header.VisiblePosition = 5;
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
            this.uGrdObra.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.uGrdObra.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uGrdObra.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.uGrdObra.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.HideRowSelector;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.Color.White;
            this.uGrdObra.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uGrdObra.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.uGrdObra.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uGrdObra.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.uGrdObra.DisplayLayout.InterBandSpacing = 10;
            this.uGrdObra.DisplayLayout.MaxColScrollRegions = 1;
            this.uGrdObra.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.Color.White;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uGrdObra.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.uGrdObra.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.uGrdObra.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uGrdObra.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.Color.White;
            this.uGrdObra.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uGrdObra.DisplayLayout.Override.CellAppearance = appearance8;
            this.uGrdObra.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.uGrdObra.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.Color.White;
            this.uGrdObra.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.BackColor = System.Drawing.Color.LightSteelBlue;
            appearance10.BackColor2 = System.Drawing.Color.White;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.None;
            appearance10.BorderColor = System.Drawing.Color.Transparent;
            appearance10.FontData.BoldAsString = "True";
            appearance10.ForeColor = System.Drawing.Color.Black;
            appearance10.ImageBackground = global::SISCOC_FEL.Properties.Resources.cuadro21;
            appearance10.ImageBackgroundStyle = Infragistics.Win.ImageBackgroundStyle.Tiled;
            appearance10.TextHAlignAsString = "Left";
            appearance10.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.uGrdObra.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.uGrdObra.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uGrdObra.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.Color.White;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.uGrdObra.DisplayLayout.Override.RowAppearance = appearance11;
            this.uGrdObra.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uGrdObra.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.uGrdObra.DisplayLayout.RowConnectorColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(167)))), ((int)(((byte)(191)))));
            this.uGrdObra.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Solid;
            this.uGrdObra.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uGrdObra.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.uGrdObra.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.uGrdObra.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uGrdObra.Location = new System.Drawing.Point(6, 19);
            this.uGrdObra.Name = "uGrdObra";
            this.uGrdObra.Size = new System.Drawing.Size(682, 268);
            this.uGrdObra.TabIndex = 11;
            this.uGrdObra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uGrdObra_KeyDown);
            this.uGrdObra.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.uGrdObra_DoubleClickRow);
            // 
            // clsObrasBuscarBindingSource
            // 
            this.clsObrasBuscarBindingSource.DataSource = typeof(SISCOC_BL.ClsObra);
            // 
            // FrmBuscaObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 316);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBuscaObra";
            this.Text = "Busqueda de Viviendas";
            this.Load += new System.EventHandler(this.FrmBuscaObra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uGrdObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsObrasBuscarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtfrase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdBtnDescripcion;
        private System.Windows.Forms.Button btnNuevaBusqueda;
        private System.Windows.Forms.Button w;
        private System.Windows.Forms.GroupBox groupBox2;
        private Infragistics.Win.UltraWinGrid.UltraGrid uGrdObra;
        private System.Windows.Forms.BindingSource clsObrasBuscarBindingSource;
    }
}