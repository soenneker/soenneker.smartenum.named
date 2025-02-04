using Ardalis.SmartEnum;

namespace Soenneker.SmartEnum.Named;

/// <summary>
/// A derivative of SmartEnum, with an implicit string operator for Name
/// </summary>
public abstract class NamedSmartEnum<TEnum> : SmartEnum<TEnum> where TEnum : NamedSmartEnum<TEnum>
{
    protected NamedSmartEnum(string name, int value) : base(name, value)
    {
    }

    public static implicit operator string(NamedSmartEnum<TEnum> smartEnum) => smartEnum.Name;
}
