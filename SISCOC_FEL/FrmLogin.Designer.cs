namespace SISCOC_FEL
{
    partial class FrmLogin
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
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.bttnCancelar = new System.Windows.Forms.Button();
            this.btnAccesar = new System.Windows.Forms.Button();
            this.bttnSalir = new System.Windows.Forms.Button();
            contraseñaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.BackColor = System.Drawing.Color.YellowGreen;
            contraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.Location = new System.Drawing.Point(67, 144);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(75, 13);
            contraseñaLabel.TabIndex = 9;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.BackColor = System.Drawing.Color.YellowGreen;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(67, 113);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(54, 13);
            usuarioLabel.TabIndex = 8;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(148, 141);
            this.contraseñaTextBox.MaxLength = 15;
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.PasswordChar = '*';
            this.contraseñaTextBox.Size = new System.Drawing.Size(173, 20);
            this.contraseñaTextBox.TabIndex = 1;
            this.contraseñaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contraseñaTextBox_KeyDown);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(148, 110);
            this.usuarioTextBox.MaxLength = 20;
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(173, 20);
            this.usuarioTextBox.TabIndex = 0;
            this.usuarioTextBox.Text = "ADMIN";
            this.usuarioTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usuarioTextBox_KeyDown);
            // 
            // bttnCancelar
            // 
            this.bttnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancelar.Location = new System.Drawing.Point(148, 184);
            this.bttnCancelar.Name = "bttnCancelar";
            this.bttnCancelar.Size = new System.Drawing.Size(68, 23);
            this.bttnCancelar.TabIndex = 3;
            this.bttnCancelar.Text = "Cancelar";
            this.bttnCancelar.UseVisualStyleBackColor = true;
            this.bttnCancelar.Click += new System.EventHandler(this.bttnCancelar_Click);
            // 
            // btnAccesar
            // 
            this.btnAccesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesar.Location = new System.Drawing.Point(74, 184);
            this.btnAccesar.Name = "btnAccesar";
            this.btnAccesar.Size = new System.Drawing.Size(68, 23);
            this.btnAccesar.TabIndex = 2;
            this.btnAccesar.Text = "Accesar";
            this.btnAccesar.UseVisualStyleBackColor = true;
            this.btnAccesar.Click += new System.EventHandler(this.btnAccesar_Click);
            // 
            // bttnSalir
            // 
            this.bttnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSalir.Location = new System.Drawing.Point(222, 184);
            this.bttnSalir.Name = "bttnSalir";
            this.bttnSalir.Size = new System.Drawing.Size(68, 23);
            this.bttnSalir.TabIndex = 10;
            this.bttnSalir.Text = "Salir";
            this.bttnSalir.UseVisualStyleBackColor = true;
            this.bttnSalir.Click += new System.EventHandler(this.bttnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::SISCOC_FEL.Properties.Resources.LoginAnju;
            this.ClientSize = new System.Drawing.Size(367, 315);
            this.ControlBox = false;
            this.Controls.Add(this.bttnSalir);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.btnAccesar);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.bttnCancelar);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button bttnCancelar;
        private System.Windows.Forms.Button btnAccesar;
        private System.Windows.Forms.Button bttnSalir;
    }
}

