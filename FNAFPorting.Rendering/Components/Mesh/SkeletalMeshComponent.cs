using CUE4Parse.UE4.Assets.Exports.SkeletalMesh;
using FNAFPorting.Rendering.Renderers;

namespace FNAFPorting.Rendering.Components.Mesh;

public class SkeletalMeshComponent(USkeletalMesh mesh) : MeshComponent(new SkeletalMeshRenderer(mesh));