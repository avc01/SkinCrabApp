﻿using MvvmHelpers;
using MvvmHelpers.Commands;
using SkinCrabApp.Services;
using SkinCrabApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SkinCrabApp.ViewModels
{
    public class RevisionPageViewModel : ObservableObject
    {
        public AsyncCommand TapLogin { get; set; }

        public RevisionPageViewModel()
        {
            TapLogin = new AsyncCommand(LogUser);
        }
        public async Task LogUser()
        {
            await Shell.Current.GoToAsync($"{nameof(CentrosMedicosPage)}");
        }
    }
}
