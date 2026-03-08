using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ILecturerRepository _lecturerRepository;

        public DepartmentService(IDepartmentRepository departmentRepository, ILecturerRepository lecturerRepository)
        {
            _departmentRepository = departmentRepository;
            _lecturerRepository = lecturerRepository;
        }

        public IEnumerable<DepartmentListDTO> GetAllDepartments()
        {
            foreach (var department in _departmentRepository.GetDepartments())
            {
                var lecturersCount = _lecturerRepository.GetLecturersByDepartmentCount(department.Id);
                yield return new DepartmentListDTO(department.Id, department.Name, department.Faculty, lecturersCount);
            }
        }

        public DepartmentDetailsDTO GetDepartment(Guid departmentId)
        {
            var department = _departmentRepository.GetDepartment(departmentId);
            return new DepartmentDetailsDTO(department.Id, department.Name, department.Faculty, department.Email);
        }
    }
}
