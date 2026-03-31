using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public partial class LecturerCreateViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly ILecturerService _lecturerService;

        private Guid _departmentId;
        private EnumWithName<LecturerPosition>[] _positions;

        [ObservableProperty]
        private string _firstName;
        [ObservableProperty]
        private string _lastName;
        [ObservableProperty]
        private EnumWithName<LecturerPosition> _position;
        [ObservableProperty]
        private DateTime? _dateOfBirth;

        public EnumWithName<LecturerPosition>[] Positions => _positions;

        public LecturerCreateViewModel(ILecturerService lecturerService)
        {
            _lecturerService = lecturerService;
            _positions = EnumExtensions.GetValuesWithNames<LecturerPosition>();
        }
        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            _departmentId = (Guid)query[nameof(LecturerCreateDTO.DepartmentId)];
        }

        [RelayCommand]
        public async Task CreateLecturer()
        {
            IsBusy = true;
            try
            {
                var newLecturer = new LecturerCreateDTO(_departmentId, FirstName, LastName, Position.Value, DateOfBirth ?? DateTime.MinValue);
                await _lecturerService.CreateLecturerAsync(newLecturer);
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Error", $"Failed to create lecturer: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        public async Task Back()
        {
            try
            {
                IsBusy = true;
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Error", $"Failed to navigate back: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
