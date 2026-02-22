using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;
using System.Collections.ObjectModel;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class DepartmentsPage : ContentPage
{
	private IStorageService _storage;
	public ObservableCollection<DepartmentUIModel> Departments { get; set; }
	public DepartmentsPage(IStorageService storage)
	{
		InitializeComponent();
		_storage = storage;
		Departments = new ObservableCollection<DepartmentUIModel>();
		foreach (var department in _storage.GetAllDepartments())
		{
			Departments.Add(new DepartmentUIModel(storage, department));
		}
		BindingContext = this;
	}

    private void DepartmentSelected(object sender, SelectionChangedEventArgs e)
    {
		var department = (DepartmentUIModel)e.CurrentSelection[0];

		Shell.Current.GoToAsync($"{nameof(DepartmentDetailsPage)}", new Dictionary<string, object> { { "SelectedDepartment", department } });
    }

}