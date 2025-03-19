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
                        new ManuallyDefinedAsset
                        {
                            Name = "Toy Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyFreddy/RIG_ToyFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toy Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyBonnie/RIG_ToyBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyBonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toy Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/RIG_ToyChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toy Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/ToyChicaCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_office2"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mangle",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Mangle/RIG_Mangle2",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Mangle"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BalloonBoy/RIG_BalloonBoy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_BalloonBoy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Marionette",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Marionette/RIG_Marionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Puppet"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Withered Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFreddy/RIG_WitheredFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Withered Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredBonnie/Rig_WitheredBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredBonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Withered Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredChica/RIG_WitheredChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Withered Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFoxy/RIG_WitheredFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Springtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringTrap/RIG_SpringTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Springtrap"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Freddy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_Nightmare_Freddy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Freddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Freddle",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_FreddleScaled",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Bonnie",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMBonnie/RIG_Nightmare_Bonnie",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Bonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Chica",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMChica/RIG_Nightmare_Chica",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Chica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Models/MOD_NightmareCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFoxy/RIG_Nightmare_Foxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Foxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Fredbear",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_Fredbear/RIG_NightmareFredBear",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareFredbear"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Plushtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Plushtrap/RIG_PlushTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Plushtrap"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmare Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_BalloonBoy/RIG_NightmareBB",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareBB"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nightmarionne",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmarrione/RIG_Nightmarrionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Nightmarionne"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ennard",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Ennard/RIG_Ennard",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Ennard"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Circus Baby",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/CircusBaby/RIG_CircusBaby",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_CircusBaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Funtime Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFoxy/RIG_FuntimeFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Funtime Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFreddy/RIG_FunTimeFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bon-Bon",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BonBon/RIG_BonBon",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_BONBON_AF"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Roach :3",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Roach/RIG_Roach",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Roach"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glitchtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringBonnieMAN/RIG_SpringBonnieMan",
                            IconPath = "freddys/Content/ProductionAssets/Textures/HiddenImages/IMG_BackToFinale"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "GLAMROCKFREDDY BUT DONT GO PAST THIS LINE TILL END OF HW1",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Freddy/RIG_Glamrock_Freddy",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_Poster_Freddy_figure"
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