﻿using System;
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
    public partial class FrmPuestos : Form
    {
        public FrmPuestos()
        {
            InitializeComponent();
        }

        ClConexion conexion = new ClConexion();

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            conexion.abrir();
            conexion.cargarDatos(dgvPuestos, "Puestos");
        }
    }
}
