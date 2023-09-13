namespace CFria_HorasExtra
{
    partial class FrmReporteMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteMensual));
            this.dataTableMensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSReporteM = new CFria_HorasExtra.DSReporteM();
            this.dTInformeMensualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RVMensual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableMensualTableAdapter = new CFria_HorasExtra.DSReporteMTableAdapters.DataTableMensualTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMensualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTInformeMensualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableMensualBindingSource
            // 
            this.dataTableMensualBindingSource.DataMember = "DataTableMensual";
            this.dataTableMensualBindingSource.DataSource = this.dSReporteM;
            // 
            // dSReporteM
            // 
            this.dSReporteM.DataSetName = "DSReporteM";
            this.dSReporteM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMes
            // 
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(380, 19);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 29);
            this.txtMes.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(525, 16);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(106, 39);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Buscar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // RVMensual
            // 
            this.RVMensual.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableMensualBindingSource;
            this.RVMensual.LocalReport.DataSources.Add(reportDataSource1);
            this.RVMensual.LocalReport.ReportEmbeddedResource = "CFria_HorasExtra.Report1.rdlc";
            this.RVMensual.Location = new System.Drawing.Point(0, 61);
            this.RVMensual.Name = "RVMensual";
            this.RVMensual.ServerReport.BearerToken = null;
            this.RVMensual.Size = new System.Drawing.Size(984, 389);
            this.RVMensual.TabIndex = 3;
            // 
            // dataTableMensualTableAdapter
            // 
            this.dataTableMensualTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CFria_HorasExtra.Properties.Resources.regreso;
            this.pictureBox2.Location = new System.Drawing.Point(936, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmReporteMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RVMensual);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtMes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReporteMensual";
            this.Text = "FrmReporteMensual";
            this.Load += new System.EventHandler(this.FrmReporteMensual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableMensualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTInformeMensualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.BindingSource dTInformeMensualBindingSource;
        private System.Windows.Forms.BindingSource dataSet11BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer RVMensual;
        private System.Windows.Forms.BindingSource dataTableMensualBindingSource;
        private DSReporteM dSReporteM;
        private DSReporteMTableAdapters.DataTableMensualTableAdapter dataTableMensualTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}