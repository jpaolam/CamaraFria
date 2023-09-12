using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFria_HorasExtra
{
    public class ClValidaciones
    {
        private bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        public void validar(Form formulario)
        {
            foreach (Control controles in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (controles is TextBox & controles.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true)
            {
                MessageBox.Show("Campos incompletos");
            }// Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
        }
    }
}
