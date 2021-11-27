using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Helpers;
using SkinCrabApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SkinCrabApp.ViewModels
{
    public class AutoExamenViewModel : ObservableObject
    {
        public AsyncCommand<AutoExamen> TapSubmit { get; set; }

        public AutoExamen AutoExamenCommand { get; set; }

        public AutoExamenViewModel()
        {
            TapSubmit = new AsyncCommand<AutoExamen>(SaveUserAutoExam);

            AutoExamenCommand = new AutoExamen();
        }

        public async Task SaveUserAutoExam(AutoExamen autoExamen) 
        {
            if (FieldsEmpty(autoExamen))
            {
                await Application.Current.MainPage.DisplayAlert("Atencion", "faltan datos o hay datos erroneos", "ok");
                return;
            }

            await Application.Current.MainPage.DisplayAlert("Notificacion", "auto examen completado exitosamente", "ok");
            await DataFile.SaveUserAutoExamToFileAsync(autoExamen);
            await CleanFieldsAsync();
        }

        public async Task CleanFieldsAsync()
        {
            await Task.Run(() =>
            {
                foreach (var item in AutoExamenCommand.GetType().GetProperties())
                {
                    item.SetValue(AutoExamenCommand, default);
                }
            });
        }

        public bool FieldsEmpty(AutoExamen autoExamen)
        {
            if (string.IsNullOrWhiteSpace(autoExamen.HaceCuantoNotoLaLesion) || 
                string.IsNullOrWhiteSpace(autoExamen.NivelDeCambioTamanoDeLaLesion) ||
                string.IsNullOrWhiteSpace(autoExamen.CambioColorDeLaLesion))
            {
                return true;
            }

            if (int.Parse(autoExamen.NivelDeCambioTamanoDeLaLesion) < 0 || int.Parse(autoExamen.NivelDeCambioTamanoDeLaLesion) > 10)
            {
                return true;
            }

            return false;
        }
    }
}
