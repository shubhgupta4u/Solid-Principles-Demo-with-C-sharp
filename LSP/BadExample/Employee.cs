using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.LSP.BadExample
{
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int PerDayCost { get; set; }
        public abstract decimal ComputeSalary();
        public abstract decimal ComputeBonus();
    }
}
