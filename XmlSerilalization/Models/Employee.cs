using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerialization.Models
{
    [Serializable]
    public class Employee
    {
        [XmlElement(ElementName = "Employee")]
        public string EmployeeName { get; set; }
    }
}
