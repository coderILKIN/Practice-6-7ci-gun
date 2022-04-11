using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Student:Person
    {
       public int StudentId { get; set; }

        private double _point;

        public double Point { 
            get 
            {
                return _point;
            } 
            set 
            {
                if (value > 0 && value <= 100)
                {
                    _point = value;
                }
            }
        }

        public Student(int studentid,string name,string surname):base(name,surname)
        {
            StudentId = studentid;
            
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname: {Surname}, Age: {Age}, StudentId: {StudentId}, Point: {Point}");
        }

    }
}
