using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            person person = new person("lilibet", 25);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("luluca", 30, "733874", "sains");
            teacher.GetNameAndAge();

            Student student = new Student("violet", 20, "848349", "epic7@gmail");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
