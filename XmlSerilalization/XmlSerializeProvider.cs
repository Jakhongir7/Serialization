using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilalization
{
    public class XmlSerializeProvider
    {
        public static void Serialize(Type type, object data, string filePath)
        {
            var xmlSerializer = new XmlSerializer(type);

            if (File.Exists(filePath))
                File.Delete(filePath);

            using TextWriter textWriter = new StreamWriter(filePath);
            xmlSerializer.Serialize(textWriter, data);
        }

        public static object Deserialize(Type type, string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using TextReader textReader = new StreamReader(filePath);
            var xmlSerializer = new XmlSerializer(type);
            return xmlSerializer.Deserialize(textReader);
        }
    }
}
