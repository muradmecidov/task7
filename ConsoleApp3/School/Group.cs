using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.School
{
    internal class Group
    {
        public string GroupName;
        private Student[] Students = new Student[0];

        public void Add(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void GetAll()
        {
           foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}{student.Surname}");
            }
        }
        public void GetOnlineStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.IsOnline);

            }

        }
        public void GetOfflineStudents()
        {
            foreach(Student student in Students)
            {
                Console.WriteLine(!student.IsOnline);
            }
        }
    }
}
