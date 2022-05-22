using System;
using System.Collections.Generic;
using XmlSerialization.Models;
using XmlSerilalization;

var department = new Department
{
    DepartmentName = "Engineers",
    Employees = new List<Employee>
    {
        new() { EmployeeName = "Jakhongir" },
        new() { EmployeeName = "Bakhodir" },
        new() { EmployeeName = "Alisher" },
        new() { EmployeeName = "Anora" },
        new() { EmployeeName = "Komila" },
    }
};

XmlSerializeProvider.Serialize(typeof(Department), department, FilePath(department.DepartmentName));
var data = (Department)XmlSerializeProvider.Deserialize(typeof(Department), FilePath("Engineers"));
Console.WriteLine(data);
string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";

