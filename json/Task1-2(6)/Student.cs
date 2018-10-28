using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_6_
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string _name { get; set; }

        [DataMember]
        public string _group { get; set; }
        
        [DataMember]
        public string _age { get; set; }
        
        public Student(string name, string group, string age)
        {
            _name = name;
            _group = group;
            _age = age;
        }
    }
}
