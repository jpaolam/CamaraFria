﻿using System;
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
    public partial class FrmPuestos : Form
    {
        public FrmPuestos()
        {
            InitializeComponent();
        }

        ClConexion conexion = new ClConexion();
        int i;
        bool errorNombre;
        ClValidaciones validaciones = new ClValidaciones();

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatos(dgvPuestos, "Puestos");
            TxtCodigo.Enabled = false;
            conexion.cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = TxtPuesto.Text;
                if (string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show("Campo de nombre incompleto","Campo incompleto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    conexion.abrir();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Puestos VALUES ('" + TxtPuesto.Text + "',1)", conexion.Sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado");
                    conexion.cargarDatos(dgvPuestos, "Puestos");
                    TxtCodigo.Clear();
                    TxtPuesto.Clear();
                }
                
            }
            catch (Exception x)
            {
                //en caso de que falle y no se ejecute la sentencia SQL enviará este mensaje
                MessageBox.Show("Error de base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string text = TxtPuesto.Text;
                if (string.IsNullOrWhiteSpace(text))
                {
                    MessageBox.Show("Campo de nombre incompleto, elija un registro a actualizar", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.abrir();
                    SqlCommand cmd = new SqlCommand("UPDATE Puestos SET Nombre_Puesto = '" + TxtPuesto.Text + "' , EstadoPuesto = 1 WHERE Id_Puesto = " + Convert.ToInt32(TxtCodigo.Text), conexion.Sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado");
                    conexion.cargarDatos(dgvPuestos, "Puestos");
                    TxtCodigo.Clear();
                    TxtPuesto.Clear();
                }
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

        private void dgvPuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * Recorre la fila indicada mediante el click lo que hace es tomar 
             * el campo de codigo y el campo de el nombre del puesto y este
             * los envía a los respectivos TextBox.
             */
            i = e.RowIndex;
            TxtCodigo.Text = dgvPuestos.CurrentRow.Cells[0].Value.ToString();
            TxtCodigo.Enabled = false;
            TxtPuesto.Text = dgvPuestos.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia los campos de texto y habilita el campo de codigo
            TxtCodigo.Clear();
            TxtPuesto.Clear();
            TxtCodigo.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal("Leyde");
            this.Close();
            frmPrincipal.Show();
        }

        private void TxtPuesto_TextChanged(object sender, EventArgs e)
        {
            foreach (char caracter in TxtPuesto.Text)
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
                epNombre.SetError(TxtPuesto, "Solo caracteres");
            }
            else
            {
                epNombre.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}