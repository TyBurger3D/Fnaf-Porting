using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Plugin;

namespace FNAFPorting.Views.Plugin;

public partial class BlenderPluginView : ViewBase<BlenderPluginViewModel>
{
    public BlenderPluginView() : base(AppSettings.Plugin.Blender)
    {
        InitializeComponent();
    }
}