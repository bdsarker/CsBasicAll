using CsBasics.data;

namespace CsBasics.UI.CSharp10
{
    // Publishes a StudentEnrolled event; used only by EventsDemo
    internal sealed class EnrollmentDesk
    {
        public event EventHandler<Student>? StudentEnrolled;

        public void Enroll(Student student)
        {
            StudentEnrolled?.Invoke(this, student);
        }
    }
}
