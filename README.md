[![](https://img.shields.io/nuget/v/soenneker.smartenum.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.smartenum.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.smartenum.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.smartenum.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.smartenum.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.smartenum.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.smartenum.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.smartenum.named/actions/workflows/codeql.yml)

# Soenneker.SmartEnum.Named

A derivative of SmartEnum, with an implicit string operator for Name.

## Install

```bash
dotnet add package Soenneker.SmartEnum.Named
```

## What you get

- `NamedSmartEnum<TEnum>` — A derivative of SmartEnum, with an implicit string operator for Name.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `NamedSmartEnum<TEnum>.ConversionOperatorDeclaration` | Converts the Named Smart Enum to its string representation. | Converts the Named Smart Enum to its string representation. |
