using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using DataDynamics.ActiveReports.Viewer;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SISCOC_BL;


namespace SISCOC_FEL
{
    public partial class FrmVisualizaReporte : Form
    {
        #region Listas&Variables        
            int? Reporte = null;
            
            //Reporte de Obra Cliente
            public DataTable TablaReporteObraCte;
            public DataTable TablaReporteObraArti;

            public string Fecha;
            public string Empresa;
            public string RFC;
            public string Domicilio;
            public string ReporteDesc;
            public string Condiciones;
            
        #endregion

        public FrmVisualizaReporte(int _Reporte)
        {
            InitializeComponent();
            InitializeViewReport();
            Reporte = _Reporte;

        }

        private void FrmVisualizaReporte_Load(object sender, EventArgs e)
        {

            switch (Reporte)
            {
                case 1: 
                    {
                        this.Cursor = Cursors.WaitCursor;
                        Reportes.AReporteCliente RptObraCte = new SISCOC_FEL.Reportes.AReporteCliente();
                        
                        RptObraCte.DataSource = TablaReporteObraCte;
                        
                        RptObraCte.Fecha = Fecha;
                        RptObraCte.Fecha = Fecha;
                        RptObraCte.Empresa = Empresa;
                        RptObraCte.RFC = RFC;
                        RptObraCte.Domicilio = Domicilio;
                        RptObraCte.ReporteDesc = ReporteDesc;
                        RptObraCte.Condiciones = Condiciones;

                        
                        RptObraCte.Run(false);                        

                        this.arvMainViwer.Document = RptObraCte.Document;                        
                        this.Cursor = Cursors.Default;
                        
                        break;
                    }

                case 2:
                    {
                        
                        this.Cursor = Cursors.WaitCursor;
                        RepObra RptObraAri = new RepObra();

                        RptObraAri.DataSource = TablaReporteObraArti;
                        RptObraAri.Empresa = Empresa;
                        RptObraAri.RFC = RFC;
                        RptObraAri.Domicilio = Domicilio;
                        RptObraAri.ReporteDesc = ReporteDesc;
                        RptObraAri.Condiciones = Condiciones;

                        RptObraAri.Run(false);
                        this.arvMainViwer.Document = RptObraAri.Document;
                        this.Cursor = Cursors.Default;   

                        break;
                    }

                case 3:
                    {
                        //this.Cursor = Cursors.WaitCursor;
                        //Reportes.ActiveRepFormaIS_Rex RptFormaISREX = new CMIN0213.Reportes.ActiveRepFormaIS_Rex();
                        ////Reportes.ARepFormaIS_AA RptFormaISAA = new CMIN0213.Reportes.ARepFormaIS_AA();

                        //RptFormaISREX.DataSource = TablaRepExistenciaFinal;

                        //RptFormaISREX.Fecha = Fecha;
                        //RptFormaISREX.Empresa = Empresa;
                        //RptFormaISREX.RFC = RFC;
                        //RptFormaISREX.NoOficio = NoOficio;
                        //RptFormaISREX.Domicilio = Domicilio;
                        //RptFormaISREX.ReporteDesc = ReporteDesc;
                        //RptFormaISREX.Condiciones = Condiciones;
                        //RptFormaISREX.Articulos = Articulos;
                        //RptFormaISREX.Gerente = Gerente;
                        //RptFormaISREX.CodIdentificacion = CodIdentificacion;
                        //RptFormaISREX.Run(false);

                        //this.arvMainViwer.Document = RptFormaISREX.Document;
                        //this.Cursor = Cursors.Default;

                        break;
                    }
            }                               
                            
        }

        private void viewer1_Load(object sender, EventArgs e)
        {           
           
        }

