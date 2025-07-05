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
                            Description = "My name is Freddy, I'm the singer in the band, got a hat and a big bowtie!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Bonnie/RIG_Bonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Bonnie",
                            Description = "Bonnie's my name, I'm hoppin' along, floppy ears and a cotton tail!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Chica/RIG_Chica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Chica",
                            Description = "Hey, I'm Chica! The lady of the group, my singing is a treat!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Mr. Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/RIG_Cupcake",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Cupcake",
                            Description = "His alias is unknown. Watch out. You never know."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 1 Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Foxy/RIG_Foxy_Clean",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Foxy",
                            Description = "One eye and a hook for a hand!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyFreddy/RIG_ToyFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyFreddy",
                            Description = "He's just a gamer at heart."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyBonnie/RIG_ToyBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyBonnie",
                            Description = "Lets ROCK!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/RIG_ToyChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_ToyChica",
                            Description = "You won't get tired of my voice... will you..."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Chica Beak",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/ToyChicaBeak",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_office2",
                            Description = "Where's my beak? Lodged in your forehead of course."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Toy Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/ToyChicaCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_office2",
                            Description = "Let's go somewhere more private... so I can eat you."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Mangle",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Mangle/RIG_Mangle2",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Mangle",
                            Description = "Now I get to play take apart and put back together! You won't feel a thing."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BalloonBoy/RIG_BalloonBoy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_BalloonBoy",
                            Description = "I asked BB what to put here and all he did was giggle so idek what that means."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Marionette",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Marionette/RIG_Marionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Puppet",
                            Description = "i recognize you. but i am not afraid of you... not anymore!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFreddy/RIG_WitheredFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFreddy",
                            Description = "Scrap Metal"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Bonnie",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredBonnie/Rig_WitheredBonnie",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredBonnie",
                            Description = "I am not a toilet bowl."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Chica",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredChica/RIG_WitheredChica",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredChica",
                            Description = "I was the first. I have seen EVERYTHING."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 2 Withered Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFoxy/RIG_WitheredFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_WitheredFoxy",
                            Description = "He hates the light."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 3 Springtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringTrap/RIG_SpringTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Springtrap",
                            Description = "I always come back."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Freddy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_Nightmare_Freddy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Freddy",
                            Description = "I am remade, but not by you, by the one you should not have killed."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Freddle",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFreddy/RIG_FreddleScaled",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017",
                            Description = "*Insert Freddle Noises Here*"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Bonnie",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMBonnie/RIG_Nightmare_Bonnie",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Bonnie",
                            Description = "In your Dreams."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Chica",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMChica/RIG_Nightmare_Chica",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Chica",
                            Description = "In your Nightmares."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Cupcake",
                            AssetPath = "freddys/Content/ProductionAssets/Models/MOD_NightmareCupcake",
                            IconPath = "freddys/Content/ProductionAssets/UI_Assets/Sprites/StaticIcons/helpy_anim_nightmare0017",
                            Description = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAH"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/NMFoxy/RIG_Nightmare_Foxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_NM_Foxy",
                            Description = "Did you forget my tongue?"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Fredbear",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_Fredbear/RIG_NightmareFredBear",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareFredbear",
                            Description = "IS THAT THE BITE OF 87??"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Plushtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Plushtrap/RIG_PlushTrap",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Plushtrap",
                            Description = "Bite sized fun"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmare Balloon Boy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmare_BalloonBoy/RIG_NightmareBB",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_NightmareBB",
                            Description = "Dude this ones darker and twisted but it's still laughing."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "FNAF 4 Nightmarionne",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Nightmarrione/RIG_Nightmarrionette",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Nightmarionne",
                            Description = "oooeahhhoooeoaoohhh"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Ennard",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Ennard/RIG_Ennard",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Ennard",
                            Description = "A little bit of everyone. All. In. One."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Circus Baby",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/CircusBaby/RIG_CircusBaby",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_CircusBaby",
                            Description = "Daddy, why won't you let me play with her?"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Foxy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFoxy/RIG_FuntimeFoxy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFoxy",
                            Description = "Is the gender debate over?"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Funtime Freddy",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/FuntimeFreddy/RIG_FunTimeFreddy",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_FuntimeFreddy",
                            Description = "BON BON! GO GET EM!!!!!!!!!!!!!!! BOOOON BOOOOONNNN GO GET EMMMMMMMMMM!!!!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sister Location Bon-Bon",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BonBon/RIG_BonBon",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_BONBON_AF",
                            Description = "Shhh nobody is here. Go back to your stage."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Roach :3",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Roach/RIG_Roach",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ICO_Roach",
                            Description = "How does this fit in with the fnaf timeline?"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Glitchtrap",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringBonnieMAN/RIG_SpringBonnieMan",
                            IconPath = "freddys/Content/ProductionAssets/Textures/HiddenImages/IMG_BackToFinale",
                            Description = ".. / .- .-.. .-- .- -.-- ... / -.-. --- -- . / -... .- -.-. -.- .-.-.- / - .-. -.-- / - .... . / -.- --- -. .- -- .. / -.-. --- -.. . .-.-.-"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Help Wanted Plush Baby",
                            AssetPath = "freddys/Content/ProductionAssets/Character_Assets/PlushCircusBaby/RIG_Plushy_CircusBaby",
                            IconPath = "freddys/Content/ProductionAssets/Actors/Prize_Actors/BeingUsed/Icons/ForGallery/ICO_Plushbaby",
                            Description = "You won't die. You won't die. You won't die. You won't die. You won't die."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Grimm Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/DLCFoxy/RIG_DLC_Foxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_GrimmFoxy_Gallery",
                            Description = "It burns"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Jack-O-Bonnie",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/JackOBonnie/RIG_JackOBonnie",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Jack-O-Bonnie_Gallery",
                            Description = "Happy Fall Fest."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Jack-O-Chica",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/JackOChica/RIG_JackOChica",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Jack-O-Chica_Gallery",
                            Description = "Happy. Happy. Happy. Happy Fall Fest."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Pirate Foxy",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/PirateFoxy/RIG_PirateFoxy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Foxy_Dark_Ride/Prop_Images/TEMP/Foxy_foxyspyglass_Prop",
                            Description = "A fun ride for all."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "DLC Dreadbear",
                            AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/DLCFreddy/RIG_DLC1_Freddy",
                            IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Dreadbear_Gallery",
                            Description = "Run from the curse. The curse? death. It is my curse. The curse, of Dreadbear."
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
                            Name = "Player Hands",
                            AssetPath = "FNAF_SOTM/Content/Characters/PlayerArms/SK_Player_Arms",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PlayerHands.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Dead Guy with a bee head",
                            AssetPath = "FNAF_SOTM/Content/Characters/OtherWorkers/SK_OtherWorkers_SpringBeeHead",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/DeadGuy.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Dead Guy in a jester suit",
                            AssetPath = "FNAF_SOTM/Content/Characters/OtherWorkers/WorkerJester/SK_WorkerJester",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/WorkerJester.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Big Top",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/BigTop/SK_BigTop",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/BigTop.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Busted/Broken Big Top",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/BigTop/SK_BustedBigTop",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/BustedBigTop.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jackie",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jackie.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jackie (Detattched)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_JackieB",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieB.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jackie Broken Stage 1",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie_C",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieC.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jackie Broken Stage 2",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie_D",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieD.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "MR2ND",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/M2RND/SK_M2RND",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MR2ND.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Mimic",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/Mimic/SK_Mimic",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mimic.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Nurse Dollie",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Dollie.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mimic Nurse Dollie",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie_B",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MimicDollie.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Molten Nurse Dollie",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie_C",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MoltenDollie.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Party Chica",
                            AssetPath = "FNAF_SOTM/Content/Characters/Primary/PChica/SK_PChica",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Partychica.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mimic Birthday Puppy",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/BirthdayPuppy/SK_BirthdayPuppy",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MimicBirthdayPuppy.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Birthday Puppy",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/BirthdayPuppy/SK_FoamBirthdayPuppy",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBirthdayPuppy.png",
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Birthday Elephant",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/ElephantMascot/SK_Elephant",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Elephant.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Birthday Elephant",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamElephant/SK_FoamElephant",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Birthday Elephant.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Lion",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamLion/SK_FoamLion",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Lion.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Penguin",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamPenguin/SK_FoamPenguin",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Penguin.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Lion",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/Lion/SK_LionMascot",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Lion.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Penguin",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/Penguin/SK_PenguinMascot",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Penguin.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Hedgeghog",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/FoamHedgehog/SK_FoamHedgehog",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Hedgehog.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Sharpay",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/FoamSharpay/SK_FoamSharpay",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/FoamSharpay.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Hedgehog",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/Hedgehog/SK_Hedgehog",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Hedgehog.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Lemur",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/Lemur/SK_Lemur",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Lemur.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Poodle",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/SharpayPoodle/SK_Sharpay",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Poodle.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Bee",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/FoamBee/SK_FoamSwingBee",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Bee.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype (Foam) Mushroom",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/FoamMushroom/SK_FoamMushroom",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Foam Mushroom.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jester",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/Jester/SK_JesterMascot",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jester.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mushroom",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/Mushrooms/SK_MushroomMascot",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mushroom.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bee",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/SwingBee/SK_SwingBeeSuit",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bee.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Moon",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/NightLight/SK_Nightlight",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Moon.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bub (Springlock)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/Bub/SK_BubSpringlock",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bub.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Captain (Springlock)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/CaptainSpringlock/SK_CaptainSpringlock",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Captain.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Monty (Springlock)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/Monty/SK_MontySpringlock",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Monty.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Springbonnie (Springlock)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/ProtoBonnie/SK_ProtoBonnieSpringlock",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Bonnie.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Fredbear (Springlock)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/ProtoFredBear/SK_ProtoFredBearSpringlock",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Freddy.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "White Tiger",
                            AssetPath = "FNAF_SOTM/Content/Characters/Secondary/WhiteTiger/SK_WhiteTiger",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/White Tiger.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Birthday Hats",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/BirthdayHats/SK_BirthdayHats",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Hats.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Sitting Birthday Puppy",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/BirthdayPuppy/SK_BirthdayPuppy",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Puppy.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Bosun Puppet",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_BosunPuppet",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bosun Puppet.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Foxy Puppet",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_CaptainFoxyPuppet",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Foxy Puppet.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Kit Puppet",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_KitPuppet",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Kit Puppet.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Renard Puppet",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_RenardPuppet",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Renard.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Roxy Puppet",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_RoxyPuppet",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Roxy.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Cupcake Pal",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CupcakePal/SK_CupCakePal",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/CupCakePal.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Diving Seal",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/DivingSeal/SK_DivingSeal",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Diving Seal.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jugband Male Frog",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandFrogs/SK_BoyFrog",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Male Frog.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jugband Female Frog",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandFrogs/SK_GirlFrog",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Female Frog.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jugband Hippo",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugbandHippo/SK_JugBandHippo",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jugbang Hippo.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Jugband Monty",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandMonty/SK_JugBandMonty",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jugband Monty.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Juggling Duck",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugglingDuck/SK_JugglingDuck",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Juggling Duck.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mannequin",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Mannequin/SK_Mannequin",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mannequin.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mr. Helpful",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/MrHelpy/SK_MrHelpful",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MrHelpful.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mrs. Helpful",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/MrHelpy/SK_MrsHelpful",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/MrsHelpful.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Mailbot (Office Animatronic)",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/OfficeAnimatronic/SK_Office_Animatronic",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mailbot (OfficeAnimatronic).png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic 1",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtoMimic_B",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 1.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic 2",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B2",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 2.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic 3",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B3",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 3.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic 4",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B4",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 4.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic 5",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B5",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 5.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic Legs 1",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_A",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic Legs 2",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_C",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs1.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic Legs 3",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_D",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs2.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic Legs 4",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_D2",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs3.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Protomimic Legs 5",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_E",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs4.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Bonnie",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoBonnie",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBonnie.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Chica",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoChica",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeChica.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Foxy",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoFoxy",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFoxy.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Prototype Freddy",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoFreddy",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFreddy.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Ringmaster Rat",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/RingmasterRat/SK_RingmasterRat",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Ringmaster Rat.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Star 1",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_A",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star1.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Star 2",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_B",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star2.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Star 3",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_C",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star3.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Star 4",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_D",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star4.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Swinging Bee",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/SwingBee/SK_SwingBee",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Swinging Bee.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Vacbot",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/VacuumBot/SK_VacuumBot",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Vacbot.png",
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Rocktopus",
                            AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/WelcomeShowOctopus/SK_WelcomeShowOctopus",
                            LocalIconPath = "avares://FNAFPorting/Assets/SotM/Rocktopus.png",
                            
                        },
                        
                        
                        
                        
                        
                        new ManuallyDefinedAsset
                        {
                            Name = "Springtrap Body (The Animatronic)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body01",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body01",
                            Description = "The Base skin for The Animatronic."
                            
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Toxic Springtrap Body (The Animatronic)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body009",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body009",
                            Description = "The child killer but in acid form."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Clown Springtrap Body (The Animatronic)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body008",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body008",
                            Description = "Welcome to the circus."
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "The Yellow Rabbit Body (The Animatronic)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body007",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body007",
                            Description = "Straight from the movie!"
                        },
                        new ManuallyDefinedAsset
                        {
                            Name = "Glitchtrap Body (The Animatronic)",
                            AssetPath = "DeadByDaylight/Plugins/DBDCharacters/K40/Content/ArtAssets/Models/Bodies/SKM_K40_Body006",
                            IconPath = "DeadByDaylight/Content/UI/UMGAssets/Icons/Customization/K40/K40_Body006",
                            Description = "I always come back... let me out."
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