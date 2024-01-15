using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.SRP.GoodExample
{
    public class PrintService
    {
        public void Print(IDocumentFormatter document)
        {
            string printDocument = document.GetHtmlContent();
            // Logic goes here.
        }
    }
}
