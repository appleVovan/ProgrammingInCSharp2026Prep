using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;

namespace KMA.ProgrammingInCSharp2026.CourseProject.DBModels
{
    

    public class DepartmentDBModel  
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
    }
}
