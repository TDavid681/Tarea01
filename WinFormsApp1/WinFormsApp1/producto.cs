using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class producto
    {
        public List<string> nombres = new List<string>();
        public List<double> precios = new List<double>();
        public void AgregarProducto(string nombre, double precio)
        {
            nombres.Add(nombre);
            precios.Add(precio);
        }
        public string BuscarPalabra(string palabra)
        {
            string resultado = "";
            for (int i = 0; i < nombres.Count; i++)
            {
                int posicion = nombres[i].IndexOf(palabra,
                    StringComparison.OrdinalIgnoreCase);
                if (posicion != -1)
                {
                    resultado += nombres[i] +
                        "-->Posicion: " +
                        posicion + "\n";
                }
            }
            if (resultado == "")
                resultado = "No se encontró la palabra";
            return resultado;
        }
        public string MostrarSubString()
        {
            string resultado = "";
            foreach (string producto in nombres)
            {
                if (producto.Length >= 5)
                    resultado += producto.Substring(0, 5) + "\n";
                else
                    resultado += producto + "\n";
            }
            return resultado;
        }
        public void Reemplazar(string viejo, string nuevo)
        {
            for (int i = 0; i < nombres.Count; i++)
            {
                nombres[i] = nombres[i].Replace(viejo, nuevo);
            }
        }
        public string SepararPalabra()
        {
            string resultado = "";
            foreach (string producto in nombres)
            {
                resultado += "\nProducto: " + producto + "\n";
                string[] palabras = producto.Split();
                foreach (string palabra in palabras)
                {
                    resultado += palabra + "\n";
                }
            }
            return resultado;
        }
        public void Ordenar()
        {
            for (int i = 0; i < nombres.Count; i++)
            {
                for (int j = i + 1; j < nombres.Count; j++)
                {
                    if (String.Compare(nombres[i], nombres[j]) > 0)
                    {
                        string auxNombre = nombres[i];
                        nombres[i] = nombres[i];
                        nombres[j] = auxNombre;
                        double auxPrecio = precios[i];
                        precios[i] = precios[j];
                        precios[j] = auxPrecio;
                    }
                }
            }
        }
        public int Buscar(string nombre)
        {
            for (int i = 0; i < nombres.Count; i++)
            {
                if (nombres[i].Equals(nombre,
                    StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}