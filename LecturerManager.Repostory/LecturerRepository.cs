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

        public Task<IEnumerable<LecturerDBModel>> GetLecturersByDepartmentAsync(Guid id)
        {
            throw new NotImplementedException();
            return _storageContext.GetLecturersByDepartmentAsync(id);
        }

        public Task<LecturerDBModel> GetLecturerAsync(Guid lecturerId)
        {
            return _storageContext.GetLecturerAsync(lecturerId);
        }

        public Task<int> GetLecturersByDepartmentCountAsync(Guid id)
        {
            return _storageContext.GetLecturersByDepartmentCountAsync(id);
        }
    }
}
