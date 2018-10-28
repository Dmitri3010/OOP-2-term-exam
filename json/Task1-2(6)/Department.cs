using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_6_
{
    [DataContract]
    public class Department
    {
        [DataMember]
        public List<Student> student;

        [DataMember]
        public string Name;

        public Department()
        {}

        public Department(string _name, List<Student> students)
        {
            Name = _name;
            student = students;
        }
    }
}
