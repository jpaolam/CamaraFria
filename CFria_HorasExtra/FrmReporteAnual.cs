using CFria_HorasExtra.DSAnualTableAdapters;
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
    public partial class FrmReporteAnual : Form
    {
        public FrmReporteAnual()
        {
            InitializeComponent();
        }

        private void FrmReporteAnual_Load(object sender, EventArgs e)
        {
            this.RVAnual.RefreshReport();
        }
        DataTableAnualTableAdapter DataTableAnualTableAdapter = new DataTableAnualTableAdapter();
        DSAnual anual = new DSAnual();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtYear.Text);
            // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
            this.DataTableAnualTableAdapter.Fill(this.dSAnual.DataTableAnual, valor);
            this.RVAnual.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
            this.Close();
            frmPrincipal.Show();
        }
    }
}
