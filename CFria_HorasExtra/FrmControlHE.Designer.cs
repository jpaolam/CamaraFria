namespace CFria_HorasExtra
{
    partial class FrmControlHE
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNombreE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtHorasExtras = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSueldoNeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtPagoHorasE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCostoHora = new System.Windows.Forms.TextBox();
            this.BtnCalcularHoras = new System.Windows.Forms.Button();
            this.TxtSueldo = new System.Windows.Forms.TextBox();
            this.TxtPuesto = new System.Windows.Forms.TextBox();
            this.BtnGuardarRegistro = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraExtra = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora de entrada:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de salida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo por hora extra:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horas extra trabajadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sueldo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Puesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "No de personal:";
            // 
            // TxtNombreE
            // 
            this.TxtNombreE.Location = new System.Drawing.Point(197, 111);
            this.TxtNombreE.Name = "TxtNombreE";
            this.TxtNombreE.ReadOnly = true;
            this.TxtNombreE.Size = new System.Drawing.Size(164, 20);
            this.TxtNombreE.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(436, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Hora de salida (Extraordinaria):";
            // 
            // TxtHorasExtras
            // 
            this.TxtHorasExtras.Location = new System.Drawing.Point(180, 45);
            this.TxtHorasExtras.Name = "TxtHorasExtras";
            this.TxtHorasExtras.Size = new System.Drawing.Size(118, 20);
            this.TxtHorasExtras.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSueldoNeto);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtPagoHorasE);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TxtCostoHora);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnCalcularHoras);
            this.panel1.Controls.Add(this.TxtSueldo);
            this.panel1.Controls.Add(this.TxtHorasExtras);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(57, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 190);
            this.panel1.TabIndex = 18;
            // 
            // TxtSueldoNeto
            // 
            this.TxtSueldoNeto.Location = new System.Drawing.Point(110, 123);
            this.TxtSueldoNeto.Name = "TxtSueldoNeto";
            this.TxtSueldoNeto.Size = new System.Drawing.Size(118, 20);
            this.TxtSueldoNeto.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 18);
            this.label13.TabIndex = 24;
            this.label13.Text = "Sueldo neto:";
            // 
            // TxtPagoHorasE
            // 
            this.TxtPagoHorasE.Location = new System.Drawing.Point(180, 97);
            this.TxtPagoHorasE.Name = "TxtPagoHorasE";
            this.TxtPagoHorasE.Size = new System.Drawing.Size(118, 20);
            this.TxtPagoHorasE.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total pago horas extras:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 18);
            this.label11.TabIndex = 21;
            // 
            // TxtCostoHora
            // 
            this.TxtCostoHora.Location = new System.Drawing.Point(168, 71);
            this.TxtCostoHora.Name = "TxtCostoHora";
            this.TxtCostoHora.ReadOnly = true;
            this.TxtCostoHora.Size = new System.Drawing.Size(118, 20);
            this.TxtCostoHora.TabIndex = 20;
            // 
            // BtnCalcularHoras
            // 
            this.BtnCalcularHoras.Location = new System.Drawing.Point(244, 142);
            this.BtnCalcularHoras.Name = "BtnCalcularHoras";
            this.BtnCalcularHoras.Size = new System.Drawing.Size(99, 32);
            this.BtnCalcularHoras.TabIndex = 19;
            this.BtnCalcularHoras.Text = "Calcular";
            this.BtnCalcularHoras.UseVisualStyleBackColor = true;
            this.BtnCalcularHoras.Click += new System.EventHandler(this.BtnCalcularHoras_Click);
            // 
            // TxtSueldo
            // 
            this.TxtSueldo.Location = new System.Drawing.Point(77, 19);
            this.TxtSueldo.Name = "TxtSueldo";
            this.TxtSueldo.ReadOnly = true;
            this.TxtSueldo.Size = new System.Drawing.Size(118, 20);
            this.TxtSueldo.TabIndex = 18;
            // 
            // TxtPuesto
            // 
            this.TxtPuesto.Location = new System.Drawing.Point(489, 112);
            this.TxtPuesto.Name = "TxtPuesto";
            this.TxtPuesto.ReadOnly = true;
            this.TxtPuesto.Size = new System.Drawing.Size(118, 20);
            this.TxtPuesto.TabIndex = 20;
            // 
            // BtnGuardarRegistro
            // 
            this.BtnGuardarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarRegistro.Location = new System.Drawing.Point(549, 311);
            this.BtnGuardarRegistro.Name = "BtnGuardarRegistro";
            this.BtnGuardarRegistro.Size = new System.Drawing.Size(141, 46);
            this.BtnGuardarRegistro.TabIndex = 21;
            this.BtnGuardarRegistro.Text = "Ingresar Registro";
            this.BtnGuardarRegistro.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(306, 63);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(133, 20);
            this.TxtBuscar.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Location = new System.Drawing.Point(549, 169);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(141, 20);
            this.dtpHoraEntrada.TabIndex = 27;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Location = new System.Drawing.Point(549, 200);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(141, 20);
            this.dtpHoraSalida.TabIndex = 28;
            // 
            // dtpHoraExtra
            // 
            this.dtpHoraExtra.Location = new System.Drawing.Point(466, 256);
            this.dtpHoraExtra.Name = "dtpHoraExtra";
            this.dtpHoraExtra.Size = new System.Drawing.Size(141, 20);
            this.dtpHoraExtra.TabIndex = 29;
            // 
            // FrmControlHE
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(708, 380);
            this.Controls.Add(this.dtpHoraExtra);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.BtnGuardarRegistro);
            this.Controls.Add(this.TxtPuesto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtNombreE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmControlHE";
            this.Load += new System.EventHandler(this.FrmControlHE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNombreE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtHorasExtras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCostoHora;
        private System.Windows.Forms.Button BtnCalcularHoras;
        private System.Windows.Forms.TextBox TxtSueldo;
        private System.Windows.Forms.TextBox TxtPagoHorasE;
        private System.Windows.Forms.TextBox TxtSueldoNeto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtPuesto;
        private System.Windows.Forms.Button BtnGuardarRegistro;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraExtra;
    }
}

