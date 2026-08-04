using System;
using System.Globalization;
using Avalonia.Data.Converters;
using FNAFPorting.Extensions;

namespace FNAFPorting.Converters;

public class ExportTypeIconConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is EExportType exportType)
        {
            return ImageExtensions.AvaresBitmap($"avares://FNAFPorting/Assets/FN/{exportType}.png");
        }
        
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}