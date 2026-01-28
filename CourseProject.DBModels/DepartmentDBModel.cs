using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;

namespace KMA.ProgrammingInCSharp2026.CourseProject.DBModels
{
    public class DepartmentDBModel  
    {
        //Guid is generated only once during the creation of the object and cannot be changed later. 
        public Guid Id { get; }        
        public string Name { get; set; }
        public Faculty Faculty { get; set; }

        private DepartmentDBModel()
        {            
        }
        public DepartmentDBModel(string name, Faculty faculty)
        {
            Id = Guid.NewGuid();
            Name = name;
            Faculty = faculty;
        }
    }
}
