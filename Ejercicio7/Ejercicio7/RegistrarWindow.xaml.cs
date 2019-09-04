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
using System.Windows.Shapes;
using System.Xml;

namespace Ejercicio7
{
    /// <summary>
    /// Lógica de interacción para RegistarWindow.xaml
    /// </summary>
    public partial class RegistrarWindow : Window
    {
        public static List<Partido> jornada = new List<Partido>();
        string anoTemporada;

        public RegistrarWindow(string ano)
        {
            int l = 0;
            int j = 1;

            InitializeComponent();

            anoTemporada = ano;

            Jornada.cargarTemporada(ano);

            NumTemporadaTextBlock.Text = ano;

            while (l < Jornada.temporada.Count)
            {
                string linea = Jornada.temporada.ElementAt(l);
                if (linea.Equals("Jornada " + j))
                {
                    NumJornadaComboBox.Items.Add("Jornada " + j);
                    j++;
                }
                l++;
            }
        }

        private void NumJornadaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DatosDataGrid.ItemsSource = "";
        }

        private void VerButton_Click(object sender, RoutedEventArgs e)
        {
            int l = 0;

            jornada.Clear();

            while (l < Jornada.temporada.Count)
            {
                string lineaJornada = Jornada.temporada.ElementAt(l);
                if (lineaJornada.Equals("Jornada " + (NumJornadaComboBox.SelectedIndex + 1)))
                {
                    l++;
                    while (l < Jornada.temporada.Count)
                    {
                        if(Jornada.temporada.ElementAt(l) != "")
                        {
                            string lineaEquipos = Jornada.temporada.ElementAt(l);
                            if (!lineaEquipos.Equals("Jornada " + (NumJornadaComboBox.SelectedIndex + 2)))
                            {
                                string[] parteEquipos = lineaEquipos.Split('-');
                                jornada.Add(new Partido { EquipoLocal = parteEquipos[0].TrimStart().TrimEnd(), GolLocal = "0", EquipoVisitante = parteEquipos[1].TrimStart().TrimEnd(), GolVisitante = "0" });
                            }
                            else
                            {
                                break;
                            }
                            l++;
                        }
                    }
                }
                l++;
            }

            DatosDataGrid.ItemsSource = jornada;
        }

        private void AnadirButton_Click(object sender, RoutedEventArgs e)
        {
            int id = 0;
            string ruta = "jornada" + (NumJornadaComboBox.SelectedIndex + 1) + "resultados" + anoTemporada + ".xml";


            if(DatosDataGrid.Items.Count != 0)
            {
                FileStream fichero = new FileStream(ruta, FileMode.Create, FileAccess.Write);
                XmlTextWriter escribir = new XmlTextWriter(fichero, Encoding.Default);
                escribir.Formatting = Formatting.Indented;

                escribir.WriteStartDocument();
                escribir.WriteStartElement("jornada");
                escribir.WriteAttributeString("numero", Convert.ToString(NumJornadaComboBox.SelectedIndex + 1));

                foreach (Partido j in jornada)
                {
                    escribir.WriteStartElement("partido");
                    escribir.WriteAttributeString("id", Convert.ToString(id++));
                    escribir.WriteStartElement("equipo");
                    escribir.WriteAttributeString("juega", "local");
                    escribir.WriteAttributeString("goles", j.GolLocal);
                    escribir.WriteString(j.EquipoLocal);
                    escribir.WriteEndElement();
                    escribir.WriteStartElement("equipo");
                    escribir.WriteAttributeString("juega", "visitante");
                    escribir.WriteAttributeString("goles", j.GolVisitante);
                    escribir.WriteString(j.EquipoVisitante);
                    escribir.WriteEndElement();
                    escribir.WriteEndElement();
                }
                escribir.WriteEndElement();
                escribir.WriteEndDocument();
                escribir.Close();

                MessageBox.Show("He añadido correctamente", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Debes elegir la jornada de esta temporada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
