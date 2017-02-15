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
//using DataDynamics.ActiveReports.Export;
//using DataDynamics.ActiveReports.Export.Pdf;
//using DataDynamics.ActiveReports.Export.Xls;
//using SISCOC_BL;
//using System.IO;
//using System.Data;

namespace SISCOC_FEL.Reportes
{
    /// <summary>
    /// Summary description for AReporteCliente.
    /// </summary>
    public partial class AReporteCliente : DataDynamics.ActiveReports.ActiveReport
    {

        #region Listas&Variables
            public DataTable TablaReporteObraCte;            

            public string Fecha;
            public string Empresa;
            public string RFC;        
            public string Domicilio;
            public string ReporteDesc;
            public string Condiciones;
        #endregion


        public AReporteCliente()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void AReporteCliente_ReportStart(object sender, EventArgs e)
        {
        }
            


        private void reportHeader1_Format(object sender, EventArgs e)
        {
            this.txtBxFecImpre.Text = Fecha;
            this.lblEmpresa.Text = Empresa;
            this.lblRFC.Text = RFC;            
            this.lblDomicilio.Text = Domicilio;
            this.lblReporte.Text = ReporteDesc;
            this.lblCondiciones.Text = Condiciones;            
        }
    }
}
