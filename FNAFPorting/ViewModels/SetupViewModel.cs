using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Framework;
using FNAFPorting.Shared.Extensions;

namespace FNAFPorting.ViewModels;

public partial class SetupViewModel : ViewModelBase
{
    [ObservableProperty] private ObservableCollection<string> _imagePaths = [];

    public override async Task Initialize()
    {
        var galleryResponse = await Api.FNAFPorting.Gallery();

        ImagePaths =
        [
            ..galleryResponse.FileNames
                .Select(fileName => Path.Combine(galleryResponse.BaseUrl, fileName))
                .Shuffle()
                .ToArray()
        ];
    }
}