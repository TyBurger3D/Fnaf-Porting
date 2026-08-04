using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Framework;
using FNAFPorting.ViewModels;

namespace FNAFPorting.Views;

public partial class SettingsView : ViewBase<SettingsViewModel>
{
    public SettingsView()
    {
        InitializeComponent();
        
        Navigation.Settings.Initialize(Sidebar, ContentFrame);
    }

    private void OnItemSelected(object? sender, SidebarItemSelectedArgs e)
    {
        Navigation.Settings.Open(e.Tag);
    }
}