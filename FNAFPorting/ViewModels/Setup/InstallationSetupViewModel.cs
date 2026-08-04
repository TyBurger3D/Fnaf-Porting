using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FNAFPorting.Framework;
using FNAFPorting.Models.Installation;
using FNAFPorting.Views.Setup;
using FNAFPorting.Services;
using Newtonsoft.Json;
using Serilog;

namespace FNAFPorting.ViewModels.Setup;

public partial class InstallationSetupViewModel : ViewModelBase
{
    [ObservableProperty] private InstallationProfile _profile = new()
    {
        ProfileName = "Default",
        ArchiveDirectory = string.Empty,
        IsSelected = true
    };
    
    public override async Task Initialize()
    {
        AppSettings.Installation.Profiles.Clear();
        
        await CheckForInstallation();
    }

    private async Task CheckForInstallation()
    {
        // Steam/Epic auto-detect for FNAF titles is not wired; user sets archive path manually.
        await Task.CompletedTask;
    }
    
    [RelayCommand]
    public async Task Continue()
    {
        AppSettings.Installation.Profiles.Add(Profile);
        
        Navigation.Setup.Open<OnlineSetupView>();
    }
}


file class LauncherInstalled
{
    public List<LauncherInstalledInfo> InstallationList = [];
}

file class LauncherInstalledInfo
{
    public string InstallLocation;
    public string AppVersion;
    public string AppName;
}