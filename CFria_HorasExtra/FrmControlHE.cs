using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CFria_HorasExtra
{
    public partial class FrmControlHE : Form
    {
        ClConexion conexion = new ClConexion();

        public FrmControlHE()
        {
            InitializeComponent();
            InitializeTimePickers();
        }
        //hacerlo más facil
        /*
         * Una sola funcion y enviar el parámetro
         */
        private void InitializeTimePickers()
        {
            //DATETIMEPICKER DE ENTRADA
            dtpHoraEntrada.Format = DateTimePickerFormat.Time;
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Width = 100;

            //DATETIMEPICKER DE SALIDA
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Location = new Point(549, 201);
            dtpHoraSalida.Width = 100;

            //DATETIMEPICKER DE SALIDA EXTRAORDINARIA
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
                SqlCommand cmd = new SqlCommand("SELECT dbo.Empleados.EmpleadoNombreCompleto, dbo.Empleados.EmpleadoSalarioMensual, dbo.Puestos.Nombre_Puesto, dbo.Empleados.PuestoId FROM dbo.Empleados INNER JOIN dbo.Puestos ON dbo.Empleados.PuestoId = dbo.Puestos.Id_Puesto WHERE dbo.Empleados.Id_Empleado = " + Convert.ToInt32(TxtBuscar.Text) + "", conexion.Sc);
                cmd.ExecuteNonQuery();
                //Este ejecuta la sentencia mientras que almacena esa informacion en una variable
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    TxtNombreE.Text = reader["EmpleadoNombreCompleto"].ToString();
                    TxtPuesto.Text = reader["Nombre_Puesto"].ToString();
                    TxtSueldo.Text = reader["EmpleadoSalarioMensual"].ToString();
                } else
                    //en caso de que no exista el registro enviará este mensaje para notificarlo
                    MessageBox.Show("No existe");
                //El cursor se va a posicionar en el textbox de No Personal.
                TxtBuscar.Focus();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalcularHoras_Click(object sender, EventArgs e)
        {

            // Obtener las fechas seleccionadas de los DateTimePicker
            //DateTime fechaEntrada = dtpHoraEntrada.Value;
            DateTime fechaSalida = dtpHoraSalida.Value;
            DateTime fechaExtra = dtpHoraExtra.Value;

            // Calcular la diferencia en horas
            TimeSpan diferencia = fechaExtra - fechaSalida;
            double horasDiferencia = diferencia.TotalHours;

            // Definir las horas de corte
            int horaCorte1 = 19;  // 19:00
            int horaCorte2 = 21;  // 21:00
            int horaCorte3 = 24;  // 00:00 (medianoche)

            // Inicializar las variables para contar las horas en cada rango
            double horasHastaCorte1 = 0.0;
            double horasHastaCorte2 = 0.0;
            double horasHastaCorte3 = 0.0;

            // Definir los recargos
            double recargoCorte1 = 0.25;  // 25%
            double recargoCorte2 = 0.50;  // 50%
            double recargoCorte3 = 0.75;  // 75%

            // Calcular las horas en cada rango y aplicar recargos
            /*si la fecha de salida es menor que la hora de corte 1 que es 19:00
             Entra a la condicional que evalua si la fecha extra es menor que la de corte
             */
            if (fechaSalida.Hour < horaCorte1)
            {
                /*
                    Si la fecha extra es menor a la hora de corte 1 : 19:00 
                horas hasta corte 1 agarra las horas de diferencia.
                 */
                if (fechaExtra.Hour < horaCorte1)
                {
                    horasHastaCorte1 = horasDiferencia;
                }
                else if (fechaExtra.Hour < horaCorte2)
                {
                    horasHastaCorte1 = (horaCorte1 - fechaSalida.Hour);
                }
                else if (fechaExtra.Hour < horaCorte3)
                {
                    horasHastaCorte1 = (horaCorte1 - fechaSalida.Hour);
                    horasHastaCorte2 = fechaExtra.Hour - horaCorte2;
                }
                else
                {
                    horasHastaCorte1 = (horaCorte1 - fechaSalida.Hour) + (horaCorte2 - horaCorte1);
                    horasHastaCorte2 = horaCorte3 - horaCorte2;
                    horasHastaCorte3 = fechaExtra.Hour - horaCorte3;
                }
            }
            if (fechaSalida.Hour < horaCorte2)
            {
                if (fechaExtra.Hour < horaCorte2)
                {
                    horasHastaCorte2 = horasDiferencia - horasHastaCorte1;
                }
                else if (fechaExtra.Hour < horaCorte3)
                {
                    horasHastaCorte2 = fechaExtra.Hour - horaCorte1;
                }
                else
                {
                    horasHastaCorte2 = horaCorte3 - horaCorte2;
                    horasHastaCorte3 = fechaExtra.Hour - horaCorte3;
                }
            }
            if (fechaSalida.Hour < horaCorte3)
            {
                if (fechaExtra.Hour < horaCorte3)
                {
                    //horasHastaCorte3 = horasDiferencia;
                    horasHastaCorte3 = horasDiferencia - (horasHastaCorte2 + horasHastaCorte1);
                    //MessageBox.Show(horasHastaCorte3.ToString());
                }
                else
                {
                    horasHastaCorte3 = fechaExtra.Hour - horaCorte2;
                }
            }

            //Calcular sueldo diario del empleado
            double sueldoDiario = Math.Round(Convert.ToDouble(TxtSueldo.Text) / 30, 2);

            //Calcular sueldo por hora del empleado
            double sueldoHora = Math.Round(sueldoDiario / 8, 2);

            // Aplicar los recargos a las horas trabajadas en cada rango
            double sueldoConRecargoCorte1 = ((sueldoHora * recargoCorte1) + sueldoHora) * horasHastaCorte1;
            double sueldoConRecargoCorte2 = ((sueldoHora * recargoCorte2) + sueldoHora) * horasHastaCorte2;
            double sueldoConRecargoCorte3 = ((sueldoHora * recargoCorte3) + sueldoHora) * horasHastaCorte3;
            
            double pagoHorasExtra = sueldoConRecargoCorte1+sueldoConRecargoCorte2+sueldoConRecargoCorte3;

            // Redondear el resultado al número entero más cercano
            double sueldoRedondeado = Convert.ToDouble(TxtSueldo.Text) + pagoHorasExtra;

            TxtPagoHorasE.Text = pagoHorasExtra.ToString() + " lps";
            TxtHorasExtras.Text = horasDiferencia.ToString() + " hrs";
            TxtSueldoNeto.Text = sueldoRedondeado.ToString() + " lps";
            TxtCostoHora.Text = sueldoHora.ToString() + " lps";
            TxtPagoCorte1.Text = sueldoConRecargoCorte1.ToString() + " lps";
            TxtPagoCorte2.Text = sueldoConRecargoCorte2.ToString() + " lps";
            TxtPagoCorte3.Text = sueldoConRecargoCorte3.ToString() + " lps";
            TxtHasta7.Text = horasHastaCorte1.ToString() + " hrs";
            TxtHasta9.Text = horasHastaCorte2.ToString() + " hrs";
            TxtHasta12.Text = horasHastaCorte3.ToString() + " hrs";
            TxtDiferencia.Text = horasDiferencia.ToString() + " hrs";

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
            frmPrincipal.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
            this.Close();
            frmPrincipal.Show();
        }
    }
}
