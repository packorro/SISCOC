using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SISCOC_BL; 

namespace SISCOC_FEL
{
    public partial class FrmFiltroObra : Form
    {
        public FrmFiltroObra()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblObra_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBusqueda Buscar = new FrmBusqueda(1,"O");
            Buscar.Show();
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            int Obra = 0;

         //if (dTPFinal.Value < dTPInicial.Value)
           // {

             //   MessageBox.Show("La fecha Final no puede ser menor a la fecha Inicial...", "MENSAJE DEL SISTEMA");
              //  return;
            //}

            if (this.textBox1.Text.Trim() == "")
            {
                Obra = 0;
            }
            else
            {
                     Obra = Convert.ToInt32( this.textBox1.Text   )  ;
            }


                this.Cursor = Cursors.WaitCursor;
                FrmVisualizaReporte ReporteObra = new FrmVisualizaReporte(2);

                ReporteObra.TablaReporteObraArti = ClsReportes.ListObraArti(dTPInicial.Value, dTPFinal.Value, Obra);

                if (ReporteObra.TablaReporteObraArti.Rows.Count <= 0)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("No hay informacion con los filtros seleccionados...", "MENSAJE DEL SISTEMA");
                    return;
                }

                string Filtro = "";
                ReporteObra.Empresa = "ANJU INMOBILIARIA";
                ReporteObra.RFC = "";
                ReporteObra.Domicilio = "CALLE TOLEDO # 910 ENTRE JIMENEZ Y ABASOLO, COL. JUAREZ, NAV., SON.";
                if (this.textBox1.Text.Trim() == "")
                {
                    Filtro = "TODAS";
                }
                else
                {
                    Filtro = this.textBox2.Text.Trim();
                }
                ReporteObra.ReporteDesc = "REPORTE DE ARTICULOS POR VIVIENDA: " + Filtro.Trim() + " ";
                ReporteObra.Condiciones = "DE LA FECHA: " + this.dTPInicial.Value.ToShortDateString() + " A " + this.dTPFinal.Value.ToShortDateString()   + " ";                
                ReporteObra.Show();
                this.Cursor = Cursors.Default;

            


            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";  
        }
    }
}