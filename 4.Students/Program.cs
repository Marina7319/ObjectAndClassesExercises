using System;
using System.Linq;
using System.Collections.Generic;
namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currentStudentInfo = Console.ReadLine().Split(" ");
                var student = new Student(firstName: currentStudentInfo[0],
                    lastName: currentStudentInfo[1],
                    grade: double.Parse(currentStudentInfo[2]));
                students.Add(student);
            }
            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();
            students.ForEach(student => Console.WriteLine(student));
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}
