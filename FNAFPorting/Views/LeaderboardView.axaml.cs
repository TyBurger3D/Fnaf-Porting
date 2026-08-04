using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Framework;
using FNAFPorting.ViewModels;

namespace FNAFPorting.Views;

public partial class LeaderboardView : ViewBase<LeaderboardViewModel>
{
    public LeaderboardView()
    {
        InitializeComponent();
        
        Navigation.Leaderboard.Initialize(Sidebar, ContentFrame);
    }
    
    private void OnItemSelected(object? sender, SidebarItemSelectedArgs e)
    {
        Navigation.Leaderboard.Open(e.Tag);
    }
}