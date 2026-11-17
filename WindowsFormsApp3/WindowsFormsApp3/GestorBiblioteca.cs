using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class GestorBiblioteca
    {
        public List<Libro> libros = new List <Libro> ();
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }
        public Libro BuscarLibro (string codigo)
        {
            return libros.FirstOrDefault (l => l.Codigo == codigo);
        }
        public bool EliminarLibro (string codigo)
        {
            Libro libro = BuscarLibro (codigo);
            if (libro != null)
            {
                libros.Remove (libro);
                return true;
            }
            return false;
        }
        public List <Libro> ObtenerLibros ()
        {
            return libros;
        }
        public int ContarLibros() 
        {
            return libros.Count;
        }
    }
}
