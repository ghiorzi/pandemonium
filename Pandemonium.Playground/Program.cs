using System;
using Pandemonium;
using Pandemonium.Types;

using static System.Console;
using static Pandemonium.Functions;

Maybe<int> value = 10;

var r = 
value
    .ToFailable()
    .Pipe<int>(
        Do<int>((_) => WriteLine(_)),
        Where<int>(x => x % 1 == 0),
        Do<int>((_) => WriteLine(_))
    );

r();