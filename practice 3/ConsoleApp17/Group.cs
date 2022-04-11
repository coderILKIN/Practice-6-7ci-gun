using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Group
    {
        public string[] Fullname = new string[0];

        public int GroupNo { get; set; }



       public void AddStudent(string fullname)
       {

            Array.Resize(ref Fullname, Fullname.Length + 1);
            Fullname[Fullname.Length - 1] = fullname;
            
       }


    }
}
