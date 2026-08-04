using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Assets.Exports.Rig;
using CUE4Parse.UE4.Objects.Engine.Animation;
using FNAFPorting.Exporting.Models;
using FNAFPorting.Exporting.Models.Files.Meta;

namespace FNAFPorting.Exporting.Types;

public class PoseAssetExport : BaseExport
{
    public string PoseAsset;
    
    public PoseAssetExport(string name, UObject asset, EExportType exportType, ExportDataMeta metaData, IExportFileMeta? fileMeta) : base(name, exportType, metaData)
    {
        if (metaData.ExportLocation.IsFolder)
        {
            Info.Message("Pose Asset Export", "Pose Assets cannot be exported to a folder.");
            return;
        }

        PoseAsset = asset switch
        {
            UPoseAsset poseAsset => Exporter.Export(poseAsset),
            UDNAAsset dnaAsset => Exporter.Export(dnaAsset),
            _ => null
        };
    }
    
}
