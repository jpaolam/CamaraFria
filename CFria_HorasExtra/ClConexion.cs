using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFria_HorasExtra
{
    internal class ClConexion
    {
        SqlDataAdapter da;
        DataTable dt;

        string conexion = "Data Source =MARTELG\\SQLEXPRESS; Initial catalog = CamaraFria; Integrated Security = true";

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
                MessageBox.Show("Ocurrió un error al abrir BD");
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

    }
}
