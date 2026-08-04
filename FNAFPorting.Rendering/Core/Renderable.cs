using FNAFPorting.Rendering.Components.Rendering;
using FNAFPorting.Rendering.Components;

namespace FNAFPorting.Rendering.Core;

public class Renderable
{
    public virtual void Initialize() { }
    public virtual void Update(float deltaTime) { }
    public virtual void Render(CameraComponent camera) { }
    public virtual void Destroy() { }
}