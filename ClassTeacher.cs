using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Sec10_Lsn1_1._9
{
    public class ClassTeacher : Teacher
    {
        public CClass AssignedClass { get; set; }
        // You can add other properties relevant to a class teacher here

        public ClassTeacher(string name, CClass assignedClass)
            : base(name)
        {
            AssignedClass = assignedClass;
        }
    }
}