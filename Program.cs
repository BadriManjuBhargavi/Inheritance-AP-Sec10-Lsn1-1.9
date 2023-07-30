using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance_Sec10_Lsn1_1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            // Create CClass object
            CClass myClass = new CClass("Class 10");

            // Create Teacher objects
            ClassTeacher classTeacher = new ClassTeacher("John Doe", myClass);
            SubjectTeacher subjectTeacher = new SubjectTeacher("Jane Smith", "Mathematics");

            // You can populate more data here if needed
        }

    }
}
