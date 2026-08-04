using System;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Models.Assets.Asset;

namespace FNAFPorting.Models.Assets.Filters;

public partial class FilterItem(string title, Predicate<AssetItem> predicate) : ObservableObject
{
    [ObservableProperty] private string _title = title;
    [ObservableProperty] private bool _isChecked;

    public Predicate<AssetItem> Predicate = predicate;
}