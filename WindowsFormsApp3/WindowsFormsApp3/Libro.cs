using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    internal class Libro
    {
        private List<Libro> listaLibros = new List<Libro>();
        public string Codigo {  get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int AnioPublicacion { get; set; }
        public Libro(string codigo, string titulo , string autor , int anioPublicacion ) 
        {
            Codigo = codigo;
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anioPublicacion;
        }
    }
}
