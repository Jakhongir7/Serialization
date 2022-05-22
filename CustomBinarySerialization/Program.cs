using System;
using CustomBinarySerialization;

var person = new Person
{
    Name = "Jakhongir",
    Age = 25,
    Gender = "Male",
    Occupation = "Engineer"
};

CustomBinarySerializeHelper.Serialize(person, FilePath(person.Name));
var data = CustomBinarySerializeHelper.Desirialize(FilePath(person.Name));
Console.WriteLine(data);
string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";
