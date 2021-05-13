namespace ShopDbBestVersion
{
    partial class ReportOtdeli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportOtdeli));
            this.OtdeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShopDS = new ShopDbBestVersion.ShopDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OtdeliTableAdapter = new ShopDbBestVersion.ShopDSTableAdapters.OtdeliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OtdeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDS)).BeginInit();
            this.SuspendLayout();
            // 
            // OtdeliBindingSource
            // 
            this.OtdeliBindingSource.DataMember = "Otdeli";
            this.OtdeliBindingSource.DataSource = this.ShopDS;
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
            reportDataSource1.Value = this.OtdeliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopDbBestVersion.Reports.ReportOtd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // OtdeliTableAdapter
            // 
            this.OtdeliTableAdapter.ClearBeforeFill = true;
            // 
            // ReportOtdeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportOtdeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по отделам";
            this.Load += new System.EventHandler(this.ReportOtdeli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OtdeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OtdeliBindingSource;
        private ShopDS ShopDS;
        private ShopDSTableAdapters.OtdeliTableAdapter OtdeliTableAdapter;
    }
}