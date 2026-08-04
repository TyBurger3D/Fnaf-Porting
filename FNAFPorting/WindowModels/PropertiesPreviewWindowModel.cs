using System;
using System.Collections.ObjectModel;
using System.Xml;
using Avalonia.Platform;
using AvaloniaEdit.Highlighting;
using AvaloniaEdit.Highlighting.Xshd;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Application;
using FNAFPorting.Framework;
using FNAFPorting.Services;
using PropertiesContainer = FNAFPorting.Models.Viewers.PropertiesContainer;
using Viewers_PropertiesContainer = FNAFPorting.Models.Viewers.PropertiesContainer;

namespace FNAFPorting.WindowModels;

[Transient]
public partial class PropertiesPreviewWindowModel(SettingsService settings) : WindowModelBase
{
    [ObservableProperty] private SettingsService _settings = settings;

    [ObservableProperty] private ObservableCollection<Viewers_PropertiesContainer> _assets = [];
    [ObservableProperty] private Viewers_PropertiesContainer? _selectedAsset;

    public static IHighlightingDefinition JsonHighlighter { get; set; }

    static PropertiesPreviewWindowModel()
    {
        using var stream = AssetLoader.Open(new Uri("avares://FNAFPorting/Assets/Highlighters/Json.xshd"));
        using var reader = new XmlTextReader(stream);
        JsonHighlighter = HighlightingLoader.Load(reader, HighlightingManager.Instance);
    }
}