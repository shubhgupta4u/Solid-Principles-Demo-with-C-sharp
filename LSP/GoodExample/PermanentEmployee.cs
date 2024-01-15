using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.LSP.GoodExample
{
    public class PermanentEmployee : Employee, IBonusCalculator
    {
        public decimal ComputeBonus()
        {
            return (this.ComputeSalary() * 10) / 100;
        }

        public override decimal ComputeSalary()
        {
            return DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * this.PerDayCost;
        }
    }
}
