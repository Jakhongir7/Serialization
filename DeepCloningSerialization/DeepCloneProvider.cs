using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable

namespace DeepCloningSerialization
{
    public class CloneHelper
    {
        public static T Clone<T>(object objSource)
        {
            using var tmpStream = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(tmpStream, objSource);
            tmpStream.Position = 0;
            return (T)bf.Deserialize(tmpStream);
        }
    }
}
