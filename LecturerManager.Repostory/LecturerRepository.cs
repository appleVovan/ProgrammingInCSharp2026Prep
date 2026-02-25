using KMA.ProgrammingInCSharp2026.LecturerManager.DBModels;
using KMA.ProgrammingInCSharp2026.LecturerManager.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Repository
{
    public class LecturerRepository : ILecturerRepository
    {
        private readonly IStorageContext _storageContext;
        public LecturerRepository(IStorageContext storageContext)
        {
            _storageContext = storageContext;
        }

        public IEnumerable<LecturerDBModel> GetLecturersByDepartment(Guid id)
        {
            return _storageContext.GetLecturersByDepartment(id);
        }

        public int GetLecturersByDepartmentCount(Guid id)
        {
            return _storageContext.GetLecturersByDepartmentCount(id);
        }
    }
}
