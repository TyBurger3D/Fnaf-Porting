using FNAFPorting.Rendering.Actors;
using FNAFPorting.Rendering.Core;

namespace FNAFPorting.Rendering.Components;

public class Component(string name)
{
    public string Name = name;
    
    public Actor? Actor;
}