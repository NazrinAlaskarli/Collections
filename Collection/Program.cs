using System.Text.RegularExpressions;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
             Group group=new Group
             {
               group=P331

             }


            List<Student> students = new List<Student>();
            Student student = new Student
            {
                Name = "Nazrin",
                Surname = "Alaskarli",
                PIN = "7L555BN"
            };
            AddStudent(students, student);

            foreach(var std in students)
            {
                Console.WriteLine(std.GetDetails());
            }
            Console.WriteLine($"Count:{GetStudentCountContainsA()});
                
        }
        static void AddStudent(List<Student> students,Student student)
        {
            bool isDuplicatedPIN=students.Any(s => s.PIN == student.PIN);
            if (!isDuplicatedPIN)
            {
                students.Add(student);
            }
        }
        static int GetStudentCountContainsA()
        {
             return students.Count(s => s.Name.ToLower().Contains('a') || s.Name.Contains('A'));
        }
    }
}