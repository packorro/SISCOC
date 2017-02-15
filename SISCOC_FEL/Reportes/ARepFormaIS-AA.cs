using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using DataDynamics.ActiveReports.Export.Pdf;
using DataDynamics.ActiveReports.Export.Xls;
using CMIN0213_BL;
using System.Data;

namespace CMIN0213.Reportes
{
    /// <summary>
    /// Summary description for ARepFormaIS_AA.
    /// </summary>
    public partial class ARepFormaIS_AA : DataDynamics.ActiveReports.ActiveReport3
    {

        #region Listas&Variables
            ////public List<RepAuxMovCuentas> _ListRepAuxMovCuentas = null;
            ////public List<RepGeneraPoliza> _ListRepGeneraPoliza = null;
            //int? Reporte = null;

            public DataTable TablaReporteSalProductos;
            //public DataTable TablaReporteEntradas;
            //public DataTable TablaReporteSalidas;

            public string Fecha;
            public string Empresa;
            public string RFC;
            public string NoOficio;
            public string Domicilio;
            public string ReporteDesc;
            public string Condiciones;
            public string Articulos;

            public string Gerente;
            public string CodIdentificacion;
            //**subreportes
            //private Reportes.SubRepEntrada _SubRepEntrada = null;
            //private Reportes.SubRepSalida _SubRepSalida = null;

        #endregion


        public ARepFormaIS_AA()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void ARepFormaIS_AA_ReportStart(object sender, EventArgs e)
        {
        }

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            this.lblResponsable.Text = Gerente;
            this.lblCodIdSuc.Text = CodIdentificacion;
        }

        private void reportHeader1_Format(object sender, EventArgs e)
        {
            this.txtBxFecImpre.Text = Fecha;
            this.lblEmpresa.Text = Empresa;
            this.lblRFC.Text = RFC;
            this.lblNoOficio.Text = NoOficio;
            this.lblDomicilio.Text = Domicilio;
            this.lblReporte.Text = ReporteDesc;
            this.lblCondiciones.Text = Condiciones;
            //this.lblArticulos.Text = Articulos;
        }

        private void detail_Format(object sender, EventArgs e)
        {

        }
    }
}
