using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using KMA.ProgrammingInCSharp2026.LecturerManager.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly ILecturerRepository _lecturerRepository;
        public LecturerService(ILecturerRepository lecturerRepository)
        {
            _lecturerRepository = lecturerRepository;
        }
        public IEnumerable<LecturerListDTO> GetLecturersByDepartment(Guid departmentId)
        {
            foreach (var lecturer in _lecturerRepository.GetLecturersByDepartment(departmentId))
            {
                yield return new LecturerListDTO(lecturer.Id, lecturer.FirstName, lecturer.LastName, lecturer.Position);
            }
        }
    }
}
