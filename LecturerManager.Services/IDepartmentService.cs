using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Services
{
    public interface IDepartmentService
    {
        IAsyncEnumerable<DepartmentListDTO> GetAllDepartmentsAsync();
        Task<DepartmentDetailsDTO> GetDepartmentAsync(Guid departmentId);
    }
}
