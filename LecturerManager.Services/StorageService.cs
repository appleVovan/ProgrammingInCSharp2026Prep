using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Services
{
    public class StorageService
    {
        private List<DepartmentDBModel> _departments;
        private List<LecturerDBModel> _lecturers;

        private void LoadData()
        {
            if (_departments != null && _lecturers != null)
                return;
            _departments = FakeStorage.Departments.ToList();
            _lecturers = FakeStorage.Lecturers.ToList();
        }
    }
}
