[![](https://img.shields.io/nuget/v/soenneker.smartenum.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.smartenum.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.smartenum.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.smartenum.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.smartenum.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.smartenum.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.smartenum.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.smartenum.named/actions/workflows/codeql.yml)

# Soenneker.SmartEnum.Named

An Ardalis SmartEnum base class with an implicit conversion from an enum member to its `Name` string.

## Installation

```bash
dotnet add package Soenneker.SmartEnum.Named
```

## Defining an enum

```csharp
using Soenneker.SmartEnum.Named;

public sealed class OrderStatus : NamedSmartEnum<OrderStatus>
{
    public static readonly OrderStatus Pending = new(nameof(Pending), 1);
    public static readonly OrderStatus Shipped = new(nameof(Shipped), 2);

    private OrderStatus(string name, int value) : base(name, value)
    {
    }
}
```

## Usage

```csharp
string statusName = OrderStatus.Pending; // "Pending"

OrderStatus byName = OrderStatus.FromName("Shipped");
OrderStatus byValue = OrderStatus.FromValue(2);
```

The implicit conversion always returns `Name`; it does not return the integer `Value`. This is useful when an API expects the enum's textual name, while the inherited SmartEnum APIs still provide lookup, comparison, and enumeration behavior.

The conversion is a C# operator. Serializers and database providers do not necessarily invoke it, so configure the appropriate Ardalis SmartEnum converter for those integrations.
