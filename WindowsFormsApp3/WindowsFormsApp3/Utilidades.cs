
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class Utilidades
    {
        public static bool ValidarCampoVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
        public static void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje,"Informacion",MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
        public static void LimpiarTextBox(params TextBox []cajas )
        {
            foreach( TextBox t in cajas )
            {
                t.Clear();
            }
        }
    }
}
