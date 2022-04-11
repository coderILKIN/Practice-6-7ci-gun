using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class Student : Person
    {
        public static int id;
        public int Id { get;}

        public string[] Lessons;

        

        public Student(string name,string surname,int age):base(name,surname,age)
        {
            id++;
            Id = id;

        }

        public void Showstudent()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age} , Id: {Id}");
        }

       
    }
}
