using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Plugin;

namespace FNAFPorting.Views.Plugin;

public partial class UnrealPluginView : ViewBase<UnrealPluginViewModel>
{
    public UnrealPluginView() : base(AppSettings.Plugin.Unreal)
    {
        InitializeComponent();
    }
}