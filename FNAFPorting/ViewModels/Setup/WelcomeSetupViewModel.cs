using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using FNAFPorting.Framework;
using FNAFPorting.Views.Setup;
using FNAFPorting.Application;
using Microsoft.Extensions.DependencyInjection;

namespace FNAFPorting.ViewModels.Setup;

public partial class WelcomeSetupViewModel : ViewModelBase
{
    
    [RelayCommand]
    public async Task Continue()
    {
        Navigation.Setup.Open<ApplicationSetupView>();
    }
}
