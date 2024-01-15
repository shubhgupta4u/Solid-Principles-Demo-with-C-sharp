using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.LSP.BadExample
{
    public class ContractualEmployee : Employee
    {
        public DateTime DateOfContractEnd { get; set; }
        public decimal NoOfDaysWorked { get; set; }
        public override decimal ComputeBonus()
        {
            throw new NotImplementedException();
        }

        public override decimal ComputeSalary()
        {
            return NoOfDaysWorked * this.PerDayCost;
        }
    }
}
