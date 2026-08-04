using System;
using Avalonia.Controls;
using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Framework;
using FNAFPorting.Services;
using AppWindowModel = FNAFPorting.WindowModels.AppWindowModel;

namespace FNAFPorting.Windows;

public partial class AppWindow : WindowBase<AppWindowModel>
{
    public AppWindow() : base(initializeWindowModel: false)
    {
        InitializeComponent();
        DataContext = WindowModel;
        
        Navigation.App.Initialize(Sidebar, ContentFrame);
        
        KeyDownEvent.AddClassHandler<TopLevel>((sender, args) => BlackHole.HandleKey(args.Key), handledEventsToo: true);

        WindowModel.SupaBase.LevelUp += (sender, level) =>
        {
            TaskService.RunDispatcher(async () => await LevelUpOverlay.ShowLevelUp(level));
        };
    }

    private void OnSidebarItemSelected(object? sender, SidebarItemSelectedArgs args)
    {
        if (!AppSettings.Installation.FinishedSetup) return;
        
        Navigation.App.Open(args.Tag);
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);

        App.Lifetime.Shutdown();
    }
}