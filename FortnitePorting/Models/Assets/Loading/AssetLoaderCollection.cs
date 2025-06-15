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
                            Name = "FNAF 1 Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Freddy/RIG_Freddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Freddy",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Bonnie/RIG_Bonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Bonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Chica/RIG_Chica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Chica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Mr. Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/RIG_Cupcake",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Cupcake"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Foxy/RIG_Foxy_Clean",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Foxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyFreddy/RIG_ToyFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyBonnie/RIG_ToyBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyBonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/RIG_ToyChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Chica Beak",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/ToyChicaBeak",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_office2"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/ToyChicaCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_office2"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Mangle",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Mangle/RIG_Mangle2",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Mangle"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BalloonBoy/RIG_BalloonBoy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_BalloonBoy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Marionette",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Marionette/RIG_Marionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Puppet"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFreddy/RIG_WitheredFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredBonnie/Rig_WitheredBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredBonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredChica/RIG_WitheredChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFoxy/RIG_WitheredFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 3 Springtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringTrap/RIG_SpringTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Springtrap"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Freddy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_Nightmare_Freddy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Freddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Freddle",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_FreddleScaled",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Bonnie",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMBonnie/RIG_Nightmare_Bonnie",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Bonnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Chica",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMChica/RIG_Nightmare_Chica",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Chica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Models/MOD_NightmareCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFoxy/RIG_Nightmare_Foxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Foxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Fredbear",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_Fredbear/RIG_NightmareFredBear",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareFredbear"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Plushtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Plushtrap/RIG_PlushTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Plushtrap"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_BalloonBoy/RIG_NightmareBB",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareBB"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmarionne",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmarrione/RIG_Nightmarrionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Nightmarionne"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Ennard",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Ennard/RIG_Ennard",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Ennard"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Circus Baby",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/CircusBaby/RIG_CircusBaby",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_CircusBaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFoxy/RIG_FuntimeFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFreddy/RIG_FunTimeFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Bon-Bon",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BonBon/RIG_BonBon",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_BONBON_AF"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Roach :3",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Roach/RIG_Roach",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Roach"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Glitchtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringBonnieMAN/RIG_SpringBonnieMan",
                            IconPath = "freddys/Content/ProductionAssets/Textures/HiddenImages/IMG_BackToFinale"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Plush Baby",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/PlushCircusBaby/RIG_Plushy_CircusBaby",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Plushbaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Grimm Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/DLCFoxy/RIG_DLC_Foxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_GrimmFoxy_Gallery"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Jack-O-Bonnie",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/JackOBonnie/RIG_JackOBonnie",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Jack-O-Bonnie_Gallery"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Jack-O-Chica",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/JackOChica/RIG_JackOChica",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Jack-O-Chica_Gallery"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Pirate Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/PirateFoxy/RIG_PirateFoxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Foxy_Dark_Ride/Prop_Images/TEMP/Foxy_foxyspyglass_Prop"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Dreadbear",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/DLCFreddy/RIG_DLC1_Freddy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Dreadbear_Gallery"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Blob",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Blob/RIG_Blob",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Burntrap",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Burntrap/RIG_Burntrap",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glamrock Chica",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Chica/RIG_Glamrock_Chica",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/Poster_ChicaVogue"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DJ Music Man",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/DJ_MusicMan/RIG_DJ_Music_Man",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Endo",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Endo/RIG_Endo",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_Endo_Poster_03"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glamrock Freddy",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Freddy/RIG_Glamrock_Freddy",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/Poster_FreddyPop"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Gregory",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Gregory/RIG_Gregory_",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Lil DJ Music Man",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Lil_DJ_Music_Man/RIG_Little_DJ_Music_Man",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Montgomery Gator (Monty)",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Monty/RIG_Montgomery_Gator",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/Poster_MontyPop"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sun (Daycare Attendant)",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/MoonMan/RIG_Sunman",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_Poster_Sunnydrop"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Moon (Daycare Attendant)",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/MoonMan/RIG_MoonMan",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_Poster_MoonDrop"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Roxane Wolf (Roxy)",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Roxy/RIG_Glamrock_Roxy",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/Poster_RoxyNegal"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Shattered Chica",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Chica/RIG_Shattered_Chica",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Shattered Monty",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Monty/RIG_Shattered_Montgomery",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Shattered Roxy",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Roxy/RIG_Shattered_Roxy",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Staff Bot (Will have styles later)",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Staffbot/RIG_Chefbot",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_FatalAccidents-poster"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Vanessa",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Vanessa/RIG_Vanessa",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Vanny",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/Vanny/RIG_Vanny",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_VannyGraffiti_Decal"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ruined Chica",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Chica/SK_DLC_Chica",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ruined Monty",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Monty/SK_Monty_DLC",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Scrapped Rabbit",
                            AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Rabbit/SK_DLC_Rabbit",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ruined Roxy",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Roxy/SK_Roxy_DLC",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Candy Cadet",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_CandyCadet/SK_DLC_CandyCadet",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ruined Freddy (Prototype)",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Freddy/SK_DLC_Freddy",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mascot Mimic",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Mascot/SK_Mascot4",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Maskbot",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Maskbot/SK_Maskbot",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Scooper",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Scooper/SK_DLC_Scooper",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "MXES",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Rabbit_6x/SK_DLC_Rabbit_6x",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Cassie",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Player/SK_DLC_Player_Body",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Mimic",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_OldEndo/SK_DLC_Old_Endo",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Eclipse",
                            AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_MoonSun/SK_Moonman_DLC",
                            IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Ballora",
                            AssetPath = "Thumper/Content/Characters/Ballora/SK_Ballora",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Ballora"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Carnie",
                            AssetPath = "Thumper/Content/Characters/BarkerBear/SK_BarkerBear",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Carnie"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Bidybab",
                            AssetPath = "Thumper/Content/Characters/Bidybab/SK_Bidybab",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Bidybab"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location BonBon",
                            AssetPath = "Thumper/Content/Characters/BonBon/SK_Bonbon",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_BonBon"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister location Bonnet",
                            AssetPath = "Thumper/Content/Characters/Bonnet/SK_Bonnet",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Bonnet"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Captain Foxy",
                            AssetPath = "Thumper/Content/Characters/CaptainFoxy/SK_CaptainFoxy",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_CaptainFoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Cassie",
                            AssetPath = "Thumper/Content/Characters/Cassie/SK_Cassie",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Celebrate_"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Glamrock Chica",
                            AssetPath = "Thumper/Content/Characters/Chica/SK_ChicaGlamrock",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_GlamChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister LocationCircus Baby",
                            AssetPath = "Thumper/Content/Characters/CircusBaby/SK_CircusBaby",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_CircusBaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Mr Cupcake",
                            AssetPath = "Thumper/Content/Characters/Cupcake/SK_MrCupcake",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach DJ Music Man",
                            AssetPath = "Thumper/Content/Characters/DJ_Music_Man/SK_DJMM",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_DJMM"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Ruined DJ Music Man",
                            AssetPath = "Thumper/Content/Characters/DJ_MusicMan_Ruined/SK_DJMusicManRuined",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_RuinedDJMM"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "RUIN Candy Cadet",
                            AssetPath = "Thumper/Content/Characters/DLC_CandyCadet/SK_DLC_CandyCadet",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Endo",
                            AssetPath = "Thumper/Content/Characters/Endo/SK_Endo",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Endo"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Ennard",
                            AssetPath = "Thumper/Content/Characters/Ennard/SK_Ennard",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Ennard"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Glamrock Freddy (Repair)",
                            AssetPath = "Thumper/Content/Characters/Freddy_ColdStorage/SK_ST_CS_Freddy_Rig",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_GlamFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Funtime Chica (Cupcake)",
                            AssetPath = "Thumper/Content/Characters/Funtime_Chica/SK_FuntimeChica",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Funtime Chica's Cupcake",
                            AssetPath = "Thumper/Content/Characters/Funtime_Chica/SK_FTChica_CupcakeOnly",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Foxy",
                            AssetPath = "Thumper/Content/Characters/Funtime_Foxy/SK_FTFoxy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Freddy",
                            AssetPath = "Thumper/Content/Characters/Funtime_Freddy/SK_FTFreddy",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTFreddy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Glitchtrap",
                            AssetPath = "Thumper/Content/Characters/GlitchTrap/SK_Glitchtrap",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2Headchef Bot",
                            AssetPath = "Thumper/Content/Characters/HeadChefBot/SK_HeadChefBot",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_HeadChefBot"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Work in Progress - Helpy",
                            AssetPath = "Thumper/Content/Characters/Jackie/SM_Jackie_Gallery",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Helpy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Secret of the Mimic Jackie",
                            AssetPath = "Thumper/Content/Characters/Jackie/SM_Jackie_Gallery",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_JackieModel"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Lefty",
                            AssetPath = "Thumper/Content/Characters/Lefty/SK_Lefty",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Lefty"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Lemonade Clown",
                            AssetPath = "Thumper/Content/Characters/LemonadeClown/SM_LemonadeClown",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Lil' DJ Music Man",
                            AssetPath = "Thumper/Content/Characters/LittleMusicMan/SK_LMM",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ruined Lil' DJ Music Man",
                            AssetPath = "Thumper/Content/Characters/LittleMusicMan_Ruined/SK_LMM_01",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Bonnie Doll",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Bonnie",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Chica Doll",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Chica",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Foxy Doll",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Foxy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Freddy Doll",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Freddy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Golden Freddy Doll",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_GoldenFreddy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Masked Puppet",
                            AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Puppet",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister LocationMinireena",
                            AssetPath = "Thumper/Content/Characters/Minireena/SK_Minireena",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Minireena"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Monty",
                            AssetPath = "Thumper/Content/Characters/Monty/SK_Monty",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Monty"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "RUIN MXES",
                            AssetPath = "Thumper/Content/Characters/MXES_Rabbit/SK_DLC_Rabbit",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Mystic Hippo",
                            AssetPath = "Thumper/Content/Characters/MysticHippo/SK_MysticHippo",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Pig Patch",
                            AssetPath = "Thumper/Content/Characters/PigPatch/SK_PPatch",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_PigPatch"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "RUIN -Plush Glamrock Bonnie",
                            AssetPath = "Thumper/Content/Characters/Plush_GlamBonnie/SK_Plush_GlamBonnie",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Plush Glamrock Chica",
                            AssetPath = "Thumper/Content/Characters/Plush_GlamChica/SK_Plush_GlamChica",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Plush Glamrock Freddy",
                            AssetPath = "Thumper/Content/Characters/Plush_GlamFreddy/SK_Plush_GlamFreddy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Plush Monty",
                            AssetPath = "Thumper/Content/Characters/Plush_GlamMonty/SK_Plush_GlamMonty",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Plush Roxy",
                            AssetPath = "Thumper/Content/Characters/Plush_GlamRoxy/SK_Plush_GlamRoxy",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Plush Moon",
                            AssetPath = "Thumper/Content/Characters/Plush_SunMoon/SK_Plush_MoonMan",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Plush Baby",
                            AssetPath = "Thumper/Content/Characters/PlushBaby/SK_PBaby",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_PlushBaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Roxanne Wolf (Roxy)",
                            AssetPath = "Thumper/Content/Characters/Roxy/SK_Roxy",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Roxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 6 Scrap Baby",
                            AssetPath = "Thumper/Content/Characters/ScrapBaby/SK_ScrapBaby",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ScrapBaby"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Shattered Chica",
                            AssetPath = "Thumper/Content/Characters/Shattered_Chica/SK_Chica_Shattered",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ShatteredChica"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Shattered Roxy",
                            AssetPath = "Thumper/Content/Characters/Shattered_Roxy/SK_Roxy_ShatteredNoJaw",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ShatteredRoxy"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Staffbot",
                            AssetPath = "Thumper/Content/Characters/Staffbot/SK_Staffbot",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Staffbots"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Daycare Attendant (sun/moon)",
                            AssetPath = "Thumper/Content/Characters/SunMoon/SK_Moonman",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Moon"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Moon's Hat",
                            AssetPath = "Thumper/Content/Characters/SunMoon/SK_Moonman_Hat",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Moon"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "RUIN Eclipse",
                            AssetPath = "Thumper/Content/Characters/SunMoonRuin/SK_Moonman_Ruin",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted 2 Glitchtrap puppet",
                            AssetPath = "Thumper/Content/Characters/Tilt/SK_Tilt_Puppet",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Security Breach Vanny",
                            AssetPath = "Thumper/Content/Characters/Vanny/SK_Vanny",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Vanny"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Secret of the Mimic White Tiger",
                            AssetPath = "Thumper/Content/Characters/WhiteTiger/SK_WhiteTiger",
                            IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Yenndo",
                            AssetPath = "Thumper/Content/Characters/Yenndo/SK_Yendo",
                            IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Yenndo"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Balloon Boy (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/BB/SK_BalloonBoy",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/BB/bbicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bonnie (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Bonnie/SK_Bonnie",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Bonnie/bonnieicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Chica (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Chica/SK_Chica",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Chica/chicaicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Foxy (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Foxy/SK_Foxy",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Foxy/foxyicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Freddy (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Freddy/SK_Freddy",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Freddy/freddyicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mangle (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Mangle/SK_Mangle",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Mangle/mangleicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Puppet (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Puppet/SK_Puppet",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Puppet/puppeticon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Springtrap (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Characters/Springtrap/SK_Springtrap",
                            IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Springtrap/springtrapicon_base"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Wolf Endo (FLAF)",
                            AssetPath = "flaf/Content/Meshes/Enemy/WolfEndo/SK_WolfEndo",
                            IconPath = "flaf/Content/UI/Items/Jumpscare/jumpscare"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bee",
                            AssetPath = "FNAF_SOTM/Content/Characters/PlayerArms/SK_Player_Arms",
                            IconPath = "avares://D:/Downloads/Five Nights At Freddy's Porting/Fnaf-Porting/FortnitePorting/Assets/SotM/PlayerHands.png",
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
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Freddy",
                            AssetPath = "freddys/Content/Meshes/GalleryCharacters/BonniePose.uasset",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Freddy",
                        },
                        
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