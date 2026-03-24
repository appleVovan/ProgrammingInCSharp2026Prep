using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using KMA.ProgrammingInCSharp2026.LecturerManager.Pages;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{    
    public partial class DepartmentDetailsViewModel : ObservableObject, IQueryAttributable
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILecturerService _lecturerService;

        private Guid _departmentId;

        [ObservableProperty]
        private DepartmentDetailsDTO _currentDepartment;
        [ObservableProperty]
        private ObservableCollection<LecturerListDTO> _lecturers;

        public DepartmentDetailsViewModel(IDepartmentService departmentService, ILecturerService lecturerService)
        {
            _departmentService = departmentService;
            _lecturerService = lecturerService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            _departmentId = (Guid)query["DepartmentId"];
        }

        internal async Task RefreshData()
        {
            CurrentDepartment = await _departmentService.GetDepartmentAsync(_departmentId);
            Lecturers = new ObservableCollection<LecturerListDTO>(await _lecturerService.GetLecturersByDepartmentAsync(_departmentId));
        }

        [RelayCommand]
        private async Task LoadLecturer(Guid lecturerId)
        {
            await Shell.Current.GoToAsync($"{nameof(LecturerDetailsPage)}", new Dictionary<string, object> { { "LecturerId", lecturerId } });
        }
    }
}
