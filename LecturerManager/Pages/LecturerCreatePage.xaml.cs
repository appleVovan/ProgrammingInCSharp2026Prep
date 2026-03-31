using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.ViewModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class LecturerCreatePage : ContentPage
{
	public LecturerCreatePage(LecturerCreateViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}