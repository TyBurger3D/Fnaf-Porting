using System;
using System.Threading.Tasks;
using FNAFPorting.Exporting.Models;
using FNAFPorting.Models;

namespace FNAFPorting.Exporting.Types;

public class BaseExport
{
    public string Name;
    public EExportType Type;
    public EPrimitiveExportType PrimitiveType => Type.PrimitiveType;

    protected Context.ExportContext Exporter;
    
    public BaseExport(string name, EExportType exportType, ExportDataMeta metaData)
    {
        Name = name;
        Type = exportType;

        Exporter = new Context.ExportContext(metaData);
    }
    
    public async Task WaitForExports()
    {
        foreach (var task in Exporter.ExportTasks)
        {
            await task.WaitAsync(TimeSpan.FromSeconds(60));
        }
    }
}