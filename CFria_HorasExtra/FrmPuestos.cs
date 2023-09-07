using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFria_HorasExtra
{
    public partial class FrmPuestos : Form
    {
        public FrmPuestos()
        {
            InitializeComponent();
        }

        ClConexion conexion = new ClConexion();

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatos(dgvPuestos, "Puestos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Puestos VALUES ('" + TxtPuesto.Text + "')",conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                conexion.cargarDatos(dgvPuestos, "Puestos");
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Error de Base de datos");
            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
}
