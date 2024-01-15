using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.SRP.GoodExample
{
    internal class InvoiceFormatter : IDocumentFormatter
    {
        public InvoiceFormatter(Invoice invoice)
        {

        }
        public string GetHtmlContent()
        {
            string formattedInvoice = string.Empty;
            //logic goes here
            return formattedInvoice;
        }
    }
}
