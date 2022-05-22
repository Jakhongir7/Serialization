using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CustomBinarySerialization
{
    [Serializable]
    public class Person : ISerializable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public Person() { }

        public Person(string name, int age, string gender, string occupation)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Occupation = occupation;
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Age = (int)info.GetValue("Age", typeof(int));
            Gender = (string)info.GetValue("Gender", typeof(string));
            Occupation = (string)info.GetValue("Occupation", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Gender", Gender);
            info.AddValue("Occupation", Occupation);
        }

        public override string ToString() => Name + ": \n- " + Age.ToString() + "years old \n- " + Gender + "\n- " + Occupation;
    }
}
