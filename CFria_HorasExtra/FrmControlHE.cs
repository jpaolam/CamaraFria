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
        public FrmControlHE()
        {
            //Inicializar los componentes
            InitializeComponent();
            InitializeTimePickers();
            dtpHoraEntrada.Value = DateTime.Today + TimeSpan.Zero;
            dtpHoraSalida.Value = DateTime.Today + TimeSpan.Zero;
            dtpHoraExtra.Value = DateTime.Today + TimeSpan.Zero;
        }

        ClConexion conexion = new ClConexion();
        ClValidaciones validaciones = new ClValidaciones();
        DataSet resultados = new DataSet();
        DataView filtro;
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
            dtpHoraSalida.Width = 100;

            //DATETIMEPICKER DE SALIDA EXTRAORDINARIA
            dtpHoraExtra.Format = DateTimePickerFormat.Time;
            dtpHoraExtra.ShowUpDown = true;
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
            this.leer_datos("SELECT dbo.Empleados.EmpleadoNombreCompleto AS Nombre FROM Empleados", ref resultados, "Empleados");

            this.filtro = ((DataTable)resultados.Tables["Empleados"]).DefaultView;

            this.dgvNombre.DataSource = filtro;
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
                SqlCommand cmd = new SqlCommand("SELECT dbo.Empleados.Id_Empleado, dbo.Empleados.EmpleadoSalarioMensual, dbo.Puestos.Nombre_Puesto, dbo.Empleados.PuestoId FROM dbo.Empleados INNER JOIN dbo.Puestos ON dbo.Empleados.PuestoId = dbo.Puestos.Id_Puesto WHERE dbo.Empleados.EmpleadoNombreCompleto= '" + TxtNombreE.Text + "'", conexion.Sc);
                cmd.ExecuteNonQuery();
                //Este ejecuta la sentencia mientras que almacena esa informacion en una variable
                SqlDataReader reader = cmd.ExecuteReader();
                //Si el reader.Read() trae algo entrará dentro de la condicional
                if (reader.Read())
                {
                    TxtBuscar.Text = reader["Id_Empleado"].ToString();
                    //TxtNombreE.Text = reader["EmpleadoNombreCompleto"].ToString();
                    TxtPuesto.Text = reader["Nombre_Puesto"].ToString();
                    TxtSueldo.Text = reader["EmpleadoSalarioMensual"].ToString();
                    TxtCodPuesto.Text = reader["PuestoId"].ToString();
                } else
                    //en caso de que no exista el registro enviará este mensaje para notificarlo
                    MessageBox.Show("No existe");
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Ingrese el No Personal","Campo Incompleto",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            try
            {
                // Obtener las fechas seleccionadas de los DateTimePicker
                //DateTime fechaEntrada = dtpHoraEntrada.Value;
                DateTime fechaSalida = dtpHoraSalida.Value;
                DateTime fechaExtra = dtpHoraExtra.Value;

                TimeSpan diferencia;
                double horasDiferencia;

                // Calcular la diferencia en horas
                if (fechaExtra.Hour < fechaSalida.Hour)
                {
                    switch (fechaExtra.Hour)
                    {
                        case 00:
                            fechaExtra = fechaExtra.AddHours(24);
                            break;
                        case 01:
                            fechaExtra = fechaExtra.AddHours(24);
                            break;
                        case 02:
                            fechaExtra = fechaExtra.AddHours(24);
                            break;
                        case 03:
                            fechaExtra = fechaExtra.AddHours(24);
                            break;
                        case 04:
                            fechaExtra = fechaExtra.AddHours(24);
                            break;
                    }

                    diferencia = fechaExtra - fechaSalida;
                    horasDiferencia = diferencia.TotalHours;
                }
                else
                {
                    diferencia = fechaExtra - fechaSalida;
                    horasDiferencia = diferencia.TotalHours;
                }
                
                // Definir las horas de corte
                int horaCorte1 = 19;  // 19:00
                int horaCorte2 = 21;  // 21:00
                int horaCorte3 = 24;  // 00:00 (medianoche)
                int horaCorte4 = 4;   // 04:00

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
                        if(fechaExtra.Hour == 0)
                        {
                            horasHastaCorte1 = (horasDiferencia - horaCorte4) - 1;
                        }else if(fechaExtra.Hour == 1)
                        {
                            horasHastaCorte1 = (horasDiferencia - horaCorte4) - 2;
                        }
                        else if (fechaExtra.Hour == 2)
                        {
                            horasHastaCorte1 = (horasDiferencia - horaCorte4) - 3;
                        }
                        else if (fechaExtra.Hour == 3)
                        {
                            horasHastaCorte1 = (horasDiferencia - horaCorte4) - 4;
                        }
                        else
                        {
                            horasHastaCorte1 = horasDiferencia;
                        }
                        //horasHastaCorte1 = horasDiferencia;
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
                        if(fechaExtra.Hour < horaCorte4)
                        {
                            horasHastaCorte2 = (horaCorte2 - horaCorte1);
                        }
                        else
                        {
                            horasHastaCorte2 = horasDiferencia - horasHastaCorte1;
                        }
                    }
                    else if (fechaExtra.Hour < horaCorte3)
                    {
                        if(fechaExtra.Hour == horaCorte2)
                        {
                            horasHastaCorte2 = fechaExtra.Hour - horaCorte1;
                        }
                        else
                        {
                            horasHastaCorte2 = fechaExtra.Hour - (horaCorte2 - 1);
                            
                        }
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
                double sueldoConRecargoCorte1 = Math.Round(((sueldoHora * recargoCorte1) + sueldoHora) * horasHastaCorte1, 2);
                double sueldoConRecargoCorte2 = Math.Round(((sueldoHora * recargoCorte2) + sueldoHora) * horasHastaCorte2, 2);
                double sueldoConRecargoCorte3 = Math.Round(((sueldoHora * recargoCorte3) + sueldoHora) * horasHastaCorte3, 2);

                double pagoHorasExtra = Math.Round(sueldoConRecargoCorte1 + sueldoConRecargoCorte2 + sueldoConRecargoCorte3, 2);

                // Redondear el resultado al número entero más cercano
                double sueldoRedondeado = Convert.ToDouble(TxtSueldo.Text) + pagoHorasExtra;

                TxtPagoHorasE.Text = pagoHorasExtra.ToString();
                TxtHorasExtras.Text = horasDiferencia.ToString();
                TxtSueldoNeto.Text = sueldoRedondeado.ToString();
                TxtCostoHora.Text = sueldoHora.ToString();
                TxtPagoCorte1.Text = sueldoConRecargoCorte1.ToString();
                TxtPagoCorte2.Text = sueldoConRecargoCorte2.ToString();
                TxtPagoCorte3.Text = sueldoConRecargoCorte3.ToString();
                TxtHasta7.Text = horasHastaCorte1.ToString();
                TxtHasta9.Text = horasHastaCorte2.ToString();
                TxtHasta12.Text = horasHastaCorte3.ToString();
                TxtDiferencia.Text = horasDiferencia.ToString();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error al realizar cálculos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

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

        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            validaciones.validar(this);
            try
            {
                DateTime fechaRegistro = dtpDiaRegistro.Value;
                // Formatear la fecha en el formato "yy-MM-dd"
                string fechaFormateada = fechaRegistro.ToString("yyyy-MM-dd");

                // Obtener la hora seleccionada y almacenarla en una variable
                DateTime horaSeleccionadaEntrada = dtpHoraEntrada.Value;
                DateTime horaSeleccionadaSalida = dtpHoraSalida.Value;
                DateTime horaSeleccionadaExtra = dtpHoraExtra.Value;

                // Si solo deseas la hora en formato de 24 horas como una cadena, puedes hacer lo siguiente:
                string horaEntrada = horaSeleccionadaEntrada.ToString("HH:mm");
                string horaSalida = horaSeleccionadaSalida.ToString("HH:mm");
                string horaExtra = horaSeleccionadaExtra.ToString("HH:mm");
                conexion.abrir();
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Bitacora] ([Id_Empleado], [Id_Puesto], [HoraEntrada], [HoraSalida] ,[HoraExtraordinaria], [HorasHasta25], [HorasHasta50], [HorasHasta75], [Pago_HrsExtra25], [Pago_HrsExtra50], [Pago_HrsExtra75], [Pago_HrsExtra], [HorasExtras], [FechaRegistro], [JustificacionEmpleado]) " +
                    "VALUES ("+ Convert.ToInt32(TxtBuscar.Text) +","+ Convert.ToInt32(TxtCodPuesto.Text) +",'"+ horaEntrada +"','"+ horaSalida +"','"+ horaExtra +"',"+ Convert.ToDouble(TxtHasta7.Text) +","+ Convert.ToDouble(TxtHasta9.Text) +","+ Convert.ToDouble(TxtHasta12.Text) +","+ Convert.ToDouble(TxtPagoCorte1.Text) +","+ Convert.ToDouble(TxtPagoCorte2.Text) + ","+ Convert.ToDouble(TxtPagoCorte3.Text) + ","+ Convert.ToDouble(TxtPagoHorasE.Text) + ","+ Convert.ToDouble(TxtDiferencia.Text) +",'"+ fechaFormateada +"','" + txtJustificacion.Text + "')", conexion.Sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro guardado");
                TxtBuscar.Clear();
                TxtCodPuesto.Clear();
                TxtCostoHora.Clear();
                TxtDiferencia.Clear();
                TxtHasta12.Clear();
                TxtHasta7.Clear();
                TxtHasta9.Clear();
                TxtHorasExtras.Clear();
                TxtNombreE.Clear();
                TxtPagoCorte1.Clear();
                TxtPagoCorte2.Clear();
                TxtPagoCorte3.Clear();
                TxtPagoHorasE.Clear();
                TxtPuesto.Clear();
                TxtSueldo.Clear();
                TxtSueldoNeto.Clear();
                txtJustificacion.Clear();
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Ocurrió un error" + x,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {//Se cierra la conexion
                conexion.cerrar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            TxtCodPuesto.Clear();
            TxtCostoHora.Clear();
            TxtDiferencia.Clear();
            TxtHasta12.Clear();
            TxtHasta7.Clear();
            TxtHasta9.Clear();
            TxtHorasExtras.Clear();
            TxtNombreE.Clear();
            TxtPagoCorte1.Clear();
            TxtPagoCorte2.Clear();
            TxtPagoCorte3.Clear();
            TxtPagoHorasE.Clear();
            TxtPuesto.Clear();
            TxtSueldo.Clear();
            TxtSueldoNeto.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtNombreE_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.TxtNombreE.Text.Split(' ');

            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = " (Nombre LIKE '%" + palabra + "%' )";
                }
                else
                {
                    salida_datos += " AND (Nombre LIKE '%" + palabra + "%')";
                }
            }
            this.filtro.RowFilter = salida_datos;
        }
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                conexion.abrir();
                SqlCommand cmd = new SqlCommand(query, conexion.Sc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();

                conexion.cerrar();
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo realizar la consulta");
            }
        }
        int i;
        private void dgvNombre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //obtener los datos de la fila seleccionada
                i = e.RowIndex;
                TxtNombreE.Text = dgvNombre.CurrentRow.Cells[0].Value.ToString();
                //TxtSueldo.Text = dgvNombre.CurrentRow.Cells[2].Value.ToString();
                //TxtPuesto.Text = dgvNombre.CurrentRow.Cells[3].Value.ToString();
                //TxtCodPuesto.Text = dgvNombre.CurrentRow.Cells[4].Value.ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpDiaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEditarHoras frmEditarHoras = new FrmEditarHoras();
            frmEditarHoras.Show();
        }
    }
}
