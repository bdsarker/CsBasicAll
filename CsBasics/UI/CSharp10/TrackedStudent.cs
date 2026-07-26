namespace CsBasics.UI.CSharp10
{
    // Wraps a student name with a finalizer to make GC visible
    internal sealed class TrackedStudent
    {
        private readonly string _name;

        public TrackedStudent(string name)
        {
            _name = name;
            Console.WriteLine($"     [Student: {_name}] allocated on heap");
        }

        ~TrackedStudent()
        {
            Console.WriteLine($"     [Student: {_name}] finalizer called -> memory reclaimed by GC");
        }
    }
}
