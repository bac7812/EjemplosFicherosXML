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
using System.Windows.Shapes;

namespace Ejercicio8
{
    /// <summary>
    /// Lógica de interacción para AnadirWindow.xaml
    /// </summary>
    public partial class AnadirWindow : Window
    {
        string ruta = "libro.xml";
        DataGrid dg;
        public AnadirWindow(DataGrid dataGrid)
        {
            InitializeComponent();
            CodigoTextBox.Text = Convert.ToString(Datos.libros.Count()+1);
            dg = dataGrid;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos.cargarXML(ruta);
            Libro libro = new Libro();
            libro.Codigo = CodigoTextBox.Text;
            libro.NumEjemplares = NumEjemplaresTextBox.Text;
            libro.Isbn = ISBNTextBox.Text;
            libro.Titulo = TituloTextBox.Text;
            libro.Autor = AutorTextBox.Text;
            libro.Descripcion = DescripcionTextBox.Text;
            Datos.AnadirNodo(libro, ruta);
            MessageBox.Show("Libro guardado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            dg.ItemsSource = "";
            dg.ItemsSource = Datos.libros;
            Close();
        }

        private void CerrarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
