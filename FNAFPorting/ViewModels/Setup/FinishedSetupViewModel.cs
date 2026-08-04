using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using FNAFPorting.Framework;
using FNAFPorting.Views;

namespace FNAFPorting.ViewModels.Setup;

public partial class FinishedSetupViewModel : ViewModelBase
{
    [RelayCommand]
    public async Task Continue()
    {
        AppSettings.Installation.FinishedSetup = true;
        AppSettings.Application.NextKofiAskDate = DateTime.Today.AddDays(7);
        Navigation.App.Open<HomeView>();
        AppSettings.Save();
    }
}
