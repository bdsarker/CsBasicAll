using CsBasics.Services;

namespace CsBasics.UI.CSharp10
{
    public class PropertiesDemo : ICSharp10Demo
    {
        private readonly IStudentService _studentService;

        public PropertiesDemo(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public string Title => "Properties";

        public void Run()
        {
            Console.WriteLine("C# 1.0: Properties");

            var student = _studentService.GetAllStudents().First();
            var gradeBook = new GradeBook();

            Console.WriteLine("   Setting grade via property setter (encapsulated, normalizes input)...");
            gradeBook.Grade = student.Grade.ToLowerInvariant();
            Console.WriteLine($"   Reading grade via property getter -> {gradeBook.Grade}");

            Console.WriteLine("\n   Attempting to set an invalid (empty) grade...");
            try
            {
                gradeBook.Grade = "";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   Setter rejected it -> {ex.Message}");
            }
        }
    }
}
