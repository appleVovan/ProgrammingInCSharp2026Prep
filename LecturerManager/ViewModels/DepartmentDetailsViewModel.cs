using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.Pages;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public class DepartmentDetailsViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        private readonly IDepartmentService _departmentService;

        private DepartmentDetailsDTO _currentDepartment;

        public event PropertyChangedEventHandler PropertyChanged;

        public DepartmentDetailsDTO CurrentDepartment
        {
            get => _currentDepartment;
            set
            {
                _currentDepartment = value;
                OnPropertyChanged(nameof(CurrentDepartment));
            }
        }
        public DepartmentDetailsViewModel(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var departmentId = (Guid)query["DepartmentId"];
            CurrentDepartment = _departmentService.GetDepartment(departmentId);
        }

        //private void LecturerSelected(object sender, SelectionChangedEventArgs e)
        //{
        //    var lecturer = (LecturerUIModel)e.CurrentSelection[0];
        //    Shell.Current.GoToAsync($"{nameof(LecturerDetailsPage)}", new Dictionary<string, object> { { "SelectedLecturer", lecturer } });
        //}

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
