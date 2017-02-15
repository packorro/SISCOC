using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SISCOC_BL;
using System.Diagnostics;
using System.Reflection;
using System.Configuration;      

namespace SISCOC_FEL
{
    public partial class FrmTraspaso : Form
    {
        int Permiso;
        List<ClsTraspaso> LObra;
        List<ClsTraspaso> LArtObra;
        

        public FrmTraspaso(int _Permiso)
        {
            InitializeComponent();

            try
            {
                Permiso = _Permiso;
            }
            catch (Exception EX )
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void FrmTraspaso_Load(object sender, EventArgs e)
        {
            this.lblIdObraSel.Visible = false;
            this.lblIdObraSel.Text = "";
        }

        private void btnBusca1_Click(object sender, EventArgs e)
        {
            LObra = ClsTraspaso.BuscaObra(1,1,this.txtOrigen.Text.Trim());
            this.clsObraBindig.DataSource = LObra;  
            
        }

        private void gridOrigen_DoubleClickRow(object sender, Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs e)
        {
            string Ren;

            Ren = e.Row.Cells[7].Text;

            this.lblIdObraSel.Text = "";
            this.lblIdObraSel.Text = Ren;
            this.txtNO.Text = Ren;
            this.txtNomObra.Text = e.Row.Cells[8].Text;    

            LArtObra = ClsTraspaso.BuscaArticulo_Obra(1, 1, Convert.ToInt32(Ren),null);
            this.clsArt_Obra.DataSource = LArtObra;
                     

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow  Rn in gridArtOrigen2.Rows)
            {
                Rn.Cells[9].Value = false; 
            }

        }

        private void btnBusca2_Click(object sender, EventArgs e)
        {
            if (lblIdObraSel.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar una Vivienda para buscar sus articulos asociados...", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK);
                txtOrigen.Focus(); 
                return;              

            }
            
            LArtObra = ClsTraspaso.BuscaArticulo_Obra(2, 1, Convert.ToInt32(this.lblIdObraSel.Text), this.txtArtOrigen.Text.Trim());
            this.clsArt_Obra.DataSource = LArtObra;

            //foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in gridArtOrigen2.Rows)
            //{
            //    Rn.Cells[9].Value = false;
            //}

            LimpiaGrd(); 
      
        }

        private void gridOrigen_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LimpiaGrd();
            //Cierro la forma.
            this.Close(); 

        }

        public void LimpiaGrd()
        {

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in gridArtOrigen2.Rows)
            {
                Rn.Cells[9].Value = false;
                Rn.Cells[19].Value = 0; 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBusqueda Buscar = new FrmBusqueda(0, "T");
            Buscar.Show();            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtNO.Text.Trim() == "")
            {
                MessageBox.Show("Falta seleccionar Vivienda Origen", "MENSAJE DEL SISTEMA");
                return;             
            }           

