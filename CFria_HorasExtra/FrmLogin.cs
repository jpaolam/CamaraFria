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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        ClConexion conexion = new ClConexion();
        public void logearAdmin(string usuario, string contra)
        {
            try
            {
                //Se abre la conexion
                conexion.abrir();
                //Se realiza la consulta
                SqlCommand cmd = new SqlCommand("SELECT username FROM Usuarios WHERE username = @usuario AND password = @pass", conexion.Sc);
                //Se agregan los parametros
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contra);

                //Se ejecuta la consulta
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //Se crea una tabla
                DataTable dt = new DataTable();
                //Se llena la tabla
                da.Fill(dt);

                //Se valida que la consulta tenga un resultado
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    //Se instancia el formulario y se muestra
                    new FrmPrincipal(dt.Rows[0][0].ToString()).ShowDialog();
                }

                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception x)
            {
                MessageBox.Show("Error al cargar la Base de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                conexion.cerrar();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se valida que los campos no esten vacios
                if (TxtUsuario.Text == "" || TxtContrasena.Text == "")
                {
                    MessageBox.Show("Error, ingresar valores al textbox.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtContrasena.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }

                else
                {//Se llama al metodo logearAdmin
                    logearAdmin(this.TxtUsuario.Text, this.TxtContrasena.Text);
                    TxtContrasena.Clear();
                    TxtUsuario.Clear();
                    TxtUsuario.Focus();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Error al ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Se cierra la aplicacion
            Application.Exit();
        }
    }
}
