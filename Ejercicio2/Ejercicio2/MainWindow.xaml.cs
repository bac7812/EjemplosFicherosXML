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

        bool arriba = true;
        int numero;
        string ano;
        int numeroJornada = 1;
        string ruta = "equipos.txt";
        HashSet<int> nEquipos = new HashSet<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void añadirBoton_Click(object sender, RoutedEventArgs e)
        {
            equipoLocalListBox.Items.Clear();
            equipoVisitanteListBox.Items.Clear();
            Jornada.equipoLocal.Clear();
            Jornada.equipoVisitante.Clear();
            Jornada.partido.Clear();
            nEquipos.Clear();
            numero = 0;
            numeroJornada = 1;
            ano = anadirTemporadaAnoTextBox.Text;

            File.Delete("jornadas" + ano + ".txt");

            Jornada.cargarEquipos(ruta);
            Random random = new Random();

            if (anadirTemporadaAnoTextBox.Text != "")
            {
                while (nEquipos.Count < Jornada.partido.Count)
                {
                    numero = random.Next(0, Jornada.partido.Count);
                    nEquipos.Add(numero);
                }

                for (int eq = 0; eq < nEquipos.Count; eq++)
                {
                    if ((nEquipos.ElementAt(eq) % 2) == 0)
                    {
                        equipoLocalListBox.Items.Add(Jornada.partido[nEquipos.ElementAt(eq)]);
                        Jornada.equipoLocal.AddFirst(Jornada.partido[nEquipos.ElementAt(eq)]);
                    }
                    else
                    {
                        equipoVisitanteListBox.Items.Add(Jornada.partido[nEquipos.ElementAt(eq)]);
                        Jornada.equipoVisitante.AddFirst(Jornada.partido[nEquipos.ElementAt(eq)]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void siguienteBoton_Click(object sender, RoutedEventArgs e)
        {
            string ano = anadirTemporadaAnoTextBox.Text;

            if(anadirTemporadaAnoTextBox.Text != "")
            {
                if (numeroJornada != 8)
                {
                    if (arriba == true)
                    {
                        Jornada.InsertarAlPrincipio();
                        equipoLocalListBox.Items.Clear();
                        for (int l = 0; l < Jornada.equipoLocal.Count; l++)
                        {
                            equipoLocalListBox.Items.Add(Jornada.equipoLocal.ElementAt(l));
                        }
                        arriba = false;
                        NumeroJornadaTextBlock.Text = Convert.ToString(numeroJornada);
                        Jornada.crearTemporada(numeroJornada, ano);
                        numeroJornada++;
                    }
                    else
                    {
                        Jornada.InsertarAlFinal();
                        equipoLocalListBox.Items.Clear();
                        equipoVisitanteListBox.Items.Clear();
                        for (int l = 0; l < Jornada.equipoLocal.Count; l++)
                        {
                            equipoLocalListBox.Items.Add(Jornada.equipoLocal.ElementAt(l));
                        }
                        for (int v = 0; v < Jornada.equipoVisitante.Count; v++)
                        {
                            equipoVisitanteListBox.Items.Add(Jornada.equipoVisitante.ElementAt(v));
                        }
                        arriba = true;
                        NumeroJornadaTextBlock.Text = Convert.ToString(numeroJornada);
                        Jornada.crearTemporada(numeroJornada, ano);
                        numeroJornada++;
                    }
                }
                else
                {
                    MessageBox.Show("Fin de Jornada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Debes introducir el año de la temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void consultarBoton_Click(object sender, RoutedEventArgs e)
        {
            string ano = consultarTemporadaAnoTextBox.Text;

            Jornada.temporada.Clear();

            Jornada.cargarTemporada(ano);

            consultarTemporadaEquiposListBox.Items.Clear();

            if(consultarTemporadaAnoTextBlock.Text != "")
            {
                if(Jornada.temporada.Count != 0)
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
    }
}
