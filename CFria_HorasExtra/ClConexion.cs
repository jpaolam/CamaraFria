using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CFria_HorasExtra
{
    internal class ClConexion
    {
        SqlDataAdapter da;
        DataTable dt;

        string conexion = "Data Source = MARTELG\\SQLEXPRESS; Initial catalog = DeptCamaraFria; Integrated Security = true";
        //string conexion = @"Data Source = L-LCE-SSOIHET\\SQLEXPRESS; Initial catalog = DeptCamaraFria; Integrated Security = true; User ID=ssoihet; Password=leyde2023;";

        public SqlConnection Sc = new SqlConnection();

        public ClConexion()
        {
            Sc.ConnectionString = conexion;
        }

        public void abrir()
        {
            try
            {
                Sc.Open();
                //MessageBox.Show("Conexión abierta");
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error al abrir BD" + x);
            }
        }

        public void cerrar()
        {
            Sc.Close();
            //MessageBox.Show("Conexión cerrada");
        }

        public void cargarDatos(DataGridView dgv, string tableName)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM " + tableName, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos.");
            }
        }
        public void cargarDatosEmpleado(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT dbo.Empleados.Id_Empleado AS [No Personal], dbo.Empleados.EmpleadoNombreCompleto AS [Nombre Completo], dbo.Empleados.EmpleadoFechaContratación AS [Fecha de Contratacion], dbo.Empleados.EmpleadoSalarioMensual AS Salario, dbo.Empleados.Estado, dbo.Puestos.Nombre_Puesto AS Puesto FROM dbo.Empleados INNER JOIN dbo.Puestos ON dbo.Empleados.PuestoId = dbo.Puestos.Id_Puesto", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception x)
            {
                MessageBox.Show("No se pueden cargar los datos", "Error");
            } 
        }
        public void cargarDatosExtras(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT dbo.Bitacora.Id_Empleado AS NoPersonal, dbo.Bitacora.Id_Puesto, dbo.Puestos.Nombre_Puesto AS Puesto, dbo.Empleados.EmpleadoNombreCompleto AS Nombre, dbo.Empleados.EmpleadoSalarioMensual AS Salario, dbo.Bitacora.HoraEntrada, dbo.Bitacora.HoraSalida, dbo.Bitacora.HoraExtraordinaria, dbo.Bitacora.FechaRegistro, dbo.Bitacora.JustificacionEmpleado AS Justificacion FROM dbo.Bitacora INNER JOIN dbo.Empleados ON dbo.Bitacora.Id_Empleado = dbo.Empleados.Id_Empleado INNER JOIN dbo.Puestos ON dbo.Bitacora.Id_Puesto = dbo.Puestos.Id_Puesto AND dbo.Empleados.PuestoId = dbo.Puestos.Id_Puesto", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception x)
            {
                MessageBox.Show("No se pueden cargar los datos", "Error");
            }
        }
    }
}
