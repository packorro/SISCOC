using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using DataDynamics.ActiveReports.Export.Pdf;
using DataDynamics.ActiveReports.Export.Xls;
//using CMCA0105_BL;
using System.Data;


//using System;
//using System.Drawing;
//using System.Collections;
//using System.ComponentModel;
//using DataDynamics.ActiveReports;
//using DataDynamics.ActiveReports.Document;

namespace SISCOC_FEL
{
    /// <summary>
    /// Summary description for RepObra.
    /// </summary>
    public partial class RepObra : DataDynamics.ActiveReports.ActiveReport
    {


        public string Fecha;
        public string Empresa;
        public string RFC;
        public string Domicilio;
        public string ReporteDesc;
        public string Condiciones;

        public RepObra()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void RepObra_ReportStart(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd-MM-yyyy"); 
        }

        private void detail_Format(object sender, EventArgs e)
        {

        }

        private void reportHeader1_Format(object sender, EventArgs e)
        {
            //this.txtBxFecImpre.Text = Fecha;
            this.lblEmpresa.Text = Empresa;
            this.lblRFC.Text = RFC;
            this.lblDomicilio.Text = Domicilio;
            this.lblReporte.Text = ReporteDesc;
            this.lblCondiciones.Text = Condiciones;     
        }
    }
}
