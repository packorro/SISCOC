using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SqlServerBackupRestore;
using SISCOC_DAL;  


namespace SISCOC_FEL
{
    public partial class FrmUtileria : Form
    {
        public FrmUtileria()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmUtileria_Load(object sender, EventArgs e)
        {
            cmbOpcion.SelectedIndex = 0;
        //public Data()
        //{
        //    this._ConnectionString = new ConnectionStrings();
        //    this.Connection = new SqlConnection();
        //}

           

        }

        private void btnDiag_Click(object sender, EventArgs e)
        {


            if (cmbOpcion.Text.Substring(0, 1).ToString() == "1")
            {

                //SaveFileDialog saveFileDialog = new SaveFileDialog();

                Object RutaDir = Convert.ToString(Environment.CurrentDirectory);
                SaveDialog.Filter = "ANJU (*.bak)|*.bak";
                SaveDialog.Title = "Respaldos";
                SaveDialog.ShowDialog();
                if (SaveDialog.FileName != "")
                {
                    try
                    {
                        string Extfile = (SaveDialog.FileName.Substring(SaveDialog.FileName.Length - 3, 3));

                        switch (Extfile.ToUpper())
                        {
                            case "BAK":
                                txtPhat.Text = SaveDialog.FileName.ToString();                        
                                btnRestaurar.Enabled = false;
                                btnRespaldar.Enabled = true;  
                                break;
                        }
                    }
                    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
                }
            }



            if (cmbOpcion.Text.Substring(0, 1).ToString() == "2")
            {

                //SaveFileDialog saveFileDialog = new SaveFileDialog();

                Object RutaDir = Convert.ToString(Environment.CurrentDirectory);
                OpenDialog.Filter = "ANJU (*.bak)|*.bak";
                OpenDialog.Title = "Respaldos";
                OpenDialog.ShowDialog();
                if (OpenDialog.FileName != "")
                {
                    try
                    {
                        string Extfile = (OpenDialog.FileName.Substring(OpenDialog.FileName.Length - 3, 3));

                        switch (Extfile.ToUpper())
                        {
                            case "BAK":
                                txtPhat.Text = OpenDialog.FileName.ToString();
                                btnRespaldar.Enabled = false;
                                btnRestaurar.Enabled = true;
                                break;
                        }
                    }
                    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
                }
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cmbOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhat.Text = "";
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            if (txtPhat.Text.Trim() == "")
            {
                MessageBox.Show("Falta información para realizar respaldo...", "MENSAJE DEL SISTEMA");
                return; 
            }
            else
            {
                String RUTA=txtPhat.Text.Trim();
                    SqlServerBackupRestore.BackupHelper Respaldo = new BackupHelper();
                    Respaldo.BackupDatabase("anju", "sa", "4159", "AYALA\\AYALA", RUTA);
                
                    //Respaldo.BackupDatabase("anju","sa","4159","ayala\\ayala",this.txtPhat.Text.Trim());
                    MessageBox.Show("La Base de Datos ha sido respaldada exitosamente !!!", "MENSAJE DEL SISTEMA");
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Data datos = new Data();
            datos.CloseConnection();

            Data dat = new Data();
            dat.CierraConexion(); 

            //string ru = "";
            //ru = "Data Source=pakosmil\\gamo;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=supervisor";

            //Data DataAccess = new Data(ru);
            //dsLoguin = DataAccess.ExecuteSPQueryDataSet(Parameters, "Sp_Select_UsuarioLogin");
            //DataAccess.CloseConnection();

            
            if (txtPhat.Text.Trim() == "")
            {
                MessageBox.Show("Falta información para realizar la restauración...", "MENSAJE DEL SISTEMA");
                return;
            }
            else
            {                
                string Ruta="";
                Ruta  ="C:\\Archivos de programa\\Microsoft SQL Server\\MSSQL.1\\MSSQL\\Data\\";

                SqlServerBackupRestore.RestoreHelper Restaura = new RestoreHelper();
                Restaura.RestoreDatabase("prueba1", this.txtPhat.Text.Trim(), "AYALA\\AYALA", "sa", "4159", Ruta, Ruta);
                MessageBox.Show("La Base de Datos ha sido restaurada exitosamente !!!", "MENSAJE DEL SISTEMA");
                MessageBox.Show("Debe iniciar nuevamente la sesion, para completar el proceso...","MENSAJE DEL SISTEMA");
                //buscar una forma de cerrar todas las ventanas abiertas nomas se cierra la actual
                //la pantalla principal se keda abierta...      
                
                Close();

            }
        }
    }
}