using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int experience;

            do
            {
                Console.WriteLine("Enter age please:");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age < 0);


            do
            {
                Console.WriteLine("Enter Experience please");
                experience = Convert.ToInt32(Console.ReadLine());

            } while (experience < 0 || experience > 80);

            Student student = new Student("ILKIN", "YUSUBOV", age);
            Student student2 = new Student("Ferid", "Eyyubov", 22);
            Teacher teacher = new Teacher(experience, "Cavid", "Esedullayev", age);
            student.Showstudent();
            student2.Showstudent();

            teacher.Showteacher();






        }
    }
}