            bool Flag=true;
            bool Flag2 = true; 
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in gridArtOrigen2.Rows)
            {
                if (Rn.Cells[9].Value.ToString().ToUpper() == "TRUE")
                {
                    Flag = false;
                    if (Rn.Cells[19].Value.ToString() != "" && Rn.Cells[19].Value.ToString() != "0")
                    {
                        Flag2 = false;                         
                    }
                }
            }

            if (Flag == true)
            {
                MessageBox.Show("Falta seleccionar almenos un articulo a Traspasar", "MENSAJE DEL SISTEMA");
                return;             
            }

            if (Flag2 == true)
            {
                MessageBox.Show("Selecciono un artículo a traspasar pero falto capturar la cantidad a traspasar, favor de revisar", "MENSAJE DEL SISTEMA");
                return;             
            }

            if (txtIdObraDest.Text.Trim() == "")
            {
                MessageBox.Show("Falta seleccionar Vivienda Destino", "MENSAJE DEL SISTEMA");
                return;
            }

            if (txtNO.Text.Trim() == txtIdObraDest.Text.Trim())
            {
                MessageBox.Show("No esta permitido el Traspaso entre viviendas IGUALES", "MENSAJE DEL SISTEMA");
                return;
            
            }

            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in this.gridArtOrigen2.Rows)
            {
                if (Rn.Cells[9].Value.ToString().ToUpper() == "TRUE")
                {
                    if (Convert.ToInt32(Rn.Cells[12].Value.ToString()) <  Convert.ToInt32(Rn.Cells[19].Value.ToString()))                        
                    {
                        MessageBox.Show("La Cantidada a traspasar es mayor a la disponible, favor de corregir", "MENSAJE DEL SISTEMA");
                        return;
                    }             
                }
            }

             DialogResult Result = MessageBox.Show("¿Seguro que Desea Realizar el Traspaso?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (Result == DialogResult.No)
             {
                 return;
             }


            ClsTraspaso Traspasos = new ClsTraspaso();

            //Inserto los Datos a la tabla de Traspasos
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in this.gridArtOrigen2.Rows)
            {
                if (Rn.Cells[9].Value.ToString().ToUpper() == "TRUE")
                {

                    Traspasos.IdObraOrigen = Convert.ToInt32(lblIdObraSel.Text.Trim());
                    Traspasos.IdObraDestino = Convert.ToInt32(txtIdObraDest.Text.Trim());
                    Traspasos.IdArticulo = Convert.ToInt32(Rn.Cells[10].Value.ToString());
                    Traspasos.CantidadArtTrasp = Convert.ToDouble(Rn.Cells[19].Value.ToString());
                                        
                    ClsTraspaso.AddTraspaso(Traspasos,0);
                }
            }

            //Inserto los Datos de la Obra.
            Traspasos.IdObraDestino = Convert.ToInt32(this.txtIdObraDest.Text.Trim());
            //ClsTraspaso.AddTraspaso(Traspasos, 1);

            int Contador = 0;
            int IdArticuloObra = 0;
            int Opcion = 0;     

            //Busco la obra
            DataSet Datos = ClsTraspaso.BuscaObra(Convert.ToInt32(txtIdObraDest.Text.Trim()), 1);
            if (Datos.Tables[0].Rows.Count != 0)
            {
                //Permiso = Convert.ToInt16(LoguinUsuario.Tables[0].Rows[i]["TipoUsuario"].ToString());     
                foreach (DataRow Rn in Datos.Tables[0].Rows)
                {
                    Contador = Convert.ToInt32(Rn["Contador"].ToString());
                    IdArticuloObra = Convert.ToInt32(Rn["IdArticuloObra"].ToString());
                }
            }

            if (Contador == 0)
            {
                Opcion = 2;
            }
            else if( Contador >= 0)
            {
                Opcion = 3;
            }

            //Inserto los Articulos de la Obra a Traspasar.
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in this.gridArtOrigen2.Rows)
            {
                if (Rn.Cells[9].Value.ToString().ToUpper() == "TRUE")
                {
                    Traspasos.IdObraDestino = Convert.ToInt32(txtIdObraDest.Text.Trim());
                    Traspasos.IdArticulo = Convert.ToInt32(Rn.Cells[10].Value.ToString());
                    Traspasos.CantidadArtTrasp = Convert.ToDouble(Rn.Cells[19].Value.ToString());
                    Traspasos.IdArtObra = IdArticuloObra;
                    ClsTraspaso.AddTraspaso(Traspasos, Opcion);
                }
            }



            double CantidadArt = 0;
            double CantidadAct = 0;
            double Total = 0;
            int Registro;

            //Actualizo la cantidad de los Articulos.
            foreach (Infragistics.Win.UltraWinGrid.UltraGridRow Rn in this.gridArtOrigen2.Rows)
            {
                if (Rn.Cells[9].Value.ToString().ToUpper() == "TRUE")
                {
                    DataSet Datos2 = ClsTraspaso.BuscaCantidad(Convert.ToInt32(lblIdObraSel.Text.Trim()), Convert.ToInt32(Rn.Cells[10].Value.ToString()), 4);                    
                    Total  = Convert.ToInt32(Rn.Cells[19].Value.ToString());
                    if (Datos2.Tables[0].Rows.Count != 0)
                    {
                        foreach (DataRow Rns in Datos2.Tables[0].Rows)
                        {
                            CantidadArt = Convert.ToDouble(Rns["CantidadArt"].ToString());
                            Registro = Convert.ToInt32(Rns["IdArtionbraD"].ToString());

                            if (CantidadArt > Total)
                            {
                                CantidadAct = CantidadArt - Total;
                                ClsTraspaso.ActualizoCantidad(Convert.ToInt32(lblIdObraSel.Text.Trim()), Convert.ToInt32(Rn.Cells[10].Value.ToString()),Registro, CantidadAct, 5);
                            }
                            else
                            {
                                ClsTraspaso.ActualizoCantidad(Convert.ToInt32(lblIdObraSel.Text.Trim()), Convert.ToInt32(Rn.Cells[10].Value.ToString()),Registro,  0, 5);
                                Total = Total - CantidadArt; 
                            }

                        }
                    }                   

                }
            }


            txtNO.Text = "";
            txtNomObra.Text = "";
            txtOrigen.Text = "";
            txtArtOrigen.Text = "";
            gridOrigen.DataBind();
            gridArtOrigen2.DataBind();
            txtIdObraDest.Text = "";
            txtObraDest.Text = "";
            LimpiaGrd();

            MessageBox.Show("Registro agregado Satisfactoriamente...", "I n f o r m a c i ó n", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
    }
}