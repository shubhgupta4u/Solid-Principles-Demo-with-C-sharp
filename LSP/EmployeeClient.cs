using Solid.Demo.LSP.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Demo.LSP
{
    internal class EmployeeClient
    {
        public EmployeeClient()
        {
            Employee employee = new ContractualEmployee();
            employee.ComputeSalary();
            employee.ComputeBonus();
        }
    }
}
