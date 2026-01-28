namespace CourseProject.DBModels
{
    public enum Faculty
    {
        FacultyOfInformatics,
        FacultyOfEconomics,
        FacultyOfLaw,
        FacultyOfNaturalSciences
    }

    public class DepartmentDBModel  
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
    }
}
