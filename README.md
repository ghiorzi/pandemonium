<p align="center">
  <img src="./Resources/logo.png">
</p>

**Pandemonium** is an open-source library focus on improve code legibility.

## Installation

#### Package Manager   

	Install-Package Pandemonium

#### .NET CLI    
    dotnet add package Pandemonium

## Get rid of "not"

```csharp
var names = new List<string>()
{
    "Hachiman",
    "Yukino"
};

// from !Any
!names.Any(name => name == "Yui");
// to None
names.None(name => name == "Yui");

// from !
if (!value)
// to
if (value.False())
```

## Avoid trivial conditional statements with higher order functions

```csharp
int number = 7;

number
      .GreaterThan(4)
      .Then(() => Console.WriteLine($"{number} is greater than 4")) // if
      .Otherwise(() => Console.WriteLine($"{number} is less than 4")); // else

string text = null;

text
    .NotNull()
    .Then(() => Console.WriteLine(text))
    .Otherwise(() => Console.WriteLine("text is required"));
```

## Get closer to human language

```csharp
// from
new DateTime(2020, 12, 31);
// to
31.December(2020);

// from 
TimeSpan.FromMilliseconds(1);
// to
1.Milliseconds();

// from
TimeSpan.FromSeconds(30);
// to
30.Seconds();

// from
TimeSpan.FromMinutes(15);
// to
15.Minutes();

// from
TimeSpan.FromHours(2);
// to
2.Hours();

// from
TimeSpan.FromDays(7);
// to
7.Days();
```