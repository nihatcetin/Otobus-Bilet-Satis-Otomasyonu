namespace OtubusBiletSatisOtomasyonu
{
    partial class Raporlama
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
            this.KayıtlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OtobusBiletDBDataSet = new OtubusBiletSatisOtomasyonu.OtobusBiletDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KayıtlarTableAdapter = new OtubusBiletSatisOtomasyonu.OtobusBiletDBDataSetTableAdapters.KayıtlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtobusBiletDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // KayıtlarBindingSource
            // 
            this.KayıtlarBindingSource.DataMember = "Kayıtlar";
            this.KayıtlarBindingSource.DataSource = this.OtobusBiletDBDataSet;
            // 
            // OtobusBiletDBDataSet
            // 
            this.OtobusBiletDBDataSet.DataSetName = "OtobusBiletDBDataSet";
            this.OtobusBiletDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KayıtlarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OtubusBiletSatisOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1532, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // KayıtlarTableAdapter
            // 
            this.KayıtlarTableAdapter.ClearBeforeFill = true;
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1532, 510);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raporlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.Raporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KayıtlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtobusBiletDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KayıtlarBindingSource;
        private OtobusBiletDBDataSet OtobusBiletDBDataSet;
        private OtobusBiletDBDataSetTableAdapters.KayıtlarTableAdapter KayıtlarTableAdapter;
    }
}