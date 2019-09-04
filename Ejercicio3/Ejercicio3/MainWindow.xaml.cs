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

namespace Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "g:/curso";
        public MainWindow()
        {
            InitializeComponent();
            string[] Directorios = Directory.GetDirectories(path, "*");
            foreach (string directorio in Directorios)
            {
                DirectorioListBox.Items.Add(directorio);
            }
        }
    }
}
