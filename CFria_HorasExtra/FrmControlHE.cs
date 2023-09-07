using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CFria_HorasExtra
{
    public partial class FrmControlHE : Form
    {
        private DateTimePicker timePicker;
        ClConexion conexion = new ClConexion();

        public FrmControlHE()
        {
            InitializeComponent();
            InitializeTimePickerHoraEntrada();
            InitializeTimePickerHoraSalida();
            InitializeTimePickerHoraExtra();
        }
        //hacerlo más facil
        /*
         * Una sola funcion y enviar el parámetro
         */
        private void InitializeTimePickerHoraEntrada()
        {
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Width = 100;
        }
        private void InitializeTimePickerHoraSalida()
        {
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Location = new Point(549, 201);
            dtpHoraSalida.Width = 100;
        }
        private void InitializeTimePickerHoraExtra()
        {
            dtpHoraExtra.Format = DateTimePickerFormat.Time;
            dtpHoraExtra.ShowUpDown = true;
            dtpHoraExtra.Location = new Point(482, 256);
            dtpHoraExtra.Width = 100;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmControlHE_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Se abre la conexion SQL
                conexion.abrir();
                /*
                 Se crea la consulta SQL la cual se almacena en cmd y despues este lo ejecuta
                y lee todos los argumentos que este envía acorde a la consulta
                esto es verificado por el reader.Read() donde establece si esto trae algo
                entrará dentro de la funcion y realizará lo requerido de otra manera dará error
                 */
                SqlCommand cmd = new SqlCommand("SELECT dbo.Empleados.EmpleadoNombre, dbo.Empleados.EmpleadoSalarioMensual, dbo.Puestos.Nombre_Puesto, dbo.Empleados.PuestoId FROM dbo.Empleados INNER JOIN dbo.Puestos ON dbo.Empleados.PuestoId = dbo.Puestos.Id_Puesto WHERE dbo.Empleados.Id_Empleado = " + Convert.ToInt32(TxtBuscar.Text)+"", conexion.Sc);
                cmd.ExecuteNonQuery();
                //Este ejecuta la sentencia mientras que almacena esa informacion en una variable
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    TxtNombreE.Text = reader["EmpleadoNombre"].ToString();
                    TxtPuesto.Text = reader["Nombre_Puesto"].ToString();
                    TxtSueldo.Text = reader["EmpleadoSalarioMensual"].ToString();
                }else
                    //en caso de que no exista el registro enviará este mensaje para notificarlo
                    MessageBox.Show("No existe");
                    //El cursor se va a posicionar en el textbox de No Personal.
                    TxtBuscar.Focus();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcularHoras_Click(object sender, EventArgs e)
        {
            // Obtener las fechas seleccionadas de los DateTimePicker
            DateTime fechaEntrada = dtpHoraSalida.Value;
            DateTime fechaSalida = dtpHoraSalida.Value;
            DateTime fechaFin = dtpHoraExtra.Value;
            double sueldo = Convert.ToDouble(TxtSueldo.Text);

            // Verificar si la hora de salida es a las 12 del mediodía
            if (fechaFin.TimeOfDay > TimeSpan.FromHours(12))
            {
                // Calcular la diferencia en horas
                TimeSpan diferencia = fechaFin - fechaSalida;
                double horasDiferencia = diferencia.TotalHours;

                // Aplicar un recargo del 25%
                horasDiferencia *= 1.25;

                // Redondear el resultado al número entero más cercano
                int horasRedondeadas = (int)Math.Round(horasDiferencia);

                // Mostrar el resultado con el recargo en un cuadro de texto u otro control
                TxtHorasExtras.Text = horasRedondeadas.ToString();
            }
            else
            {
                // Si la hora de salida no es a las 12 del mediodía, calcular la diferencia sin recargo
                TimeSpan diferencia = fechaFin - fechaSalida;
                double horasDiferencia = diferencia.TotalHours;

                // Redondear el resultado al número entero más cercano
                int horasRedondeadas = (int)Math.Round(horasDiferencia);

                // Mostrar el resultado sin recargo en un cuadro de texto u otro control
                TxtHorasExtras.Text = horasRedondeadas.ToString();
            }
            //MessageBox.Show(dtpHoraExtra.Value.ToString());
        }
    }
}
