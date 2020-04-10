using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class Student : person
    {
        public Student(string person, int age, string studentId, string email) :
        base (person, age)
        {
            StudentId = studentId;
            Email = email;
        }

        public string StudentId { get; set; }

        public string Email { get; set; }
    }
}
