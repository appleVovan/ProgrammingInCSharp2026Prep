using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Repository
{
    public interface IDepartmentRepository
    {
        IEnumerable<DepartmentDBModel> GetDepartments();
    }
}
