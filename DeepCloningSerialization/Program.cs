using BinarySerialization.Models;
using DeepCloningSerialization;
using System;
using System.Collections.Generic;

var department = new Department
{
    DepartmentName = "Managers",
    Employees = new List<Employee>
    {
        new() { EmployeeName = "Jakhongir" },
        new() { EmployeeName = "Bakhodir" },
        new() { EmployeeName = "Alisher" },
        new() { EmployeeName = "Anora" },
        new() { EmployeeName = "Komila" },
    }
};

var clone = CloneHelper.Clone<Department>(department);

Console.WriteLine(department);
Console.WriteLine(clone);
department.DepartmentName = "Engineers";
department.Employees[1].EmployeeName = "NotJakhongir";
Console.WriteLine(department);
Console.WriteLine(clone);
