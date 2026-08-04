using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using FNAFPorting.Framework;
using FNAFPorting.Views.Setup;

namespace FNAFPorting.ViewModels.Setup;

public partial class OnlineSetupViewModel : ViewModelBase
{
    [RelayCommand]
    public async Task Skip()
    {
        Navigation.Setup.Open<FinishedSetupView>();
    }

    [RelayCommand]
    public async Task SignIn()
    {
        await SupaBase.SignIn();
        Navigation.Setup.Open<FinishedSetupView>();
    }
}
