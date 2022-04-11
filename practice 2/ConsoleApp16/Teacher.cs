using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Teacher:Person
    {
        private int _experience;
        private static int id;
        public int Id { get;}

        public Teacher(int experience,string name,string surname,int age):base(name,surname,age)
        {
            id++;
            Id = id;
            Experience = experience;
        }

        public int Experience { 
            get
            {
                return _experience;
            } 
            set 
            {
                if (value>0 && value <= 80)
                {
                    _experience = value;

                }
            } 
        }

        public void Showteacher()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age} , Id: {Id}, Experience: {Experience}");
        }



    }
}
