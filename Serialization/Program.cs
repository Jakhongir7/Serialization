using BinarySerialization;
using BinarySerialization.Models;
using System;
using System.Collections.Generic;

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

BinarySerializeProvider.Serialize(department, FilePath(department.DepartmentName));
var data = (Department)BinarySerializeProvider.Desirialize(FilePath("Engineers"));
Console.WriteLine(data);
string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";
