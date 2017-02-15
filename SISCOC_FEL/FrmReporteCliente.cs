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
    public partial class FrmReporteCliente : Form
    {
        #region Variables
            List<ClsObra> ListObras;
            List<ClsListas> ListZona;
            List<ClsListas> ListOperador;

            string  Operador;
            decimal Monto;
            int Zona;
            string Fecha;
        #endregion

        public FrmReporteCliente()
        {
            try
            {                
                InitializeComponent();

                ListZona = ClsListas.ListZona();
                clsListasZonaBindingSource.DataSource = ListZona;
                                
                //ListObras = ClsObra.ListObras();
                //clsObraBindingSource.DataSource = ListObras;

                ListOperador = ClsListas.ListOperadores();
                clsListasOperadorBindingSource.DataSource = ListOperador;

            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void bttnReporte_Click(object sender, EventArgs e)
        {

            if (this.txtBxNombreObra.Text.Trim() != "")
            {
                this.Cursor = Cursors.WaitCursor;
                FrmVisualizaReporte RepObraCte = new FrmVisualizaReporte(1);

                Operador = this.clsListasOperadorComboBox.Text;
                Monto = Convert.ToDecimal(this.montoEstimadoTextBox.Text);
                Zona = Convert.ToInt16(this.clsListasZonaComboBox.SelectedValue);

                //origen de datos 
                RepObraCte.TablaReporteObraCte = ClsReportes.ListObraCliente(Operador, Monto, Zona);

                Fecha = DateTime.Now.ToString("dd-MM-yyyy");

                RepObraCte.Fecha = Fecha;

                RepObraCte.Empresa = "ANJU INMOBILIARIA";
                RepObraCte.RFC = "";
                RepObraCte.Domicilio = "CALLE TOLEDO # 910 ENTRE JIMENEZ Y ABASOLO, COL. JUAREZ, NAV., SON.";
                RepObraCte.ReporteDesc = "REPORTE DE PROSPECTOS QUE COINCIDEN CON LA VIVIENDA: " + this.txtBxNombreObra.Text.Trim() + " ";
                RepObraCte.Condiciones = "CON MONTO  " + Operador + " AL  $  " + Monto.ToString("#,##0.000") + "  EN LA ZONA:  " + this.clsListasZonaComboBox.Text.Trim() + " ";

                RepObraCte.Show();
                this.Cursor = Cursors.Arrow;
            }
            else
            {
                MessageBox.Show("Debe de Seleccionar Una Vivienda Para poder ver los Prospectos que coincidan con los Parametros...", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {            
             Close();         
        }               

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscaObra BuscaObra = new FrmBuscaObra();                
                BuscaObra.ShowDialog();                

                ClsObra Obra = BuscaObra.BuscaObra;                
                if (BuscaObra.BuscaObra != null)                
                {
                    clsObraBindingSource.Add(Obra);
                    //rescatamos valores
                    Obra.IdObra = BuscaObra.BuscaObra.IdObra;                    
                    Obra.NombreObra = BuscaObra.BuscaObra.NombreObra;                    
                    Obra.MontoEstimado = BuscaObra.BuscaObra.MontoEstimado;
                    Obra.Zona = BuscaObra.BuscaObra.Zona;
                    clsObraBindingSource.ResetBindings(false);                    
                    BuscaObra.Dispose();                    
                    this.btnBusca.Focus();
                }
            }

            catch (Exception Ex) { MessageBox.Show(Ex.Message + " -- " + Ex.InnerException); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clsObraBindingSource.Clear();
        }
    }
}