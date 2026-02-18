using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

[QueryProperty(nameof(CurrentDepartment), "SelectedDepartment")]
public partial class DepartmentDetailsPage : ContentPage
{
    private DepartmentUIModel _currentDepartment;

    public DepartmentUIModel CurrentDepartment
    {
        get => _currentDepartment;
        set
        {
            _currentDepartment = value;
            _currentDepartment.LoadLecturers();
            BindingContext = CurrentDepartment;
        }
    }
    public DepartmentDetailsPage()
	{
		InitializeComponent();
    }

}