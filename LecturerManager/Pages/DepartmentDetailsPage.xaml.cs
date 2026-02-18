using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

[QueryProperty(nameof(CurrentDepartment), "SelectedDepartment")]
public partial class DepartmentDetailsPage : ContentPage, IQueryAttributable
{
    private DepartmentUIModel _currentDepartment;

    public DepartmentUIModel CurrentDepartment
    {
        get => _currentDepartment;
        set
        {
            _currentDepartment = value;
            BindingContext = CurrentDepartment;
        }
    }
    public DepartmentDetailsPage()
	{
		InitializeComponent();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        BindingContext = CurrentDepartment;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        CurrentDepartment = query["SelectedDepartment"] as DepartmentUIModel;
    }
}