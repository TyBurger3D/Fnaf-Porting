using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Models.Supabase.Tables;


namespace FNAFPorting.Models.Supabase.User;

public partial class UserPermissions : ObservableObject
{
    [ObservableProperty] private ESupabaseRole _role = ESupabaseRole.User;
    [ObservableProperty] private bool _canExportUEFN = false;
    [ObservableProperty] private bool _isMuted = false;
}