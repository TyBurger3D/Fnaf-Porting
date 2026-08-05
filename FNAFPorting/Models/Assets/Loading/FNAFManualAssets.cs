namespace FNAFPorting.Models.Assets.Loading;

public static class FNAFManualAssets
{

    public static ManuallyDefinedAsset[] AnimatronicsFor(EFNAFVersion version) => version switch
    {
        EFNAFVersion.HelpWanted => HelpWantedAnimatronics,
        EFNAFVersion.HelpWanted2 => HelpWanted2Animatronics,
        EFNAFVersion.SecurityBreach => SecurityBreachAnimatronics,
        EFNAFVersion.FLAF => FLAFAnimatronics,
        EFNAFVersion.SOTM => SotMAnimatronics,
        EFNAFVersion.Chapter1 => Chapter1Animatronics,
        EFNAFVersion.Custom => AllAnimatronics,
        _ => []
    };

    public static ManuallyDefinedAsset[] ItemsFor(EFNAFVersion version) => version switch
    {
        EFNAFVersion.HelpWanted => HelpWantedItems,
        EFNAFVersion.HelpWanted2 => HelpWanted2Items,
        EFNAFVersion.SecurityBreach => SecurityBreachItems,
        EFNAFVersion.FLAF => FLAFItems,
        EFNAFVersion.SOTM => SotMItems,
        EFNAFVersion.Chapter1 => Chapter1Items,
        EFNAFVersion.Custom => AllItems,
        _ => []
    };

