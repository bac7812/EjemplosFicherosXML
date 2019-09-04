using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Ejercicio7
{
    /// <summary>
    /// Lógica de interacción para clasificarWindow.xaml
    /// </summary>
    public partial class ClasificarWindow : Window
    {
        public ClasificarWindow(string ano)
        {
            InitializeComponent();

            Jornada.clasificacion.Clear();

            DatosDataGrid.ItemsSource = "";

            Jornada.cargarJornadas(ano);

            NumTemporadaTextBlock.Text = ano;

            DatosDataGrid.ItemsSource = Jornada.clasificacion.OrderByDescending(c => c.partidoPuntos);
        }
    }
}
