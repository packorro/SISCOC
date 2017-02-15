namespace CMIN0213.Reportes
{
    /// <summary>
    /// Summary description for SubRepEntrada.
    /// </summary>
    partial class SubRepEntrada
    {
        private DataDynamics.ActiveReports.PageHeader pageHeader;
        private DataDynamics.ActiveReports.Detail detail;
        private DataDynamics.ActiveReports.PageFooter pageFooter;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SubRepEntrada));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtBxProveedor = new DataDynamics.ActiveReports.TextBox();
            this.txtBxFechaEnt = new DataDynamics.ActiveReports.TextBox();
            this.txtBxCantidadEntM3 = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.txtBxSumTotSal = new DataDynamics.ActiveReports.TextBox();
            this.lblTotalEnt = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxFechaEnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxCantidadEntM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxSumTotSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Height = 0F;
            this.pageHeader.Name = "pageHeader";
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtBxProveedor,
            this.txtBxFechaEnt,
            this.txtBxCantidadEntM3});
            this.detail.Height = 0.1770833F;
            this.detail.Name = "detail";
            // 
            // txtBxProveedor
            // 
            this.txtBxProveedor.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxProveedor.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxProveedor.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxProveedor.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxProveedor.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxProveedor.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxProveedor.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxProveedor.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxProveedor.DataField = "Proveedor";
            this.txtBxProveedor.Height = 0.1875F;
            this.txtBxProveedor.Left = 0F;
            this.txtBxProveedor.Name = "txtBxProveedor";
            this.txtBxProveedor.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxProveedor.Text = null;
            this.txtBxProveedor.Top = 0F;
            this.txtBxProveedor.Width = 3.8125F;
            // 
            // txtBxFechaEnt
            // 
            this.txtBxFechaEnt.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxFechaEnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFechaEnt.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxFechaEnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFechaEnt.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxFechaEnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFechaEnt.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxFechaEnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFechaEnt.DataField = "FechaEnt";
            this.txtBxFechaEnt.Height = 0.1875F;
            this.txtBxFechaEnt.Left = 3.8125F;
            this.txtBxFechaEnt.Name = "txtBxFechaEnt";
            this.txtBxFechaEnt.OutputFormat = resources.GetString("txtBxFechaEnt.OutputFormat");
            this.txtBxFechaEnt.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; vert" +
                "ical-align: middle; ";
            this.txtBxFechaEnt.Text = null;
            this.txtBxFechaEnt.Top = 0F;
            this.txtBxFechaEnt.Width = 0.8125F;
            // 
            // txtBxCantidadEntM3
            // 
            this.txtBxCantidadEntM3.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxCantidadEntM3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadEntM3.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxCantidadEntM3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadEntM3.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxCantidadEntM3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadEntM3.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxCantidadEntM3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadEntM3.DataField = "CantidadEntM3";
            this.txtBxCantidadEntM3.Height = 0.1875F;
            this.txtBxCantidadEntM3.Left = 4.625F;
            this.txtBxCantidadEntM3.Name = "txtBxCantidadEntM3";
            this.txtBxCantidadEntM3.OutputFormat = resources.GetString("txtBxCantidadEntM3.OutputFormat");
            this.txtBxCantidadEntM3.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxCantidadEntM3.Text = null;
            this.txtBxCantidadEntM3.Top = 0F;
            this.txtBxCantidadEntM3.Width = 0.8125F;
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // groupHeader1
            // 
            this.groupHeader1.Height = 0F;
            this.groupHeader1.Name = "groupHeader1";
            // 
            // groupFooter1
            // 
            this.groupFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtBxSumTotSal,
            this.lblTotalEnt});
            this.groupFooter1.Height = 0.1875F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // txtBxSumTotSal
            // 
            this.txtBxSumTotSal.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxSumTotSal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxSumTotSal.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxSumTotSal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxSumTotSal.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxSumTotSal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxSumTotSal.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxSumTotSal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxSumTotSal.DataField = "CantidadEntM3";
            this.txtBxSumTotSal.Height = 0.1875F;
            this.txtBxSumTotSal.Left = 4.625F;
            this.txtBxSumTotSal.Name = "txtBxSumTotSal";
            this.txtBxSumTotSal.OutputFormat = resources.GetString("txtBxSumTotSal.OutputFormat");
            this.txtBxSumTotSal.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxSumTotSal.SummaryGroup = "groupHeader1";
            this.txtBxSumTotSal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.txtBxSumTotSal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtBxSumTotSal.Text = null;
            this.txtBxSumTotSal.Top = 0F;
            this.txtBxSumTotSal.Width = 0.8125F;
            // 
            // lblTotalEnt
            // 
            this.lblTotalEnt.Border.BottomColor = System.Drawing.Color.Black;
            this.lblTotalEnt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotalEnt.Border.LeftColor = System.Drawing.Color.Black;
            this.lblTotalEnt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotalEnt.Border.RightColor = System.Drawing.Color.Black;
            this.lblTotalEnt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotalEnt.Border.TopColor = System.Drawing.Color.Black;
            this.lblTotalEnt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotalEnt.Height = 0.1875F;
            this.lblTotalEnt.HyperLink = null;
            this.lblTotalEnt.Left = 3.791667F;
            this.lblTotalEnt.Name = "lblTotalEnt";
            this.lblTotalEnt.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
            this.lblTotalEnt.Text = "TotEntrada";
            this.lblTotalEnt.Top = 0F;
            this.lblTotalEnt.Width = 0.8125F;
            // 
            // SubRepEntrada
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 5.447917F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.SubRepEntrada_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.txtBxProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxFechaEnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxCantidadEntM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxSumTotSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox txtBxProveedor;
        private DataDynamics.ActiveReports.TextBox txtBxFechaEnt;
        private DataDynamics.ActiveReports.TextBox txtBxCantidadEntM3;
        private DataDynamics.ActiveReports.TextBox txtBxSumTotSal;
        private DataDynamics.ActiveReports.Label lblTotalEnt;
    }
}
