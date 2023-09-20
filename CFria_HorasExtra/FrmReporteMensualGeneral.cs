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
    public partial class FrmReporteMensualGeneral : Form
    {
        public FrmReporteMensualGeneral()
        {
            InitializeComponent();
        }

        DataTableMensualGeneralTableAdapter adapter = new DataTableMensualGeneralTableAdapter();

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
                    this.adapter.Fill(this.dSReporteM1.DataTableMensualGeneral, valor);
                    this.RVMensual.RefreshReport();
                }

            }
            catch (Exception x)
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

        private void FrmReporteMensualGeneral_Load(object sender, EventArgs e)
        {
            this.RVMensual.RefreshReport();
        }
    }
}
