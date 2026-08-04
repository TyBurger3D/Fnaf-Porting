using System;
using System.IO;
using System.Linq;
using CUE4Parse.UE4.Versions;

namespace FNAFPorting.Models;

public class UEVersionAttribute(EGame version) : Attribute
{
    public EGame UeVersion = version;
}

public class AESKeyAttribute(string key) : Attribute
{
    public string AesKey = key;
}

public class MappingsFileAttribute(string mappingsFile) : Attribute
{
    public string Mappings = mappingsFile;
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
        return attribute!.UeVersion;
    }

    public static string GetAESKey(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(AESKeyAttribute), false)
            .SingleOrDefault() as AESKeyAttribute;
        return attribute!.AesKey;
    }

    public static string GetMappings(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(MappingsFileAttribute), false)
            .SingleOrDefault() as MappingsFileAttribute;
        return Path.Combine(App.DataFolder.FullName, attribute!.Mappings);
    }

    public static bool HasMappings(this Enum value)
    {
        var attribute = value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(MappingsFileAttribute), false);
        return attribute?.Length > 0;
    }
}
