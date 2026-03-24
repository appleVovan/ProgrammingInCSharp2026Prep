using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.Pages;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public partial class DepartmentsViewModel : BaseViewModel
    {
        private readonly IDepartmentService _departmentService;
        [ObservableProperty]
        private ObservableCollection<DepartmentListDTO> _departments;
        [ObservableProperty]
        private DepartmentListDTO _currentDepartment;
        
        public DepartmentsViewModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        internal async Task RefreshData()
        {
            IsBusy = true;
            Departments = new ObservableCollection<DepartmentListDTO>();
            await foreach (var department in _departmentService.GetAllDepartmentsAsync())
            {
                Departments.Add(department);
            }
            IsBusy = false;
        }

        [RelayCommand]
        private async Task GotoDepartment()
        {
            IsBusy = true;
            if (CurrentDepartment != null)
                await Shell.Current.GoToAsync($"{nameof(DepartmentDetailsPage)}", new Dictionary<string, object> { { "DepartmentId", CurrentDepartment.Id } });
            IsBusy = false;
        }
    }
}
