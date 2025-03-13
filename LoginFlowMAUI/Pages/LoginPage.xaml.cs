using LoginFlowMAUI.ViewModels;
using LoginFlowMAUI.Services;

namespace LoginFlowMAUI.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage(AuthService authService)
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(authService);
        }
    }
}
