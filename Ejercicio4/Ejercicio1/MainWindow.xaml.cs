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
using System.IO;

namespace Ejercicio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DirectoryInfo> listaDirectorio = new List<DirectoryInfo>();
        
        string pathDirectorio = "g:/curso";
        String pathArchivos;
        public MainWindow()
        {
            InitializeComponent();
            string[] Directorios = Directory.GetDirectories(pathDirectorio, "*");
            foreach (string directorio in Directorios)
            {
                DirectoryInfo resultadoDirectorio = new DirectoryInfo(directorio);
                listaDirectorio.Add(resultadoDirectorio);
            }
            directorioDataGrid.ItemsSource = listaDirectorio;
        }

        private void DirectorioDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DirectoryInfo resultadoDirectorio = (DirectoryInfo) directorioDataGrid.SelectedItem;
                pathArchivos = resultadoDirectorio.FullName;
                string[] Archivos = Directory.GetFiles(pathArchivos, "*");
                List<FileInfo> listaArchivos = new List<FileInfo>();
                foreach (string archivo in Archivos)
                {
                    FileInfo resultadoArchivo = new FileInfo(archivo);
                    listaArchivos.Add(resultadoArchivo);
                }
                archivosDataGrid.ItemsSource = "";
                archivosDataGrid.ItemsSource = listaArchivos;
            }
            catch
            {

            }
        }
    }
}
