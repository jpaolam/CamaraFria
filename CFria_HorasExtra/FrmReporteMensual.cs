using CFria_HorasExtra.DSReporteMTableAdapters;
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
    public partial class FrmReporteMensual : Form
    {
        public FrmReporteMensual()
        {
            InitializeComponent();
        }


        
        private void FrmReporteMensual_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet11.VistaInforme' Puede moverla o quitarla según sea necesario.
            //this.vistaInformeTableAdapter.Fill(this.dataSet11.VistaInforme);
            //int valor = Convert.ToInt32(txtMes.Text);
            // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
            //this.DTInformeMensualTableAdapter.Fill(this.DataSet1.DTInformeMensual, 12);
            //this.RVMensual.RefreshReport();
            //this.RVMensual.RefreshReport();
        }

        private void RVMensual_Load(object sender, EventArgs e)
        {

        }

        DataTableMensualTableAdapter DataTableMensualTableAdapter = new DataTableMensualTableAdapter();
        //ORIGEN DE DATOS
        DSReporteM reporteM = new DSReporteM();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtMes.Text);
            // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
            this.DataTableMensualTableAdapter.Fill(this.dSReporteM.DataTableMensual,valor);
            this.RVMensual.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
            this.Close();
            frmPrincipal.Show();
        }
    }
}
