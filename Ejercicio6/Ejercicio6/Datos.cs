using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio6
{
    class Datos
    {
        public static List<Libro> libros = new List<Libro>();
        public static Libro libro = new Libro();
        public static void leerXML(string ruta)
        {
            if (File.Exists(ruta))
            {
                libros.Clear();
                FileStream fichero = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                XmlTextReader leer = new XmlTextReader(ruta);
                while (leer.Read())
                {
                    if (leer.NodeType == XmlNodeType.Element)
                    {
                        switch (leer.Name)
                        {
                            case "libro":
                                libro = new Libro();
                                libro.Codigo = leer.GetAttribute(0);
                                libro.NumEjemplares = leer.GetAttribute(1);
                                break;
                            case "isbn":
                                libro.Isbn = leer.ReadString();
                                break;
                            case "autor":
                                libro.Autor = leer.ReadString();
                                break;
                            case "titulo":
                                libro.Titulo = leer.ReadString();
                                break;
                            case "descripcion":
                                libro.Descripcion = leer.ReadString();
                                libros.Add(libro);
                                break;
                        }
                    }
                }
                leer.Close();
            }
        }
        public static void escribirXML(string ruta, List<Libro> libros)
        {
            FileStream fichero = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            XmlTextWriter escribir = new XmlTextWriter(fichero, Encoding.Default);
            escribir.Formatting = Formatting.Indented;
            escribir.WriteStartDocument();

            escribir.WriteStartElement("libros");

            foreach (Libro l in libros)
            {
                escribir.WriteStartElement("libro");
                escribir.WriteAttributeString("codigo", l.Codigo);
                escribir.WriteAttributeString("numEjemplares", l.NumEjemplares);
                escribir.WriteElementString("isbn", l.Isbn);
                escribir.WriteElementString("autor", l.Autor);
                escribir.WriteElementString("titulo", l.Titulo);
                escribir.WriteElementString("descripcion", l.Descripcion);
                escribir.WriteEndElement();
            }
            escribir.WriteEndElement();
            escribir.WriteEndDocument();
            escribir.Close();
        }
    }
}
