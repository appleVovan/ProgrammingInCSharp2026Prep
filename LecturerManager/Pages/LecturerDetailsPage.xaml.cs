using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

[QueryProperty(nameof(CurrentLecturer), "SelectedLecturer")]
public partial class LecturerDetailsPage : ContentPage
{
	private LecturerUIModel _currentLecturer;

	public LecturerUIModel CurrentLecturer
	{
		get => _currentLecturer;
		set
		{
			_currentLecturer = value;
			BindingContext = CurrentLecturer;
		}
    }

    public LecturerDetailsPage()
	{
		InitializeComponent();
	}
}