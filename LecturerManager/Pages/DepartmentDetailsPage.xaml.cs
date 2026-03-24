using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class DepartmentDetailsPage : ContentPage
{
    private readonly DepartmentDetailsViewModel _viewModel;
    public DepartmentDetailsPage(DepartmentDetailsViewModel vm)
    {
        InitializeComponent();
        BindingContext = _viewModel = vm;
    }

    override protected async void OnAppearing()
    {
        await _viewModel.RefreshData();
    }
}