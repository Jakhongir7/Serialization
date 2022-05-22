using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerialization.Models
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public IList<Employee> Employees { get; set; }

        public override string ToString() => "Employees in " + DepartmentName + " department: \n" + string.Join("\n", Employees.Select(x => x.EmployeeName));
    }
}
