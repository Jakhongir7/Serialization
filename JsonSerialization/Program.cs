using System;
using System.Collections.Generic;
using JsonSerialization.Models;

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

JsonSerializeProvider.Serialize(department, FilePath(department.DepartmentName));
var data = (Department)JsonSerializeProvider.Desirialize(typeof(Department), FilePath("Engineers"));
Console.WriteLine(data);
string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";
