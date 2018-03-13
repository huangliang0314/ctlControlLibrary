using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [XmlRoot()]
    public class Person
    {
        #region Variable
        private string name;

        private int age;

        private double height;

        private Sex sex;
        #endregion


   
        #region Properity
        [XmlElement("")]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        [XmlElement("")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        [XmlElement("")]
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        [XmlAttribute]
        public Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        #endregion

    }

    public enum Sex
    {
        Man=1,
        Woman=2
    }
}
