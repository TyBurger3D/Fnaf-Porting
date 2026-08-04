using System.Threading.Tasks;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Extensions;
using FNAFPorting.Models.API.Responses;
using FNAFPorting.Models.Supabase.Tables;
using Newtonsoft.Json;

namespace FNAFPorting.Models.Leaderboard;

public partial class LeaderboardStats : ObservableObject
{
    [ObservableProperty] [JsonProperty("current_streak")] private int _currentStreak;
    [ObservableProperty] [JsonProperty("total_exports")] private int _totalExports;
    [ObservableProperty] [JsonProperty("total_assets")] private int _totalAssets;
    [ObservableProperty] [JsonProperty("most_exported_object_path")] private string _mostPopularObjectPath;
    [ObservableProperty] [JsonProperty("most_exported_object_count")] private int _mostPopularObjectCount;
    [ObservableProperty] [JsonProperty("total_xp")] private long _totalXP;

}