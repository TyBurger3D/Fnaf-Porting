using FNAFPorting.Rendering.Components.Rendering;
using FNAFPorting.Rendering.Components;
using FNAFPorting.Rendering.Core;

namespace FNAFPorting.Rendering.Actors;

public class CameraActor : Actor
{
    public CameraComponent Camera { get; }

    public CameraActor(string name) : base(name)
    {
        Camera = new CameraComponent();
        Components.Add(Camera);
    }
}