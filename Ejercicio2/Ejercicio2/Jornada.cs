using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Jornada
    {
        public static List<string> partido = new List<string>();

        public static LinkedList<string> equipoLocal = new LinkedList<string>();

        public static LinkedList<string> equipoVisitante = new LinkedList<string>();

        public static List<Partido> jornada = new List<Partido>();

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
            FileStream crearFichero = new FileStream("jornadas" + ano + ".txt", FileMode.Append);
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
    }
}
