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
    /// Lógica de interacción para ModificarWindow.xaml
    /// </summary>
    public partial class ModificarWindow : Window
    {
        string ruta = "libro.xml";
        DataGrid dg;
        public ModificarWindow(Libro li , DataGrid dataGrid)
        {
            InitializeComponent();

            dg = dataGrid;

            CodigoTextBox.Text = li.Codigo;
            NumEjemplaresTextBox.Text = li.NumEjemplares;
            ISBNTextBox.Text = li.Isbn;
            TituloTextBox.Text = li.Titulo;
            AutorTextBox.Text = li.Autor;
            DescripcionTextBox.Text = li.Descripcion;
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            Datos.cargarXML(ruta);
            Libro libro = Datos.libros.Where(c => c.Codigo.Equals(CodigoTextBox.Text)).FirstOrDefault();
            libro.Codigo = CodigoTextBox.Text;
            libro.NumEjemplares = NumEjemplaresTextBox.Text;
            libro.Isbn = ISBNTextBox.Text;
            libro.Titulo = TituloTextBox.Text;
            libro.Autor = AutorTextBox.Text;
            libro.Descripcion = DescripcionTextBox.Text;
            Datos.modificarNodo(libro, ruta);
            MessageBox.Show("Libro modificado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
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
