using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace ShapeEditor.Converters;

public class CenterConverter : IValueConverter
{
    public static readonly CenterConverter Instance = new();

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is double val)
        {
            return val / 2.0;
        }
        return 0;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}