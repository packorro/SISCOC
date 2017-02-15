namespace SISCOC_FEL
{
    partial class FrmReporteCliente
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
            System.Windows.Forms.Label montoEstimadoLabel;
            System.Windows.Forms.Label zonaLabel;
            System.Windows.Forms.Label lblA;
            System.Windows.Forms.Label lblIdObra;
            System.Windows.Forms.Label lblNombreObra;
            this.grpBxFiltroRep = new System.Windows.Forms.GroupBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBxNombreObra = new System.Windows.Forms.TextBox();
            this.clsObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBxIdObra = new System.Windows.Forms.TextBox();
            this.clsListasOperadorComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasOperadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsListasZonaComboBox = new System.Windows.Forms.ComboBox();
            this.clsListasZonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.montoEstimadoTextBox = new System.Windows.Forms.TextBox();
            this.bttnSalir = new System.Windows.Forms.Button();
            this.bttnReporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            montoEstimadoLabel = new System.Windows.Forms.Label();
            zonaLabel = new System.Windows.Forms.Label();
            lblA = new System.Windows.Forms.Label();
            lblIdObra = new System.Windows.Forms.Label();
            lblNombreObra = new System.Windows.Forms.Label();
            this.grpBxFiltroRep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsObraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasOperadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // montoEstimadoLabel
            // 
            montoEstimadoLabel.AutoSize = true;
            montoEstimadoLabel.Location = new System.Drawing.Point(35, 99);
            montoEstimadoLabel.Name = "montoEstimadoLabel";
            montoEstimadoLabel.Size = new System.Drawing.Size(86, 13);
            montoEstimadoLabel.TabIndex = 4;
            montoEstimadoLabel.Text = "Monto Estimado:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Location = new System.Drawing.Point(86, 125);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new System.Drawing.Size(35, 13);
            zonaLabel.TabIndex = 6;
            zonaLabel.Text = "Zona:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new System.Drawing.Point(201, 99);
            lblA.Name = "lblA";
            lblA.Size = new System.Drawing.Size(17, 13);
            lblA.TabIndex = 8;
            lblA.Text = "A:";
            // 
            // lblIdObra
            // 
            lblIdObra.AutoSize = true;
            lblIdObra.Location = new System.Drawing.Point(35, 45);
            lblIdObra.Name = "lblIdObra";
            lblIdObra.Size = new System.Drawing.Size(63, 13);
            lblIdObra.TabIndex = 9;
            lblIdObra.Text = "Id Vivienda:";
            // 
            // lblNombreObra
            // 
            lblNombreObra.AutoSize = true;
            lblNombreObra.Location = new System.Drawing.Point(29, 71);
            lblNombreObra.Name = "lblNombreObra";
            lblNombreObra.Size = new System.Drawing.Size(91, 13);
            lblNombreObra.TabIndex = 12;
            lblNombreObra.Text = "Nombre Vivienda:";
            // 
            // grpBxFiltroRep
            // 
            this.grpBxFiltroRep.Controls.Add(this.btnBusca);
            this.grpBxFiltroRep.Controls.Add(lblNombreObra);
            this.grpBxFiltroRep.Controls.Add(this.txtBxNombreObra);
            this.grpBxFiltroRep.Controls.Add(this.txtBxIdObra);
            this.grpBxFiltroRep.Controls.Add(lblIdObra);
            this.grpBxFiltroRep.Controls.Add(lblA);
            this.grpBxFiltroRep.Controls.Add(this.clsListasOperadorComboBox);
            this.grpBxFiltroRep.Controls.Add(this.clsListasZonaComboBox);
            this.grpBxFiltroRep.Controls.Add(zonaLabel);
            this.grpBxFiltroRep.Controls.Add(montoEstimadoLabel);
            this.grpBxFiltroRep.Controls.Add(this.montoEstimadoTextBox);
            this.grpBxFiltroRep.Location = new System.Drawing.Point(12, 3);
            this.grpBxFiltroRep.Name = "grpBxFiltroRep";
            this.grpBxFiltroRep.Size = new System.Drawing.Size(687, 206);
            this.grpBxFiltroRep.TabIndex = 0;
            this.grpBxFiltroRep.TabStop = false;
            this.grpBxFiltroRep.Text = "Filtros del Reporte";
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::SISCOC_FEL.Properties.Resources.icons7129_mod1;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Location = new System.Drawing.Point(251, 26);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(91, 36);
            this.btnBusca.TabIndex = 13;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtBxNombreObra
            // 
            this.txtBxNombreObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "NombreObra", true));
            this.txtBxNombreObra.Location = new System.Drawing.Point(127, 68);
            this.txtBxNombreObra.MaxLength = 21;
            this.txtBxNombreObra.Name = "txtBxNombreObra";
            this.txtBxNombreObra.ReadOnly = true;
            this.txtBxNombreObra.Size = new System.Drawing.Size(376, 20);
            this.txtBxNombreObra.TabIndex = 11;
            // 
            // clsObraBindingSource
            // 
            this.clsObraBindingSource.DataSource = typeof(SISCOC_BL.ClsObra);
            // 
            // txtBxIdObra
            // 
            this.txtBxIdObra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "IdObra", true));
            this.txtBxIdObra.Location = new System.Drawing.Point(127, 42);
            this.txtBxIdObra.MaxLength = 21;
            this.txtBxIdObra.Name = "txtBxIdObra";
            this.txtBxIdObra.ReadOnly = true;
            this.txtBxIdObra.Size = new System.Drawing.Size(118, 20);
            this.txtBxIdObra.TabIndex = 10;
            // 
            // clsListasOperadorComboBox
            // 
            this.clsListasOperadorComboBox.DataSource = this.clsListasOperadorBindingSource;
            this.clsListasOperadorComboBox.DisplayMember = "text";
            this.clsListasOperadorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clsListasOperadorComboBox.Location = new System.Drawing.Point(127, 96);
            this.clsListasOperadorComboBox.Name = "clsListasOperadorComboBox";
            this.clsListasOperadorComboBox.Size = new System.Drawing.Size(65, 21);
            this.clsListasOperadorComboBox.TabIndex = 7;
            this.clsListasOperadorComboBox.ValueMember = "value";
            // 
            // clsListasOperadorBindingSource
            // 
            this.clsListasOperadorBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // clsListasZonaComboBox
            // 
            this.clsListasZonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clsObraBindingSource, "Zona", true));
            this.clsListasZonaComboBox.DataSource = this.clsListasZonaBindingSource;
            this.clsListasZonaComboBox.DisplayMember = "text";
            this.clsListasZonaComboBox.Enabled = false;
            this.clsListasZonaComboBox.Location = new System.Drawing.Point(127, 122);
            this.clsListasZonaComboBox.Name = "clsListasZonaComboBox";
            this.clsListasZonaComboBox.Size = new System.Drawing.Size(118, 21);
            this.clsListasZonaComboBox.TabIndex = 7;
            this.clsListasZonaComboBox.ValueMember = "value";
            // 
            // clsListasZonaBindingSource
            // 
            this.clsListasZonaBindingSource.DataSource = typeof(SISCOC_BL.ClsListas);
            // 
            // montoEstimadoTextBox
            // 
            this.montoEstimadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clsObraBindingSource, "MontoEstimado", true));
            this.montoEstimadoTextBox.Enabled = false;
            this.montoEstimadoTextBox.Location = new System.Drawing.Point(242, 96);
            this.montoEstimadoTextBox.Name = "montoEstimadoTextBox";
            this.montoEstimadoTextBox.Size = new System.Drawing.Size(120, 20);
            this.montoEstimadoTextBox.TabIndex = 5;
            // 
            // bttnSalir
            // 
            this.bttnSalir.BackgroundImage = global::SISCOC_FEL.Properties.Resources.Switch_User;
            this.bttnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnSalir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalir.Location = new System.Drawing.Point(584, 271);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(115, 42);
            this.bttnSalir.TabIndex = 36;
            this.bttnSalir.Text = "Salir     ";
            this.bttnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // bttnReporte
            // 
            this.bttnReporte.BackgroundImage = global::SISCOC_FEL.Properties.Resources._49TXT_File;
            this.bttnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bttnReporte.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReporte.Location = new System.Drawing.Point(342, 271);
            this.bttnReporte.Name = "bttnReporte";
            this.bttnReporte.Size = new System.Drawing.Size(115, 42);
            this.bttnReporte.TabIndex = 35;
            this.bttnReporte.Text = "Reporte";
            this.bttnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnReporte.UseVisualStyleBackColor = true;
            this.bttnReporte.Click += new System.EventHandler(this.bttnReporte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::SISCOC_FEL.Properties.Resources.Copiar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(463, 271);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 42);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 324);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(this.bttnReporte);
            this.Controls.Add(this.grpBxFiltroRep);
            this.Name = "FrmReporteCliente";
            this.Text = "FrmReporteCliente";
            this.Load += new System.EventHandler(this.FrmReporteCliente_Load);
            this.grpBxFiltroRep.ResumeLayout(false);
            this.grpBxFiltroRep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsObraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasOperadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsListasZonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxFiltroRep;
        private System.Windows.Forms.Button bttnSalir;
        private System.Windows.Forms.Button bttnReporte;
        private System.Windows.Forms.BindingSource clsObraBindingSource;
        private System.Windows.Forms.TextBox montoEstimadoTextBox;
        private System.Windows.Forms.BindingSource clsListasZonaBindingSource;
        private System.Windows.Forms.ComboBox clsListasZonaComboBox;
        private System.Windows.Forms.ComboBox clsListasOperadorComboBox;
        private System.Windows.Forms.BindingSource clsListasOperadorBindingSource;
        private System.Windows.Forms.TextBox txtBxNombreObra;
        private System.Windows.Forms.TextBox txtBxIdObra;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnCancelar;
    }
}