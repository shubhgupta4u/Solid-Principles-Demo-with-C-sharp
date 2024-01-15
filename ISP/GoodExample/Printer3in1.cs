using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.ISP.GoodExample
{
    internal class Printer3in1 : IPrinter, IPhotocopier, IScanner
    {
        public void PrintContent()
        {
            //Print logic goes here
        }

        public void PhotoCopyContent()
        {
            //Photo copy logic goes here
        }

        public void ScanContent()
        {
            //Scan logic goes here
        }
    }
}
