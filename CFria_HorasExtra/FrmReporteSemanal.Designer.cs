namespace CFria_HorasExtra
{
    partial class FrmReporteSemanal
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
            this.dtpIncioSemana = new System.Windows.Forms.DateTimePicker();
            this.dtpFinalSemana = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.RVSemanal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSReporteSemanal = new CFria_HorasExtra.DSReporteSemanal();
            this.dataTableSemanalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableSemanalTableAdapter1 = new CFria_HorasExtra.DSReporteSemanalTableAdapters.DataTableSemanalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteSemanal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSemanalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpIncioSemana
            // 
            this.dtpIncioSemana.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIncioSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIncioSemana.Location = new System.Drawing.Point(55, 36);
            this.dtpIncioSemana.Name = "dtpIncioSemana";
            this.dtpIncioSemana.Size = new System.Drawing.Size(261, 24);
            this.dtpIncioSemana.TabIndex = 0;
            this.dtpIncioSemana.ValueChanged += new System.EventHandler(this.dtpIncioSemana_ValueChanged);
            // 
            // dtpFinalSemana
            // 
            this.dtpFinalSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinalSemana.Location = new System.Drawing.Point(341, 36);
            this.dtpFinalSemana.Name = "dtpFinalSemana";
            this.dtpFinalSemana.Size = new System.Drawing.Size(269, 24);
            this.dtpFinalSemana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio de semana:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cierre de semana:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(649, 21);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(106, 39);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Buscar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // RVSemanal
            // 
            this.RVSemanal.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableSemanalBindingSource;
            this.RVSemanal.LocalReport.DataSources.Add(reportDataSource1);
            this.RVSemanal.LocalReport.ReportEmbeddedResource = "CFria_HorasExtra.RSemanal.rdlc";
            this.RVSemanal.Location = new System.Drawing.Point(0, 80);
            this.RVSemanal.Name = "RVSemanal";
            this.RVSemanal.ServerReport.BearerToken = null;
            this.RVSemanal.Size = new System.Drawing.Size(984, 370);
            this.RVSemanal.TabIndex = 5;
            // 
            // dSReporteSemanal
            // 
            this.dSReporteSemanal.DataSetName = "DSReporteSemanal";
            this.dSReporteSemanal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableSemanalBindingSource
            // 
            this.dataTableSemanalBindingSource.DataMember = "DataTableSemanal";
            this.dataTableSemanalBindingSource.DataSource = this.dSReporteSemanal;
            // 
            // dataTableSemanalTableAdapter1
            // 
            this.dataTableSemanalTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReporteSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.RVSemanal);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFinalSemana);
            this.Controls.Add(this.dtpIncioSemana);
            this.Name = "FrmReporteSemanal";
            this.Text = "FrmReporteSemanal";
            this.Load += new System.EventHandler(this.FrmReporteSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSReporteSemanal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableSemanalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIncioSemana;
        private System.Windows.Forms.DateTimePicker dtpFinalSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIngresar;
        private Microsoft.Reporting.WinForms.ReportViewer RVSemanal;
        private System.Windows.Forms.BindingSource dataTableSemanalBindingSource;
        private DSReporteSemanal dSReporteSemanal;
        private DSReporteSemanalTableAdapters.DataTableSemanalTableAdapter dataTableSemanalTableAdapter1;
    }
}