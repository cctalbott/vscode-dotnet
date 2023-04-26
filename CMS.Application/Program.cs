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
            Initialization();

            await students.Dump();
        }

        private static void Initialization()
        {
            students.Add(new Student(101, "Mark", "Smith", 1));
            students.Add(new Student(102, "Robert", "Smith", 2));
            students.Add(new Student(103, "Maria", "Rodriguez", 3));
        }

        private static void Cleanup()
        {

        }

        private static void Print()
        {

        }
    }
}

