using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.SRP.GoodExample
{
    internal class EmailService
    {
        public void Email(IDocumentFormatter document)
        {
            string printDocument = document.GetHtmlContent();
            // Logic goes here to send email.
        }
    }
}
