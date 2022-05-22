using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace CustomBinarySerialization
{
    public static class CustomBinarySerializeHelper
    {
        public static void Serialize(Person data, string filePath)
        {
            var binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
                File.Delete(filePath);

            using var fileStream = File.Create(filePath);

            binaryFormatter.Serialize(fileStream, data);
        }

        public static Person Desirialize(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using var fileStream = File.OpenRead(filePath);
            var binaryFormatter = new BinaryFormatter();
            return (Person)binaryFormatter.Deserialize(fileStream);
        }
    }
}
