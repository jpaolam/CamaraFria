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
                //Se instancia el formulario y se muestra
                FrmReporteMensual frmReporteMensual = new FrmReporteMensual();
                frmReporteMensual.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                //Si ocurre un error se muestra un mensaje de error
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Se instancia el formulario y se muestra
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
            //Se instancia el formulario y se muestra
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteSemanal frm = new FrmReporteSemanal();
                frm.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRSemanalG_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteSGeneral frm = new FrmReporteSGeneral();
                frm.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRMensualG_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteMensualGeneral frm = new FrmReporteMensualGeneral();
                frm.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRAnualG_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteAnualGeneral frm = new FrmReporteAnualGeneral();
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
