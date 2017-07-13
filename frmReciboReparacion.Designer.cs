namespace softchape
{
    partial class frmReciboReparacion
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ds_informes = new softchape.ds_informes();
            this.InfClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfClienteTableAdapter = new softchape.ds_informesTableAdapters.InfClienteTableAdapter();
            this.InfReparacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfReparacionTableAdapter = new softchape.ds_informesTableAdapters.InfReparacionTableAdapter();
            this.InfDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InfDetalleTableAdapter = new softchape.ds_informesTableAdapters.InfDetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds_informes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfReparacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsCliente";
            reportDataSource1.Value = this.InfClienteBindingSource;
            reportDataSource2.Name = "DsReparacion";
            reportDataSource2.Value = this.InfReparacionBindingSource;
            reportDataSource3.Name = "DsDetalle";
            reportDataSource3.Value = this.InfDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "softchape.InfReparacion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(843, 509);
            this.reportViewer1.TabIndex = 0;
            // 
            // ds_informes
            // 
            this.ds_informes.DataSetName = "ds_informes";
            this.ds_informes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InfClienteBindingSource
            // 
            this.InfClienteBindingSource.DataMember = "InfCliente";
            this.InfClienteBindingSource.DataSource = this.ds_informes;
            // 
            // InfClienteTableAdapter
            // 
            this.InfClienteTableAdapter.ClearBeforeFill = true;
            // 
            // InfReparacionBindingSource
            // 
            this.InfReparacionBindingSource.DataMember = "InfReparacion";
            this.InfReparacionBindingSource.DataSource = this.ds_informes;
            // 
            // InfReparacionTableAdapter
            // 
            this.InfReparacionTableAdapter.ClearBeforeFill = true;
            // 
            // InfDetalleBindingSource
            // 
            this.InfDetalleBindingSource.DataMember = "InfDetalle";
            this.InfDetalleBindingSource.DataSource = this.ds_informes;
            // 
            // InfDetalleTableAdapter
            // 
            this.InfDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // frmReciboReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 509);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReciboReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReciboReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds_informes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfReparacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InfClienteBindingSource;
        private ds_informes ds_informes;
        private System.Windows.Forms.BindingSource InfReparacionBindingSource;
        private System.Windows.Forms.BindingSource InfDetalleBindingSource;
        private ds_informesTableAdapters.InfClienteTableAdapter InfClienteTableAdapter;
        private ds_informesTableAdapters.InfReparacionTableAdapter InfReparacionTableAdapter;
        private ds_informesTableAdapters.InfDetalleTableAdapter InfDetalleTableAdapter;
    }
}