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
using FortnitePorting.Extensions;
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
                            Name = "The First (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Bodies/SKM_K42_Body01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_Body01",
                            Description = "The Leader of the monsters" 
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Scion of the Upside Down (The First) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Bodies/SKM_K42_Body006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_Body006",
                            Description = "When he first arrived"
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The First (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Head/SKM_K42_Head01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_Head01",
                            Description = "The Leader of the Monsters"
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Scion of the Upside Down (The First) (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Head/SKM_K42_Head006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_Head006",
                            Description = "When he first arrived."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The First (Arms)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Arms/SKM_K42_W01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_W01",
                            Description = "The Leader of the Monsters"
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Scion of the Upside Down (The First) (Arms)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K42/Content/ArtAssets/Models/Arms/SKM_K42_W006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K42/K42_W006",
                            Description = "When he first arrived."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Animatronic (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body01",
                            Description = "The Base skin for The Animatronic."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toxic Springtrap (The Animatronic) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body009",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body009",
                            Description = "Acidic!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Clown Springtrap (The Animatronic) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body008",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body008",
                            Description = "Welcome to the circus."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Yellow Rabbit (The Animatronic) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body007",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body007",
                            Description = "Straight from the movie!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glitchtrap (The Animatronic) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body006",
                            Description = "I always come back... let me out."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Blighted Springtrap (The Animatronic) (Body)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body010",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body010",
                            Description = "Burnt to a crisp!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Animatronic (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head01",
                            Description = "The Base skin for The Animatronic."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toxic Springtrap (The Animatronic) (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head009",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head009",
                            Description = "Acidic!"
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Clown Springtrap (The Animatronic) (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head008",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head008",
                            Description = "Welcome to the circus."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Yellow Rabbit (The Animatronic) (Head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head007",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head007",
                            Description = "Straight from the movie!"
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glitchtrap (The Animatronic) (head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head006",
                            Description = "I always come back... let me out."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Blighted Springtrap (The Animatronic) (head)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Heads/SKM_K40_Head010",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Head010",
                            Description = "Burnt to a crisp!"
                            
                        },


                    ]),
                },
                new AssetLoader(EExportType.Emoticon)
                    
                {

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
                    ManuallyDefinedAssets = new Lazy<ManuallyDefinedAsset[]>(
                    [
                        
                    ]),
                    
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
                        Source = ImageExtensions.AvaresBitmap($"avares://Daylight Porting/Assets/FN/{category.Category.ToString()}.png")
                    },
                    MenuItemsSource = category.Loaders.Select(loader => new NavigationViewItem
                    {
                        Tag = loader.Type, 
                        Content = loader.Type.GetDescription(), 
                        IconSource = new ImageIconSource
                        {
                            Source = ImageExtensions.AvaresBitmap($"avares://Daylight Porting/Assets/FN/{loader.Type.ToString()}.png")
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