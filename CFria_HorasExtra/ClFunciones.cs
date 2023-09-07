using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CFria_HorasExtra
{
    public class ClFunciones
    {
        ClConexion conexion = new ClConexion();

        protected int codigo_Empleado;
        protected string estado;
        protected float sueldo;
        protected string hora_entrada;
        protected string hora_salida;
        protected float costo_horaExtra;
        protected string nom_tabla;
        protected string nombre_Puesto;

        public int Codigo_Empleado
        { 
            get => codigo_Empleado;
            set
            {
                if (value > 0)
                {
                    codigo_Empleado = value;
                }
                else
                {
                    codigo_Empleado = 0;
                }
            }
        }
        public string Estado
        { 
            get => estado;
            set {
                if (!string.IsNullOrEmpty(value))
                {
                    estado = value;
                }
                else
                {
                    estado = "*";
                }
            }
        }
        public float Sueldo
        { 
            get => sueldo;
            set
            {
                if (value > 0)
                {
                    sueldo = value;
                }
                else
                {
                    sueldo= 0;
                }
            }
        }
        public string Hora_entrada
        {
            get => hora_entrada;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    hora_entrada = value;
                }
                else
                {
                    hora_entrada = "";
                }
            }
        }
        public string Hora_salida 
        {
            get => hora_salida;
            set => hora_salida = value; 
        }
        public float Costo_horaExtra
        { 
            get => costo_horaExtra; 
            set => costo_horaExtra = value;
        }
        protected string Nom_tabla
        {
            get => nom_tabla; 
            set => nom_tabla = value; 
        }
        protected string Nombre_Puesto
        { 
            get => nombre_Puesto; 
            set => nombre_Puesto = value; 
        }

    }
}
