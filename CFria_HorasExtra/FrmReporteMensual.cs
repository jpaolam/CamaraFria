﻿using CFria_HorasExtra.DSReporteMTableAdapters;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFria_HorasExtra
{
    public partial class FrmReporteMensual : Form
    {
        public FrmReporteMensual()
        {
            InitializeComponent();
        }
        private void FrmReporteMensual_Load(object sender, EventArgs e)
        {
            this.RVMensual.RefreshReport();
        }
        private void RVMensual_Load(object sender, EventArgs e)
        {

        }
        //ORIGEN DE DATOS
        DataTableMensualTableAdapter DataTableMensualTableAdapter = new DataTableMensualTableAdapter();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtMes.Text;
                if (string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show("Campo de mes incompleto", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int valor = Convert.ToInt32(txtMes.Text);
                    // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
                    this.DataTableMensualTableAdapter.Fill(this.dSReporteM.DataTableMensual, valor);
                    this.RVMensual.RefreshReport();
                }

            }catch(Exception x)
            {
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTipoReporte frm = new FrmTipoReporte();
            this.Close();
            frm.Show();
        }

        private void RVMensual_Load_1(object sender, EventArgs e)
        {

        }
    }
}
