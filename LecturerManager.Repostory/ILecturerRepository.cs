using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Repository
{
    public interface ILecturerRepository
    {
        IEnumerable<LecturerDBModel> GetLecturersByDepartment(Guid id);
        int GetLecturersByDepartmentCount(Guid id);
    }
}
