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

namespace Ejercicio8
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
            Datos.cargarNodo(ruta);
            datosDataGrid.ItemsSource = Datos.libros;
        }

        private void anadirButton_Click(object sender, RoutedEventArgs e)
        {
            AnadirWindow anadirWindow = new AnadirWindow(datosDataGrid);
            anadirWindow.Show();
        }

        private void modificarButton_Click(object sender, RoutedEventArgs e)
        {
            if(datosDataGrid.SelectedItem != null)
            {
                Libro libro = (Libro)datosDataGrid.SelectedItem;
                ModificarWindow modificarWindow = new ModificarWindow(libro, datosDataGrid);
                modificarWindow.Show();
            }
            else
            {
                MessageBox.Show("Debes seleccionar libro", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos.cargarXML(ruta);
            Libro libro = (Libro)datosDataGrid.SelectedItem;
            Datos.eliminarNodo(libro.Codigo, ruta);
            MessageBox.Show("Libro eliminado", "Atención", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            datosDataGrid.ItemsSource = "";
            datosDataGrid.ItemsSource = Datos.libros;
        }

        private void buscarButton_Click(object sender, RoutedEventArgs e)
        {
            if(buscarTextBox.Text != "")
            {
                Datos.buscarNodo(buscarTextBox.Text);

                if (Datos.libros.Count != 0)
                {
                    datosDataGrid.ItemsSource = "";
                    datosDataGrid.ItemsSource = Datos.libros;
                }
                else
                {
                    MessageBox.Show("No encuentro lo que buscas", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir el codigo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
