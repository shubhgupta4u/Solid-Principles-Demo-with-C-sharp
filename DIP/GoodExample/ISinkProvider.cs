using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.DIP.GoodExample
{
    public interface ISinkProvider
    {
        void Log(string message, LogLevel level);
    }
}
