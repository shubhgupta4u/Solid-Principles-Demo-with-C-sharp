using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.ISP.BadExample
{
    public class BasicPrinter : IPrinter
    {
        public void PrintContent()
        {
            //Print logic goes here
        }

        public void PhotoCopyContent()
        {
            throw new NotImplementedException();
        }

        public void ScanContent()
        {
            throw new NotImplementedException();
        }
        public void FaxContent()
        {
            throw new NotImplementedException();
        }
    }
}
