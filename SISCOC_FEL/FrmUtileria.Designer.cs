namespace SISCOC_FEL
{
    partial class FrmUtileria
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRutaRespRest = new System.Windows.Forms.Label();
            this.txtPhat = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnRespaldar = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDiag = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmbOpcion = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOpcion);
            this.groupBox1.Controls.Add(this.btnDiag);
            this.groupBox1.Controls.Add(this.txtPhat);
            this.groupBox1.Controls.Add(this.lblRutaRespRest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Respaldo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRutaRespRest
            // 
            this.lblRutaRespRest.AutoSize = true;
            this.lblRutaRespRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaRespRest.Location = new System.Drawing.Point(11, 74);
            this.lblRutaRespRest.Name = "lblRutaRespRest";
            this.lblRutaRespRest.Size = new System.Drawing.Size(187, 16);
            this.lblRutaRespRest.TabIndex = 0;
            this.lblRutaRespRest.Text = "Ruta y Nombre Respaldo:";
            // 
            // txtPhat
            // 
            this.txtPhat.Location = new System.Drawing.Point(203, 73);
            this.txtPhat.Name = "txtPhat";
            this.txtPhat.ReadOnly = true;
            this.txtPhat.Size = new System.Drawing.Size(454, 20);
            this.txtPhat.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::SISCOC_FEL.Properties.Resources.Switch_User;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(629, 176);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 49);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackgroundImage = global::SISCOC_FEL.Properties.Resources.icons7012_;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestaurar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(508, 176);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(115, 49);
            this.btnRestaurar.TabIndex = 50;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.BackgroundImage = global::SISCOC_FEL.Properties.Resources.icons7015_;
            this.btnRespaldar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRespaldar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldar.Location = new System.Drawing.Point(387, 176);
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.Size = new System.Drawing.Size(115, 49);
            this.btnRespaldar.TabIndex = 49;
            this.btnRespaldar.Text = "Respaldar";
            this.btnRespaldar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRespaldar.UseVisualStyleBackColor = true;
            this.btnRespaldar.Click += new System.EventHandler(this.btnRespaldar_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            // 
            // btnDiag
            // 
            this.btnDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiag.Location = new System.Drawing.Point(663, 69);
            this.btnDiag.Name = "btnDiag";
            this.btnDiag.Size = new System.Drawing.Size(34, 26);
            this.btnDiag.TabIndex = 2;
            this.btnDiag.Text = "...";
            this.btnDiag.UseVisualStyleBackColor = true;
            this.btnDiag.Click += new System.EventHandler(this.btnDiag_Click);
            // 
            // cmbOpcion
            // 
            this.cmbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcion.FormattingEnabled = true;
            this.cmbOpcion.Items.AddRange(new object[] {
            "1 - RESPALDAR",
            "2 - RESTAURAR"});
            this.cmbOpcion.Location = new System.Drawing.Point(203, 33);
            this.cmbOpcion.Name = "cmbOpcion";
            this.cmbOpcion.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcion.TabIndex = 3;
            this.cmbOpcion.SelectedIndexChanged += new System.EventHandler(this.cmbOpcion_SelectedIndexChanged);
            // 
            // FrmUtileria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 251);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnRespaldar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUtileria";
            this.Text = "FrmUtileria";
            this.Load += new System.EventHandler(this.FrmUtileria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRutaRespRest;
        private System.Windows.Forms.TextBox txtPhat;
        private System.Windows.Forms.Button btnRespaldar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDiag;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.ComboBox cmbOpcion;
    }
}