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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aF = 0;
        int sF = 0;
        Datos datos = new Datos();
        Frase frase = new Frase();
        string ruta = "frases.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SeleccionarButton_Click(object sender, RoutedEventArgs e)
        {
            NombreArchivoTextBox.Text = ruta;
        }

        private void VerButton_Click(object sender, RoutedEventArgs e)
        {
            if (NombreArchivoTextBox.Text != "")
            {
                datos.cargarFrases(NombreArchivoTextBox.Text);
                FrasesCelebresDataGrid.ItemsSource = "";
                FrasesCelebresDataGrid.ItemsSource = Datos.frases;
            }
            else
            {
                MessageBox.Show("Debes elegir un nombre de archivo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            if(BuscarAutorTextBox.Text != "")
            {
                frase = Datos.frases.Where(b => b.autor.Equals(BuscarAutorTextBox.Text)).FirstOrDefault();
                if(frase != null)
                {
                    List<Frase> mostrarFraseAutor = new List<Frase>();
                    mostrarFraseAutor.Add(frase);
                    FrasesCelebresDataGrid.ItemsSource = "";
                    FrasesCelebresDataGrid.ItemsSource = mostrarFraseAutor;
                }
                else
                {
                    MessageBox.Show("No encuentro lo que buscas", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir el autor para buscar", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AñadirButton_Click(object sender, RoutedEventArgs e)
        {
            if (NombreArchivoTextBox.Text != "")
            {
                if (NuevaFraseTextBox.Text != "" || NuevoAutorTextBox.Text != "")
                {
                    frase.frase = NuevaFraseTextBox.Text;
                    frase.autor = NuevoAutorTextBox.Text;
                    Datos.frases.Add(frase);
                    FrasesCelebresDataGrid.ItemsSource = "";
                    FrasesCelebresDataGrid.ItemsSource = Datos.frases;
                    MessageBox.Show("Guardar la frase y el autor", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Debes introducir la frase y el autor para añadir", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes elegir un nombre de archivo", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }   
        }

        private void AnteriorButton_Click(object sender, RoutedEventArgs e)
        {
            int aL = 0;

            List<Frase> mostrarFrase = new List<Frase>();


            FrasesCelebresDataGrid.ItemsSource = "";

            if(aF != 10)
            {
                aF = aF - 10;
            }
            else
            {
                aF = aF - 10;
            }

            while (aF < Datos.frases.Count && aL != 10)
            {
                mostrarFrase.Add(Datos.frases[aF]);
                aF++;
                aL++;
            }

            if (mostrarFrase.Count == 10)
            {
                FrasesCelebresDataGrid.ItemsSource = mostrarFrase;
                aF = aF - 10;
                sF = sF - 10;
            }
        }


        private void SiguienteButton_Click(object sender, RoutedEventArgs e)
        {
            int sL = 0;

            List<Frase> mostrarFrase = new List<Frase>();

            FrasesCelebresDataGrid.ItemsSource = "";

            while (sF < Datos.frases.Count && sL != 10)
            {
                mostrarFrase.Add(Datos.frases[sF]);
                sF++;
                sL++;
            }

            if (mostrarFrase.Count == 10)
            {
                FrasesCelebresDataGrid.ItemsSource = mostrarFrase;
                aF = sF - 10;
                
            }
            else
            {
                FrasesCelebresDataGrid.ItemsSource = mostrarFrase;
                MessageBox.Show("Se acabo la lista", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                aF = sF - mostrarFrase.Count;
            }
        }
    }
}
