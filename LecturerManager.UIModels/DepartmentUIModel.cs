using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.UIModels
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
        // Constructor used to create new Department
        public DepartmentUIModel()
        {
            _lecturers = new List<LecturerUIModel>();
        }
        // Constructor used to load existing Department for viewing/editing
        public DepartmentUIModel(DepartmentDBModel dBModel):this()
        {
            _dbModel = dBModel;
            _name = dBModel.Name;
            _faculty = dBModel.Faculty;
        }

        public void SaveChangesToDBModel()
        {
            if (_dbModel != null)
            {
                _dbModel.Name = _name;
                _dbModel.Faculty = _faculty;
            }
            else
            {
                _dbModel = new DepartmentDBModel(_name, _faculty);
            }
        }
    }
}
