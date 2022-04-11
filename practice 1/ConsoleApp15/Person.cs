using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        private double _age;

        public double Age { 
            get
            {
                return _age;
            } 
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            } 
        }


        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
            
           
        }
    }
}
