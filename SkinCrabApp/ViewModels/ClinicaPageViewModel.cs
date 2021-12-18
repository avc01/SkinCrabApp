using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.DataInjection;
using SkinCrabApp.Models;
using SkinCrabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;


namespace SkinCrabApp.ViewModels
{
    public class ClinicaPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Clinica> Clinica { get; set; }
        public AsyncCommand RefreshCommand { get; set; }
        public AsyncCommand<object> SelectedCommand { get; set; }

        private Clinica _selectedClinica;
        public Clinica SelectedClinica
        {
            get => _selectedClinica;
            set => SetProperty(ref _selectedClinica, value);
        }

        public ClinicaPageViewModel()
        {
            Clinica = new ObservableRangeCollection<Clinica>();
            SelectedCommand = new AsyncCommand<object>(Selected);
            RefreshCommand = new AsyncCommand(Refresh);
        }

        private async Task Selected(object args) 
        {
            var clinica = args as Clinica;

            if (clinica is null) return;

            SelectedClinica = null;

            // logica

            if (clinica.Nombre == "Clinica Central")
            {
                await Map.OpenAsync(9.9361650, -84.07070275, new MapLaunchOptions
                {
                    Name = "Clinica Central"
                });
            }
            else if (clinica.Nombre == "Clinica Santa Rita")
            {
                await Map.OpenAsync(9.9298722, -84.0718273, new MapLaunchOptions
                {
                    Name = "Clinica Santa Rita"
                });
            }
            else if (clinica.Nombre == "Clinica Victoria")
            {
                await Map.OpenAsync(9.9321055, -84.0455798, new MapLaunchOptions
                {
                    Name = "Clinica Victoria"
                });
            }
            else if (clinica.Nombre == "Clinica Medi Club")
            {
                await Map.OpenAsync(9.9322544, -84.0801621, new MapLaunchOptions
                {
                    Name = "Clinica Medi Club"
                });
            }
            else if (clinica.Nombre == "Clinica Sin Fronteras")
            {
                await Map.OpenAsync(9.9281204, -84.0854422, new MapLaunchOptions
                {
                    Name = "Clinica Sin Fronteras"
                });
            }


        }

        private async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            Clinica.Clear();

            var clinicas = await SkinCrabService.GetClinicas();

            Clinica.AddRange(clinicas);

            IsBusy = false;
        }
    }
}
