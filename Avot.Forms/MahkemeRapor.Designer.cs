namespace Avot.Forms
{
    partial class MahkemeRapor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MahkemeRapor));
            this.MahkemeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MahkemeReport = new Avot.Forms.MahkemeReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MahkemeTableAdapter = new Avot.Forms.MahkemeReportTableAdapters.MahkemeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MahkemeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MahkemeReport)).BeginInit();
            this.SuspendLayout();
            // 
            // MahkemeBindingSource
            // 
            this.MahkemeBindingSource.DataMember = "Mahkeme";
            this.MahkemeBindingSource.DataSource = this.MahkemeReport;
            // 
            // MahkemeReport
            // 
            this.MahkemeReport.DataSetName = "MahkemeReport";
            this.MahkemeReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MahkemeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Avot.Forms.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // MahkemeTableAdapter
            // 
            this.MahkemeTableAdapter.ClearBeforeFill = true;
            // 
            // MahkemeRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 594);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MahkemeRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahkeme Rapor Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MahkemeRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MahkemeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MahkemeReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MahkemeBindingSource;
        private MahkemeReport MahkemeReport;
        private MahkemeReportTableAdapters.MahkemeTableAdapter MahkemeTableAdapter;

    }
}