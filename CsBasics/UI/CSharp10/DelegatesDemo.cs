using CsBasics.data;
using CsBasics.Services;

namespace CsBasics.UI.CSharp10
{
    public class DelegatesDemo : ICSharp10Demo
    {
        private delegate string StudentFormatter(Student student);

        private readonly IStudentService _studentService;

        public DelegatesDemo(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public string Title => "Delegates";

        public void Run()
        {
            Console.WriteLine("C# 1.0: Delegates");

            var student = _studentService.GetAllStudents().First();

            StudentFormatter formatter = FormatShort;
            Console.WriteLine($"   Single delegate (short format) -> {formatter(student)}");

            formatter = FormatDetailed;
            Console.WriteLine($"   Reassigned delegate (detailed format) -> {formatter(student)}");

            StudentFormatter multicast = FormatShort;
            multicast += FormatDetailed;
            Console.WriteLine("\n   Multicast delegate (invokes both; returns last result):");
            Console.WriteLine($"   Result -> {multicast(student)}");
        }

        private static string FormatShort(Student student) => student.Name;

        private static readonly StudentFormatter FormatDetailed = (Student student) =>
        {
            return $"{student.Name}, Age {student.Age}, Grade {student.Grade}";
        };
    }
}
