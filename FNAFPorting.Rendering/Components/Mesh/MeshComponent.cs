using FNAFPorting.Rendering.Renderers;
using FNAFPorting.Rendering.Components.Rendering;

namespace FNAFPorting.Rendering.Components.Mesh;

public class MeshComponent : SpatialComponent
{
    public readonly MeshRenderer Renderer;

    public MeshComponent(MeshRenderer renderer)
    {
        Renderer = renderer;
        
        Renderer.Component = this;
        Renderer.Initialize();
    }
}