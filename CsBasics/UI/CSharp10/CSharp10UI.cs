using CsBasics.UI;

namespace CsBasics.UI.CSharp10
{
    public class CSharp10UI : IConsoleUI
    {
        private readonly IEnumerable<ICSharp10Demo> _demos;

        public CSharp10UI(IEnumerable<ICSharp10Demo> demos)
        {
            _demos = demos;
        }

        public string Title => "C# 1.0 Features";

        public void Run()
        {
            foreach (var demo in _demos)
            {
                demo.Run();
            }
        }
    }
}
