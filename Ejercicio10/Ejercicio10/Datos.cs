using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio10
{
    class Datos
    {
        public static List<Prediccion> predicciones = new List<Prediccion>();
        public static Meteorologia meteorologia = new Meteorologia();        
        public static XmlDocument documento = new XmlDocument();
        public static string mensaje;
        public static void cargarTXT()
        {
            string ruta = "predicciones.txt";
            if (File.Exists(ruta))
            {
                StreamReader leer = new StreamReader(ruta, Encoding.Default, true);
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    string[] partes = linea.Split('+');
                    predicciones.Add(new Prediccion { Grado = Convert.ToInt32(partes[0].TrimStart().TrimEnd()), Denominacion = partes[1].TrimStart().TrimEnd(), VelocidadMinima = Convert.ToDouble(partes[2].TrimStart().TrimEnd()), VelocidadMaxima = Convert.ToDouble(partes[3].TrimStart().TrimEnd()), Tierra = partes[4].TrimStart().TrimEnd(), Mar = partes[5].TrimStart().TrimEnd(), Altura = partes[6].TrimStart().TrimEnd() });
                }
                leer.Close();
            }
        }

        public static void cargarXML(DateTime fecha)
        {
            DateTime fechaDesde = fecha;
            DateTime fechaHasta = fechaDesde.AddDays(1);

            string url = "http://www2.meteogalicia.es/galego/observacion/estacions/contidos/DatosHistoricosXML_dezminutal.asp?est=10155&param=2542,2548,2540,2541,2547,2545&data1=" + fechaDesde + "&data2=" + fechaHasta + "&idprov=2&red=102";

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
            double velocidadMax = 0;
            double velocidadMin = 0;
            double temperaturaManana = 0;
            int totalTemperaturaManana = 0;
            double temperaturaTarde = 0;
            int totalTemperaturaTarde = 0;
            double temperaturaNoche = 0;
            int totalTemperaturaNoche = 0;

            XmlNodeList listaValores = documento.GetElementsByTagName("Valores");

            foreach (XmlElement v in listaValores)
            {
                DateTime fecha = Convert.ToDateTime(v.Attributes["Data"].Value);

                XmlNodeList medidas = v.GetElementsByTagName("Medida");

                foreach (XmlNode m in medidas)
                {
                    if (m.Attributes["ID"].Value == "81")
                    {
                        if (velocidadMax < Convert.ToDouble(m.Attributes["Valor"].Value))
                        {
                            velocidadMax = Convert.ToDouble(m.Attributes["Valor"].Value);
                        }

                        if (velocidadMin > Convert.ToDouble(m.Attributes["Valor"].Value))
                        {
                            velocidadMin = Convert.ToDouble(m.Attributes["Valor"].Value);
                        }
                    }

                    if ((fecha.Hour >= 7) && (fecha.Hour < 13))
                    {
                        if (m.Attributes["ID"].Value == "83")
                        {
                            temperaturaManana += Convert.ToDouble(m.Attributes["Valor"].Value);
                            totalTemperaturaManana++;
                        }
                    }

                    if ((fecha.Hour >= 13) && (fecha.Hour < 20))
                    {
                        if (m.Attributes["ID"].Value == "83")
                        {
                            temperaturaTarde += Convert.ToDouble(m.Attributes["Valor"].Value);
                            totalTemperaturaTarde++;
                        }
                    }

                    if ((fecha.Hour >= 20) || (fecha.Hour < 7))
                    {
                        if (m.Attributes["ID"].Value == "83")
                        {
                            temperaturaNoche += Convert.ToDouble(m.Attributes["Valor"].Value);
                            totalTemperaturaNoche++;
                        }
                    }
                }
            }

            temperaturaManana = temperaturaManana / totalTemperaturaManana;
            temperaturaTarde = temperaturaTarde / totalTemperaturaTarde;
            temperaturaNoche = temperaturaNoche / totalTemperaturaNoche;

            meteorologia = new Meteorologia();

            meteorologia.TemperaturaManana = Math.Round(temperaturaManana, 2);
            meteorologia.TemperaturaTarde = Math.Round(temperaturaTarde, 2);
            meteorologia.TemperaturaNoche = Math.Round(temperaturaNoche, 2);

            foreach (Prediccion p in predicciones)
            {
                if ((velocidadMin >= p.VelocidadMinima) && (velocidadMin < p.VelocidadMaxima))
                {
                    meteorologia.GradoMin = p.Grado;
                    meteorologia.DenominacionMin = p.Denominacion;
                    meteorologia.TierraMin = p.Tierra;
                }
                if ((velocidadMax >= p.VelocidadMinima) && (velocidadMax < p.VelocidadMaxima))
                {
                    meteorologia.GradoMax = p.Grado;
                    meteorologia.DenominacionMax = p.Denominacion;
                    meteorologia.TierraMax = p.Tierra;
                }
            }
        }

        public static void guardarXML()
        {
            string fichero = "predicciones.xml";
            XmlTextWriter escribir = new XmlTextWriter(fichero, Encoding.Default);
            escribir.Formatting = Formatting.Indented;

            escribir.WriteStartDocument();
            escribir.WriteStartElement("pronosticos");

            escribir.WriteStartElement("localizacion");
            escribir.WriteAttributeString("nombre", "Ourense");

            escribir.WriteStartElement("temperaturas");
            escribir.WriteAttributeString("mañana", Convert.ToString(meteorologia.TemperaturaManana));
            escribir.WriteAttributeString("tarde", Convert.ToString(meteorologia.TemperaturaTarde));
            escribir.WriteAttributeString("noche", Convert.ToString(meteorologia.TemperaturaNoche));
            escribir.WriteEndElement();

            escribir.WriteStartElement("pronostico");
            escribir.WriteAttributeString("descripcion", "viento mínimo");
            escribir.WriteAttributeString("grado", Convert.ToString(meteorologia.GradoMin));
            escribir.WriteElementString("denominacion", meteorologia.DenominacionMin);
            escribir.WriteElementString("efectos en tierra", meteorologia.TierraMin);
            escribir.WriteEndElement();

            escribir.WriteStartElement("pronostico");
            escribir.WriteAttributeString("descripcion", "viento máximo");
            escribir.WriteAttributeString("grado", Convert.ToString(meteorologia.GradoMax));
            escribir.WriteElementString("denominacion", meteorologia.DenominacionMax);
            escribir.WriteElementString("efectos en tierra", meteorologia.TierraMax);
            escribir.WriteEndElement();

            escribir.WriteEndElement(); 
            escribir.WriteEndElement();

            escribir.WriteEndDocument();
            escribir.Flush();
            escribir.Close();
        }
    }
}
