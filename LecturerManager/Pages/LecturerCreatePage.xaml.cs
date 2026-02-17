using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;

namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class LecturerCreatePage : ContentPage
{
	public LecturerCreatePage()
	{
		InitializeComponent();
        pPosition.ItemsSource = EnumExtensions.GetValuesWithNames<LecturerPosition>();        
	}

    private void CreateClicked(object sender, EventArgs e)
    {
        if (String.IsNullOrWhiteSpace(eFirstName.Text))
        {
            DisplayAlert("Incomlete data!", "First Name can't be empty", "OK");
        }
    }

    private void BackClicked(object sender, EventArgs e)
    {
        //TODO: Navigate back
    }
}