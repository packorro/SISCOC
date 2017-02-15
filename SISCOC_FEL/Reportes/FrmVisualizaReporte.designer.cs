namespace SISCOC_FEL
{
    partial class FrmVisualizaReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.arvMainViwer = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.SuspendLayout();
            // 
            // arvMainViwer
            // 
            this.arvMainViwer.BackColor = System.Drawing.SystemColors.Control;
            this.arvMainViwer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arvMainViwer.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            this.arvMainViwer.Location = new System.Drawing.Point(0, 0);
            this.arvMainViwer.Name = "arvMainViwer";
            this.arvMainViwer.ReportViewer.CurrentPage = 0;
            this.arvMainViwer.ReportViewer.MultiplePageCols = 3;
            this.arvMainViwer.ReportViewer.MultiplePageRows = 2;
            this.arvMainViwer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
            this.arvMainViwer.Size = new System.Drawing.Size(766, 383);
            this.arvMainViwer.TabIndex = 0;
            this.arvMainViwer.TableOfContents.Text = "Table Of Contents";
            this.arvMainViwer.TableOfContents.Width = 200;
            this.arvMainViwer.TabTitleLength = 35;
            this.arvMainViwer.Toolbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arvMainViwer.Load += new System.EventHandler(this.viewer1_Load);
            this.arvMainViwer.ToolClick += new DataDynamics.ActiveReports.Toolbar.ToolClickEventHandler(this.arvMainViwer_ToolClick);
            // 
            // FrmVisualizaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 383);
            this.Controls.Add(this.arvMainViwer);
            this.Name = "FrmVisualizaReporte";
            this.Text = "FrmVisualizaReporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisualizaReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DataDynamics.ActiveReports.Viewer.Viewer arvMainViwer;



    }
}