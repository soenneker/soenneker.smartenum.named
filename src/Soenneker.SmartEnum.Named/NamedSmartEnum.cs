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
    /// Executes the operator string operation.
    /// </summary>
    /// <param name="smartEnum">The smart enum.</param>
    /// <returns>The result of the operation.</returns>
    public static implicit operator string(NamedSmartEnum<TEnum> smartEnum) => smartEnum.Name;
}
