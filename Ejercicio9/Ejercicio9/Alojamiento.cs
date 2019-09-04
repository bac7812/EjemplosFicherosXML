using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    public class Alojamiento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Web { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Localidad { get; set; }
        public string CP { get; set; }
        public List<string> Imagenes { get; set; }
        public string Estrellas { get; set; }
    }
}
