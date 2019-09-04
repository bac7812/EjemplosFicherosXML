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

namespace Ejercicio9
{
    /// <summary>
    /// Lógica de interacción para AlojamientoWindow.xaml
    /// </summary>
    public partial class AlojamientoWindow : Window
    {
        public AlojamientoWindow(Alojamiento alojamiento)
        {
            InitializeComponent();

            idTextBlock.Text = "Codigo: " + alojamiento.Codigo;
            nombreTextBlock.Text = "Nombre: " + alojamiento.Nombre;
            estrellasTextBlock.Text = "Estrellas: " + alojamiento.Estrellas;
            direccionTextBlock.Text = "Dirección: " + alojamiento.Direccion;
            localidadTextBlock.Text = "Localidad: " + alojamiento.Localidad;
            cpTextBlock.Text = "CP: " + alojamiento.CP;
            emailTextBlock.Text = "E-mail: " + alojamiento.Email;
            telefonoTextBlock.Text = "Teléfono: " + alojamiento.Telefono;
            webTextBlock.Text = "Web: " + alojamiento.Web;
            descripcionTextBlock.Text = alojamiento.Descripcion;
            cargarImagenes(alojamiento.Imagenes);
        }

        private void cargarImagenes(List<String> listaImagenes)
        {
            imagenesStackPanel.Children.Clear();

            foreach (var i in listaImagenes)
            {
                Image img = new Image();
                string url = i.Replace("http", "https");
                img.Source = new BitmapImage(new Uri(url));
                img.Height = 200;
                img.Width = 300;
                img.Margin = new Thickness(5);
                img.Stretch = Stretch.UniformToFill;
                imagenesStackPanel.Orientation = Orientation.Horizontal;
                imagenesStackPanel.Children.Add(img);
            }
        }
    }
}
