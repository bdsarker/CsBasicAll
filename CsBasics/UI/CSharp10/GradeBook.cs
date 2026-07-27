namespace CsBasics.UI.CSharp10
{
    // Encapsulates a grade behind explicit get/set accessors; used only by PropertiesDemo
    internal sealed class GradeBook
    {
        private string _grade = string.Empty;

        public string Grade
        {
            get { return _grade; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Grade cannot be empty.");
                }
                _grade = value.ToUpperInvariant();
            }
        }
    }
}
