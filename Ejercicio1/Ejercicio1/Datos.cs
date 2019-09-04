using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Datos
    {
        public static List<Frase> frases = new List<Frase>();
        public void cargarFrases(string ruta)
        {
            if (File.Exists(ruta))
            {
                StreamReader leer = new StreamReader(ruta, Encoding.Default, true);
                while (!leer.EndOfStream)
                {
                    string linea = leer.ReadLine();
                    string[] partes = linea.Split('-');
                    frases.Add(new Frase { frase = partes[0].TrimStart().TrimEnd(), autor = partes[1].TrimStart().TrimEnd() });
                }
                leer.Close();
            }
        }
    }
}
