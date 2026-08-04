using System.Threading;
using Avalonia.Controls;
using FNAFPorting.Controls;
using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Framework;
using FNAFPorting.Services;
using FNAFPorting.ViewModels.Settings;

namespace FNAFPorting.Views.Settings;

public partial class FolderSettingsView : ViewBase<FolderSettingsViewModel>
{
    private readonly EntranceTransition _transition = new();
    private CancellationTokenSource _cts = new();
    
    public FolderSettingsView() : base(AppSettings.ExportSettings.Folder)
    {
        InitializeComponent();
    }

    private void OnItemSelected(object? sender, SidebarItemSelectedArgs e)
    {
        if (e.Tag is not Control control) return;
        
        SectionContent.Content = control;
        
        _cts.Cancel();
        _cts = new CancellationTokenSource();

        SectionContent.Content = control;
        TaskService.RunDispatcher(async () => await _transition.Start(null, SectionContent, true, _cts.Token));
    }
}