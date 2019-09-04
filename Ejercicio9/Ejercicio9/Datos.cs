using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio9
{
    class Datos
    {
        public static List<Alojamiento> alojamientos = new List<Alojamiento>();
        public static Alojamiento alojamiento = new Alojamiento();
        public static XmlDocument documento = new XmlDocument();
        public static string mensaje;
        public static void cargarXML()
        {
            string url = "https://www.esmadrid.com/opendata/alojamientos_v1_es.xml";

            using (WebClient webCliente = new WebClient())
            {
                if (!webCliente.IsBusy)
                {
                    Stream respuesta;
                    try
                    {
                        respuesta = webCliente.OpenRead(new Uri(url));
                        StreamReader leer = new StreamReader(respuesta, Encoding.UTF8);
                        documento.Load(leer);
                    }
                    catch (WebException error)
                    {
                        mensaje = error.Message;
                    }
                }
                else
                {
                    mensaje = "Está ocupado intentarlo de nuevo";
                }
            }
        }

        public static void cargarNodo()
        {
            List<string> imagenes = new List<string>();

            XmlNodeList listaAlojamientos = documento.SelectNodes("serviceList/service");

            SautinSoft.HtmlToRtf html = new SautinSoft.HtmlToRtf();
            html.OutputFormat = SautinSoft.HtmlToRtf.eOutputFormat.TextUnicode;

            foreach (XmlNode a in listaAlojamientos)
            {
                alojamiento = new Alojamiento();
                alojamiento.Codigo = a.Attributes["id"].Value;
                alojamiento.Nombre = WebUtility.HtmlDecode(a["basicData"]["name"].InnerText);
                alojamiento.Email = a["basicData"]["email"].InnerText;
                alojamiento.Telefono = a["basicData"]["phone"].InnerText;
                alojamiento.Descripcion = html.ConvertString(a["basicData"]["body"].InnerText).Replace("\r\nTrial version converts only first 100000 characters. Evaluation only.", "");
                alojamiento.Web = a["basicData"]["web"].InnerText;
                alojamiento.Direccion = a["geoData"]["address"].InnerText;
                alojamiento.Localidad = a["geoData"]["subAdministrativeArea"].InnerText;
                alojamiento.CP = a["geoData"]["zipcode"].InnerText;

                XmlNodeList listaMultimedia = a["multimedia"].ChildNodes;
                imagenes=new List<string>();
                foreach (XmlElement m in listaMultimedia)
                {
                    imagenes.Add(m.InnerText);
                }
                alojamiento.Imagenes = imagenes;

                XmlNodeList listaExtradata = a["extradata"].ChildNodes;
                foreach (XmlElement e in listaExtradata)
                {
                    if (e.Name == "categorias")
                    {
                        //XmlNodeList listaCategoria = e["categoria"].ChildNodes;
                        XmlNodeList listaCategoria = e.SelectNodes("categoria");
                        foreach (XmlElement c in listaCategoria)
                        {
                            if (c.Name == "subcategorias")
                            {
                                XmlNodeList listaSubcategoria = c["subcategoria"].ChildNodes;
                                foreach (XmlElement s in listaSubcategoria)
                                {
                                    if (s.Attributes["name"].Value == "SubCategoria")
                                    {
                                        alojamiento.Estrellas = s.InnerText;
                                    }

                                }
                            }
                        }
                    }
                }
                alojamientos.Add(alojamiento);
            }
        }
    }
}
