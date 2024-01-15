using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.LSP.BadExample
{
    public class PermanentEmployee : Employee
    {
        private const int BONUS = 10;
        public override decimal ComputeBonus()
        {
            return (this.ComputeSalary() * BONUS) / 100;
        }

        public override decimal ComputeSalary()
        {
            return DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * this.PerDayCost;
        }
    }
}
