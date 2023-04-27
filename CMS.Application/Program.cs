using CMS.UI.Models;
using SharpPad;

namespace CMS.Application
{
    class Program
    {
        static List<Student> students = new List<Student>();

        public int MyProperty { get; set; }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Entered Main()");
            Initialization();

            await students.Dump();
        }

        private static void Initialization()
        {
            students.Add(new Student(101, "John", "Smith", 1));
            students.Add(new Student(102, "Robert", "Smith", 2));
        }

        private static void Cleanup()
        {

        }

        private static void Print()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.FirstName + student.LastName);
            }
            
            foreach(Student student in students)
            {
                Console.WriteLine(student.FirstName + student.LastName);
            }
        }
    }
}

