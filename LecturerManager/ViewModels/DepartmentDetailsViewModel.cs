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
    public partial class DepartmentDetailsViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILecturerService _lecturerService;

        private Task<DepartmentDetailsDTO> _detailsTask;
        private Task<IEnumerable<LecturerListDTO>> _lecturersTask;

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
            _detailsTask = _departmentService.GetDepartmentAsync(_departmentId);
            _lecturersTask = _lecturerService.GetLecturersByDepartmentAsync(_departmentId);
        }

        internal async Task RefreshData()
        {
            IsBusy = true;
            try
            {
                CurrentDepartment = await _departmentService.GetDepartmentAsync(_departmentId) ?? throw new Exception("Department does not exist.");
                Lecturers = new ObservableCollection<LecturerListDTO>(await _lecturerService.GetLecturersByDepartmentAsync(_departmentId));
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Error", $"Failed to load department details: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task LoadLecturer(Guid lecturerId)
        {
            IsBusy = true;
            try
            {
                await Shell.Current.GoToAsync($"{nameof(LecturerDetailsPage)}", new Dictionary<string, object> { { "LecturerId", lecturerId } });
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlertAsync("Error", $"Failed to navigate to lecturer details: {ex.Message}", "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