    private static readonly ManuallyDefinedAsset[] HelpWantedAnimatronics =
    [
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Freddy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Freddy/RIG_Freddy",
                IconPath = "avares://FNAFPorting/Assets/HW/FRDY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/FRDY.png",
                Description = "My name is Freddy, I'm the singer in the band, got a hat and a big bowtie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Bonnie",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Bonnie/RIG_Bonnie",
                IconPath = "avares://FNAFPorting/Assets/HW/BNIE.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/BNIE.png",
                Description = "Bonnie's my name, I'm hoppin' along, floppy ears and a cotton tail!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Chica",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Chica/RIG_Chica",
                IconPath = "avares://FNAFPorting/Assets/HW/CHCA.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/CHCA.png",
                Description = "Hey, I'm Chica! The lady of the group, my singing is a treat!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Mr. Cupcake",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/RIG_Cupcake",
                IconPath = "avares://FNAFPorting/Assets/HW/CPCK.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/CPCK.png",
                Description = "Perfect size for chomping faces off."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Foxy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Foxy/RIG_Foxy_Clean",
                IconPath = "avares://FNAFPorting/Assets/HW/FXY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/FXY.png",
                Description = "One eye and a hook for a hand!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Toy Freddy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyFreddy/RIG_ToyFreddy",
                IconPath = "avares://FNAFPorting/Assets/HW/TFRD.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/TFRD.png",
                Description = "He's just a gamer at heart."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Toy Bonnie",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyBonnie/RIG_ToyBonnie",
                IconPath = "avares://FNAFPorting/Assets/HW/TBNE.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/TBNE.png",
                Description = "Lets ROCK!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Toy Chica",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/RIG_ToyChica",
                IconPath = "avares://FNAFPorting/Assets/HW/TCHC.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/TCHC.png",
                Description = "You won't get tired of my voice... will you..."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Toy Chica Beak",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/ToyChica/ToyChicaBeak",
                IconPath = "avares://FNAFPorting/Assets/HW/TCB.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/TCB.png",
                Description = "Where's my beak? Lodged in your forehead of course."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Toy Cupcake",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Cupcake/ToyChicaCupcake",
                IconPath = "avares://FNAFPorting/Assets/HW/TCCC.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/TCCC.png",
                Description = "Let's go somewhere more private... so I can eat you."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Mangle",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Mangle/RIG_Mangle2",
                IconPath = "avares://FNAFPorting/Assets/HW/MNGL.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/MNGL.png",
                Description = "Now I get to play take apart and put back together! You won't feel a thing."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Balloon Boy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/BalloonBoy/RIG_BalloonBoy",
                IconPath = "avares://FNAFPorting/Assets/HW/BB.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/BB.png",
                Description = "I asked BB what to put here and all he did was giggle so idek what that means."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Marionette",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Marionette/RIG_Marionette",
                IconPath = "avares://FNAFPorting/Assets/HW/MANT.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/MANT.png",
                Description = "i recognize you. but i am not afraid of you... not anymore!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Withered Freddy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFreddy/RIG_WitheredFreddy",
                IconPath = "avares://FNAFPorting/Assets/HW/WFRD.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/WFRD.png",
                Description = "Scrap Metal"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Withered Bonnie",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredBonnie/Rig_WitheredBonnie",
                IconPath = "avares://FNAFPorting/Assets/HW/WBNE.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/WBNE.png",
                Description = "I am not a toilet bowl."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Withered Chica",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredChica/RIG_WitheredChica",
                IconPath = "avares://FNAFPorting/Assets/HW/WCHK.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/WCHK.png",
                Description = "I was the first. I have seen EVERYTHING."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 2 Withered Foxy",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/WitheredFoxy/RIG_WitheredFoxy",
                IconPath = "avares://FNAFPorting/Assets/HW/WFXY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/WFXY.png",
                Description = "He hates the light."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 3 Springtrap",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringTrap/RIG_SpringTrap",
                IconPath = "avares://FNAFPorting/Assets/HW/FXY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/SPTP.png",
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
                IconPath = "avares://FNAFPorting/Assets/HW/FDLE.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/FDLE.png",
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
                IconPath = "avares://FNAFPorting/Assets/HW/NMCP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/NMCP.png",
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
                IconPath = "avares://FNAFPorting/Assets/HW/BB.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/BB.png",
                Description = "Shhh nobody is here. Go back to your stage."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted Roach :3",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/Roach/RIG_Roach",
                IconPath = "avares://FNAFPorting/Assets/HW/RCH.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/RCH.png",
                Description = "How does this fit in with the fnaf timeline?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted Glitchtrap",
                AssetPath = "freddys/Content/ProductionAssets/Character_Assets/SpringBonnieMAN/RIG_SpringBonnieMan",
                IconPath = "avares://FNAFPorting/Assets/HW/SBM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/SBM.png",
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
                IconPath = "avares://FNAFPorting/Assets/HW/PRFY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW/PRFY.png",
                Description = "A fun ride for all."
            },
            new ManuallyDefinedAsset
            {
                Name = "DLC Dreadbear",
                AssetPath = "freddys/Plugins/HalloweenDLC/Content/CharacterAssets/DLCFreddy/RIG_DLC1_Freddy",
                IconPath = "freddys/Plugins/HalloweenDLC/Content/Textures/Icons/Gallery/ICO_Dreadbear_Gallery",
                Description = "Run from the curse. The curse? death. It is my curse. The curse, of Dreadbear."
            }
    ];

    private static readonly ManuallyDefinedAsset[] HelpWanted2Animatronics =
    [
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Ballora",
                AssetPath = "Thumper/Content/Characters/Ballora/SK_Ballora",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Ballora",
                Description = "Why do you hide inside your walls, when there is music in my halls?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Carnie",
                AssetPath = "Thumper/Content/Characters/BarkerBear/SK_BarkerBear",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Carnie",
                Description = "Step right up!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Bidybab",
                AssetPath = "Thumper/Content/Characters/Bidybab/SK_Bidybab",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Bidybab",
                Description = "Someone's in there..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location BonBon",
                AssetPath = "Thumper/Content/Characters/BonBon/SK_Bonbon",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_BonBon",
                Description = "I think it was just a mouse."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister location Bonnet",
                AssetPath = "Thumper/Content/Characters/Bonnet/SK_Bonnet",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Bonnet",
                Description = "hahaha!!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Captain Foxy",
                AssetPath = "Thumper/Content/Characters/CaptainFoxy/SK_CaptainFoxy",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_CaptainFoxy",
                Description = "Welcome back to the log ride..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Cassie",
                AssetPath = "Thumper/Content/Characters/Cassie/SK_Cassie",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Celebrate_",
                Description = "Gregory?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Glamrock Chica",
                AssetPath = "Thumper/Content/Characters/Chica/SK_ChicaGlamrock",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_GlamChica",
                Description = "nom nom nom nom nom"
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister LocationCircus Baby",
                AssetPath = "Thumper/Content/Characters/CircusBaby/SK_CircusBaby",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_CircusBaby",
                Description = "There were two, then three, then five, then four... There were four, then three, then two. Then one. Something happened when there was one."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 1 Mr Cupcake",
                AssetPath = "Thumper/Content/Characters/Cupcake/SK_MrCupcake",
                IconPath = "avares://FNAFPorting/Assets/HW2/CC.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/CC.png",
                Description = "Hey they modeled his mouth this time!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach DJ Music Man",
                AssetPath = "Thumper/Content/Characters/DJ_Music_Man/SK_DJMM",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_DJMM",
                Description = "Boots and cats..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Ruined DJ Music Man",
                AssetPath = "Thumper/Content/Characters/DJ_MusicMan_Ruined/SK_DJMusicManRuined",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_RuinedDJMM",
                Description = "Is this the death of slim shady?! (Edit: I'm back to this and idk wtf this was in reference to??)"
            },
            new ManuallyDefinedAsset
            {
                Name = "RUIN Candy Cadet",
                AssetPath = "Thumper/Content/Characters/DLC_CandyCadet/SK_DLC_CandyCadet",
                IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132",
                Description = "C-C-C-C-C-C-Come.. C-Andy."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Endo",
                AssetPath = "Thumper/Content/Characters/Endo/SK_Endo",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Endo",
                Description = "Yeah no these things suck in HW2 more im ngl"
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Ennard",
                AssetPath = "Thumper/Content/Characters/Ennard/SK_Ennard",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Ennard",
                Description = "Everyone. All at once."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Glamrock Freddy (Repair)",
                AssetPath = "Thumper/Content/Characters/Freddy_ColdStorage/SK_ST_CS_Freddy_Rig",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_GlamFreddy",
                Description = "The Birthdaycake..."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Funtime Chica (Cupcake)",
                AssetPath = "Thumper/Content/Characters/Funtime_Chica/SK_FuntimeChica",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTChica",
                Description = "Nobody likes me."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Funtime Chica's Cupcake",
                AssetPath = "Thumper/Content/Characters/Funtime_Chica/SK_FTChica_CupcakeOnly",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTChica",
                Description = "Why does this exist. Like genuinely this didn't need to exist."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Funtime Foxy",
                AssetPath = "Thumper/Content/Characters/Funtime_Foxy/SK_FTFoxy",
                IconPath = "avares://FNAFPorting/Assets/HW2/FTFY.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/FTFY.png",
                Description = "Still.. no gender..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Funtime Freddy",
                AssetPath = "Thumper/Content/Characters/Funtime_Freddy/SK_FTFreddy",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_FTFreddy",
                Description = "BON BON GO GET EM!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted Glitchtrap",
                AssetPath = "Thumper/Content/Characters/GlitchTrap/SK_Glitchtrap",
                IconPath = "Thumper/Content/UI/Art/Test/T_LoadingIcon_132x132",
                Description = "Shhhhh... **I wlli tge uto** "
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Headchef Bot",
                AssetPath = "Thumper/Content/Characters/HeadChefBot/SK_HeadChefBot",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_HeadChefBot",
                Description = "Welcome human. Prepare food!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Work in Progress - Helpy",
                AssetPath = "Thumper/Content/Characters/Jackie/SM_Jackie_Gallery",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Helpy",
                Description = "Still a work in progress.."
            },
            new ManuallyDefinedAsset
            {
                Name = "Secret of the Mimic Jackie",
                AssetPath = "Thumper/Content/Characters/Jackie/SM_Jackie_Gallery",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_JackieModel",
                Description = "Just a gallery prop.. Absolutely nothing in here!"
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Lefty",
                AssetPath = "Thumper/Content/Characters/Lefty/SK_Lefty",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Lefty",
                Description = "Lure. Encapsulate. Fuse. Transport. Extract."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Lemonade Clown",
                AssetPath = "Thumper/Content/Characters/LemonadeClown/SM_LemonadeClown",
                IconPath = "avares://FNAFPorting/Assets/HW2/Lemon Clown.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/Lemon Clown.png",
                Description = "Astral Spiff was here"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Lil' DJ Music Man",
                AssetPath = "Thumper/Content/Characters/LittleMusicMan/SK_LMM",
                IconPath = "avares://FNAFPorting/Assets/HW2/LDJMM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/LDJMM.png",
                Description = "awww just a wittwe gwuy agwain"
            },
            new ManuallyDefinedAsset
            {
                Name = "Ruined Lil' DJ Music Man",
                AssetPath = "Thumper/Content/Characters/LittleMusicMan_Ruined/SK_LMM_01",
                IconPath = "avares://FNAFPorting/Assets/HW2/RLDJMM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/RLDJMM.png",
                Description = "Oh damn, just a fucked up little guy again"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Bonnie Doll",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Bonnie",
                IconPath = "avares://FNAFPorting/Assets/HW2/BP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/BP.png",
                Description = "Jeremy."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Chica Doll",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Chica",
                IconPath = "avares://FNAFPorting/Assets/HW2/CP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/CP.png",
                Description = "Susie."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Foxy Doll",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Foxy",
                IconPath = "avares://FNAFPorting/Assets/HW2/FP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/FP.png",
                Description = "Fritz"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Freddy Doll",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Freddy",
                IconPath = "avares://FNAFPorting/Assets/HW2/FRP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/FRP.png",
                Description = "Gabriel"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Golden Freddy Doll",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_GoldenFreddy",
                IconPath = "avares://FNAFPorting/Assets/HW2/GP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/GP.png",
                Description = "Cassidy."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Masked Puppet",
                AssetPath = "Thumper/Content/Characters/MaskedDolls/SK_MaskedDoll_Puppet",
                IconPath = "avares://FNAFPorting/Assets/HW2/PP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/PP.png",
                Description = "Charlotte Emily."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Minireena",
                AssetPath = "Thumper/Content/Characters/Minireena/SK_Minireena",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Minireena",
                Description = "Shake if they crawl in."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Monty",
                AssetPath = "Thumper/Content/Characters/Monty/SK_Monty",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Monty",
                Description = "Showtime!"
            },
            new ManuallyDefinedAsset
            {
                Name = "RUIN MXES",
                AssetPath = "Thumper/Content/Characters/MXES_Rabbit/SK_DLC_Rabbit",
                IconPath = "avares://FNAFPorting/Assets/HW2/MXES.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/MXES.png",
                Description = "Fiona."
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Mystic Hippo",
                AssetPath = "Thumper/Content/Characters/MysticHippo/SK_MysticHippo",
                IconPath = "avares://FNAFPorting/Assets/HW2/MH.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/MH.png",
                Description = "I will read your fortune."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Pig Patch",
                AssetPath = "Thumper/Content/Characters/PigPatch/SK_PPatch",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_PigPatch",
                Description = "The nail that sticks out gets hammered down."
            },
            new ManuallyDefinedAsset
            {
                Name = "RUIN -Plush Glamrock Bonnie",
                AssetPath = "Thumper/Content/Characters/Plush_GlamBonnie/SK_Plush_GlamBonnie",
                IconPath = "avares://FNAFPorting/Assets/HW2/GB.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/GB.png",
                Description = "Poor guy."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Plush Glamrock Chica",
                AssetPath = "Thumper/Content/Characters/Plush_GlamChica/SK_Plush_GlamChica",
                IconPath = "avares://FNAFPorting/Assets/HW2/GCP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/GCP.png",
                Description = "The glutton, but as a plushie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Plush Glamrock Freddy",
                AssetPath = "Thumper/Content/Characters/Plush_GlamFreddy/SK_Plush_GlamFreddy",
                IconPath = "avares://FNAFPorting/Assets/HW2/CFP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/CFP.png",
                Description = "The Savior, but as a plushie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Plush Monty",
                AssetPath = "Thumper/Content/Characters/Plush_GlamMonty/SK_Plush_GlamMonty",
                IconPath = "avares://FNAFPorting/Assets/HW2/GRM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/GRM.png",
                Description = "The Angry, but as a plushie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Plush Roxy",
                AssetPath = "Thumper/Content/Characters/Plush_GlamRoxy/SK_Plush_GlamRoxy",
                IconPath = "avares://FNAFPorting/Assets/HW2/ROP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/ROP.png",
                Description = "The Insecure, but as a plushie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Plush Moon",
                AssetPath = "Thumper/Content/Characters/Plush_SunMoon/SK_Plush_MoonMan",
                IconPath = "avares://FNAFPorting/Assets/HW2/MOOP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/MOOP.png",
                Description = "The Broken, but as a plushie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted Plush Baby",
                AssetPath = "Thumper/Content/Characters/PlushBaby/SK_PBaby",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_PlushBaby",
                Description = "I have never wanted to punt something across a room more."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Roxanne Wolf (Roxy)",
                AssetPath = "Thumper/Content/Characters/Roxy/SK_Roxy",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Roxy",
                Description = "Make her look beautiful."
            },
            new ManuallyDefinedAsset
            {
                Name = "FNAF 6 Scrap Baby",
                AssetPath = "Thumper/Content/Characters/ScrapBaby/SK_ScrapBaby",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ScrapBaby",
                Description = "You don't really know who your employer is, do you?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Shattered Chica",
                AssetPath = "Thumper/Content/Characters/Shattered_Chica/SK_Chica_Shattered",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ShatteredChica",
                Description = "She used to be full."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Shattered Roxy",
                AssetPath = "Thumper/Content/Characters/Shattered_Roxy/SK_Roxy_ShatteredNoJaw",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_ShatteredRoxy",
                Description = "She was once the star of a show"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Staffbot",
                AssetPath = "Thumper/Content/Characters/Staffbot/SK_Staffbot",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Staffbots",
                Description = "Get them ready. or else."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Daycare Attendant (sun/moon)",
                AssetPath = "Thumper/Content/Characters/SunMoon/SK_Moonman",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Moon",
                Description = "Lights off. Light's ON. Lights OFF. LIGHTS ON!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Moon's Hat",
                AssetPath = "Thumper/Content/Characters/SunMoon/SK_Moonman_Hat",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Moon",
                Description = "Lights off. Light's OFF. Lights OFF. LIGHTS OFF!"
            },
            new ManuallyDefinedAsset
            {
                Name = "RUIN Eclipse",
                AssetPath = "Thumper/Content/Characters/SunMoonRuin/SK_Moonman_Ruin",
                IconPath = "avares://FNAFPorting/Assets/HW2/RE.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/RE.png",
                Description = "Harmony"
            },
            new ManuallyDefinedAsset
            {
                Name = "Help Wanted 2 Glitchtrap puppet",
                AssetPath = "Thumper/Content/Characters/Tilt/SK_Tilt_Puppet",
                IconPath = "avares://FNAFPorting/Assets/HW2/GTP.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/GTP.png",
                Description = "Uif rctwb lt KVUV ihwwjoh uvcuwhe. Fbv aqxu fblf."
            },
            new ManuallyDefinedAsset
            {
                Name = "Security Breach Vanny",
                AssetPath = "Thumper/Content/Characters/Vanny/SK_Vanny",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Vanny",
                Description = "The masked bunny"
            },
            new ManuallyDefinedAsset
            {
                Name = "Secret of the Mimic White Tiger",
                AssetPath = "Thumper/Content/Characters/WhiteTiger/SK_WhiteTiger",
                IconPath = "avares://FNAFPorting/Assets/HW2/whitetiger.png",
                LocalIconPath = "avares://FNAFPorting/Assets/HW2/whitetiger.png",
                Description = "David's favorite."
            },
            new ManuallyDefinedAsset
            {
                Name = "Sister Location Yenndo",
                AssetPath = "Thumper/Content/Characters/Yenndo/SK_Yendo",
                IconPath = "Thumper/Content/Shading_Assets/Textures/Icons/GalleryIcons/T_GalleryBust_Yenndo",
                Description = "MY SKINNNNNNNN EUUUGAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHH - Yendo (probably)"
            }
    ];

    private static readonly ManuallyDefinedAsset[] SecurityBreachAnimatronics =
    [
            new ManuallyDefinedAsset
            {
                Name = "The Blob",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Blob/RIG_Blob",
                IconPath = "avares://FNAFPorting/Assets/SB/Blob.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Blob.png",
                Description = "A little bit of everyone."
            },
            new ManuallyDefinedAsset
            {
                Name = "Burntrap",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Burntrap/RIG_Burntrap",
                IconPath = "avares://FNAFPorting/Assets/SB/Afton.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Afton.png",
                Description = "I will always. always come back."
            },
            new ManuallyDefinedAsset
            {
                Name = "Glamrock Chica",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Chica/RIG_Glamrock_Chica",
                IconPath = "avares://FNAFPorting/Assets/SB/CHICA.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/CHICA.png",
                Description = "Greeeeeggooorrryyyyy"
            },
            new ManuallyDefinedAsset
            {
                Name = "DJ Music Man",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/DJ_MusicMan/RIG_DJ_Music_Man",
                IconPath = "avares://FNAFPorting/Assets/SB/DJMM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/DJMM.png",
                Description = "IT'S MUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUSIC MAN!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Endo",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Endo/RIG_Endo",
                IconPath = "avares://FNAFPorting/Assets/SB/Endo.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Endo.png",
                Description = "*endo activation noise* (ps the endo warehouse is bottom 10 gaming moments in any game)"
            },
            new ManuallyDefinedAsset
            {
                Name = "Glamrock Freddy",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Freddy/RIG_Glamrock_Freddy",
                IconPath = "avares://FNAFPorting/Assets/SB/GRFred.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/GRFred.png",
                Description = "You're my superstar."
            },
            new ManuallyDefinedAsset
            {
                Name = "Gregory",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Gregory/RIG_Gregory_",
                IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021",
                Description = "I.. I'm gregory"
            },
            new ManuallyDefinedAsset
            {
                Name = "Lil DJ Music Man",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Lil_DJ_Music_Man/RIG_Little_DJ_Music_Man",
                IconPath = "avares://FNAFPorting/Assets/SB/LDJMM.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/LDJMM.png",
                Description = "Mini!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Montgomery Gator (Monty)",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Monty/RIG_Montgomery_Gator",
                IconPath = "avares://FNAFPorting/Assets/SB/mont.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/mont.png",
                Description = "ROCK AND ROLL!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Sun (Daycare Attendant)",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/MoonMan/RIG_Sunman",
                IconPath = "avares://FNAFPorting/Assets/SB/Sun.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Sun.png",
                Description = "GLITTER GLUE! I HAVE TOOOOOONS OF GLITTER GLUE!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Moon (Daycare Attendant)",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/MoonMan/RIG_MoonMan",
                IconPath = "avares://FNAFPorting/Assets/SB/Moon.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Moon.png",
                Description = "Nighty Night..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Roxane Wolf (Roxy)",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Roxy/RIG_Glamrock_Roxy",
                IconPath = "avares://FNAFPorting/Assets/SB/Roxy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Roxy.png",
                Description = "I'm the best. The BEST."
            },
            new ManuallyDefinedAsset
            {
                Name = "Shattered Chica",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Chica/RIG_Shattered_Chica",
                IconPath = "avares://FNAFPorting/Assets/SB/SHATICA.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/SHATICA.png",
                Description = "She may be shattered, but her anger (and gluttony) still survive."
            },
            new ManuallyDefinedAsset
            {
                Name = "Shattered Monty",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Monty/RIG_Shattered_Montgomery",
                IconPath = "avares://FNAFPorting/Assets/SB/Shattered Monty.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Shattered Monty.png",
                Description = "No legs, no problem"
            },
            new ManuallyDefinedAsset
            {
                Name = "Shattered Roxy",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Shattered_Roxy/RIG_Shattered_Roxy",
                IconPath = "avares://FNAFPorting/Assets/SB/Shatxy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Shatxy.png",
                Description = "Am.. Am I still the best..?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Staff Bot (Will have styles later)",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Staffbot/RIG_Chefbot",
                IconPath = "fnaf9/Content/ShadingAssets/Textures/TEX_FatalAccidents-poster",
                Description = "take a map. take. a. map. take it. the map? Take it. (this is temporary)"
            },
            new ManuallyDefinedAsset
            {
                Name = "Vanessa",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Vanessa/RIG_Vanessa",
                IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021",
                Description = "Gregory... Come meet me at the front stage."
            },
            new ManuallyDefinedAsset
            {
                Name = "Vanny",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/Vanny/RIG_Vanny",
                IconPath = "avares://FNAFPorting/Assets/SB/Vanny.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Vanny.png",
                Description = "I see you..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Ruined Chica",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Chica/SK_DLC_Chica",
                IconPath = "avares://FNAFPorting/Assets/SB/Chuin.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Chuin.png",
                Description = "We all know who caused what"
            },
            new ManuallyDefinedAsset
            {
                Name = "Ruined Monty",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Monty/SK_Monty_DLC",
                IconPath = "avares://FNAFPorting/Assets/SB/ruin monty.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/ruin monty.png",
                Description = "Even more legless!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Scrapped Rabbit",
                AssetPath = "fnaf9/Content/Model_Assets/Chars/DLC_Chars/DLC_Rabbit/SK_DLC_Rabbit",
                IconPath = "avares://FNAFPorting/Assets/SB/scrap.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/scrap.png",
                Description = "Never meant to be seen..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Ruined Roxy",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Roxy/SK_Roxy_DLC",
                IconPath = "avares://FNAFPorting/Assets/SB/RRoxy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/RRoxy.png",
                Description = "Wait... Cassie?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Candy Cadet",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_CandyCadet/SK_DLC_CandyCadet",
                IconPath = "avares://FNAFPorting/Assets/SB/Candy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Candy.png",
                Description = "Come get your candy. Candy. Candy."
            },
            new ManuallyDefinedAsset
            {
                Name = "Ruined Freddy (Prototype)",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Freddy/SK_DLC_Freddy",
                IconPath = "avares://FNAFPorting/Assets/SB/Reddy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Reddy.png",
                Description = "*Headless Shreaks*"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mascot Mimic",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Mascot/SK_Mascot4",
                IconPath = "avares://FNAFPorting/Assets/SB/mascot.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/mascot.png",
                Description = "In order to go forward, we need to take a step into the past."
            },
            new ManuallyDefinedAsset
            {
                Name = "Maskbot",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Maskbot/SK_Maskbot",
                IconPath = "avares://FNAFPorting/Assets/SB/Bot.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Bot.png",
                Description = "Take a... Mask?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Scooper",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Scooper/SK_DLC_Scooper",
                IconPath = "avares://FNAFPorting/Assets/SB/scoop.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/scoop.png",
                Description = "It won't hurt for long..."
            },
            new ManuallyDefinedAsset
            {
                Name = "MXES",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Rabbit_6x/SK_DLC_Rabbit_6x",
                IconPath = "avares://FNAFPorting/Assets/SB/MXES.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/MXES.png",
                Description = "Fiona..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Cassie",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_Player/SK_DLC_Player_Body",
                IconPath = "fnaf9/Content/ShadingAssets/Textures/LoadingSprites/HelpyLoading/Helpy_Anim_pizza0021",
                Description = "Gregory? What... are you?"
            },
            new ManuallyDefinedAsset
            {
                Name = "The Mimic",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_OldEndo/SK_DLC_Old_Endo",
                IconPath = "avares://FNAFPorting/Assets/SB/Mimi.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/Mimi.png",
                Description = "MY NAME IS THE FUCKING MIMIC OH YEAH!!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Eclipse",
                AssetPath = "fnaf9/Plugins/Chowda/Content/Characters/DLC_MoonSun/SK_Moonman_DLC",
                IconPath = "avares://FNAFPorting/Assets/SB/eclipse.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SB/eclipse.png",
                Description = "Merged, finally."
            }
    ];

    private static readonly ManuallyDefinedAsset[] FLAFAnimatronics =
    [
            new ManuallyDefinedAsset
            {
                Name = "Balloon Boy (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/BB/SK_BalloonBoy",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/BB/bbicon_base",
                Description = "Hello? hahaha! Hi. Hahaha! Hahahaha!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Bonnie (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Bonnie/SK_Bonnie",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Bonnie/bonnieicon_base",
                Description = "Listen to this sick solo!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Chica (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Chica/SK_Chica",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Chica/chicaicon_base",
                Description = "Just a bird who likes to eat!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Foxy (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Foxy/SK_Foxy",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Foxy/foxyicon_base",
                Description = "The pirate fox!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Freddy (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Freddy/SK_Freddy",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Freddy/freddyicon_base",
                Description = "The leader of the group!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mangle (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Mangle/SK_Mangle",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Mangle/mangleicon_base",
                Description = "Taken apart. Put back together."
            },
            new ManuallyDefinedAsset
            {
                Name = "Puppet (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Puppet/SK_Puppet",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Puppet/puppeticon_base",
                Description = "wind the box up!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Springtrap (FLAF)",
                AssetPath = "flaf/Content/Meshes/Characters/Springtrap/SK_Springtrap",
                IconPath = "flaf/Content/UI/CharacterIcons/NewInTrack/Springtrap/springtrapicon_base",
                Description = "Evil."
            },
            new ManuallyDefinedAsset
            {
                Name = "Wolf Endo (FLAF)",
                AssetPath = "flaf/Content/Meshes/Enemy/WolfEndo/SK_WolfEndo",
                IconPath = "flaf/Content/UI/Items/Jumpscare/jumpscare",
                Description = "Just an NPC"
            }
    ];

    private static readonly ManuallyDefinedAsset[] SotMAnimatronics =
    [
            new ManuallyDefinedAsset
            {
                Name = "Player Hands",
                AssetPath = "FNAF_SOTM/Content/Characters/PlayerArms/SK_Player_Arms",
                IconPath = "avares://FNAFPorting/Assets/SotM/PlayerHands.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PlayerHands.png",
                Description = "Arnold."
            },
            new ManuallyDefinedAsset
            {
                Name = "Dead Guy with a bee head",
                AssetPath = "FNAF_SOTM/Content/Characters/OtherWorkers/SK_OtherWorkers_SpringBeeHead",
                IconPath = "avares://FNAFPorting/Assets/SotM/DeadGuy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/DeadGuy.png",
                Description = "An unfortunate case."
            },
            new ManuallyDefinedAsset
            {
                Name = "Dead Guy in a jester suit",
                AssetPath = "FNAF_SOTM/Content/Characters/OtherWorkers/WorkerJester/SK_WorkerJester",
                IconPath = "avares://FNAFPorting/Assets/SotM/WorkerJester.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/WorkerJester.png",
                Description = "Lost in the maze"
            },
            new ManuallyDefinedAsset
            {
                Name = "Big Top",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/BigTop/SK_BigTop",
                IconPath = "avares://FNAFPorting/Assets/SotM/BigTop.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/BigTop.png",
                Description = "Tickets Please."
            },
            new ManuallyDefinedAsset
            {
                Name = "Busted/Broken Big Top",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/BigTop/SK_BustedBigTop",
                IconPath = "avares://FNAFPorting/Assets/SotM/BustedBigTop.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/BustedBigTop.png",
                Description = "T... Ickets... Ple...."
            },
            new ManuallyDefinedAsset
            {
                Name = "Jackie",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie",
                IconPath = "avares://FNAFPorting/Assets/SotM/Jackie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jackie.png",
                Description = "Wind it up."
            },
            new ManuallyDefinedAsset
            {
                Name = "Jackie (Detattched)",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_JackieB",
                IconPath = "avares://FNAFPorting/Assets/SotM/JackieB.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieB.png",
                Description = "Here I come!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jackie Broken Stage 1",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie_C",
                IconPath = "avares://FNAFPorting/Assets/SotM/JackieC.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieC.png",
                Description = "WHO WANTS A BIRTHDAY HUG!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jackie Broken Stage 2",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/Jackie/SK_Jackie_D",
                IconPath = "avares://FNAFPorting/Assets/SotM/JackieD.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/JackieD.png",
                Description = "MY NAME IS JACKIE. I'M FUCKING BACKIE."
            },
            new ManuallyDefinedAsset
            {
                Name = "MR2ND",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/M2RND/SK_M2RND",
                IconPath = "avares://FNAFPorting/Assets/SotM/MR2ND.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MR2ND.png",
                Description = "Prototype. Prototype."
            },
            new ManuallyDefinedAsset
            {
                Name = "The Mimic",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/Mimic/SK_Mimic",
                IconPath = "avares://FNAFPorting/Assets/SotM/Mimic.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mimic.png",
                Description = "Built for David. Built by David."
            },
            new ManuallyDefinedAsset
            {
                Name = "Nurse Dollie",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie",
                IconPath = "avares://FNAFPorting/Assets/SotM/Dollie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Dollie.png",
                Description = "Recycle!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mimic Nurse Dollie",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie_B",
                IconPath = "avares://FNAFPorting/Assets/SotM/MimicDollie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MimicDollie.png",
                Description = "LOOK AT THESE LEGS MMMHMMMMMM!!!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Molten Nurse Dollie",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/NurseDolly/SK_NurseDollie_C",
                IconPath = "avares://FNAFPorting/Assets/SotM/MoltenDollie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MoltenDollie.png",
                Description = "Made from Tungsten"
            },
            new ManuallyDefinedAsset
            {
                Name = "Party Chica",
                AssetPath = "FNAF_SOTM/Content/Characters/Primary/PChica/SK_PChica",
                IconPath = "avares://FNAFPorting/Assets/SotM/Partychica.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Partychica.png",
                Description = "Welcome to the Party World!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mimic Birthday Puppy",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/BirthdayPuppy/SK_BirthdayPuppy",
                IconPath = "avares://FNAFPorting/Assets/SotM/MimicBirthdayPuppy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MimicBirthdayPuppy.png",
                Description = "Arf arf!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Birthday Puppy",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/BirthdayPuppy/SK_FoamBirthdayPuppy",
                IconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBirthdayPuppy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBirthdayPuppy.png",
                Description = "The birthday hasn't started yet."
            },
            new ManuallyDefinedAsset
            {
                Name = "Birthday Elephant",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/ElephantMascot/SK_Elephant",
                IconPath = "avares://FNAFPorting/Assets/SotM/Birthday Elephant.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Elephant.png",
                Description = "Let's go!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Birthday Elephant",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamElephant/SK_FoamElephant",
                IconPath = "avares://FNAFPorting/Assets/SotM/Prototype Birthday Elephant.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Birthday Elephant.png",
                Description = "Foam."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Lion",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamLion/SK_FoamLion",
                IconPath = "avares://FNAFPorting/Assets/SotM/Prototype Lion.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Lion.png",
                Description = "I can't say much more about these foam ones im ngl."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Penguin",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/FoamPenguin/SK_FoamPenguin",
                IconPath = "avares://FNAFPorting/Assets/SotM/Prototype Penguin.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Penguin.png",
                Description = "Like this is getting ridiculous."
            },
            new ManuallyDefinedAsset
            {
                Name = "Lion",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/Lion/SK_LionMascot",
                IconPath = "avares://FNAFPorting/Assets/SotM/Lion.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Lion.png",
                Description = "ROARRRRR"
            },
            new ManuallyDefinedAsset
            {
                Name = "Penguin",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeA/Penguin/SK_PenguinMascot",
                IconPath = "avares://FNAFPorting/Assets/SotM/Penguin.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Penguin.png",
                Description = "This thing's a penguin???"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Hedgeghog",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/FoamHedgehog/SK_FoamHedgehog",
                IconPath = "avares://FNAFPorting/Assets/SotM/Prototype Hedgehog.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Hedgehog.png",
                Description = "again. another proto."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Sharpay",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/FoamSharpay/SK_FoamSharpay",
                IconPath = "avares://FNAFPorting/Assets/SotM/FoamSharpay.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/FoamSharpay.png",
                Description = "no desc- nah jk im just done with the foam."
            },
            new ManuallyDefinedAsset
            {
                Name = "Hedgehog",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/Hedgehog/SK_Hedgehog",
                IconPath = "avares://FNAFPorting/Assets/SotM/Hedgehog.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Hedgehog.png",
                Description = "Hudgie!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Lemur",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/Lemur/SK_Lemur",
                IconPath = "avares://FNAFPorting/Assets/SotM/Lemur.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Lemur.png",
                Description = "This is in the game?? I never saw it."
            },
            new ManuallyDefinedAsset
            {
                Name = "Poodle",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeB/SharpayPoodle/SK_Sharpay",
                IconPath = "avares://FNAFPorting/Assets/SotM/Poodle.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Poodle.png",
                Description = "Sharpay! Poodle! It's codenamed BOTH!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Bee",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/FoamBee/SK_FoamSwingBee",
                IconPath = "avares://FNAFPorting/Assets/SotM/Prototype Bee.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Prototype Bee.png",
                Description = "Prototype. Again."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype (Foam) Mushroom",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/FoamMushroom/SK_FoamMushroom",
                IconPath = "avares://FNAFPorting/Assets/SotM/Foam Mushroom.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Foam Mushroom.png",
                Description = "I like this guy at least, the mushroom men were cool!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jester",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/Jester/SK_JesterMascot",
                IconPath = "avares://FNAFPorting/Assets/SotM/Jester.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jester.png",
                Description = "What a fun time..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Mushroom",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/Mushrooms/SK_MushroomMascot",
                IconPath = "avares://FNAFPorting/Assets/SotM/Mushroom.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mushroom.png",
                Description = "The Mycellium Men!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Bee",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/BodyTypeC/SwingBee/SK_SwingBeeSuit",
                IconPath = "avares://FNAFPorting/Assets/SotM/Bee.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bee.png",
                Description = "Buzzzzz"
            },
            new ManuallyDefinedAsset
            {
                Name = "Moon",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/NightLight/SK_Nightlight",
                IconPath = "avares://FNAFPorting/Assets/SotM/Moon.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Moon.png",
                Description = "With lillies or spread, his babies wee bed. (The undead husk, waiting for eternal serenity.)"
            },
            new ManuallyDefinedAsset
            {
                Name = "Bub (Springlock)",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/Bub/SK_BubSpringlock",
                IconPath = "avares://FNAFPorting/Assets/SotM/Bub.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bub.png",
                Description = "His origin is known. Rest now Sparky, for you are now Bub."
            },
            new ManuallyDefinedAsset
            {
                Name = "Captain (Springlock)",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/CaptainSpringlock/SK_CaptainSpringlock",
                IconPath = "avares://FNAFPorting/Assets/SotM/Captain.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Captain.png",
                Description = "Foxy is a dwimwit."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Monty (Springlock)",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/Monty/SK_MontySpringlock",
                IconPath = "avares://FNAFPorting/Assets/SotM/Springlock Monty.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Monty.png",
                Description = "Soon to be forgotten."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Springbonnie (Springlock)",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/ProtoBonnie/SK_ProtoBonnieSpringlock",
                IconPath = "avares://FNAFPorting/Assets/SotM/Springlock Bonnie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Bonnie.png",
                Description = "The start of a suit that will kill many"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Fredbear (Springlock)",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/Springlocks/ProtoFredBear/SK_ProtoFredBearSpringlock",
                IconPath = "avares://FNAFPorting/Assets/SotM/Springlock Freddy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Springlock Freddy.png",
                Description = "Watch out for the teeth."
            },
            new ManuallyDefinedAsset
            {
                Name = "White Tiger",
                AssetPath = "FNAF_SOTM/Content/Characters/Secondary/WhiteTiger/SK_WhiteTiger",
                IconPath = "avares://FNAFPorting/Assets/SotM/White Tiger.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/White Tiger.png",
                Description = "David's Favorite. Forever."
            },
            new ManuallyDefinedAsset
            {
                Name = "Birthday Hats",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/BirthdayHats/SK_BirthdayHats",
                IconPath = "avares://FNAFPorting/Assets/SotM/Birthday Hats.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Hats.png",
                Description = "These guys are fun aren't they!?"
            },
            new ManuallyDefinedAsset
            {
                Name = "Sitting Birthday Puppy",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/BirthdayPuppy/SK_BirthdayPuppy",
                IconPath = "avares://FNAFPorting/Assets/SotM/Birthday Puppy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Birthday Puppy.png",
                Description = "Just a prop."
            },
            new ManuallyDefinedAsset
            {
                Name = "Bosun Puppet",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_BosunPuppet",
                IconPath = "avares://FNAFPorting/Assets/SotM/Bosun Puppet.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Bosun Puppet.png",
                Description = "One of the captain's crew."
            },
            new ManuallyDefinedAsset
            {
                Name = "Foxy Puppet",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_CaptainFoxyPuppet",
                IconPath = "avares://FNAFPorting/Assets/SotM/Foxy Puppet.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Foxy Puppet.png",
                Description = "His uprising will impress many, including his captain."
            },
            new ManuallyDefinedAsset
            {
                Name = "Kit Puppet",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_KitPuppet",
                IconPath = "avares://FNAFPorting/Assets/SotM/Kit Puppet.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Kit Puppet.png",
                Description = "One of the captain's crew"
            },
            new ManuallyDefinedAsset
            {
                Name = "Renard Puppet",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_RenardPuppet",
                IconPath = "avares://FNAFPorting/Assets/SotM/Renard.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Renard.png",
                Description = "Chef of the ship."
            },
            new ManuallyDefinedAsset
            {
                Name = "Roxy Puppet",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CaptainFoxyAndCrew/SK_RoxyPuppet",
                IconPath = "avares://FNAFPorting/Assets/SotM/Roxy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Roxy.png",
                Description = "Poor thing... you will soon be the best."
            },
            new ManuallyDefinedAsset
            {
                Name = "Cupcake Pal",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/CupcakePal/SK_CupCakePal",
                IconPath = "avares://FNAFPorting/Assets/SotM/CupCakePal.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/CupCakePal.png",
                Description = "Carl's Greatest ancestor."
            },
            new ManuallyDefinedAsset
            {
                Name = "Diving Seal",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/DivingSeal/SK_DivingSeal",
                IconPath = "avares://FNAFPorting/Assets/SotM/Diving Seal.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Diving Seal.png",
                Description = "A death defying dive!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jugband Male Frog",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandFrogs/SK_BoyFrog",
                IconPath = "avares://FNAFPorting/Assets/SotM/Male Frog.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Male Frog.png",
                Description = "All in a band!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jugband Female Frog",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandFrogs/SK_GirlFrog",
                IconPath = "avares://FNAFPorting/Assets/SotM/Female Frog.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Female Frog.png",
                Description = "Forever in a band!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Jugband Hippo",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugbandHippo/SK_JugBandHippo",
                IconPath = "avares://FNAFPorting/Assets/SotM/Jugbang Hippo.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jugbang Hippo.png",
                Description = "The hippest hippo of all."
            },
            new ManuallyDefinedAsset
            {
                Name = "Jugband Monty",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugBandMonty/SK_JugBandMonty",
                IconPath = "avares://FNAFPorting/Assets/SotM/Jugband Monty.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Jugband Monty.png",
                Description = "See you soon old pal"
            },
            new ManuallyDefinedAsset
            {
                Name = "Juggling Duck",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/JugglingDuck/SK_JugglingDuck",
                IconPath = "avares://FNAFPorting/Assets/SotM/Juggling Duck.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Juggling Duck.png",
                Description = "One of Chippy's favorites!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mannequin",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Mannequin/SK_Mannequin",
                IconPath = "avares://FNAFPorting/Assets/SotM/Mannequin.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mannequin.png",
                Description = "I want to buy more!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mr. Helpful",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/MrHelpy/SK_MrHelpful",
                IconPath = "avares://FNAFPorting/Assets/SotM/MrHelpful.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MrHelpful.png",
                Description = "Welcome to Murray's Costume Manor!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mrs. Helpful",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/MrHelpy/SK_MrsHelpful",
                IconPath = "avares://FNAFPorting/Assets/SotM/MrsHelpful.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/MrsHelpful.png",
                Description = "Enter your data diver!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Mailbot (Office Animatronic)",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/OfficeAnimatronic/SK_Office_Animatronic",
                IconPath = "avares://FNAFPorting/Assets/SotM/Mailbot (OfficeAnimatronic).png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Mailbot (OfficeAnimatronic).png",
                Description = "Mail call!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic 1",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtoMimic_B",
                IconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 1.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 1.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic 2",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B2",
                IconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 2.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 2.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic 3",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B3",
                IconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 3.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 3.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic 4",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B4",
                IconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 4.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 4.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic 5",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_Protomimic_B5",
                IconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 5.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Protomimic 5.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic Legs 1",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_A",
                IconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic Legs 2",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_C",
                IconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs1.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs1.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic Legs 3",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_D",
                IconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs2.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs2.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic Legs 4",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_D2",
                IconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs3.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs3.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Protomimic Legs 5",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Protomimics/SK_ProtomimicLegs_E",
                IconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs4.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/ProtomimicLegs4.png",
                Description = "A disastrous attempt"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Bonnie",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoBonnie",
                IconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBonnie.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeBonnie.png",
                Description = "A future guitarist"
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Chica",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoChica",
                IconPath = "avares://FNAFPorting/Assets/SotM/PrototypeChica.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeChica.png",
                Description = "Not quite hungry yet..."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Foxy",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoFoxy",
                IconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFoxy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFoxy.png",
                Description = "He proved his worth."
            },
            new ManuallyDefinedAsset
            {
                Name = "Prototype Freddy",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Prototypes/SK_ProtoFreddy",
                IconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFreddy.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/PrototypeFreddy.png",
                Description = "The leader of the group, soon to be."
            },
            new ManuallyDefinedAsset
            {
                Name = "Ringmaster Rat",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/RingmasterRat/SK_RingmasterRat",
                IconPath = "avares://FNAFPorting/Assets/SotM/Ringmaster Rat.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Ringmaster Rat.png",
                Description = "A little guy!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Star 1",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_A",
                IconPath = "avares://FNAFPorting/Assets/SotM/Star1.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star1.png",
                Description = "Twinkle Twinkle Little Star."
            },
            new ManuallyDefinedAsset
            {
                Name = "Star 2",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_B",
                IconPath = "avares://FNAFPorting/Assets/SotM/Star2.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star2.png",
                Description = "How I Wonder What You Are."
            },
            new ManuallyDefinedAsset
            {
                Name = "Star 3",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_C",
                IconPath = "avares://FNAFPorting/Assets/SotM/Star3.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star3.png",
                Description = "Up Above The World So High."
            },
            new ManuallyDefinedAsset
            {
                Name = "Star 4",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/Stars/SK_Star_D",
                IconPath = "avares://FNAFPorting/Assets/SotM/Star4.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Star4.png",
                Description = "Like A Diamond In The Sky."
            },
            new ManuallyDefinedAsset
            {
                Name = "Swinging Bee",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/SwingBee/SK_SwingBee",
                IconPath = "avares://FNAFPorting/Assets/SotM/Swinging Bee.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Swinging Bee.png",
                Description = "In the air!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Vacbot",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/VacuumBot/SK_VacuumBot",
                IconPath = "avares://FNAFPorting/Assets/SotM/Vacbot.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Vacbot.png",
                Description = "You can pet the bots!"
            },
            new ManuallyDefinedAsset
            {
                Name = "Rocktopus",
                AssetPath = "FNAF_SOTM/Content/Characters/Tertiary/WelcomeShowOctopus/SK_WelcomeShowOctopus",
                IconPath = "avares://FNAFPorting/Assets/SotM/Rocktopus.png",
                LocalIconPath = "avares://FNAFPorting/Assets/SotM/Rocktopus.png",
                Description = "Such a cool guy"
            }
    ];
    
    private static readonly ManuallyDefinedAsset[] Chapter1Animatronics = [];

    private static readonly ManuallyDefinedAsset[] AllAnimatronics = [
        ..HelpWantedAnimatronics, 
        ..HelpWanted2Animatronics, 
        ..SecurityBreachAnimatronics, 
        ..FLAFAnimatronics, 
        ..SotMAnimatronics, 
        ..Chapter1Animatronics
    ];

    private static readonly ManuallyDefinedAsset[] HelpWantedItems =
    [
            new ManuallyDefinedAsset
            {
                Name = "Faz Tokens",
                AssetPath = "freddys/Content/ProductionAssets/Models/Environments/ENV_MOD_FreddyToken01",
                IconPath = "freddys/Content/ProductionAssets/UI_Assets/Textures/FNAFVR_UI_CoinFull",
                Description = "Cha-Ching! YAYYY!!"
            }
    ];

    private static readonly ManuallyDefinedAsset[] HelpWanted2Items = [];

    private static readonly ManuallyDefinedAsset[] SecurityBreachItems = [];

    private static readonly ManuallyDefinedAsset[] FLAFItems = [];

    private static readonly ManuallyDefinedAsset[] SotMItems = [];
    
    private static readonly ManuallyDefinedAsset[] Chapter1Items = [];

    private static readonly ManuallyDefinedAsset[] AllItems = [
        ..HelpWantedItems, 
        ..HelpWanted2Items, 
        ..SecurityBreachItems, 
        ..FLAFItems, 
        ..SotMItems, 
        ..Chapter1Items
    ];

}
