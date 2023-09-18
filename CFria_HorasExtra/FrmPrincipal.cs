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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nombre)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmControlHE controlHE = new FrmControlHE();
                controlHE.Show();
            }
            catch(Exception x){
                MessageBox.Show("Error de navegación","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmPuestos puestos = new FrmPuestos();
                puestos.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmEmpleados frmEmpleados = new FrmEmpleados();
                frmEmpleados.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTipoReporte frmTipoReporte = new FrmTipoReporte();
                frmTipoReporte.Show();
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
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
