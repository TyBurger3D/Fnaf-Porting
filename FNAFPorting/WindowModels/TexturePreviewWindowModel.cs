using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Application;
using FNAFPorting.Framework;
using FNAFPorting.Models.Viewers;
using FNAFPorting.Services;

namespace FNAFPorting.WindowModels;

[Transient]
public partial class TexturePreviewWindowModel(SettingsService settings) : WindowModelBase
{
    [ObservableProperty] private SettingsService _settings = settings;

    [ObservableProperty] private ObservableCollection<TextureContainer> _textures = [];
    [ObservableProperty] private TextureContainer _selectedTexture;

}