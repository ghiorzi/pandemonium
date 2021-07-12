<p align="center">
  <img src="./Resources/logo.png">
</p>

**Pandemonium** is an open-source library focus on improve code legibility.

## Installation

#### Package Manager   

	Install-Package Pandemonium

#### .NET CLI    
    dotnet add package Pandemonium

## Usage
```csharp
using Pandemonium; // use the namespace
```

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

bool value = false;

// from !
if (!value)
// to
if (value.False())
```

## Avoid trivial conditional statements with higher order functions

```csharp
int number = 7;

number
      .GreaterThanOrEqualTo(4)
      .Then(() => Console.WriteLine($"{number} is greater than or equal to 4")) // if
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
new (2020, 12, 31);
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

## Use higher order functions to extract or remove values from string

```csharp
string numbers = "123 text".Where(value => value.Number()); // 123

string letters = "123 text".Where(value => value.Letter()); // text

// Predicate over replace
"123 text".Remove(value => value.Letter() || value.Whitespace()); // 123
```

## Stop worring about null

```csharp
Maybe<string> maybe = "I am not null";

// Match || Match<T> 
maybe
  .Match(
      // If there's a value
      onSome: (value) => WriteLine(value),
      // Otherwise
      onNone: () => WriteLine("value is null")
  );
```

## Enjoy the power of chaining

```csharp
#region Simple
// <success, failure>
var isUniqueUsername = Flow.Of<bool, Exception>(true);

// Match || Match<T> 
isUniqueUsername
  .Match(
    // If it's a bool type (success)
    onSuccess: (value) => WriteLine(value),
    // If it's a exception type (failure)
    onFailure: (error) => WriteLine(error)
  );

// Action || Action<T>
isUniqueUsername
  // It runs only If it's a bool type (success)
  .OnSuccess((value) => WriteLine(value));

// Action || Action<T>
isUniqueUsername
    // It runs only if it's a exception type (failure)
  .OnFailure((error) => WriteLine(error));
#endregion

#region With objects 
var account = Flow.Of<Account, Exception>(new Account());

account
  // It checks if account can withdraw 1000$
  .Ensure(a => a.CanWithdraw(1000), new Exception("It cannot withdraw"))
  // From here, it will run only if "CanWithdraw" returned true
  .Tap(a => a.Withdraw(1000))
  .Tap(a => a.Freeze())
  .Match(
    // If all steps were successful 
    onSuccess: (a) => WriteLine(a.Amount),
    // if at least one step has failed, it can be handle here
    onFailure: (error) => WriteLine(error)
  );
#endregion

#region With Maybe 
Maybe<string> maybe = "I am not null";

// Match || Match<T> 
maybe
  .Then((value) => Flow.Of<string, Exception>(value), new Exception("It must have a value"))
  .Ensure(value => value.NotEmpty())
  .Tap(value => WriteLine(value))
  .Finally(_ => WriteLine("End of flow"));
#endregion

#region With Nothing (void)
// Given a function
Nothing Write(string message) 
{
  WriteLine(message);

  return Nothing.Of();
}

Flow<string, Exception> WriteTwice(string message) 
{
  WriteLine(message);
  WriteLine(message);

  return message;
}


Write("Hello")
  .Then(() => WriteTwice("Hello again"))
  .Match(
    onSuccess: (value) => ...
    onFailure: (error) => ...
  );

#endregion

```

## Make code more explicit

```csharp
// Flow<string, Exception>
var nonEmptyString = NonEmptyString.Of("I'm not empty");

// Flow<sbyte | short | int | long | float | double | decimal, Exception>
var nonNegativeNumber = NonNegativeNumber.Of(1);

// now enjoy the power of chaining
```

## Set your own exceptions (optional)
```csharp
var exceptions = 
  new Exceptions(
    new NonEmptyStringCustomException(),
    new NonNegativeNumberCustomException(),
    new MaybeExceptionCustomerException()
  );

// use ServiceCollection
services.AddPandemonium(exceptions);
```

## Contributors

<a href="https://github.com/ghiorzi/pandemonium/graphs/contributors">
  <img src="https://contributors-img.web.app/image?repo=ghiorzi/pandemonium" />
</a>
