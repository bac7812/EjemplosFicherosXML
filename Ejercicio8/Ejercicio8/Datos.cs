using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio8
{
    class Datos
    {
        public static List<Libro> libros = new List<Libro>();
        public static Libro libro = new Libro();
        public static XmlDocument documento = new XmlDocument();
        public static XmlElement nodoRaiz;
        public static void cargarXML(string ruta)
        {
            if (!File.Exists(ruta))
            {
                XmlDeclaration declaracion = documento.CreateXmlDeclaration("1.0", "ISO-8859-1", null);
                documento.AppendChild(declaracion);
                nodoRaiz = documento.CreateElement("libros");
                documento.AppendChild(nodoRaiz);
            }
            else
            {
                documento.Load(ruta);
                nodoRaiz = documento.DocumentElement;
            }
        }
        public static void cargarNodo(string ruta)
        {
            documento.Load(ruta);

            XmlNodeList listaLibros = documento.SelectNodes("libros/libro");

            foreach (XmlNode l in listaLibros)
            {
                libro = new Libro();
                libro.Codigo = l.Attributes["codigo"].Value;
                libro.NumEjemplares = l.Attributes["numEjemplares"].Value;
                libro.Isbn = l["isbn"].InnerText;
                libro.Titulo = l["titulo"].InnerText;
                libro.Autor = l["autor"].InnerText;
                libro.Descripcion = l["descripcion"].InnerText;
                libros.Add(libro);
            }
        }
        public static XmlNode crearNodo(Libro li)
        {
            XmlElement libro = documento.CreateElement("libro");

            XmlAttribute codigo = documento.CreateAttribute("codigo");
            codigo.Value = li.Codigo;
            libro.Attributes.Append(codigo);

            XmlAttribute numEjemplares = documento.CreateAttribute("numEjemplares");
            numEjemplares.Value = li.NumEjemplares;
            libro.Attributes.Append(numEjemplares);

            XmlElement isbn = documento.CreateElement("isbn");
            isbn.InnerText = li.Isbn;
            libro.AppendChild(isbn);

            XmlElement titulo = documento.CreateElement("titulo");
            titulo.InnerText = li.Titulo;
            libro.AppendChild(titulo);

            XmlElement autor = documento.CreateElement("autor");
            autor.InnerText = li.Autor;
            libro.AppendChild(autor);

            XmlElement descripcion = documento.CreateElement("descripcion");
            descripcion.InnerText = li.Descripcion;
            libro.AppendChild(descripcion);

            return libro;
        }
        public static void AnadirNodo(Libro li, string ruta)
        {
            libros.Clear();

            XmlNode libro = crearNodo(new Libro (li.Codigo, li.NumEjemplares, li.Isbn, li.Titulo, li.Autor, li.Descripcion));

            nodoRaiz.InsertAfter(libro, nodoRaiz.LastChild);

            documento.Save(ruta);

            cargarNodo(ruta);
        }
        public static void modificarNodo(Libro li, string ruta)
        {
            libros.Clear();

            XmlNodeList listaLibros = documento.SelectNodes("libros/libro");

            foreach (XmlNode l in listaLibros)
            {
                if (l.Attributes["codigo"].Value == li.Codigo)
                {
                    XmlNode nodoAntiguo = l;

                    XmlNode nodoNuevo = crearNodo(new Libro(li.Codigo, li.NumEjemplares, li.Isbn, li.Titulo, li.Autor, li.Descripcion));

                    nodoRaiz.ReplaceChild(nodoNuevo, nodoAntiguo);
                }
            }
            documento.Save(ruta);

            cargarNodo(ruta);
        }
        public static void eliminarNodo(string codigo, string ruta)
        {
            libros.Clear();

            XmlNodeList listaLibros = documento.SelectNodes("libros/libro");

            foreach (XmlNode l in listaLibros)
            {
                if (l.Attributes["codigo"].Value == codigo)
                {
                    nodoRaiz.RemoveChild(l);
                }
            }
            documento.Save(ruta);

            cargarNodo(ruta);
        }
        public static void buscarNodo(string codigo)
        {
            libros.Clear();

            XmlNodeList listaLibros = documento.SelectNodes("libros/libro");

            foreach (XmlNode l in listaLibros)
            {
                if (l.Attributes["codigo"].Value == codigo)
                {
                    libro.Codigo = codigo;
                    libro.NumEjemplares = l.Attributes["numEjemplares"].Value;
                    libro.Isbn = l["isbn"].InnerText;
                    libro.Titulo = l["titulo"].InnerText;
                    libro.Autor = l["autor"].InnerText;
                    libro.Descripcion = l["descripcion"].InnerText;
                    libros.Add(libro);
                }
            }
        }
    }
}
