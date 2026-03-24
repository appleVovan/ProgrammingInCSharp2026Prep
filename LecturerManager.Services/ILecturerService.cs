using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Services
{
    public interface ILecturerService
    {
        Task<IEnumerable<LecturerListDTO>> GetLecturersByDepartmentAsync(Guid departmentId);
        Task<LecturerDetailsDTO> GetLecturerAsync(Guid lecturerId);
    }
}
