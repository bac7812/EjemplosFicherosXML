using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Ejercicio5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int aC = 0;
        int sC = 1;
        Cliente cliente = new Cliente();
        public MainWindow()
        {
            InitializeComponent();

            Datos.cargarDeserializar();

            GuardarBoton.IsEnabled = false;
            CodigoTextBox.IsEnabled = true;
            RazonSocialTextBox.IsEnabled = false;
            CIFTextBox.IsEnabled = false;
            CompaniaTextBox.IsEnabled = false;
            FechaAltaDataPicker.IsEnabled = false;
            DomicilioTextBox.IsEnabled = false;
            CPTextBox.IsEnabled = false;
            PaisComboBox.IsEnabled = false;
            AutonomiaComboBox.IsEnabled = false;
            ProvinciaComboBox.IsEnabled = false;
            LocalidadComboBox.IsEnabled = false;
            TelefonoTextBox.IsEnabled = false;
            MovilTextBox.IsEnabled = false;
            EmailTextBox.IsEnabled = false;

            for (int c = 0; c < Datos.clientes.Count; c++)
            {
                CodigoTextBox.Text = Datos.clientes.ElementAt(0).Codigo.ToString();
                RazonSocialTextBox.Text = Datos.clientes.ElementAt(0).RazonSocial.ToString();
                CIFTextBox.Text = Datos.clientes.ElementAt(0).CIF.ToString();
                CompaniaTextBox.Text = Datos.clientes.ElementAt(0).Compania.ToString();
                FechaAltaDataPicker.Text = Datos.clientes.ElementAt(0).FechaAlta.ToString();
                DomicilioTextBox.Text = Datos.clientes.ElementAt(0).Domicilio.ToString();
                CPTextBox.Text = Datos.clientes.ElementAt(0).CP.ToString();
                PaisComboBox.Text = Datos.clientes.ElementAt(0).Pais.ToString();
                AutonomiaComboBox.Text = Datos.clientes.ElementAt(0).Autonomia.ToString();
                ProvinciaComboBox.Text = Datos.clientes.ElementAt(0).Provincia.ToString();
                LocalidadComboBox.Text = Datos.clientes.ElementAt(0).Localidad.ToString();
                TelefonoTextBox.Text = Datos.clientes.ElementAt(0).Telefono.ToString();
                MovilTextBox.Text = Datos.clientes.ElementAt(0).Movil.ToString();
                EmailTextBox.Text = Datos.clientes.ElementAt(0).Email.ToString();
            }
        }

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            SiguienteBoton.IsEnabled = true;
            AnteriorBoton.IsEnabled = true;
            GuardarBoton.IsEnabled = false;

            CodigoTextBox.IsEnabled = true;
            RazonSocialTextBox.IsEnabled = false;
            CIFTextBox.IsEnabled = false;
            CompaniaTextBox.IsEnabled = false;
            FechaAltaDataPicker.IsEnabled = false;
            DomicilioTextBox.IsEnabled = false;
            CPTextBox.IsEnabled = false;
            PaisComboBox.IsEnabled = false;
            AutonomiaComboBox.IsEnabled = false;
            ProvinciaComboBox.IsEnabled = false;
            LocalidadComboBox.IsEnabled = false;
            TelefonoTextBox.IsEnabled = false;
            MovilTextBox.IsEnabled = false;
            EmailTextBox.IsEnabled = false;

            if (Regex.IsMatch(CodigoTextBox.Text, @"^[0-9]"))
            {
                cliente = Datos.clientes.Where(c => c.Codigo == Convert.ToUInt32(CodigoTextBox.Text)).FirstOrDefault();

                if (cliente != null)
                {
                    RazonSocialTextBox.Text = "";
                    CIFTextBox.Text = "";
                    CompaniaTextBox.Text = "";
                    FechaAltaDataPicker.Text = "";
                    DomicilioTextBox.Text = "";
                    CPTextBox.Text = "";
                    PaisComboBox.Text = "";
                    AutonomiaComboBox.Text = "";
                    ProvinciaComboBox.Text = "";
                    LocalidadComboBox.Text = "";
                    TelefonoTextBox.Text = "";
                    MovilTextBox.Text = "";
                    EmailTextBox.Text = "";
                    RazonSocialTextBox.Text = cliente.RazonSocial;
                    CIFTextBox.Text = cliente.CIF;
                    CompaniaTextBox.Text = cliente.Compania;
                    FechaAltaDataPicker.Text = cliente.FechaAlta;
                    DomicilioTextBox.Text = cliente.Domicilio;
                    CPTextBox.Text = cliente.CP.ToString();
                    PaisComboBox.Text = cliente.Pais;
                    AutonomiaComboBox.Text = cliente.Autonomia;
                    ProvinciaComboBox.Text = cliente.Provincia;
                    LocalidadComboBox.Text = cliente.Localidad;
                    TelefonoTextBox.Text = cliente.Telefono.ToString();
                    MovilTextBox.Text = cliente.Movil.ToString();
                    EmailTextBox.Text = cliente.Email;
                    sC = Convert.ToInt32(CodigoTextBox.Text) - 1;
                    sC = sC + 1;
                    aC = Convert.ToInt32(CodigoTextBox.Text) - 2;
                }
                else
                {
                    MessageBox.Show("No encontrado datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduce un número de código", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            BuscarBoton.IsEnabled = false;
            SiguienteBoton.IsEnabled = false;
            AnteriorBoton.IsEnabled = false;
            GuardarBoton.IsEnabled = true;
            CodigoTextBox.Text = Convert.ToString(Datos.clientes.Count + 1);
            RazonSocialTextBox.Text = "";
            CIFTextBox.Text = "";
            CompaniaTextBox.Text = "";
            FechaAltaDataPicker.Text = "";
            DomicilioTextBox.Text = "";
            CPTextBox.Text = "";
            PaisComboBox.Text = "";
            AutonomiaComboBox.Text = "";
            ProvinciaComboBox.Text = "";
            LocalidadComboBox.Text = "";
            TelefonoTextBox.Text = "";
            MovilTextBox.Text = "";
            EmailTextBox.Text = "";
            CodigoTextBox.IsEnabled = false;
            RazonSocialTextBox.IsEnabled = true;
            CIFTextBox.IsEnabled = true;
            CompaniaTextBox.IsEnabled = true;
            FechaAltaDataPicker.IsEnabled = true;
            DomicilioTextBox.IsEnabled = true;
            CPTextBox.IsEnabled = true;
            PaisComboBox.IsEnabled = true;
            AutonomiaComboBox.IsEnabled = true;
            ProvinciaComboBox.IsEnabled = true;
            LocalidadComboBox.IsEnabled = true;
            TelefonoTextBox.IsEnabled = true;
            MovilTextBox.IsEnabled = true;
            EmailTextBox.IsEnabled = true;
        }

        private void ModificarBoton_Click(object sender, RoutedEventArgs e)
        {
            BuscarBoton.IsEnabled = false;
            SiguienteBoton.IsEnabled = false;
            AnteriorBoton.IsEnabled = false;
            GuardarBoton.IsEnabled = true;
            CodigoTextBox.IsEnabled = false;
            RazonSocialTextBox.IsEnabled = true;
            CIFTextBox.IsEnabled = true;
            CompaniaTextBox.IsEnabled = true;
            FechaAltaDataPicker.IsEnabled = true;
            DomicilioTextBox.IsEnabled = true;
            CPTextBox.IsEnabled = true;
            PaisComboBox.IsEnabled = true;
            AutonomiaComboBox.IsEnabled = true;
            ProvinciaComboBox.IsEnabled = true;
            LocalidadComboBox.IsEnabled = true;
            TelefonoTextBox.IsEnabled = true;
            MovilTextBox.IsEnabled = true;
            EmailTextBox.IsEnabled = true;
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            SiguienteBoton.IsEnabled = false;
            AnteriorBoton.IsEnabled = false;
            GuardarBoton.IsEnabled = true;
            Datos.clientes.Remove(cliente);
            Datos.cargarSerializer();
            CodigoTextBox.Text = "";
            RazonSocialTextBox.Text = "";
            CIFTextBox.Text = "";
            CompaniaTextBox.Text = "";
            FechaAltaDataPicker.Text = "";
            DomicilioTextBox.Text = "";
            CPTextBox.Text = "";
            PaisComboBox.Text = "";
            AutonomiaComboBox.Text = "";
            ProvinciaComboBox.Text = "";
            LocalidadComboBox.Text = "";
            TelefonoTextBox.Text = "";
            MovilTextBox.Text = "";
            EmailTextBox.Text = "";
            CodigoTextBox.IsEnabled = true;
            RazonSocialTextBox.IsEnabled = false;
            CIFTextBox.IsEnabled = false;
            CompaniaTextBox.IsEnabled = false;
            FechaAltaDataPicker.IsEnabled = false;
            DomicilioTextBox.IsEnabled = false;
            CPTextBox.IsEnabled = false;
            PaisComboBox.IsEnabled = false;
            AutonomiaComboBox.IsEnabled = false;
            ProvinciaComboBox.IsEnabled = false;
            LocalidadComboBox.IsEnabled = false;
            TelefonoTextBox.IsEnabled = false;
            MovilTextBox.IsEnabled = false;
            EmailTextBox.IsEnabled = false;
            MessageBox.Show("Eliminar datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void AnteriorBoton_Click(object sender, RoutedEventArgs e)
        {
            if(aC != -1)
            {
                if (aC < Datos.clientes.Count)
                {
                    CodigoTextBox.Text = Datos.clientes.ElementAt(aC).Codigo.ToString();
                    RazonSocialTextBox.Text = Datos.clientes.ElementAt(aC).RazonSocial.ToString();
                    CIFTextBox.Text = Datos.clientes.ElementAt(aC).CIF.ToString();
                    CompaniaTextBox.Text = Datos.clientes.ElementAt(aC).Compania;
                    FechaAltaDataPicker.Text = Datos.clientes.ElementAt(aC).FechaAlta;
                    DomicilioTextBox.Text = Datos.clientes.ElementAt(aC).Domicilio;
                    CPTextBox.Text = Datos.clientes.ElementAt(aC).CP.ToString();
                    PaisComboBox.Text = Datos.clientes.ElementAt(aC).Pais;
                    AutonomiaComboBox.Text = Datos.clientes.ElementAt(aC).Autonomia;
                    ProvinciaComboBox.Text = Datos.clientes.ElementAt(aC).Provincia;
                    LocalidadComboBox.Text = Datos.clientes.ElementAt(aC).Localidad;
                    TelefonoTextBox.Text = Datos.clientes.ElementAt(aC).Telefono.ToString();
                    MovilTextBox.Text = Datos.clientes.ElementAt(aC).Movil.ToString();
                    EmailTextBox.Text = Datos.clientes.ElementAt(aC).Email;
                    aC--;
                }
            }
            else
            {
                MessageBox.Show("No encontrado datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sC = aC + 2;

        }

        private void SiguienteBoton_Click(object sender, RoutedEventArgs e)
        {
            if (sC < Datos.clientes.Count)
            {
                CodigoTextBox.Text = Datos.clientes.ElementAt(sC).Codigo.ToString();
                RazonSocialTextBox.Text = Datos.clientes.ElementAt(sC).RazonSocial;
                CIFTextBox.Text = Datos.clientes.ElementAt(sC).CIF.ToString();
                CompaniaTextBox.Text = Datos.clientes.ElementAt(sC).Compania;
                FechaAltaDataPicker.Text = Datos.clientes.ElementAt(sC).FechaAlta;
                DomicilioTextBox.Text = Datos.clientes.ElementAt(sC).Domicilio;
                CPTextBox.Text = Datos.clientes.ElementAt(sC).CP.ToString();
                PaisComboBox.Text = Datos.clientes.ElementAt(sC).Pais;
                AutonomiaComboBox.Text = Datos.clientes.ElementAt(sC).Autonomia;
                ProvinciaComboBox.Text = Datos.clientes.ElementAt(sC).Provincia;
                LocalidadComboBox.Text = Datos.clientes.ElementAt(sC).Localidad;
                TelefonoTextBox.Text = Datos.clientes.ElementAt(sC).Telefono.ToString();
                MovilTextBox.Text = Datos.clientes.ElementAt(sC).Movil.ToString();
                EmailTextBox.Text = Datos.clientes.ElementAt(sC).Email;
                sC++;
            }
            else
            {
                MessageBox.Show("No encontrado datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            aC = sC - 2;
        }

        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            SiguienteBoton.IsEnabled = true;
            AnteriorBoton.IsEnabled = true;
            GuardarBoton.IsEnabled = false;

            cliente = Datos.clientes.Where(c => c.Codigo == Convert.ToUInt32(CodigoTextBox.Text)).FirstOrDefault();

            if (cliente != null)
            {
                if (RazonSocialTextBox.Text != "" && CIFTextBox.Text != "" && DomicilioTextBox.Text != "" && CPTextBox.Text != "" && PaisComboBox.Text != "" && AutonomiaComboBox.Text != "" && ProvinciaComboBox.Text != "" && LocalidadComboBox.Text != "" && LocalidadComboBox.Text != "" && TelefonoTextBox.Text != "" && MovilTextBox.Text != "" && EmailTextBox.Text != "")
                {
                    if (Regex.IsMatch(CIFTextBox.Text, @"^[A-Z]{1}[0-9]"))
                    {
                        if (Regex.IsMatch(CPTextBox.Text, @"^[0-9]{5}"))
                        {
                            if (Regex.IsMatch(TelefonoTextBox.Text, @"^[0-9]{9}"))
                            {
                                if (Regex.IsMatch(MovilTextBox.Text, @"^[0-9]{9}"))
                                {
                                    if (Regex.IsMatch(EmailTextBox.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                                    {
                                        cliente.RazonSocial = RazonSocialTextBox.Text;
                                        cliente.CIF = CIFTextBox.Text;
                                        cliente.Compania = CompaniaTextBox.Text;
                                        cliente.FechaAlta = FechaAltaDataPicker.Text;
                                        cliente.Domicilio = DomicilioTextBox.Text;
                                        cliente.CP = Convert.ToInt32(CPTextBox.Text);
                                        cliente.Pais = PaisComboBox.Text;
                                        cliente.Autonomia = AutonomiaComboBox.Text;
                                        cliente.Provincia = ProvinciaComboBox.Text;
                                        cliente.Localidad = LocalidadComboBox.Text;
                                        cliente.Telefono = Convert.ToInt32(TelefonoTextBox.Text);
                                        cliente.Movil = Convert.ToInt32(MovilTextBox.Text);
                                        cliente.Email = EmailTextBox.Text;
                                        Datos.cargarSerializer();
                                        MessageBox.Show("Guardar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                                        CodigoTextBox.IsEnabled = true;
                                        RazonSocialTextBox.IsEnabled = false;
                                        CIFTextBox.IsEnabled = false;
                                        CompaniaTextBox.IsEnabled = false;
                                        FechaAltaDataPicker.IsEnabled = false;
                                        DomicilioTextBox.IsEnabled = false;
                                        CPTextBox.IsEnabled = false;
                                        PaisComboBox.IsEnabled = false;
                                        AutonomiaComboBox.IsEnabled = false;
                                        ProvinciaComboBox.IsEnabled = false;
                                        LocalidadComboBox.IsEnabled = false;
                                        TelefonoTextBox.IsEnabled = false;
                                        MovilTextBox.IsEnabled = false;
                                        EmailTextBox.IsEnabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Introduce E-mail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Introduce nueve números en móvil", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introduce nueve números en teléfono", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduce cinco números en CP", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduce una letra y ocho números en CIF", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puedan estar vacíos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                if (RazonSocialTextBox.Text != "" && CIFTextBox.Text != "" && DomicilioTextBox.Text != "" && CPTextBox.Text != "" && PaisComboBox.Text != "" && AutonomiaComboBox.Text != "" && ProvinciaComboBox.Text != "" && LocalidadComboBox.Text != "" && LocalidadComboBox.Text != "" && TelefonoTextBox.Text != "" && MovilTextBox.Text != "" && EmailTextBox.Text != "")
                {
                    if (Regex.IsMatch(CIFTextBox.Text, @"^[A-Z]{1}[0-9]"))
                    {
                        if (Regex.IsMatch(CPTextBox.Text, @"^[0-9]{5}"))
                        {
                            if (Regex.IsMatch(TelefonoTextBox.Text, @"^[0-9]{9}"))
                            {
                                if (Regex.IsMatch(MovilTextBox.Text, @"^[0-9]{9}"))
                                {
                                    if (Regex.IsMatch(EmailTextBox.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                                    {
                                        Cliente nuevoCliente = new Cliente();
                                        nuevoCliente.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                                        nuevoCliente.RazonSocial = RazonSocialTextBox.Text;
                                        nuevoCliente.CIF = CIFTextBox.Text;
                                        nuevoCliente.Compania = CompaniaTextBox.Text;
                                        nuevoCliente.FechaAlta = FechaAltaDataPicker.Text;
                                        nuevoCliente.Domicilio = DomicilioTextBox.Text;
                                        nuevoCliente.CP = Convert.ToInt32(CPTextBox.Text);
                                        nuevoCliente.Pais = PaisComboBox.Text;
                                        nuevoCliente.Autonomia = AutonomiaComboBox.Text;
                                        nuevoCliente.Provincia = ProvinciaComboBox.Text;
                                        nuevoCliente.Localidad = LocalidadComboBox.Text;
                                        nuevoCliente.Telefono = Convert.ToInt32(TelefonoTextBox.Text);
                                        nuevoCliente.Movil = Convert.ToInt32(MovilTextBox.Text);
                                        nuevoCliente.Email = EmailTextBox.Text;
                                        Datos.clientes.Add(nuevoCliente);
                                        Datos.cargarSerializer();
                                        MessageBox.Show("Guardar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                                        CodigoTextBox.IsEnabled = true;
                                        RazonSocialTextBox.IsEnabled = false;
                                        CIFTextBox.IsEnabled = false;
                                        CompaniaTextBox.IsEnabled = false;
                                        FechaAltaDataPicker.IsEnabled = false;
                                        DomicilioTextBox.IsEnabled = false;
                                        CPTextBox.IsEnabled = false;
                                        PaisComboBox.IsEnabled = false;
                                        AutonomiaComboBox.IsEnabled = false;
                                        ProvinciaComboBox.IsEnabled = false;
                                        LocalidadComboBox.IsEnabled = false;
                                        TelefonoTextBox.IsEnabled = false;
                                        MovilTextBox.IsEnabled = false;
                                        EmailTextBox.IsEnabled = false;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Introduce E-mail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Introduce nueve números en móvil", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Introduce nueve números en teléfono", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Introduce cinco números en CP", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Introduce una letra y ocho números en CIF", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se puedan estar vacíos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void CancelarBoton_Click(object sender, RoutedEventArgs e)
        {
            BuscarBoton.IsEnabled = true;
            SiguienteBoton.IsEnabled = false;
            AnteriorBoton.IsEnabled = false;
            GuardarBoton.IsEnabled = false;

            CodigoTextBox.Text = "";
            RazonSocialTextBox.Text = "";
            CIFTextBox.Text = "";
            CompaniaTextBox.Text = "";
            FechaAltaDataPicker.Text = "";
            DomicilioTextBox.Text = "";
            CPTextBox.Text = "";
            PaisComboBox.Text = "";
            AutonomiaComboBox.Text = "";
            ProvinciaComboBox.Text = "";
            LocalidadComboBox.Text = "";
            TelefonoTextBox.Text = "";
            MovilTextBox.Text = "";
            EmailTextBox.Text = "";

            CodigoTextBox.IsEnabled = true;
            RazonSocialTextBox.IsEnabled = false;
            CIFTextBox.IsEnabled = false;
            CompaniaTextBox.IsEnabled = false;
            FechaAltaDataPicker.IsEnabled = false;
            DomicilioTextBox.IsEnabled = false;
            CPTextBox.IsEnabled = false;
            PaisComboBox.IsEnabled = false;
            AutonomiaComboBox.IsEnabled = false;
            ProvinciaComboBox.IsEnabled = false;
            LocalidadComboBox.IsEnabled = false;
            TelefonoTextBox.IsEnabled = false;
            MovilTextBox.IsEnabled = false;
            EmailTextBox.IsEnabled = false;
        }
    }
}