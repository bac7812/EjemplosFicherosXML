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

namespace Ejercicio10
{
    /// <summary>
    /// Lógica de interacción para PrediccionesWindow.xaml
    /// </summary>
    public partial class PrediccionesWindow : Window
    {
        public PrediccionesWindow()
        {
            InitializeComponent();
        }

        private void consultarBtton_Click(object sender, RoutedEventArgs e)
        {
            if(fechaDatePicker.Text == "")
            {
                MessageBox.Show("Introduce una fecha", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(fechaDatePicker.Text);

                if (fecha >= DateTime.Today)
                {
                    MessageBox.Show("Ninguna fecha puede ser posterior al día actual", "Aviso", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    Datos.cargarXML(fecha);
                    Datos.cargarNodo();
                    mananaTextBlock.Text = "Mañana: " + Convert.ToString(Datos.meteorologia.TemperaturaManana) + "º";
                    tardeTextBlock.Text = "Tarde: " + Convert.ToString(Datos.meteorologia.TemperaturaTarde) + "º";
                    nocheTextBlock.Text = "Noche: " + Convert.ToString(Datos.meteorologia.TemperaturaNoche) + "º";
                    gradoMinTextBlock.Text = "Grado: " + Convert.ToString(Datos.meteorologia.GradoMin) + "º";
                    denominacionMinTextBlock.Text = "Denominación: " + Datos.meteorologia.DenominacionMin;
                    efectoTierraMinTextBlock.Text = "Efecto en tierra: " + Datos.meteorologia.TierraMin;
                    gradoMaxTextBlock.Text = "Grado: " + Convert.ToString(Datos.meteorologia.GradoMax) + "º";
                    denominacionMaxTextBlock.Text = "Denominación: " + Datos.meteorologia.DenominacionMax;
                    efectoTierraMaxTextBlock.Text = "Efecto en tierra: " + Datos.meteorologia.TierraMax;
                }
            }
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (fechaDatePicker.Text == "")
            {
                MessageBox.Show("Introduce una fecha", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Datos.guardarXML();
                MessageBox.Show("Guardar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
