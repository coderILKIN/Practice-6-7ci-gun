using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();

            
            group.AddStudent("ILKIN YUSUBOV");
            group.AddStudent("ILKIN YUSUBOV");

            foreach (string item in group.Fullname)
            {
                Console.WriteLine(item);
            }


            

            

        }
    }
}
