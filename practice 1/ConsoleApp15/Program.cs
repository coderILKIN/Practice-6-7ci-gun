using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1,"ILKIN","YUSUBOV");

            int age = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (age>0)
                {
                    Console.WriteLine(age);
                    break;
                }
                if(age<0)
                {
                    Console.WriteLine("menfi deyer olmaz");
                    
                }
                  age = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("yeniden daxil edin");
                


            } while (age ==0);

            int point = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (point > 0 && point<=100)
                {
                    Console.WriteLine(age);
                    break;
                }
                else
                {
                    Console.WriteLine("100 den boyuk ola bilmez");
                }


            } while (point==100);



            student.ShowInfo();
            
            



        }
    }
}
