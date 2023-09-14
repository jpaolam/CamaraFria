using CFria_HorasExtra.DSReporteSemanalTableAdapters;
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
    public partial class FrmReporteSemanal : Form
    {
        DataTableSemanalTableAdapter DataTableSemanalTableAdapter = new DataTableSemanalTableAdapter();
        public FrmReporteSemanal()
        {
            InitializeComponent();

            // Configura el valor inicial del DateTimePicker para mostrar el inicio de la semana actual
            dtpIncioSemana.Value = GetStartOfWeek(DateTime.Now);

            // Calcula y configura el valor final de la semana en el otro DateTimePicker
            dtpFinalSemana.Value = GetEndOfWeek(dtpIncioSemana.Value);
        }
        // Función para obtener el inicio de la semana a partir de una fecha dada
        private DateTime GetStartOfWeek(DateTime date)
        {
            // Obtiene el día de la semana de la fecha dada
            int daysUntilSunday = (int)date.DayOfWeek;
            // Resta el día de la semana a la fecha para obtener el inicio de la semana
            return date.AddDays(-(daysUntilSunday-1));
        }

        // Función para obtener el final de la semana a partir de una fecha de inicio de semana
        private DateTime GetEndOfWeek(DateTime startOfWeek)
        {
            // Suma 6 días a la fecha de inicio para obtener el final de la semana
            return startOfWeek.AddDays(5);
        }

        private void dtpIncioSemana_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se toman los valores de los DateTimePicker
                DateTime fechaIncioSemana = dtpIncioSemana.Value;
                DateTime fechaFinalSemana = dtpFinalSemana.Value;
                
                // Formatear la fecha en el formato "yy-MM-dd"
                string fechaInicioFormateada = fechaIncioSemana.ToString("yyyy-MM-dd");
                string fechaFinalFormateada = fechaFinalSemana.ToString("yyyy-MM-dd");
                
                // TODO: This line of code loads data into the 'DataSetPrestamos.Prestamos' table. You can move, or remove it, as needed.
                this.DataTableSemanalTableAdapter.Fill(this.dSReporteSemanal.DataTableSemanal, fechaInicioFormateada, fechaFinalFormateada);
                this.RVSemanal.RefreshReport();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al cargar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmReporteSemanal_Load(object sender, EventArgs e)
        {
            this.RVSemanal.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTipoReporte frm = new FrmTipoReporte();
            this.Close();
            frm.Show();
        }
    }
}
