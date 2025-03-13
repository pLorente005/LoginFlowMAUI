using LoginFlowMAUI.Pages;
using LoginFlowMAUI.Services;

namespace LoginFlowMAUI;

public partial class AppShell : Shell
{
    private readonly AuthService authService;

    public AppShell()
    {
        InitializeComponent();

        authService = new AuthService();

        this.Navigating += OnNavigating;
    }

    private async void OnNavigating(object sender, ShellNavigatingEventArgs e)
    {
        var rutasProtegidas = new[] { nameof(HomePage), nameof(ProfilePage), nameof(ListingPage) };

        if (rutasProtegidas.Any(ruta => e.Target.Location.OriginalString.Contains(ruta)))
        {
            // Comprobación sincrónica del estado (sin delay)
            bool isAuthenticated = Preferences.Default.Get("AuthState", false);

            if (!isAuthenticated)
            {
                e.Cancel();
                await Shell.Current.GoToAsync("//LoginPage");
            }
        }
    }
}
