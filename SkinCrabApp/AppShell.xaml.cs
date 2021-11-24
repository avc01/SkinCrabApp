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
            Routing.RegisterRoute(nameof(RegistroPage), typeof(RegistroPage));
            Routing.RegisterRoute(nameof(ClinicaPage), typeof(ClinicaPage));
            Routing.RegisterRoute(nameof(AutoExamenPage), typeof(AutoExamenPage));
            Routing.RegisterRoute(nameof(DictamenPage), typeof(DictamenPage));
        }
    }
}
