using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class DepartmentDetailsPage : ContentPage
{
    public DepartmentUIModel CurrentDepartment { get; set; }
    public DepartmentDetailsPage()
	{
		InitializeComponent();
		var storage = new StorageService();
		var department = storage.GetAllDepartments().FirstOrDefault();
		CurrentDepartment = new DepartmentUIModel(department);
		BindingContext = CurrentDepartment;
    }
}