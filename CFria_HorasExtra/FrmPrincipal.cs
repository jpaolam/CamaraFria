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
            this.Hide();
            FrmControlHE controlHE = new FrmControlHE();
            controlHE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPuestos puestos = new FrmPuestos();
            puestos.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
