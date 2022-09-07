namespace Universidad.Presentaciones
{
    partial class FrmReporteCarreras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsCarreras = new Universidad.dsCarreras();
            this.carrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasTableAdapter = new Universidad.dsCarrerasTableAdapters.carrerasTableAdapter();
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.btnmostrarfiltro = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsCarreras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.carrerasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Universidad.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsCarreras
            // 
            this.dsCarreras.DataSetName = "dsCarreras";
            this.dsCarreras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carrerasBindingSource
            // 
            this.carrerasBindingSource.DataMember = "carreras";
            this.carrerasBindingSource.DataSource = this.dsCarreras;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.Location = new System.Drawing.Point(41, 24);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(113, 26);
            this.btnmostrartodo.TabIndex = 1;
            this.btnmostrartodo.Text = "Mostrar todo";
            this.btnmostrartodo.UseVisualStyleBackColor = true;
            this.btnmostrartodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmostrarfiltro
            // 
            this.btnmostrarfiltro.Location = new System.Drawing.Point(690, 19);
            this.btnmostrarfiltro.Name = "btnmostrarfiltro";
            this.btnmostrarfiltro.Size = new System.Drawing.Size(98, 37);
            this.btnmostrarfiltro.TabIndex = 2;
            this.btnmostrarfiltro.Text = "Mostrar con Filtro";
            this.btnmostrarfiltro.UseVisualStyleBackColor = true;
            this.btnmostrarfiltro.Click += new System.EventHandler(this.btnmostrarfiltro_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(568, 36);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(100, 20);
            this.txtfiltro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(565, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carrera:";
            // 
            // FrmReporteCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.btnmostrarfiltro);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCarreras";
            this.Text = "FrmReporteCarreras";
            this.Load += new System.EventHandler(this.FrmReporteCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCarreras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsCarreras dsCarreras;
        private System.Windows.Forms.BindingSource carrerasBindingSource;
        private dsCarrerasTableAdapters.carrerasTableAdapter carrerasTableAdapter;
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.Button btnmostrarfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label label1;
    }
}