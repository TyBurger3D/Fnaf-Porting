using System.Collections.Generic;
using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Exports.Material;
using FNAFPorting.Exporting.Models;
using FNAFPorting.Exporting.Models.Files.Meta;
using FNAFPorting.Shared.Extensions;

namespace FNAFPorting.Exporting.Types;

public class MaterialExport : BaseExport
{
    public readonly List<ExportMaterial> Materials = [];
    
    public MaterialExport(string name, UObject asset, EExportType exportType, ExportDataMeta metaData, IExportFileMeta? fileMeta) : base(name, exportType, metaData)
    {
        Materials.AddIfNotNull(Exporter.Material((UMaterialInterface)asset, 0));
    }
}