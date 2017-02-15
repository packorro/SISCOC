namespace CMIN0213.Reportes
{
    /// <summary>
    /// Summary description for SubRepSalida.
    /// </summary>
    partial class SubRepSalida
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SubRepSalida));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtBxFecha = new DataDynamics.ActiveReports.TextBox();
            this.txtBxCantidadSalM3 = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.txtBxTotSal = new DataDynamics.ActiveReports.TextBox();
            this.lblTotSal = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxCantidadSalM3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxTotSal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotSal)).BeginInit();
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
            this.txtBxFecha,
            this.txtBxCantidadSalM3});
            this.detail.Height = 0.1875F;
            this.detail.Name = "detail";
            // 
            // txtBxFecha
            // 
            this.txtBxFecha.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxFecha.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFecha.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxFecha.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFecha.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxFecha.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFecha.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxFecha.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxFecha.DataField = "FechaSal";
            this.txtBxFecha.Height = 0.1875F;
            this.txtBxFecha.Left = 0F;
            this.txtBxFecha.Name = "txtBxFecha";
            this.txtBxFecha.OutputFormat = resources.GetString("txtBxFecha.OutputFormat");
            this.txtBxFecha.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxFecha.Text = null;
            this.txtBxFecha.Top = 0F;
            this.txtBxFecha.Width = 0.75F;
            // 
            // txtBxCantidadSalM3
            // 
            this.txtBxCantidadSalM3.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxCantidadSalM3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadSalM3.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxCantidadSalM3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadSalM3.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxCantidadSalM3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadSalM3.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxCantidadSalM3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxCantidadSalM3.DataField = "CantidadSalM3";
            this.txtBxCantidadSalM3.Height = 0.1875F;
            this.txtBxCantidadSalM3.Left = 0.75F;
            this.txtBxCantidadSalM3.Name = "txtBxCantidadSalM3";
            this.txtBxCantidadSalM3.OutputFormat = resources.GetString("txtBxCantidadSalM3.OutputFormat");
            this.txtBxCantidadSalM3.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxCantidadSalM3.Text = null;
            this.txtBxCantidadSalM3.Top = 0F;
            this.txtBxCantidadSalM3.Width = 0.8125F;
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
            this.txtBxTotSal,
            this.lblTotSal});
            this.groupFooter1.Height = 0.1875F;
            this.groupFooter1.Name = "groupFooter1";
            // 
            // txtBxTotSal
            // 
            this.txtBxTotSal.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBxTotSal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxTotSal.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBxTotSal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxTotSal.Border.RightColor = System.Drawing.Color.Black;
            this.txtBxTotSal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxTotSal.Border.TopColor = System.Drawing.Color.Black;
            this.txtBxTotSal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.txtBxTotSal.DataField = "CantidadSalM3";
            this.txtBxTotSal.Height = 0.1875F;
            this.txtBxTotSal.Left = 0.75F;
            this.txtBxTotSal.Name = "txtBxTotSal";
            this.txtBxTotSal.OutputFormat = resources.GetString("txtBxTotSal.OutputFormat");
            this.txtBxTotSal.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; ";
            this.txtBxTotSal.SummaryGroup = "groupHeader1";
            this.txtBxTotSal.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.txtBxTotSal.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.txtBxTotSal.Text = null;
            this.txtBxTotSal.Top = 0F;
            this.txtBxTotSal.Width = 0.8125F;
            // 
            // lblTotSal
            // 
            this.lblTotSal.Border.BottomColor = System.Drawing.Color.Black;
            this.lblTotSal.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotSal.Border.LeftColor = System.Drawing.Color.Black;
            this.lblTotSal.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotSal.Border.RightColor = System.Drawing.Color.Black;
            this.lblTotSal.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotSal.Border.TopColor = System.Drawing.Color.Black;
            this.lblTotSal.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTotSal.Height = 0.1875F;
            this.lblTotSal.HyperLink = null;
            this.lblTotSal.Left = 0F;
            this.lblTotSal.Name = "lblTotSal";
            this.lblTotSal.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
            this.lblTotSal.Text = "TotSalida";
            this.lblTotSal.Top = 0F;
            this.lblTotSal.Width = 0.6875F;
            // 
            // SubRepSalida
            // 
            this.MasterReport = false;
            this.PageSettings.PaperHeight = 11F;
            this.PageSettings.PaperWidth = 8.5F;
            this.PrintWidth = 1.577446F;
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
            this.ReportStart += new System.EventHandler(this.SubRepSalida_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.txtBxFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxCantidadSalM3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBxTotSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.TextBox txtBxFecha;
        private DataDynamics.ActiveReports.TextBox txtBxCantidadSalM3;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox txtBxTotSal;
        private DataDynamics.ActiveReports.Label lblTotSal;
    }
}
