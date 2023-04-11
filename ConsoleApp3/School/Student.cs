using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.School
{
    internal class Student : Person
    {
        public bool IsOnline;

        public Student(string Name, string Surname, byte Age, bool isOnline) : base(Name, Surname, Age)
        {
            IsOnline = isOnline;
        }
        
      

    
    
    
    }
}
