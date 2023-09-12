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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        int codpuesto, estado, i;
        ClValidaciones validaciones = new ClValidaciones();
        bool errorcod, errorNombre, errorSueldo;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
                this.Close();
                frmPrincipal.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error de navegación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            validaciones.validar(this);
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
                MessageBox.Show("Ingrese los datos requeridos");
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

        private void button1_Click(object sender, EventArgs e)
        {
            TxtNombreCompleto.Clear();
            TxtNoPersonal.Clear();
            TxtSueldoMensual.Clear();
            cmbPuesto.SelectedIndex = 0;
        }

        private void TxtSueldoMensual_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNoPersonal_TextChanged(object sender, EventArgs e)
        {
            foreach (char caracter in TxtNoPersonal.Text)
            {
                if (!char.IsDigit(caracter))
                {
                    errorcod = true;
                    break;
                }
                else
                {
                    errorcod = false;
                }
            }
            if (errorcod == true)
            {
                epNoPersonal.SetError(TxtNoPersonal, "Solo datos numericos");
            }
            else
            {
                epNoPersonal.Clear();
            }
        }
        private void TxtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            foreach (char caracter in TxtNombreCompleto.Text)
            {
                if (char.IsDigit(caracter))
                {
                    errorNombre = true;
                    break;
                }
                else
                {
                    errorNombre = false;
                }
            }
            if (errorNombre == true)
            {
                epNombre.SetError(TxtNombreCompleto, "Solo caracteres");
            }
            else
            {
                epNombre.Clear();
            }
        }
        private void BtnEditar_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Empleados] SET [EmpleadoNombreCompleto] = '"+ TxtNombreCompleto.Text + "',[EmpleadoFechaContratación] = '" + fechaFormateada + "',[PuestoId] = "+ codpuesto +" ,[EmpleadoSalarioMensual] = "+ Convert.ToDouble(TxtSueldoMensual.Text) + " ,[Estado] = "+ estado + "  WHERE Id_Empleado = " + Convert.ToInt32(TxtNoPersonal.Text) , conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros actualizados");
                conexion.cargarDatosEmpleado(dgvEmpleados);
                TxtNombreCompleto.Clear();
                TxtNoPersonal.Clear();
                TxtSueldoMensual.Clear();
                dtpFechaContratacion.Value = DateTime.Now;
                rbActivo.Checked = false;
                rbInactivo.Checked = false;
                cmbPuesto.SelectedIndex = 0;
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Establezca los datos a editar","Campos incompletos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
                conexion.cerrar();
            }
        }
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                i = e.RowIndex;
                TxtNoPersonal.Enabled = false;
                TxtNoPersonal.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                TxtNombreCompleto.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                dtpFechaContratacion.Value = (DateTime)dgvEmpleados.CurrentRow.Cells[2].Value;
                TxtSueldoMensual.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                if ((bool)dgvEmpleados.CurrentRow.Cells[4].Value == true)
                {
                    rbActivo.Checked = true;
                }
                else
                {
                    rbInactivo.Checked = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al cargar los datos a los controles");
            }
            finally
            {
                conexion.cerrar();
            }
        }
    }
}
