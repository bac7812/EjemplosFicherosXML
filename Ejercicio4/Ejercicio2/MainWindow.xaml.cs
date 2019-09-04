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

namespace Ejercicio2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<FileInfo> listaArchivos = new List<FileInfo>();
        string pathDirectorio = "g:/";
        public MainWindow()
        {
            InitializeComponent();
            string[] Archivos = Directory.GetFiles(pathDirectorio, "*.pdf");
            foreach (string archivos in Archivos)
            {
                FileInfo resultadoArchivos = new FileInfo(archivos);
                listaArchivos.Add(resultadoArchivos);

            }
            listaComboxBox.ItemsSource = listaArchivos;
        }

        private void ListaComboxBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uri uri = new Uri(listaComboxBox.SelectedValue.ToString());
            mostrarWebBrowser.Navigate(uri);
        }
    }
}
