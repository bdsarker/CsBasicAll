using System.Runtime.CompilerServices;
using CsBasics.data;
using CsBasics.Services;

namespace CsBasics.UI.CSharp10
{
    public class GarbageCollectionDemo : ICSharp10Demo
    {
        private readonly IStudentService _studentService;

        public GarbageCollectionDemo(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public string Title => "Garbage Collection (GC)";

        public void Run()
        {
            Console.WriteLine("C# 1.0: Garbage Collection (GC)");

            var students = _studentService.GetAllStudents();

            Console.WriteLine("   Creating tracked student objects on the heap...");
            CreateAndDropReferences(students);

            Console.WriteLine("\n   Dropping references -- objects are now unreachable...");

            Console.WriteLine("\n   Requesting GC collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\n   GC reclaimed both student objects. No delete or free was needed.");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void CreateAndDropReferences(List<Student> students)
        {
            foreach (var student in students)
            {
                _ = new TrackedStudent(student.Name);
            }
        }
    }
}
