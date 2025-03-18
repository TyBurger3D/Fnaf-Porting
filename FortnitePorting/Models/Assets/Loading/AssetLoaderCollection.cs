using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Exports.Engine;
using CUE4Parse.UE4.Assets.Exports.Texture;
using CUE4Parse.UE4.Assets.Objects;
using CUE4Parse.UE4.Objects.Core.i18N;
using CUE4Parse.UE4.Objects.Core.Math;
using CUE4Parse.UE4.Objects.GameplayTags;
using CUE4Parse.UE4.Objects.UObject;
using DynamicData;
using FluentAvalonia.Core;
using FluentAvalonia.UI.Controls;
using FortnitePorting.Application;
using FortnitePorting.Export.Custom;
using FortnitePorting.Export.Types;
using FortnitePorting.Models.Assets.Asset;
using FortnitePorting.Models.Assets.Custom;
using FortnitePorting.Services;
using FortnitePorting.Shared;
using FortnitePorting.Shared.Extensions;
using FortnitePorting.Shared.Services;
using SkiaSharp;

namespace FortnitePorting.Models.Assets.Loading;

public partial class AssetLoaderCollection : ObservableObject
{
    public static AssetLoaderCollection CategoryAccessor = new(false);
    
    public AssetLoader[] Loaders => Categories.SelectMany(category => category.Loaders).ToArray();
    
    public List<AssetLoaderCategory> Categories { get; set; } =
    [
        new AssetLoaderCategory(EAssetCategory.Cosmetics)
        {
            Loaders = 
            [
                new AssetLoader(EExportType.Outfit)
                {
                    ManuallyDefinedAssets = new Lazy<ManuallyDefinedAsset[]>(
                    [
                        new ManuallyDefinedAsset
                        {
                            Name = "Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Freddy/RIG_Freddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Freddy",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Bonnie/RIG_Bonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Bonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Chica/RIG_Chica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Chica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mr. Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/RIG_Cupcake",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Cupcake"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Foxy/RIG_Foxy_Clean",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Foxy"
                        },
                    ]),
                },
                new AssetLoader(EExportType.Emoticon)
                {
                    ClassNames = ["AthenaEmojiItemDefinition"],
                    HideNames = ["Emoji_100APlus"]
                },
                new AssetLoader(EExportType.Spray)
                {
                    ClassNames = ["AthenaSprayItemDefinition"],
                    HideNames = ["SPID_000", "SPID_001"]
                },
                new AssetLoader(EExportType.Banner)
                {
                    ClassNames = ["FortHomebaseBannerIconItemDefinition"],
                    HideRarity = true
                },
                new AssetLoader(EExportType.LoadingScreen)
                {
                    ClassNames = ["AthenaLoadingScreenItemDefinition"]
                },
                new AssetLoader(EExportType.Emote)
                {
                    ClassNames = ["AthenaDanceItemDefinition"],
                    HideNames = ["_CT", "_NPC"]
                }
            ]
        },
        new AssetLoaderCategory(EAssetCategory.Gameplay)
        {
            Loaders = 
            [
                new AssetLoader(EExportType.Item)
                {
                    ClassNames = ["AthenaGadgetItemDefinition", "FortWeaponRangedItemDefinition", 
                        "FortWeaponMeleeItemDefinition", "FortCreativeWeaponMeleeItemDefinition", 
                        "FortCreativeWeaponRangedItemDefinition", "FortWeaponMeleeDualWieldItemDefinition"],
                    HideNames = ["_Harvest", "Weapon_Pickaxe_", "Weapons_Pickaxe_", "Dev_WID"],
                    HidePredicate = (loader, asset, name) =>
                    {
                        if (loader.FilteredAssetBag.Contains(name)) return true;
                        loader.FilteredAssetBag.Add(name);
                        return false;
                    },
                    AddStyleHandler = (loader, asset, name) =>
                    {
                        var path = asset.GetPathName();
                        loader.StyleDictionary.TryAdd(name, []);
                        loader.StyleDictionary[name].Add(path);
                    }
                },
            ],
        }
    ];
    
    [ObservableProperty] private ObservableCollection<NavigationViewItem> _navItems = [];
    [ObservableProperty] private NavigationViewItem _selectedNavItem;
    
    [ObservableProperty] private AssetLoader _activeLoader;
    [ObservableProperty] private ReadOnlyObservableCollection<Base.BaseAssetItem> _activeCollection;

    public AssetLoaderCollection(bool isForUi = true)
    {
        if (!isForUi) return;
        
        TaskService.RunDispatcher(() =>
        {
            foreach (var category in Categories)
            {
                NavItems.Add(new NavigationViewItem
                {
                    Tag = category.Category,
                    Content = category.Category.GetDescription(),
                    SelectsOnInvoked = false,
                    IconSource = new ImageIconSource
                    {
                        Source = ImageExtensions.AvaresBitmap($"avares://FNAFPorting/Assets/FN/{category.Category.ToString()}.png")
                    },
                    MenuItemsSource = category.Loaders.Select(loader => new NavigationViewItem
                    {
                        Tag = loader.Type, 
                        Content = loader.Type.GetDescription(), 
                        IconSource = new ImageIconSource
                        {
                            Source = ImageExtensions.AvaresBitmap($"avares://FNAFPorting/Assets/FN/{loader.Type.ToString()}.png")
                        },
                    })
                });
            }
        });
    }
    
    public async Task Load(EExportType type)
    {
        Set(type);
        await ActiveLoader.Load();
    }
    
    public void Set(EExportType type)
    {
        DiscordService.Update(type);
        ActiveLoader = Get(type);
        ActiveCollection = ActiveLoader.Filtered;
        ActiveLoader.UpdateFilterVisibility();
    }

    public AssetLoader Get(EExportType type)
    {
        foreach (var category in Categories)
        {
            if (category.Loaders.FirstOrDefault(loader => loader.Type == type) is { } assetLoader)
            {
                return assetLoader;
            }
        }

        return null!; // if this happens it's bc im stupid
    }
    
    private class HeroKey
    {
        private string _heroID { get; }
        private string _shapeID { get; }

        public HeroKey(FStructFallback identifier)
        {
            _heroID = identifier.Get<string>("HeroID");
            _shapeID = identifier.Get<string>("ShapeID");
        }

        public HeroKey(string heroID)
        {
            _heroID = heroID.Substring(0, 4);
            _shapeID = heroID.Substring(4, 1);
        }

        public override bool Equals(object? obj)
        {
            return obj != null && _heroID.Equals(((HeroKey)obj)._heroID) && _shapeID.Equals(((HeroKey)obj)._shapeID);
        }

        public override int GetHashCode()
        {
            return (_heroID + _shapeID).GetHashCode();
        }
    }
}