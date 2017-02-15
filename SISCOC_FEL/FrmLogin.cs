using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SISCOC_BL;
using System.Configuration;
using System.Threading; 


namespace SISCOC_FEL
{
    public partial class FrmLogin : Form
    {
        public string usuario;
        public int Permiso;

        public FrmLogin()
        {
            InitializeComponent();

            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(1500);
            th.Abort();
            Thread.Sleep(500);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            usuarioTextBox.Focus();
        }

        private void usuarioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contraseñaTextBox.Focus();
                contraseñaTextBox.Select(0, contraseñaTextBox.Text.Length);
            }   
        }

        private void contraseñaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { btnAccesar_Click(sender, e); }   
        }

        private void btnAccesar_Click(object sender, EventArgs e)
        {
            if (usuarioTextBox.Text == "") { MessageBox.Show("Proporcione su Usuario ", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); usuarioTextBox.Focus(); return; }
            if (contraseñaTextBox.Text == "") { MessageBox.Show("Proporcione La Contraseña", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); contraseñaTextBox.Focus(); return; }

            try
            {
                DataSet LoguinUsuario = ClsLogin.LoguinUsuario(usuarioTextBox.Text.Trim(), contraseñaTextBox.Text.Trim());                
                if (LoguinUsuario.Tables[0].Rows.Count!=0)                
                {
                    //Para Sacar el Tipo de Usuario 1 Admin, 2 Normal, 3 Limitado
                    for (int i = 0; i < LoguinUsuario.Tables[0].Rows.Count; i++)
                    {
                        Permiso = Convert.ToInt16(LoguinUsuario.Tables[0].Rows[i]["TipoUsuario"].ToString());                   
                    }    
                    
                    usuario = Convert.ToString(this.usuarioTextBox.Text.Trim());
                    this.Close();                 
                }
                else
                {
                    MessageBox.Show("Usuario Y/O Contraseña Incorrecta");
                    usuarioTextBox.Text = "";
                    contraseñaTextBox.Text = "";
                    usuarioTextBox.Focus();
                }
            }
            catch (Exception Ex)
            { MessageBox.Show(Ex.Message); }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            this.usuarioTextBox.Text = "";
            this.contraseñaTextBox.Text = "";
            this.usuarioTextBox.Focus();  
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void FrmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            #region Next Control
                if (e.KeyCode == Keys.Enter)
                { SendKeys.Send("{TAB}"); }
            #endregion
        }

        private void DoSplash()
        {
            Splash sp = new Splash();
            sp.ShowDialog();
        }
      

    
    }
}