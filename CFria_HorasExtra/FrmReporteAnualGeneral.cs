﻿using CFria_HorasExtra.DSAnualTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFria_HorasExtra
{
    public partial class FrmReporteAnualGeneral : Form
    {
        public FrmReporteAnualGeneral()
        {
            InitializeComponent();
        }

        DataTableAnualGeneralTableAdapter adapter = new DataTableAnualGeneralTableAdapter();

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se valida que el campo no este vacio
                string texto = dtpYear.Text;
                if (string.IsNullOrWhiteSpace(texto))
                {
                    //Si el campo esta vacio se muestra un mensaje de error
                    MessageBox.Show("Campo de año incompleto", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Si el campo no esta vacio se realiza la consulta
                    int valor = Convert.ToInt32(dtpYear.Text);
                    // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
                    this.adapter.Fill(this.dSAnual.DataTableAnualGeneral, valor);
                    //Se muestra el reporte
                    this.RVAnual.RefreshReport();
                }
            }
            catch (Exception x)
            {
                //Si ocurre un error se muestra un mensaje de error
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Se instancia el formulario y se muestra
            FrmTipoReporte frm = new FrmTipoReporte();
            this.Close();
            frm.Show();
        }

        private void FrmReporteAnualGeneral_Load(object sender, EventArgs e)
        {
            //Se hace la consulta de todos los datos
            this.RVAnual.RefreshReport();
        }
    }
}
