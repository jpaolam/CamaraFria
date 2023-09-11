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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            conexion.cargarDatosEmpleado(dgvEmpleados);
        }

        ClConexion conexion = new ClConexion();
        int codpuesto;
        int estado;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            this.Close();
            frmPrincipal.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbActivo.Checked == true)
                {
                    estado = 1;
                }
                else if (rbInactivo.Checked == true)
                {
                    estado = 0;
                }
                DateTime fechaSeleccionada = dtpFechaContratacion.Value;
                // Formatear la fecha en el formato "yy-MM-dd"
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd");

                conexion.abrir();
                SqlCommand cmd = new SqlCommand("INSERT INTO Empleados VALUES (" + Convert.ToInt32(TxtNoPersonal.Text) + " ,'" + TxtNombreCompleto.Text + "','" + fechaFormateada + "'," + codpuesto + "," + Convert.ToDouble(TxtSueldoMensual.Text )+", "+ estado +")", conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                conexion.cargarDatos(dgvEmpleados, "Empleados");
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

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            // Establecer el formato personalizado en YY-MM-DD
            dtpFechaContratacion.Format = DateTimePickerFormat.Custom;
            dtpFechaContratacion.CustomFormat = "yy-MM-dd";
            conexion.abrir();
            SqlCommand command = new SqlCommand("Select * from Puestos", conexion.Sc);
            SqlDataReader registro = command.ExecuteReader();
            cmbPuesto.DisplayMember = "TEXT";

            while (registro.Read())
            {
                cmbPuesto.Items.Add(new { Text = registro["Nombre_Puesto"], value = registro["Id_Puesto"].ToString() });
            }
            conexion.cerrar();
        }

        private void dtpFechaContratacion_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            codpuesto = Convert.ToInt32((cmbPuesto.SelectedItem as dynamic).value);
        }
    }
}
