using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public class GestorProducto
    {
        public List<Producto> productos;
        public GestorProducto()
        {
            productos = new List<Producto>();
            
        }
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
        public Producto BuscarProductos(string codigo)
        {
            return productos.Find(p => p.Codigo == codigo);
        }
        public bool EliminarProducto(string codigo)
        {
            Producto producto =
                productos.Find(p => p.Codigo == codigo);
            if (producto == null)
            {
                productos.Remove(producto);
                return true;
            }
            return false;
        }
        public List<Producto> MostrarProducto() 
        {
            return productos;
        }
        public void LimpiarLista()
        {
            productos.Clear();
        }
        public void GuardarTexto(string ruta)
        {
            StreamWriter sw = new StreamWriter(ruta);
            foreach (Producto p in productos)
            {
                sw.WriteLine(
                    p.Codigo + ";" +
                    p.Nombre + ";" +
                    p.Precio + ";" +
                    p.Stock + ";"
                    );
            }
            sw.Close();
        }
        public void LeerTexto(string ruta)
        {
            productos.Clear();
            StreamReader sr = new StreamReader(ruta);
            string linea;
            while ((linea = sr.ReadLine()) !=null)
            {
                string[] datos = linea.Split();
                Producto p = new Producto(
                    datos[0], datos[1], 
                    Convert.ToDouble(datos[2]),
                    Convert.ToInt32(datos[3]));
                productos.Add(p);
            }
            sr.Close();
        }
        public void GuardarBinario(string ruta)
        {
            using FileStream fs = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize(fs, productos);
        }
         public void LeerBinario(string ruta)
        {
            using FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            productos = JsonSerializer.Deserialize<List<Producto>>(fs) ?? new List<Producto>();
        }
        }
    }

