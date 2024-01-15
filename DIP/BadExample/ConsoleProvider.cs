﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.DIP.BadExample
{
    public class ConsoleProvider
    {
        public void Log(string message, LogLevel level)
        {
            //logic to write the log message to console goes here
        }
    }
}