        public void InitializeViewReport()
        {

            this.arvMainViwer.Toolbar.Tools.ToolById(0).ToolTip = "Tabla de Contenidos";
            this.arvMainViwer.Toolbar.Tools.ToolById(2).ToolTip = "Imprimir";
            this.arvMainViwer.Toolbar.Tools.ToolById(4).ToolTip = "Copiar";
            this.arvMainViwer.Toolbar.Tools.ToolById(6).ToolTip = "Buscar";
            this.arvMainViwer.Toolbar.Tools.ToolById(8).ToolTip = "Vista en Página Sencilla";
            this.arvMainViwer.Toolbar.Tools.ToolById(9).ToolTip = "Vista en Multiples Paginas";
            this.arvMainViwer.Toolbar.Tools.ToolById(21).ToolTip = "Scroll Continuo";
            this.arvMainViwer.Toolbar.Tools.ToolById(11).ToolTip = "Alejar";
            this.arvMainViwer.Toolbar.Tools.ToolById(12).ToolTip = "Acercar";
            this.arvMainViwer.Toolbar.Tools.ToolById(13).ToolTip = "% de Acercamiento";
            this.arvMainViwer.Toolbar.Tools.ToolById(15).ToolTip = "Pagina Anterior";
            this.arvMainViwer.Toolbar.Tools.ToolById(16).ToolTip = "Pagina Siguiente";
            this.arvMainViwer.Toolbar.Tools.ToolById(17).ToolTip = "Pagina Actual";
            this.arvMainViwer.Toolbar.Tools.ToolById(19).ToolTip = "Retroceder";
            this.arvMainViwer.Toolbar.Tools.ToolById(20).ToolTip = "Avanzar";
            this.arvMainViwer.Toolbar.Tools.ToolById(19).Caption = "Retroceder";
            this.arvMainViwer.Toolbar.Tools.ToolById(20).Caption = "Avanzar";
            this.arvMainViwer.Toolbar.Tools.ToolById(22).ToolTip = "Anotaciones";
            this.arvMainViwer.Toolbar.Tools.ToolById(2).Caption = "&Imprimir";
            DataDynamics.ActiveReports.Toolbar.Button Btn = new DataDynamics.ActiveReports.Toolbar.Button();
            Btn.Caption = "&Exportar Reporte";
            Btn.ToolTip = "Exportar Reporte";
            Btn.Id = 25;
            this.arvMainViwer.Toolbar.Tools.Add(Btn);
        }

        private void arvMainViwer_ToolClick(object sender, DataDynamics.ActiveReports.Toolbar.ToolClickEventArgs e)
        {
            if (e.Tool.Id == 25)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                Object RutaDir = Convert.ToString(Environment.CurrentDirectory);
                saveFileDialog.Filter = "Microsoft Excel (*.xls)|*.xls|Acrobat Reader (*.pdf)|*.pdf|Página Web (*.html)|*.htm";
                saveFileDialog.Title = "Exportar a archivo";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                        string Extfile = (saveFileDialog.FileName.Substring(saveFileDialog.FileName.Length - 3, 3));

                        switch (Extfile.ToUpper())
                        {
                            case "XLS":
                                DataDynamics.ActiveReports.Export.Xls.XlsExport MyEx = new DataDynamics.ActiveReports.Export.Xls.XlsExport();
                                MyEx.RemoveVerticalSpace = false;
                                MyEx.DisplayGridLines = true;
                                MyEx.UseCellMerging = false;
                                MyEx.AutoRowHeight = true;
                                MyEx.MinRowHeight = (float)0.1;
                                MyEx.MultiSheet = false;
                                MyEx.Export(this.arvMainViwer.Document, saveFileDialog.FileName);
                                MyEx.Dispose();
                                break;
                            case "PDF":
                                DataDynamics.ActiveReports.Export.Pdf.PdfExport MyPd = new DataDynamics.ActiveReports.Export.Pdf.PdfExport();
                                MyPd.Export(this.arvMainViwer.Document, saveFileDialog.FileName);
                                MyPd.Dispose();
                                break;
                            case "TML":
                                DataDynamics.ActiveReports.Export.Html.HtmlExport MyHtml = new DataDynamics.ActiveReports.Export.Html.HtmlExport();
                                MyHtml.Export(this.arvMainViwer.Document, saveFileDialog.FileName);
                                MyHtml.Dispose();
                                break;
                        }
                    }
                    catch (Exception Ex) { throw new Exception(Ex.Message, Ex.InnerException); }
                }
            }
        }

      

    }
}