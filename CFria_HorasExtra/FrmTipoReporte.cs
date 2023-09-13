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
    public partial class FrmTipoReporte : Form
    {
        public FrmTipoReporte()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteMensual frmReporteMensual = new FrmReporteMensual();
                frmReporteMensual.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteAnual frm = new FrmReporteAnual();
                frm.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPrincipal frm = new FrmPrincipal("Usuario");
                frm.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
