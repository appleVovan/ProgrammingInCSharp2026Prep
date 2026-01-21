using KMA.ProgrammingInCSharp2026.Samples.Original;
using KMA.ProgrammingInCSharp2026.Samples.Copy;
using OriginalStudent = KMA.ProgrammingInCSharp2026.Samples.Original.Student;
using CopyStudent = KMA.ProgrammingInCSharp2026.Samples.Copy.Student;

using циферка = System.Int32;

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
            var mystudent1 = new OriginalStudent() { FirstName = "Steve", LastName = "Jobs" };

            CopyStudent mystudent2 = new CopyStudent();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
        }
        #endregion

        #region Variable Initialization Examples
        static void Sample2()
        {
            циферка i, j, k;
            i = j = k = 0;
        }
        #endregion
    }
}
