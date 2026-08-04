using System;
using System.Collections.Generic;
using System.Linq;
using CUE4Parse.GameTypes.FN.Assets.Exports.DataAssets;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Exports.Texture;
using FNAFPorting.Exporting.Models;
using FNAFPorting.Exporting.Models.Files.Meta;
using FNAFPorting.Models.Assets;
using FNAFPorting.Models.Unreal;
using FNAFPorting.ViewModels.Settings;
using FNAFPorting.Extensions;
using FNAFPorting.Models.Fortnite;
using FNAFPorting.Shared.Extensions;
using Path = System.IO.Path;

namespace FNAFPorting.Exporting.Types;

public class TextureExport : BaseExport
{
    public List<ExportTexture> Textures = [];
    
    private static readonly Dictionary<EExportType, string> TextureNames = new()
    {
        { EExportType.Spray, "DecalTexture" },
        { EExportType.Banner, "LargePreviewImage" },
        { EExportType.LoadingScreen, "BackgroundImage" },
        { EExportType.Emoticon, "SpriteSheet" }
    };
    
    public TextureExport(string name, UObject asset, EExportType exportType, ExportDataMeta metaData, IExportFileMeta? fileMeta) : this(name, asset, [], exportType, metaData, fileMeta)
    {
    }

    public TextureExport(string name, UObject asset, BaseStyleData[] styles, EExportType exportType, ExportDataMeta metaData, IExportFileMeta? fileMeta) : base(name, exportType, metaData)
    {
        if (styles.Length > 0 && !string.Equals(styles[0].StyleName, name, StringComparison.Ordinal))
            Name = $"{name} - {styles[0].StyleName}";

        var textures = new List<UTexture>();
        var softTextures = styles.OfType<SoftTextureStyleData>().ToArray();
        if (softTextures.Length > 0)
        {
            foreach (var softTexture in softTextures)
            {
                if (UEParse.Provider.TryLoadPackageObject(softTexture.TexturePath, out UTexture texture))
                    textures.Add(texture);
            }
        }
        else
        {
            switch (asset)
            {
                case UVirtualTextureBuilder virtualTextureBuilder:
                {
                    textures.AddIfNotNull(virtualTextureBuilder.Texture.Load<UVirtualTexture2D>());
                    break;
                }
                case UTexture texture:
                {
                    textures.Add(texture);
                    break;
                }
                case UBuildingTextureData textureData:
                {
                    textures.AddIfNotNull(textureData.Diffuse.Load<UTexture2D>());
                    textures.AddIfNotNull(textureData.Normal.Load<UTexture2D>());
                    textures.AddIfNotNull(textureData.Specular.Load<UTexture2D>());
                    break;
                }
                default:
                {
                    textures.AddIfNotNull(asset.GetOrDefault<UTexture2D?>(TextureNames[exportType]) ?? asset.GetDataListItem<UTexture2D>("LargeIcon", "Icon"));
                    break;
                }
            }
        }

        var textureOpenPaths = new HashSet<string>();
        foreach (var texture in textures)
        {
            if (metaData.ExportLocation.IsFolder)
            {
                var exportPath = Exporter.Export(texture, returnRealPath: true, synchronousExport: true);
                if (Path.GetDirectoryName(exportPath) is { } exportFolder)
                    textureOpenPaths.Add(exportFolder);
            }
            else
            {
                Textures.Add(new ExportTexture(Exporter.Export(texture), texture.SRGB, texture.CompressionSettings));
            }
        }

        if (metaData.ExportLocation.IsFolder &&
            metaData.Settings is FolderSettingsViewModel { OpenFoldersOnExport: true })
        {
            textureOpenPaths.ForEach(path => App.Launch(path));
        }
       
    }
    
}
