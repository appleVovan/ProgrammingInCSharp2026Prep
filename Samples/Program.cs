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
            Student mystudent1 = new Student();
            mystudent1.FirstName = "Steve";
            mystudent1.LastName = "Jobs";

            Student mystudent2 = new Student();
            mystudent1.FirstName = "Bill";
            mystudent1.LastName = "Gates";
        }
        #endregion
    }
}
