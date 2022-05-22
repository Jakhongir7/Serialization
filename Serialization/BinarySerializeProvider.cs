using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace BinarySerialization.Models
{
    public static class BinarySerializeProvider
    {
        public static void Serialize(object data, string filePath)
        {
            var binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
                File.Delete(filePath);

            using var fileStream = File.Create(filePath);
            binaryFormatter.Serialize(fileStream, data);
        }

        public static object Desirialize(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using var fileStream = File.OpenRead(filePath);
            var binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(fileStream);
        }
    }
}
