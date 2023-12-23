namespace Presentacion
{
    partial class Frm_Reporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bD_Estudiantes_VSDataSetPCasita = new Presentacion.BD_Estudiantes_VSDataSetPCasita();
            this.estudianteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudianteTableAdapter = new Presentacion.BD_Estudiantes_VSDataSetPCasitaTableAdapters.EstudianteTableAdapter();
            this.estudianteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bD_Estudiantes_VSDataSetPCasita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estudianteBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Informe.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(888, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // bD_Estudiantes_VSDataSetPCasita
            // 
            this.bD_Estudiantes_VSDataSetPCasita.DataSetName = "BD_Estudiantes_VSDataSetPCasita";
            this.bD_Estudiantes_VSDataSetPCasita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudianteBindingSource
            // 
            this.estudianteBindingSource.DataMember = "Estudiante";
            this.estudianteBindingSource.DataSource = this.bD_Estudiantes_VSDataSetPCasita;
            // 
            // estudianteTableAdapter
            // 
            this.estudianteTableAdapter.ClearBeforeFill = true;
            // 
            // estudianteBindingSource1
            // 
            this.estudianteBindingSource1.DataMember = "Estudiante";
            this.estudianteBindingSource1.DataSource = this.bD_Estudiantes_VSDataSetPCasita;
            // 
            // Frm_Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Reporte";
            this.Text = "Frm_Reporte";
            this.Load += new System.EventHandler(this.Frm_Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_Estudiantes_VSDataSetPCasita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BD_Estudiantes_VSDataSetPCasita bD_Estudiantes_VSDataSetPCasita;
        private System.Windows.Forms.BindingSource estudianteBindingSource;
        private BD_Estudiantes_VSDataSetPCasitaTableAdapters.EstudianteTableAdapter estudianteTableAdapter;
        private System.Windows.Forms.BindingSource estudianteBindingSource1;
    }
}