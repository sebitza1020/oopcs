using System;

namespace OOPINtroCSharp
{
    internal class Student
    {
        private string name;
        private int grade;

        public Student()
        {
            name = "Default Student";
            grade = 5;
        }

        public Student(string nameParam, int gradeParam)
        {
            this.name = nameParam;
            this.grade = gradeParam;
        }

        public void ConsoleWrite()
        {
            Console.WriteLine(name + " - " + grade);
        }
    }
}