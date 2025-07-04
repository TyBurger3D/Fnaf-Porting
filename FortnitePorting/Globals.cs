global using static FortnitePorting.Services.ApplicationService;
using System.Collections.ObjectModel;
using Avalonia.Platform.Storage;
using CUE4Parse.UE4.Objects.Core.Misc;
using FortnitePorting.Shared.Models;

namespace FortnitePorting;

public static class Globals
{
    public static string VersionString => Version.GetDisplayString(EVersionStringType.IdentifierPrefix);
    public static readonly FPVersion Version = new(0, 2, 0, identifier: "Beta");
    public const string OnlineTag = "FNAFPorting";
    
    public static readonly FilePickerFileType MappingsFileType = new("Unreal Mappings") { Patterns = [ "*.usmap" ] };
    public static readonly FilePickerFileType JSONFileType = new("JSON") { Patterns = [ "*.json" ] };
    public static readonly FilePickerFileType MP3FileType = new("MP3 Audio") { Patterns = [ "*.mp3" ] };
    public static readonly FilePickerFileType WAVFileType = new("WAV Audio") { Patterns = [ "*.wav" ] };
    public static readonly FilePickerFileType OGGFileType = new("OGG Audio") { Patterns = [ "*.ogg" ] };
    public static readonly FilePickerFileType FLACFileType = new("FLAC Audio") { Patterns = [ "*.flac" ] };
    public static readonly FilePickerFileType PNGFileType = new("PNG Image") { Patterns = [ "*.png" ] };
    public static readonly FilePickerFileType GIFFileType = new("GIF Image") { Patterns = [ "*.gif" ] };
    public static readonly FilePickerFileType ImageFileType = new("Image") { Patterns = [ "*.png", "*.jpg", "*.jpeg", "*.tga" ] };
    public static readonly FilePickerFileType PlaylistFileType = new("Fortnite Porting Playlist") { Patterns = [ "*.fp.playlist" ] };
    public static readonly FilePickerFileType ChatAttachmentFileType = new("Image") { Patterns = [ "*.png", "*.jpg", "*.jpeg" ] };
    public static readonly FilePickerFileType BlenderFileType = new("Blender") { Patterns = ["blender.exe"] };
    public static readonly FilePickerFileType UnrealProjectFileType = new("Unreal Project") { Patterns = ["*.uproject"] };
    
    public static readonly FGuid ZERO_GUID = new();
    public const string ZERO_CHAR = "0x0000000000000000000000000000000000000000000000000000000000000000";
    
    public const string HELP_WANTED_AES = "0x710891DF17EAFFCA17CB0620F0F0DCA90A00C657F49BC131D4110B265EC2E41E";
    public const string SECURITY_BREACH_AES = "0x85F7D4007015493ED0359C9007266038F8F7B1F96988F19A610103874CC95286";
    public const string SOTM_AES = "0x38CE9CDC970FF5A18F5980CB0CE729495ED103A5388A81A58C32E9CA8AD776E1";
    public const string DBD_AES = "0x22B1639B548124925CF7B9CBAA09F9AC295FCF0324586D6B37EE1D42670B39B3";

    public const string DBD_MAPPINGS = "DBD_8.6.0.usmap";
    
    public static readonly ReadOnlyCollection<string> LATEST_EXTRA_AES = new([]);
    
    public const string DISCORD_URL = "https://discord.gg/E9krSwRWZH";
    public const string TWITTER_URL = "https://x.com/FNAFPORTING";
    public const string GITHUB_URL = "https://github.com/TyBurger3D/FNAFPorting";
    public const string KOFI_URL = "https://ko-fi.com/halfuwu";
}