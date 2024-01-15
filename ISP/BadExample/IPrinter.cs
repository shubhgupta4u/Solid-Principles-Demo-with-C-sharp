using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.ISP.BadExample
{
    public interface IPrinter
    {
        void PrintContent();
        void ScanContent();
        void PhotoCopyContent();
        void FaxContent();
    }
}