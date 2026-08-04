using System;
using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Framework;
using FNAFPorting.ViewModels;
using FNAFPorting.Exporting.Models;

namespace FNAFPorting.Views;

public partial class ExportSettingsView : ViewBase<ExportSettingsViewModel>
{
    public ExportSettingsView() : base(AppSettings.ExportSettings)
    {
        InitializeComponent();
        Navigation.ExportSettings.Initialize(Sidebar, ContentFrame);
        Navigation.ExportSettings.AddTypeResolver<EExportLocation>(location =>
        {
            var name = location.IsFolder ? "Folder" : location.ToString();
            var viewName = $"FNAFPorting.Views.Settings.{name}SettingsView";
        
            var type = Type.GetType(viewName);
            return type;
        });
        
        Navigation.ExportSettings.Open(EExportLocation.Blender);
        
    }
    

    private void OnItemSelected(object? sender, SidebarItemSelectedArgs e)
    {
        if (e.Tag is not EExportLocation exportLocation) return;
        
        Navigation.ExportSettings.Open(exportLocation);
    }
}