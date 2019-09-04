using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ejercicio7
{
    class Jornada
    {
        public static List<string> partido = new List<string>();

        public static LinkedList<string> equipoLocal = new LinkedList<string>();

        public static LinkedList<string> equipoVisitante = new LinkedList<string>();

        public static List<Partido> jornada = new List<Partido>();

        public static List<Clasificacion> clasificacion = new List<Clasificacion>();

        public static List<string> temporada = new List<string>();

        public static void cargarEquipos(string ruta)
        {
            if (File.Exists(ruta))
            {
                StreamReader leer = new StreamReader(ruta, Encoding.Default, true);
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    partido.Add(linea);
                }
                leer.Close();
            }
        }

        public static void InsertarAlPrincipio()
        {
            equipoLocal.AddFirst(equipoLocal.Last());
            equipoLocal.RemoveFirst();
            crearJornada();
        }

        public static void InsertarAlFinal()
        {
            equipoVisitante.AddLast(equipoLocal.Last());
            equipoLocal.RemoveLast();
            equipoLocal.AddLast(equipoLocal.First());
            equipoLocal.RemoveFirst();
            equipoLocal.AddFirst(equipoVisitante.First());
            equipoVisitante.RemoveFirst();
            crearJornada();
        }

        public static void crearJornada()
        {
            jornada.Clear();
            for (int i = 0; i < equipoLocal.Count; i++)
            {
                Partido partido = new Partido();
                partido.EquipoLocal = equipoLocal.ElementAt(i);
                partido.EquipoVisitante = equipoVisitante.ElementAt(i);
                jornada.Add(partido);
            }
        }

        public static void crearTemporada(int numeroJornada, string ano)
        {
            string ruta = "jornadas" + ano + ".txt";
            FileStream crearFichero = new FileStream(ruta, FileMode.Append);
            StreamWriter escribir = new StreamWriter(crearFichero);
            escribir.WriteLine("Jornada " + numeroJornada);
            for (int e = 0; e < jornada.Count; e++)
            {
                escribir.WriteLine(jornada[e].EquipoLocal + " - " + jornada[e].EquipoVisitante);
            }
            escribir.Close();
        }

        public static void cargarTemporada(string ano)
        {
            string ruta = "jornadas" + ano + ".txt";
            if (File.Exists(ruta))
            {
                StreamReader leer = new StreamReader(ruta);
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    temporada.Add(linea);
                }
                leer.Close();
            }
        }

        public static void cargarJornadas(string ano)
        {
            XmlDocument documento = new XmlDocument();
            string rutaTXT = "equipos.txt";
            string rutaXML = Environment.CurrentDirectory;

            if (File.Exists(rutaTXT))
            {
                StreamReader leer = new StreamReader(rutaTXT, Encoding.Default, true);
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    clasificacion.Add(new Clasificacion { partidoNombre = linea });
                }
                leer.Close();
            }

            string[] Archivos = Directory.GetFiles(rutaXML ,"*.xml");
            foreach (string archivos in Archivos)
            {
                FileInfo resultadoArchivo = new FileInfo(archivos);
                if (File.Exists(Convert.ToString(resultadoArchivo)))
                {
                    documento.Load(Convert.ToString(resultadoArchivo));
                    XmlNodeList listaPartidos = documento.GetElementsByTagName("partido");
                    foreach (XmlElement partido in listaPartidos)
                    {
                        XmlNode local = partido.FirstChild;
                        XmlNode visitante = partido.LastChild;

                        string nombreLocal = local.InnerText;
                        int golesLocal = Convert.ToInt32(local.Attributes["goles"].Value);
                        string nombreVisitante = visitante.InnerText;
                        int golesVisitante = Convert.ToInt32(visitante.Attributes["goles"].Value);

                        Clasificacion nombreEquipoLocal = clasificacion.Where(c => c.partidoNombre.Equals(nombreLocal)).First();
                        Clasificacion nombreEquipoVisitante = clasificacion.Where(c => c.partidoNombre.Equals(nombreVisitante)).First();

                        if (golesLocal > golesVisitante)
                        {
                            nombreEquipoLocal.partidoGanados++;
                            nombreEquipoLocal.partidoPuntos += 3;
                            nombreEquipoVisitante.partidoPerdidos++;

                        }
                        else if (golesLocal < golesVisitante)
                        {
                            nombreEquipoVisitante.partidoGanados++;
                            nombreEquipoVisitante.partidoPuntos += 3;
                            nombreEquipoLocal.partidoPerdidos++;
                        }
                        else
                        {
                            nombreEquipoLocal.partidoEmpatados += 1;
                            nombreEquipoVisitante.partidoEmpatados += 1;
                            nombreEquipoLocal.partidoPuntos += 1;
                            nombreEquipoVisitante.partidoPuntos += 1;
                        }
                        nombreEquipoLocal.partidoJugados = nombreEquipoLocal.partidoGanados + nombreEquipoLocal.partidoPerdidos + nombreEquipoLocal.partidoEmpatados;
                        nombreEquipoVisitante.partidoJugados = nombreEquipoVisitante.partidoGanados + nombreEquipoVisitante.partidoPerdidos + nombreEquipoVisitante.partidoEmpatados;
                    }
                }
            }
        }
    }
}
