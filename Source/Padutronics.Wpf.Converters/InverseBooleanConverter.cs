using System.Windows.Data;

namespace Padutronics.Wpf.Converters;

[ValueConversion(sourceType: typeof(bool), targetType: typeof(bool))]
public sealed class InverseBooleanConverter : BooleanConverter<bool>
{
    public InverseBooleanConverter() :
        base(trueValue: false, falseValue: true)
    {
    }
}