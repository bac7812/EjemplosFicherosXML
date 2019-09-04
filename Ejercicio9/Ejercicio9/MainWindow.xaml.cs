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

namespace Ejercicio9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Datos.cargarXML();

            if (Datos.mensaje == null)
            {
                Datos.cargarNodo();
                datosDataGrid.ItemsSource = Datos.alojamientos.Select(a => new { a.Nombre }).ToList();
            }
            else
            {
                MessageBox.Show(Datos.mensaje, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
        }

        private void consultarButton_Click(object sender, RoutedEventArgs e)
        {
            if (datosDataGrid.SelectedItem != null)
            {
                Alojamiento alojamiento = (Alojamiento)Datos.alojamientos[datosDataGrid.SelectedIndex];
                AlojamientoWindow alojamientoWindow = new AlojamientoWindow(alojamiento);
                alojamientoWindow.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar alojamiento", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
