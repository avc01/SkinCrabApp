using SkinCrabApp.Views;
using Xamarin.Forms;

namespace SkinCrabApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
            Routing.RegisterRoute(nameof(RegistroPage), typeof(RegistroPage));
            Routing.RegisterRoute(nameof(ClinicaPage), typeof(ClinicaPage));
            Routing.RegisterRoute(nameof(AutoExamenPage), typeof(AutoExamenPage));
            Routing.RegisterRoute(nameof(DictamenPage), typeof(DictamenPage));
            Routing.RegisterRoute(nameof(DictamenUnoPage), typeof(DictamenUnoPage));
            Routing.RegisterRoute(nameof(DictamenDosPage), typeof(DictamenDosPage));
            Routing.RegisterRoute(nameof(DictamenTresPage), typeof(DictamenTresPage));
            Routing.RegisterRoute(nameof(DeteccionPage), typeof(DeteccionPage));
            Routing.RegisterRoute(nameof(RevisionPage), typeof(RevisionPage));
            Routing.RegisterRoute(nameof(CentrosMedicosPage), typeof(CentrosMedicosPage));
            Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
        }
    }
}
