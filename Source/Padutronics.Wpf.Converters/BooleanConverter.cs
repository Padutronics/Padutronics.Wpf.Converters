using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace Padutronics.Wpf.Converters;

public abstract class BooleanConverter<T> : IValueConverter
{
    protected BooleanConverter(T trueValue, T falseValue)
    {
        FalseValue = falseValue;
        TrueValue = trueValue;
    }

    public T FalseValue { get; }

    public T TrueValue { get; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
#nullable disable
        return value is bool typedValue && typedValue ? TrueValue : FalseValue;
#nullable restore
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is T typedValue && EqualityComparer<T>.Default.Equals(typedValue, TrueValue);
    }
}