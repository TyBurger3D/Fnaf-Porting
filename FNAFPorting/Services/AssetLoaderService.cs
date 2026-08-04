using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using FNAFPorting.Extensions;
using FNAFPorting.Framework;
using FNAFPorting.Models.Assets;
using FNAFPorting.Models.Assets.Asset;
using FNAFPorting.Models.Assets.Base;
using FNAFPorting.Models.Assets.Loading;

namespace FNAFPorting.Services;

public partial class AssetLoaderService : ObservableObject, IService, IResettable
{
    [ObservableProperty] private AssetLoader? _activeLoader;
    [ObservableProperty] private ReadOnlyObservableCollection<BaseAssetItem> _activeCollection = new([]);

    public List<AssetLoaderCategory> Categories { get; set; } =
    [
        new(EAssetCategory.Cosmetics)
        {
            Loaders =
            [
                new AssetLoader(EExportType.Outfit)
                {
                    ClassNames = [],
                    HideRarity = true,
                    ManuallyDefinedAssetsFactory = () =>
                        FNAFManualAssets.AnimatronicsFor(AppSettings.Installation.CurrentProfile.FnafVersion)
                },
                new AssetLoader(EExportType.Backpack)
                {
                    ClassNames = [],
                    HideRarity = true,
                    ManuallyDefinedAssetsFactory = () =>
                        FNAFManualAssets.ItemsFor(AppSettings.Installation.CurrentProfile.FnafVersion)
                }
            ]
        }
    ];

    public void Reset()
    {
        foreach (var loader in Categories.SelectMany(category => category.Loaders))
            loader.Reset();

        AssetItem.ResetCaches();

        ActiveLoader = null;
        ActiveCollection = new ReadOnlyObservableCollection<BaseAssetItem>([]);
    }

    public async Task Load(EExportType type)
    {
        if (type is EExportType.None) return;

        Set(type);
        await ActiveLoader!.Load();
    }

    public AssetLoader Get(EExportType type)
    {
        if (!Enum.IsDefined(type))
            type = EExportType.Outfit;

        return Categories.SelectMany(cat => cat.Loaders).FirstOrDefault(loader => loader.Type == type)
               ?? throw new ArgumentOutOfRangeException(nameof(type),
                   $"Asset type {type.Description} does not have an implemented loader.");
    }

    public void Set(EExportType type)
    {
        Discord.Update(type);
        ActiveLoader = Get(type);
        ActiveCollection = ActiveLoader.Filtered;
        ActiveLoader.UpdateFilterVisibility();
    }
}
