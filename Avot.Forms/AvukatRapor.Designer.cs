namespace Avot.Forms
{
    partial class AvukatRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvukatRapor));
            this.AvukatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AvukatReport = new Avot.Forms.AvukatReport();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AvukatTableAdapter = new Avot.Forms.AvukatReportTableAdapters.AvukatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AvukatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvukatReport)).BeginInit();
            this.SuspendLayout();
            // 
            // AvukatBindingSource
            // 
            this.AvukatBindingSource.DataMember = "Avukat";
            this.AvukatBindingSource.DataSource = this.AvukatReport;
            // 
            // AvukatReport
            // 
            this.AvukatReport.DataSetName = "AvukatReport";
            this.AvukatReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AvktReport";
            reportDataSource1.Value = this.AvukatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Avot.Forms.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(845, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // AvukatTableAdapter
            // 
            this.AvukatTableAdapter.ClearBeforeFill = true;
            // 
            // AvukatRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 594);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvukatRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avukat Rapor Ekranı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AvukatRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvukatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvukatReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AvukatBindingSource;
        private AvukatReport AvukatReport;
        private AvukatReportTableAdapters.AvukatTableAdapter AvukatTableAdapter;




    }
}