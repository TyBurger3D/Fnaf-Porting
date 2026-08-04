using CommunityToolkit.Mvvm.ComponentModel;

namespace FNAFPorting.Models.Viewers;

public partial class PropertiesContainer : ObservableObject
{
    [ObservableProperty] private string _assetName;
    [ObservableProperty] private string _propertiesData;
    
    [ObservableProperty] private int _scrollLine;

}