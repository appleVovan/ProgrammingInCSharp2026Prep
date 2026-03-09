using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Department;
using KMA.ProgrammingInCSharp2026.LecturerManager.DTOModels.Lecturer;
using KMA.ProgrammingInCSharp2026.LecturerManager.Pages;
using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels
{
    public class DepartmentDetailsViewModel : IQueryAttributable, INotifyPropertyChanged
    {
        private readonly IDepartmentService _departmentService;
        private readonly ILecturerService _lecturerService;

        private DepartmentDetailsDTO _currentDepartment;

        public event PropertyChangedEventHandler PropertyChanged;

        public DepartmentDetailsDTO CurrentDepartment
        {
            get => _currentDepartment;
            set
            {
                _currentDepartment = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<LecturerListDTO> Lecturers { get; set; }

        public DepartmentDetailsViewModel(IDepartmentService departmentService, ILecturerService lecturerService)
        {
            _departmentService = departmentService;
            _lecturerService = lecturerService;
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            var departmentId = (Guid)query["DepartmentId"];
            CurrentDepartment = _departmentService.GetDepartment(departmentId);
            Lecturers = new ObservableCollection<LecturerListDTO>(_lecturerService.GetLecturersByDepartment(departmentId));
            OnPropertyChanged(nameof(Lecturers));
        }

        //private void LecturerSelected(object sender, SelectionChangedEventArgs e)
        //{
        //    var lecturer = (LecturerUIModel)e.CurrentSelection[0];
        //    Shell.Current.GoToAsync($"{nameof(LecturerDetailsPage)}", new Dictionary<string, object> { { "SelectedLecturer", lecturer } });
        //}

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
