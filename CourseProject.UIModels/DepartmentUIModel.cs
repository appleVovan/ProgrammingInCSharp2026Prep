using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;

namespace KMA.ProgrammingInCSharp2026.CourseProject.UIModels
{    

    public class DepartmentUIModel  
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        public List<LecturerUIModel> Lecturers { get; set; }
        public int Staff { get; set; }
    }
}
