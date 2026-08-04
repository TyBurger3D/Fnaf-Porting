using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Application;
using FNAFPorting.Services;
using FNAFPorting.Framework;
using Newtonsoft.Json;
using FNAFPorting.Models.Supabase.User;

namespace FNAFPorting.ViewModels.Settings;

public partial class AccountSettingsViewModel : SettingsViewModelBase
{
   [JsonIgnore] public SupabaseService SupaBase => AppServices.SupaBase;

   [ObservableProperty] private string? _sessionInfoEncrypted = null;

   [ObservableProperty] private bool _useDiscordRichPresence = true;

   partial void OnUseDiscordRichPresenceChanged(bool value)
   {
      if (value)
         Discord.Initialize();
      else
         Discord.Deinitialize();
   }
}