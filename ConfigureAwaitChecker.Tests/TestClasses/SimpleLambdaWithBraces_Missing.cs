﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureAwaitChecker.Tests.TestClasses
{
    public class SimpleLambdaWithBraces_Missing : TestClassBase
    {
#pragma warning disable 1998
        public async Task FooBar()
#pragma warning restore 1998
        {
            var func = (Func<Task>)(async () => await (Task.Delay(1)));
        }
    }
}