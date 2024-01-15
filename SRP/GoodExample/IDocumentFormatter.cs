using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.SRP.GoodExample
{
    public interface IDocumentFormatter
    {
        String GetHtmlContent();
    }
}
