using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Settings;

namespace FNAFPorting.Views.Settings;

public partial class DeveloperSettingsView : ViewBase<DeveloperSettingsViewModel>
{
    public DeveloperSettingsView() : base(AppSettings.Developer)
    {
        InitializeComponent();
    }
}