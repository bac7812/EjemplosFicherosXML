using Microsoft.Win32;
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
using System.Windows.Forms;
namespace Ejercicio3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathDirectorioOrigen;
        string pathDirectorioDestino;
        List<FileInfo> listaArchivos = new List<FileInfo>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void directorioOrigenButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog abrir = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult resultado = abrir.ShowDialog();

           if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                pathDirectorioOrigen = abrir.SelectedPath;
                directorioOrigenTextBox.Text = pathDirectorioOrigen;
                string[] Archivos = Directory.GetFiles(pathDirectorioOrigen, "*");
                foreach (string archivos in Archivos)
                {
                    directorioOrigenListBox.Items.Add(System.IO.Path.GetFileName(archivos));
                }
            }
        }

        private void directorioDestinoButton_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog abrir = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult resultado = abrir.ShowDialog();

            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                pathDirectorioDestino = abrir.SelectedPath;
                directorioDestinoTextBox.Text = pathDirectorioDestino;
                string[] Archivos = Directory.GetFiles(pathDirectorioDestino, "*");
                foreach (string archivos in Archivos)
                {
                    directorioDestinoListBox.Items.Add(System.IO.Path.GetFileName(archivos));
                }
            }
        }

        private void copiarButton_Click(object sender, RoutedEventArgs e)
        {
            if (directorioOrigenTextBox.Text != "")
            {
                if(directorioDestinoTextBox.Text != "")
                {
                    if (directorioOrigenListBox.SelectedItem != null)
                    {
                        for (int c = 1; c <= directorioOrigenListBox.SelectedItems.Count; c++)
                        {
                            directorioDestinoListBox.Items.Add(directorioOrigenListBox.SelectedItem);
                            string fichero = directorioOrigenListBox.SelectedItem.ToString();
                            string ficheroOrigen = System.IO.Path.Combine(directorioOrigenTextBox.Text, fichero);
                            string ficheroDestino = System.IO.Path.Combine(directorioDestinoTextBox.Text, fichero);
                            System.IO.File.Copy(ficheroOrigen, ficheroDestino, true);
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Debes elegir un archivo origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Debes elegir un directorio destino", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Debes elegir un directorio origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void moverButton_Click(object sender, RoutedEventArgs e)
        {
            if (directorioOrigenTextBox.Text != "")
            {
                if (directorioDestinoTextBox.Text != "")
                {
                    if (directorioOrigenListBox.SelectedItem != null)
                    {
                        for (int c = 1; c <= directorioOrigenListBox.SelectedItems.Count; c++)
                        {
                            string fichero = directorioDestinoListBox.SelectedItem.ToString();
                            string ficheroOrigen = System.IO.Path.Combine(directorioOrigenTextBox.Text, fichero);
                            string ficheroDestino = System.IO.Path.Combine(directorioDestinoTextBox.Text, fichero);
                            if (System.IO.File.Exists(ficheroDestino))
                            {
                                System.IO.File.Delete(ficheroOrigen);
                                directorioOrigenListBox.Items.Remove(directorioOrigenListBox.SelectedItem);
                            }
                            else
                            {
                                System.IO.File.Move(ficheroOrigen, ficheroDestino);
                                directorioDestinoListBox.Items.Add(directorioOrigenListBox.SelectedItem);
                                directorioOrigenListBox.Items.Remove(directorioOrigenListBox.SelectedItem);
                            }
                        }
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Debes elegir un archivo origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("Debes elegir un directorio destino", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Debes elegir un directorio origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (directorioOrigenTextBox.Text != "")
            {
                if (directorioOrigenListBox.SelectedItem != null)
                {
                    string fichero = directorioOrigenListBox.SelectedItem.ToString();
                    string ficheroOrigen = System.IO.Path.Combine(directorioOrigenTextBox.Text, fichero);
                    File.Delete(ficheroOrigen);
                    directorioOrigenListBox.Items.Remove(directorioOrigenListBox.SelectedItem);
                }
                else
                {
                    System.Windows.MessageBox.Show("Debes elegir un archivo origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("Debes elegir un directorio origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void verButton_Click(object sender, RoutedEventArgs e)
        {
            if (directorioOrigenTextBox.Text != "")
            {
                string[] Archivos = Directory.GetFiles(directorioOrigenTextBox.Text, "*");
                foreach (string archivos in Archivos)
                {
                    FileInfo resultadoArchivos = new FileInfo(archivos);
                    listaArchivos.Add(resultadoArchivos);
                }
                directorioArchivosDataGrid.ItemsSource = listaArchivos;
            }
            else
            {
                System.Windows.MessageBox.Show("Debes elegir un directorio origen", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
