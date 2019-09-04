using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio6
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ruta = "libro.xml";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void VerButton_Click(object sender, RoutedEventArgs e)
        {
            DatosDataGrid.ItemsSource = "";
            Datos.leerXML(ruta);
            DatosDataGrid.ItemsSource = Datos.libros;
        }

        private void anadirButton_Click(object sender, RoutedEventArgs e)
        {
            NuevoLibro abrirVentana = new NuevoLibro();
            abrirVentana.Show();
        }
    }
}
