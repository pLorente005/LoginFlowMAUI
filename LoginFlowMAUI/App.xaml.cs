using LoginFlowMAUI.Pages;

namespace LoginFlowMAUI
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = serviceProvider.GetRequiredService<AppShell>();

            Routing.RegisterRoute(nameof(ListingPage), typeof(ListingPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));

        }
    }
}
