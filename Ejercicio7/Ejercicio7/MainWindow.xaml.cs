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

namespace Ejercicio7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool arriba = true;
        string ano;
        int numero;
        int numeroJornada = 1;
        string ruta = "equipos.txt";
        HashSet<int> nEquipos = new HashSet<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void anadirButton_Click(object sender, RoutedEventArgs e)
        {
            Jornada.equipoLocal.Clear();
            Jornada.equipoVisitante.Clear();
            Jornada.partido.Clear();
            nEquipos.Clear();
            numero = 0;
            numeroJornada = 1;

            if (TemporadaAnoTextBox.Text != "")
            {
                ano = TemporadaAnoTextBox.Text;
                File.Delete("jornadas" + ano + ".txt");

                Jornada.cargarEquipos(ruta);
                Random random = new Random();

                while (nEquipos.Count < Jornada.partido.Count)
                {
                    numero = random.Next(0, Jornada.partido.Count);
                    nEquipos.Add(numero);
                }

                for (int eq = 0; eq < nEquipos.Count; eq++)
                {
                    if ((nEquipos.ElementAt(eq) % 2) == 0)
                    {
                        Jornada.equipoLocal.AddFirst(Jornada.partido[nEquipos.ElementAt(eq)]);
                    }
                    else
                    {
                        Jornada.equipoVisitante.AddFirst(Jornada.partido[nEquipos.ElementAt(eq)]);
                    }
                }

                while(numeroJornada < 8)
                {
                    if (arriba == true)
                    {
                        Jornada.InsertarAlPrincipio();
                        arriba = false;
                        Jornada.crearTemporada(numeroJornada, ano);
                        numeroJornada++;
                    }
                    else
                    {
                        Jornada.InsertarAlFinal();
                        arriba = true;
                        Jornada.crearTemporada(numeroJornada, ano);
                        numeroJornada++;
                    }
                }
                MessageBox.Show("He guardado correctamente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void consultarButton_Click(object sender, RoutedEventArgs e)
        {
            Jornada.temporada.Clear();

            consultarTemporadaEquiposListBox.Items.Clear();

            if (TemporadaAnoTextBox.Text != "")
            {
                ano = TemporadaAnoTextBox.Text;

                Jornada.cargarTemporada(ano);

                if (Jornada.temporada.Count != 0)
                {
                    for (int t = 0; t < Jornada.temporada.Count; t++)
                    {
                        consultarTemporadaEquiposListBox.Items.Add(Jornada.temporada[t]);
                    }
                }
                else
                {
                    MessageBox.Show("No encuentro lo que buscas", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void registrarButton_Click(object sender, RoutedEventArgs e)
        {
            if (TemporadaAnoTextBox.Text != "")
            {
                ano = TemporadaAnoTextBox.Text;
                RegistrarWindow registrarWindow = new RegistrarWindow(ano);
                registrarWindow.Show();
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void clasificarButton_Click(object sender, RoutedEventArgs e)
        {
            if (TemporadaAnoTextBox.Text != "")
            {
                ano = TemporadaAnoTextBox.Text;
                ClasificarWindow clasificarWindow = new ClasificarWindow(ano);
                clasificarWindow.Show();
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
