using LoginFlowMAUI.Services;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace LoginFlowMAUI.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        private readonly AuthService _authService;

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
        }

        public Command LoginCommand => new Command(async () => await ExecuteLoginCommand());

        private async Task ExecuteLoginCommand()
        {
            _authService.Login();
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
