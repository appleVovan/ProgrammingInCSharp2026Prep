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
            Sample10();
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

        #region Value Type Behaviour Examples
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

        #region Reference Type Behaviour Examples
        class MyClass
        {
            internal MyClass myChild;

            public int MyProperty { get; set; }
            public MyClass MyChild { get => myChild; set => myChild = value; }
        }

        static void Sample6()
        {
            MyClass myObject = new MyClass();
            myObject.MyProperty = 5;
            myObject.MyChild = new MyClass();
            myObject.MyChild.MyProperty = 5;
            MyMethodObject(ref myObject.myChild);
            Console.WriteLine(myObject.MyChild.MyProperty);
        }

        static void MyMethodObject(ref MyClass myObject)
        {
            myObject = new MyClass();
            myObject.MyProperty = 6;
            Console.WriteLine(myObject.MyProperty);
        }
        #endregion

        #region Value Types comparison
        static void Sample7()
        {
            int val1 = 5;
            int val2 = 5;

            Console.WriteLine(val1 == val2);
            Console.WriteLine(val1.Equals(val2));
        }
        #endregion

        #region Reference Types comparison
        static void Sample8()
        {
            var obj1 = new OriginalStudent("Volodymyr", "Yablonskyi");
            var obj2 = new OriginalStudent("Volodymyr", "Yablonskyi");

            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj1.Equals(obj2));
        }
        #endregion

        #region String comparison
        static void Sample9()
        {
            var str1 = "Volodymyr";
            var str2 = "Volodymyr";

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals(str2));
        }
        #endregion

        #region | and || comparison
        static void Sample10()
        {
            if (SaveToServer() || SaveLocalCopy())
            {
            }

            if (SaveToServer() | SaveLocalCopy())
            {
            }
        }

        private static bool SaveLocalCopy()
        {
            return true;
        }

        private static bool SaveToServer()
        {
            return true;
        }
        #endregion
    }
}
