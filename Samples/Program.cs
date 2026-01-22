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
            Sample5();
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

        #region Type conversion Examples
        static void Sample3()
        {
            int x = 1000;

            byte y = checked((byte)x);

            Console.WriteLine(y);
        }
        #endregion

        #region New Line Examples
        static void Sample4()
        {
            string tempVar = "My name is Volodymyr" + Environment.NewLine + "My age is 30.";
        }
        #endregion

        #region Value & Reference Type Behaviour Examples
        static void Sample5()
        {
            int myInt;
            MyMethodInt(out myInt);
            Console.WriteLine(myInt);
        }

        static void MyMethodInt(out int myInt)
        {
            myInt = 6;
            Console.WriteLine(myInt);
        }
        #endregion
    }
}
