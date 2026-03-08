using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.Pages;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public class DepartmentsViewModel
    {
        private readonly IDepartmentService _departmentService;
        public ObservableCollection<DepartmentListDTO> Departments { get; set; }
        public DepartmentsViewModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            Departments = new ObservableCollection<DepartmentListDTO>(_departmentService.GetAllDepartments());
        }

        private void LoadDepartment()
        {
            //var department = (DepartmentUIModel)e.CurrentSelection[0];

            //Shell.Current.GoToAsync($"{nameof(DepartmentDetailsPage)}", new Dictionary<string, object> { { "SelectedDepartment", department } });
        }
    }
}
