using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Storage
{
    public interface IStorageContext
    {
        IAsyncEnumerable<DepartmentDBModel> GetDepartmentsAsync();
        Task<DepartmentDBModel> GetDepartmentAsync(Guid departmentGuid);
        IEnumerable<LecturerDBModel> GetLecturersByDepartment(Guid departmentId);
        LecturerDBModel GetLecturer(Guid lecturerGuid);
        int GetLecturersByDepartmentCount(Guid id);
    }
}
