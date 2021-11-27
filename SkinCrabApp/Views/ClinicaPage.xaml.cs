using SkinCrabApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkinCrabApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClinicaPage : ContentPage
    {
        public IList<Clinica> Clinicas
        {
            get; private set;
        }
        public ClinicaPage()
        {
            InitializeComponent();
            Clinicas = new List<Clinica>();

            Clinicas.Add(new Clinica
            {
                Nombre = "Clinica Central",
                Telefono = "+50622560907",
                Direccion = "San José",
                Url = "https://lh5.googleusercontent.com/p/AF1QipPOUqN6-Rk_vEQ8BoaK3Cw6qmN3I0vPPDVsM-DF=w408-h306-k-no"
            });

            Clinicas.Add(new Clinica
            {
                Nombre = "Clinica Santa Rita",
                Telefono = "+50622216433",
                Direccion = "San José",
                Url = "https://lh5.googleusercontent.com/p/AF1QipNVIRN5WATBeDoSXrOE5PM5Bpixvnb85igsyMfJ=w426-h240-k-no"
            });

            Clinicas.Add(new Clinica
            {
                Nombre = "Clinica Victoria",
                Telefono = "+50640001054",
                Direccion = "San José",
                Url = "https://lh5.googleusercontent.com/p/AF1QipMCpPWn3pL5mdsxaoSjDJxGfflKzWO6CH7ICBW4=w408-h500-k-no"
            });

            Clinicas.Add(new Clinica
            {
                Nombre = "Clinica Medi Club",
                Telefono = "+50650045001",
                Direccion = "San José",
                Url = "https://lh5.googleusercontent.com/p/AF1QipOFYOfGHQ3GqcX9yesIHkUq2wPH-gR1lbG6TQfg=w408-h408-k-no"
            });

            Clinicas.Add(new Clinica
            {
                Nombre = "Clinica Sin Fronteras",
                Telefono = "+50622226285",
                Direccion = "La Sabana",
                Url = "https://lh3.googleusercontent.com/proxy/v5CnSSwnBbbRgpqYGNSwYNhJWap0_jbFTPcWjSQDXPbOwfsbWuxrSFy4YamX7_awL7ImCzYo8dapy31jGmxEWLXNBE46eYMN1nKU3A"
            });



            BindingContext = this;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Clinica selectedItem = e.SelectedItem as Clinica;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Clinica tappedItem = e.Item as Clinica;
        }
    }
    }
