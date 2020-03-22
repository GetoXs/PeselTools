# PeselTools

[![NuGet](https://img.shields.io/nuget/dt/PeselTools.svg)](https://www.nuget.org/packages/PeselTools) 
[![NuGet](https://img.shields.io/nuget/vpre/PeselTools.svg)](https://www.nuget.org/packages/PeselTools)

Tools and helpers for PESEL (Polish identification number). Simple and fast valid and parse (sex, birthday) from string values.

Fully cooperate with checksum checking and 2000+ birthdays

### Install 

#### with nuget

```
Install-Package PeselTools
```

#### with .NET CLI
```
dotnet add package PeselTools
```

## How to use

#### Parse

```csharp
  //Parse
  string value = "70092746571";
  var pesel = Pesel.Parse(value);
  
  //or TryParse
  var isValid = Pesel.TryParse(value, out var result);

  //birthday
  var bd = pesel.BirthDate;

  //sex
  var sex = pesel.Sex;

  Console.WriteLine($"Pesel {pesel}. Birthday: {bd}, sex: {sex}.");
```
#### Validation only

```csharp
  string value = "70092746571";
  var isValid = Pesel.IsValid(value);
```
