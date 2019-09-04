using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ejercicio6
{
    /// <summary>
    /// Lógica de interacción para NuevoLibro.xaml
    /// </summary>
    public partial class NuevoLibro : Window
    {
        string ruta = "libro.xml";
        public NuevoLibro()
        {
            InitializeComponent();
            Datos.leerXML(ruta);
            CodigoTextBox.Text = Convert.ToString(Datos.libros.Count + 1);
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if(CodigoTextBox.Text != "" && NumEjemplaresTextBox.Text != "" && ISBNTextBox.Text != "" && TituloTextBox.Text != "" && AutorTextBox.Text != "" && DescripcionTextBox.Text != "")
            {
                if (Regex.IsMatch(NumEjemplaresTextBox.Text, @"^[0-9]"))
                {
                    if (Regex.IsMatch(ISBNTextBox.Text, @"^[0-9]{13}"))
                    {
                        Libro libro = new Libro();
                        libro.Codigo = CodigoTextBox.Text;
                        libro.NumEjemplares = NumEjemplaresTextBox.Text;
                        libro.Isbn = ISBNTextBox.Text;
                        libro.Titulo = TituloTextBox.Text;
                        libro.Autor = AutorTextBox.Text;
                        libro.Descripcion = DescripcionTextBox.Text;
                        Datos.libros.Add(libro);
                        File.Delete(ruta);
                        Datos.escribirXML(ruta, Datos.libros);
                        MessageBox.Show("Guardar libro ", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        CodigoTextBox.Text = "";
                        NumEjemplaresTextBox.Text = "";
                        ISBNTextBox.Text = "";
                        TituloTextBox.Text = "";
                        AutorTextBox.Text = "";
                        DescripcionTextBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Introduce trece números en ISBN", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Introduce número de ejemplares", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("No se puedan estar vacíos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CerrarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
