using KMA.ProgrammingInCSharp2026.Samples.Original;

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
            var mystudent1 = new Student() { FirstName = "Steve", LastName = "Jobs" };

            Student mystudent2 = new Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
        }
        #endregion
    }
}
