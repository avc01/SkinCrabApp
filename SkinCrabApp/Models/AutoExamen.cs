using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkinCrabApp.Models
{
    public class AutoExamen : ObservableObject
    {
        public string HaceCuantoNotoLaLesion { get => _haceCuantoNotoLaLesion; set => SetProperty(ref _haceCuantoNotoLaLesion, value); }

        public string NivelDeCambioTamanoDeLaLesion { get => _nivelDeCambioTamanoDeLaLesion; set => SetProperty(ref _nivelDeCambioTamanoDeLaLesion, value); }

        public bool HinchazonLesion { get => _hinchazonDeLaLesion; set => SetProperty(ref _hinchazonDeLaLesion, value); }

        public bool AumentoTemperaturaDeLaLesion { get => _aumentoTemperaturaDeLaLesion; set => SetProperty(ref _aumentoTemperaturaDeLaLesion, value); }

        public bool EnrojecimientoZonaDeLaLesion { get => _enrojecimientoZonaDeLaLesion; set => SetProperty(ref _enrojecimientoZonaDeLaLesion, value); }

        public bool CambioEnLaTexturaDeLaLesion { get => _cambioEnLaTexturaDeLaLesion; set => SetProperty(ref _cambioEnLaTexturaDeLaLesion, value); }
        
        public string CambioColorDeLaLesion { get => _cambioColorDeLaLesion; set => SetProperty(ref _cambioColorDeLaLesion, value); }

        // Values Auto Examen

        private string _haceCuantoNotoLaLesion;
        private string _nivelDeCambioTamanoDeLaLesion;
        private bool _hinchazonDeLaLesion;
        private bool _aumentoTemperaturaDeLaLesion;
        private bool _enrojecimientoZonaDeLaLesion;
        private bool _cambioEnLaTexturaDeLaLesion;
        private string _cambioColorDeLaLesion;
    }
}
