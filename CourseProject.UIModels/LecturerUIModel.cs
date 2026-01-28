using KMA.ProgrammingInCSharp2026.CourseProject.CourseProject.Common.Enums;
using KMA.ProgrammingInCSharp2026.CourseProject.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.CourseProject.UIModels
{    
    public class LecturerUIModel
    {
        private LecturerDBModel _dbModel;
        private Guid _departmentGuid;
        private string _firstName;
        private string _lastName;
        private LecturerPosition _position;
        private DateTime _dateOfBirth;
        private int _age;

        public Guid? Id
        {
            get => _dbModel?.Id;
        }
        public Guid DepartmentGuid 
        { 
            get => _departmentGuid;
        }
        public string FirstName 
        { 
            get => _firstName; 
            set => _firstName = value; 
        }
        public string LastName 
        { 
            get => _lastName; 
            set => _lastName = value; 
        }
        public LecturerPosition Position 
        { 
            get => _position; 
            set => _position = value; 
        }
        public DateTime DateOfBirth 
        { 
            get => _dateOfBirth;
            set
            {
                if (_dbModel != null)
                    return; //Prevent changing DateOfBirth if DBModel exists
                _dateOfBirth = value;
                CalculateAge();
            }
        }
        public int Age 
        { 
            get => _age;
        }

        internal LecturerUIModel(Guid departmentGuid)
        {
            _departmentGuid = departmentGuid;
        }

        public LecturerUIModel(LecturerDBModel dBModel)
        {
            _dbModel = dBModel;
            _departmentGuid = dBModel.DepartmentGuid;
            _firstName = dBModel.FirstName;
            _lastName = dBModel.LastName;
            _position = dBModel.Position;
            _dateOfBirth = dBModel.DateOfBirth;
            CalculateAge();
        }

        private void CalculateAge()
        {
            var today = DateTime.Today;
            _age = today.Year - _dateOfBirth.Year;
            if (_dateOfBirth.Date > today.AddYears(-_age))
                _age--;
        }
    }
}
