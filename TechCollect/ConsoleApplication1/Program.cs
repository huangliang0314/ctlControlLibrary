using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using System.Runtime.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                ID = 1,
                Name = "LiLi",
                Addresscls = new Address {line2="12",line1="23" }
            };
            var file = System.IO.File.Create("Person.bin");
            ProtoBuf.Serializer.Serialize(file, person1);
            Console.ReadLine();
        }

        [Serializable]
        [ProtoContract]
        private class Person
        {
            [ProtoMember(1)]
            public int ID { get; set; }

            [ProtoMember(2)]
            public string Name { get; set; }

            [ProtoMember(3)]
            public Address Addresscls { get; set; }
        }

        [Serializable]
        [ProtoContract]
        private class Address
        {
            [ProtoMember(1)]
            public string line1 { get; set; }
            [ProtoMember(2)]
            public string line2 { get; set; }
        }
    }


}
