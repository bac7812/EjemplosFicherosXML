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

namespace Ejercicio4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<DirectoryInfo> listaDirectorio = new List<DirectoryInfo>();
        List<FileInfo> listaArchivos = new List<FileInfo>();
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
            DirectorioDataGrid.ItemsSource = listaDirectorio;
        }

        private void DirectorioDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DirectoryInfo resultadoDirectorio = (DirectoryInfo)DirectorioDataGrid.SelectedItem;
                pathArchivos = resultadoDirectorio.FullName;
                string[] Archivos = Directory.GetFiles(pathArchivos, "*");
                foreach (string archivo in Archivos)
                {
                    FileInfo resultadoArchivo = new FileInfo(archivo);
                    listaArchivos.Add(resultadoArchivo);
                }
                ArchivosDataGrid.ItemsSource = "";
                ArchivosDataGrid.ItemsSource = listaArchivos.ToList();
            }
            catch
            {

            }
        }
    }
}
