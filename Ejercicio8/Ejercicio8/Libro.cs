using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Libro
    {
        public Libro() { }
        public Libro(string codigo, string numEjemplares, string isbn, string titulo, string autor, string descripcion)
        {
            Codigo = codigo;
            NumEjemplares = numEjemplares;
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Descripcion = descripcion;
        }
        public string Codigo { get; set; }
        public string NumEjemplares { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Descripcion { get; set; }
    }
}
