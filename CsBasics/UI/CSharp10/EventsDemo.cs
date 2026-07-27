using CsBasics.data;
using CsBasics.Services;

namespace CsBasics.UI.CSharp10
{
    public class EventsDemo : ICSharp10Demo
    {
        private readonly IStudentService _studentService;

        public EventsDemo(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void Run()
        {
            Console.WriteLine("C# 1.0: Events");

            var desk = new EnrollmentDesk();
            desk.StudentEnrolled += OnStudentEnrolled;

            var student = _studentService.GetAllStudents().First();
            Console.WriteLine($"   Enrolling {student.Name}...");
            desk.Enroll(student);
        }

        private static void OnStudentEnrolled(object? sender, Student student)
        {
            Console.WriteLine($"   [Notification] {student.Name} has been enrolled.");
        }
    }
}
