namespace softchape
{
    partial class InfReciboLimpieza
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.InfClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_informes = new softchape.ds_informes();
            this.InfServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfTdetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InfClienteTableAdapter = new softchape.ds_informesTableAdapters.InfClienteTableAdapter();
            this.InfServicioTableAdapter = new softchape.ds_informesTableAdapters.InfServicioTableAdapter();
            this.InfTdetalleTableAdapter = new softchape.ds_informesTableAdapters.InfTdetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InfClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_informes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfTdetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InfClienteBindingSource
            // 
            this.InfClienteBindingSource.DataMember = "InfCliente";
            this.InfClienteBindingSource.DataSource = this.ds_informes;
            // 
            // ds_informes
            // 
            this.ds_informes.DataSetName = "ds_informes";
            this.ds_informes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfServicioBindingSource
            // 
            this.InfServicioBindingSource.DataMember = "InfServicio";
            this.InfServicioBindingSource.DataSource = this.ds_informes;
            // 
            // InfTdetalleBindingSource
            // 
            this.InfTdetalleBindingSource.DataMember = "InfTdetalle";
            this.InfTdetalleBindingSource.DataSource = this.ds_informes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsCliente";
            reportDataSource1.Value = this.InfClienteBindingSource;
            reportDataSource2.Name = "DsLimpieza";
            reportDataSource2.Value = this.InfServicioBindingSource;
            reportDataSource3.Name = "DsDetalle";
            reportDataSource3.Value = this.InfTdetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "softchape.InfReciboLimpieza.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(773, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // InfClienteTableAdapter
            // 
            this.InfClienteTableAdapter.ClearBeforeFill = true;
            // 
            // InfServicioTableAdapter
            // 
            this.InfServicioTableAdapter.ClearBeforeFill = true;
            // 
            // InfTdetalleTableAdapter
            // 
            this.InfTdetalleTableAdapter.ClearBeforeFill = true;
            // 
            // InfReciboLimpieza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 503);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfReciboLimpieza";
            this.Load += new System.EventHandler(this.InfReciboLimpieza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_informes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfTdetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InfClienteBindingSource;
        private ds_informes ds_informes;
        private System.Windows.Forms.BindingSource InfServicioBindingSource;
        private System.Windows.Forms.BindingSource InfTdetalleBindingSource;
        private ds_informesTableAdapters.InfClienteTableAdapter InfClienteTableAdapter;
        private ds_informesTableAdapters.InfServicioTableAdapter InfServicioTableAdapter;
        private ds_informesTableAdapters.InfTdetalleTableAdapter InfTdetalleTableAdapter;
    }
}