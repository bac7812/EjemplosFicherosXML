using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Equipo
    {
        public string equipo { get; set; }
    }
    class Datos
    {
        public static List<Equipo> equipos = new List<Equipo>() {
            new Equipo { equipo = "Alavés" },
            new Equipo { equipo = "Athletic" },
            new Equipo { equipo = "Atlético" },
            new Equipo { equipo = "Barcelona" },
            new Equipo { equipo = "Betis" },
            new Equipo { equipo = "Celta" },
            new Equipo { equipo = "Deportivo" },
            new Equipo { equipo = "Eibar" },
            new Equipo { equipo = "Espanyol" },
            new Equipo { equipo = "Getafe" },
            new Equipo { equipo = "Girona" },
            new Equipo { equipo = "Las Palmas" },
            new Equipo { equipo = "Leganés" },
            new Equipo { equipo = "Levante" },
            new Equipo { equipo = "Malága" },
            new Equipo { equipo = "R. Sociedad" },
            new Equipo { equipo = "R. Madrid" },
            new Equipo { equipo = "Sevilla" },
            new Equipo { equipo = "Valencia" },
            new Equipo { equipo = "Villarreal" },
        };
    }
}
