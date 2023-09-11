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
        int i;

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatos(dgvPuestos, "Puestos");
            TxtCodigo.Enabled = false;
            conexion.cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("INSERT INTO Puestos VALUES ('" + TxtPuesto.Text + "',1)",conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                conexion.cargarDatos(dgvPuestos, "Puestos");
                TxtCodigo.Clear();
                TxtPuesto.Clear();
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Error de Base de datos" + x);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("UPDATE Puestos SET Nombre_Puesto = '" + TxtPuesto.Text + "' , EstadoPuesto = 1 WHERE Id_Puesto = " + Convert.ToInt32(TxtCodigo.Text), conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
                conexion.cargarDatos(dgvPuestos, "Puestos");
                TxtCodigo.Clear();
                TxtPuesto.Clear();
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

        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Recorre la fila indicada mediante el click lo que hace es tomar 
             * el campo de codigo y el campo de el nombre del puesto y este
             * los envía a los respectivos TextBox.
             */
            i = e.RowIndex;
            TxtCodigo.Text = dgvPuestos.CurrentRow.Cells[0].Value.ToString();
            TxtCodigo.Enabled = false;
            TxtPuesto.Text = dgvPuestos.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCodigo.Clear();
            TxtPuesto.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }
    }
}