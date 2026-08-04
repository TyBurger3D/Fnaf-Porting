using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Settings;

namespace FNAFPorting.Views.Settings;

public partial class AccountSettingsView : ViewBase<AccountSettingsViewModel>
{
    public AccountSettingsView() : base(AppSettings.Account)
    {
        InitializeComponent();
    }
}