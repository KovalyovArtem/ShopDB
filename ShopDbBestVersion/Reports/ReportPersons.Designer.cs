namespace ShopDbBestVersion
{
    partial class ReportPersons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPersons));
            this.PersonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopDS = new ShopDbBestVersion.ShopDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PersonsTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.PersonsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDS)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonsBindingSource
            // 
            this.PersonsBindingSource.DataMember = "Persons";
            this.PersonsBindingSource.DataSource = this.ShopDS;
            // 
            // ShopDS
            // 
            this.ShopDS.DataSetName = "ShopDS";
            this.ShopDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopDbBestVersion.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1184, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // PersonsTableAdapter
            // 
            this.PersonsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт по сотрудникам";
            this.Load += new System.EventHandler(this.ReportPersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonsBindingSource;
        private ShopDS ShopDS;
        private ShopDSTableAdapters.PersonsTableAdapter PersonsTableAdapter;
    }
}