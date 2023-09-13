namespace CFria_HorasExtra
{
    partial class FrmReporteAnual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteAnual));
            this.RVAnual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dSAnual = new CFria_HorasExtra.DSAnual();
            this.dataTableAnualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAnualTableAdapter1 = new CFria_HorasExtra.DSAnualTableAdapters.DataTableAnualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVAnual
            // 
            this.RVAnual.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableAnualBindingSource;
            this.RVAnual.LocalReport.DataSources.Add(reportDataSource1);
            this.RVAnual.LocalReport.ReportEmbeddedResource = "CFria_HorasExtra.RAnual.rdlc";
            this.RVAnual.Location = new System.Drawing.Point(0, 51);
            this.RVAnual.Name = "RVAnual";
            this.RVAnual.ServerReport.BearerToken = null;
            this.RVAnual.Size = new System.Drawing.Size(800, 399);
            this.RVAnual.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CFria_HorasExtra.Properties.Resources.regreso;
            this.pictureBox2.Location = new System.Drawing.Point(752, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(414, 6);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(106, 39);
            this.btnIngresar.TabIndex = 38;
            this.btnIngresar.Text = "Buscar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(286, 12);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 29);
            this.txtYear.TabIndex = 37;
            // 
            // dSAnual
            // 
            this.dSAnual.DataSetName = "DSAnual";
            this.dSAnual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableAnualBindingSource
            // 
            this.dataTableAnualBindingSource.DataMember = "DataTableAnual";
            this.dataTableAnualBindingSource.DataSource = this.dSAnual;
            // 
            // dataTableAnualTableAdapter1
            // 
            this.dataTableAnualTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmReporteAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.RVAnual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteAnual";
            this.Text = "FrmReporteAnual";
            this.Load += new System.EventHandler(this.FrmReporteAnual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVAnual;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.BindingSource dataTableAnualBindingSource;
        private DSAnual dSAnual;
        private DSAnualTableAdapters.DataTableAnualTableAdapter dataTableAnualTableAdapter1;
    }
}