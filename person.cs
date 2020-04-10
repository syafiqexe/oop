using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class person
    {
        string Name;
        int Age;

        public person(string person, int age)
        {
            Name = person;
            Age = age;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The person name  :   {0}    ", Name);
            Console.WriteLine("The person age   :   {0}", Age);
            Console.WriteLine("--------------------------------");


        }
    }
}
