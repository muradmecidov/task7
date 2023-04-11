using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.School
{
    internal class Person
    {
        public string _name;
        public string _surname;
        public byte _age;

        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name 
        {
           get { return _name; }
            set {
                if (value.Length > 3)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set { }
        }
        
        public byte Age
        {
            get { return _age; }
            set { if ( value > 0)
                {
                    _age = value;
                }
            }
        }








    }
}
