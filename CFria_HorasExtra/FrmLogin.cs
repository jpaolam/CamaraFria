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
                conexion.abrir();

                SqlCommand cmd = new SqlCommand("SELECT username FROM Usuarios WHERE username = @usuario AND password = @pass", conexion.Sc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contra);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();

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
            if (TxtUsuario.Text == "" || TxtContrasena.Text == "")
            {
                MessageBox.Show("Error, ingresar valores al textbox.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtContrasena.Clear();
                TxtUsuario.Clear();
                TxtUsuario.Focus();
            }

            else
            {
                logearAdmin(this.TxtUsuario.Text, this.TxtContrasena.Text);
                TxtContrasena.Clear();
                TxtUsuario.Clear();
                TxtUsuario.Focus();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
