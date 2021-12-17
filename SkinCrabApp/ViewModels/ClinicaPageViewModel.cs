using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.DataInjection;
using SkinCrabApp.Models;
using SkinCrabApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
