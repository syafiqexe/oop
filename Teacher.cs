using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Teacher : person 
    {
        public Teacher(string person, int age, string teacherId, string subject)    :
        base(person, age)
        {
            TeacherId = teacherId;
            Subject = subject;
        }

        public string TeacherId { get; set; }

        public string Subject { get; set; }
    }
}
