using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Settings;

namespace FNAFPorting.Views.Settings;

public partial class ApplicationSettingsView : ViewBase<ApplicationSettingsViewModel>
{
    public ApplicationSettingsView() : base(AppSettings.Application)
    {
        InitializeComponent();
    }
}