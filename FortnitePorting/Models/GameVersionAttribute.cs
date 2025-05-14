using System;
using System.Linq;
using CUE4Parse.UE4.Versions;

namespace FortnitePorting.Models;

public class UEVersionAttribute(EGame version) : Attribute
{
    public EGame UeVersion = version;
}

public class AESKeyAttribute(string key) : Attribute
{
    public string AesKey = key;
}

public static class GameVersionExtensions
{
    public static EGame GetUEVersion(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(UEVersionAttribute), false)
            .SingleOrDefault() as UEVersionAttribute;
        return attribute.UeVersion;
    }
    
    public static string GetAESKey(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(AESKeyAttribute), false)
            .SingleOrDefault() as AESKeyAttribute;
        return attribute.AesKey;
    }
}