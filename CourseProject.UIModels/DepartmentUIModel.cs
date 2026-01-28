using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;
using KMA.ProgrammingInCSharp2026.CourseProject.DBModels;

namespace KMA.ProgrammingInCSharp2026.CourseProject.UIModels
{    

    public class DepartmentUIModel  
    {
        private DepartmentDBModel _dbModel;
        private string _name;
        private Faculty _faculty;
        private List<LecturerUIModel> _lecturers;

        public Guid? Id 
        { 
            get => _dbModel?.Id; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
        public Faculty Faculty 
        { 
            get => _faculty;
            set => _faculty = value; 
        }
        public IReadOnlyList<LecturerUIModel> Lecturers 
        { 
            get => _lecturers; 
        }
        public int Staff 
        { 
            get => _lecturers?.Count ?? 0;
        }

        internal DepartmentUIModel()
        {            
        }

        public DepartmentUIModel(DepartmentDBModel dBModel)
        {
            _dbModel = dBModel;
            _name = dBModel.Name;
            _faculty = dBModel.Faculty;            
        }
    }
}
