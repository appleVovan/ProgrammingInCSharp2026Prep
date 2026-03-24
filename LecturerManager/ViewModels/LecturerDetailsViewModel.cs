using CommunityToolkit.Mvvm.ComponentModel;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public partial class LecturerDetailsViewModel : ObservableObject, IQueryAttributable
    {
        private readonly ILecturerService _lecturerService;
        private LecturerDetailsDTO _currentLecturer;
        private int _age;
        private Guid _lecturerId;

        public string FirstName => _currentLecturer?.FirstName;
        public string LastName => _currentLecturer?.LastName;
        public LecturerPosition? Position => _currentLecturer?.Position;
        public DateTime? DateOfBirth => _currentLecturer?.DateOfBirth;
        public int Age => _age;

        public LecturerDetailsViewModel(ILecturerService lecturerService)
        {
            _lecturerService = lecturerService;
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            _lecturerId = (Guid)query["LecturerId"];            
        }

        internal async Task RefreshData()
        {
            _currentLecturer = await _lecturerService.GetLecturerAsync(_lecturerId);
            await Task.Run(CalculateAge);
            OnPropertyChanged(nameof(FirstName));
            OnPropertyChanged(nameof(LastName));
            OnPropertyChanged(nameof(Position));
            OnPropertyChanged(nameof(DateOfBirth));
            OnPropertyChanged(nameof(Age));
        }

        private void CalculateAge()
        {
            if (DateOfBirth == null)
                return;

            var dob = DateOfBirth.Value;
            var today = DateTime.Today;
            _age = today.Year - dob.Year;
            if (today < dob.AddYears(_age))
                _age--;
        }
    }
}
