using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Models.Leaderboard;
using FNAFPorting.Framework;
using FNAFPorting.Shared.Extensions;

namespace FNAFPorting.ViewModels.Leaderboard;

public partial class LeaderboardExportsViewModel : PagedLeaderboardViewModelBase<LeaderboardExport>
{
    protected override string PageCountFunctionName => "leaderboard_exports_page_count";
    protected override string PageDataFunctionName => "leaderboard_exports";

    protected override async Task LoadItem(LeaderboardExport item)
    {
        await item.Load();
    }
}