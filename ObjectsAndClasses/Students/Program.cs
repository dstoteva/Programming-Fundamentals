using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{


    class Program
    {
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student s in students)
            {
                if (s.FirstName == firstName && s.LastName == lastName)
                {
                    existingStudent = s;
                }
            }
            return existingStudent;
        }
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student s in students)
            {
                if (s.FirstName == firstName && s.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            while (true)
            {
                string[] info = Console.ReadLine().Split();

                if (info[0] == "end")
                {
                    break;
                }

                string firstName = info[0];
                string lastName = info[1];
                string age = info[2];
                string hometown = info[3];

                if (IsStudentExisting(allStudents, firstName, lastName))
                {
                    Student currentStudent = GetStudent(allStudents, firstName, lastName);

                    currentStudent.FirstName = firstName;
                    currentStudent.LastName = lastName;
                    currentStudent.Age = age;
                    currentStudent.Hometown = hometown;
                }
                else
                {
                    Student currentStudent = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };
                    allStudents.Add(currentStudent);
                }
                
            }
            string city = Console.ReadLine();

            foreach (var students in allStudents)
            {
                if (city == students.Hometown)
                {
                    Console.WriteLine($"{students.FirstName} {students.LastName} is {students.Age} years old.");
                }
            }
        }
    }
}
