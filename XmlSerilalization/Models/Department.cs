using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    [Serializable]
    public class Department
    {
        [XmlElement(ElementName = "Department")]
        public string DepartmentName { get; set; }

        [XmlArray("ListOfEmployees")]
        [XmlArrayItem("EmployeeName")]
        public List<Employee> Employees { get; set; }

        public override string ToString() => "Employees in " + DepartmentName + " department: \n" + string.Join("\n", Employees.Select(x => x.EmployeeName));
    }
}
