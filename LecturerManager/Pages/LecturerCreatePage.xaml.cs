using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents;
using KMA.ProgrammingInCSharp2026.LecturerManager.CommonComponents.Enums;
using KMA.ProgrammingInCSharp2026.LecturerManager.UIModels;

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
            return;
        }
        if (String.IsNullOrWhiteSpace(eLastName.Text))
        {
            DisplayAlert("Incomlete data!", "Last Name can't be empty", "OK");
            return;
        }
        if (pPosition.SelectedItem == null)
        {
            DisplayAlert("Incomlete data!", "Position must be selected", "OK");
            return;
        }
        if (dpDoB.Date == null)
        {
            DisplayAlert("Incomlete data!", "Date of birth mus be selected", "OK");
            return;
        }
        var lecturer = new LecturerUIModel(Guid.Empty)
        {
            FirstName = eFirstName.Text,
            LastName = eLastName.Text,
            Position = ((EnumWithName<LecturerPosition>)pPosition.SelectedItem).Value,
            DateOfBirth = dpDoB.Date.Value
        };
        lecturer.SaveChangesToDBModel();
        DisplayAlert("Lecturer Created!", $"Lecturer {lecturer.FirstName} {lecturer.LastName} was created successfully, his age is {lecturer.Age}", "OK");
    }

    private void BackClicked(object sender, EventArgs e)
    {
        //TODO: Navigate back
    }
}