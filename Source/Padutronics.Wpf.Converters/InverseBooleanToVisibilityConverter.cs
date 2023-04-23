using System.Windows;
using System.Windows.Data;

namespace Padutronics.Wpf.Converters;

[ValueConversion(sourceType: typeof(bool), targetType: typeof(Visibility))]
public sealed class InverseBooleanToVisibilityConverter : BooleanConverter<Visibility>
{
    public InverseBooleanToVisibilityConverter() :
        base(Visibility.Collapsed, Visibility.Visible)
    {
    }
}