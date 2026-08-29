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

    /// <summary>
    /// Converts the Named Smart Enum to its string representation.
    /// </summary>
    /// <param name="smartEnum">Smart-enum value whose name should be returned.</param>
    /// <returns>The text produced by operator string.</returns>
    public static implicit operator string(NamedSmartEnum<TEnum> smartEnum) => smartEnum.Name;
}
