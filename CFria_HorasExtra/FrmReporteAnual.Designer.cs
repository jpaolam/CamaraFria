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
            this.dataTableAnualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSAnual = new CFria_HorasExtra.DSAnual();
            this.RVAnual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dataTableAnualTableAdapter1 = new CFria_HorasExtra.DSAnualTableAdapters.DataTableAnualTableAdapter();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableAnualBindingSource
            // 
            this.dataTableAnualBindingSource.DataMember = "DataTableAnual";
            this.dataTableAnualBindingSource.DataSource = this.dSAnual;
            // 
            // dSAnual
            // 
            this.dSAnual.DataSetName = "DSAnual";
            this.dSAnual.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RVAnual
            // 
            this.RVAnual.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTableAnualBindingSource;
            this.RVAnual.LocalReport.DataSources.Add(reportDataSource1);
            this.RVAnual.LocalReport.ReportEmbeddedResource = "CFria_HorasExtra.RAnual.rdlc";
            this.RVAnual.Location = new System.Drawing.Point(0, 0);
            this.RVAnual.Name = "RVAnual";
            this.RVAnual.ServerReport.BearerToken = null;
            this.RVAnual.Size = new System.Drawing.Size(1277, 599);
            this.RVAnual.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CFria_HorasExtra.Properties.Resources.regreso;
            this.pictureBox2.Location = new System.Drawing.Point(1306, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 35);
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(212)))));
            this.btnIngresar.Location = new System.Drawing.Point(641, 35);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 32);
            this.btnIngresar.TabIndex = 38;
            this.btnIngresar.Text = "Buscar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dataTableAnualTableAdapter1
            // 
            this.dataTableAnualTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpYear
            // 
            this.dtpYear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(499, 34);
            this.dtpYear.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dtpYear.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(117, 29);
            this.dtpYear.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.dtpYear);
            this.panel1.Location = new System.Drawing.Point(23, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 91);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RVAnual);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 599);
            this.panel2.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84181F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.1582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 718);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1277, 28);
            this.panel3.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(614, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "© 2023 - Jessie Martel";
            // 
            // FrmReporteAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReporteAnual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteAnual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAnualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVAnual;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.BindingSource dataTableAnualBindingSource;
        private DSAnual dSAnual;
        private DSAnualTableAdapters.DataTableAnualTableAdapter dataTableAnualTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}