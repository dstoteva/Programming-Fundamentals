using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByAge
{
    class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string [] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Student student = new Student(name, id, age);
                students.Add(student);

                
            }
            students = students.OrderBy(x => x.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}
