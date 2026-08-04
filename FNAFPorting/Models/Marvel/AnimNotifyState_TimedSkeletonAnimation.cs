using CUE4Parse.UE4.Assets.Exports;
using CUE4Parse.UE4.Objects.UObject;

namespace FNAFPorting.Models.Marvel;

public class AnimNotifyState_TimedSkeletonAnimation : UObject
{
    [UProperty] public FSoftObjectPath SkeletalMeshTemplate;
    [UProperty] public FName SocketName;
    [UProperty] public FSoftObjectPath AnimToPlay;
}
