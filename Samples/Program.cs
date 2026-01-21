using KMA.ProgrammingInCSharp2026.Samples.Original;
using KMA.ProgrammingInCSharp2026.Samples.Copy;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        #region Initialization in C# Examples
        static void Sample1()
        {
            var mystudent1 = new Original.Student() { FirstName = "Steve", LastName = "Jobs" };

            Copy.Student mystudent2 = new Copy.Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
        }
        #endregion
    }
}
