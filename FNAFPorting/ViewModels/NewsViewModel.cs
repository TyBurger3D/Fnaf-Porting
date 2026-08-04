using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Framework;
using FNAFPorting.Models.API.Responses;
using FNAFPorting.Windows;

namespace FNAFPorting.ViewModels;

public partial class NewsViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<NewsEntry> _news = [];

    public override async Task OnViewOpened()
    {
        var newsResponse = await Api.FNAFPorting.News();
        News = [..newsResponse.Entries];
    }
    
    public void OpenNews(NewsEntry news)
    {
        ChangelogWindow.Preview(news.Description);
    }
}