using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Storage
{
    public interface IStorageContext
    {
        IEnumerable<DepartmentDBModel> GetDepartments();
        IEnumerable<LecturerDBModel> GetLecturersByDepartment(Guid departmentId);
        int GetLecturersByDepartmentCount(Guid id);
    }
}
