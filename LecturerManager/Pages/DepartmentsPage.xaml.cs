using KMA.ProgrammingInCSharp2026.LecturerManager.Services;
using KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels;
using System.Collections.ObjectModel;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class DepartmentsPage : ContentPage
{
	private readonly DepartmentsViewModel _viewModel;
    public DepartmentsPage(DepartmentsViewModel vm)
	{
		InitializeComponent();
		BindingContext = _viewModel = vm;
	}

	override protected async void OnAppearing()
	{
		await _viewModel.RefreshData();
    }
}