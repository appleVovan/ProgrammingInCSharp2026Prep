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

    private async void CreateClicked(object sender, EventArgs e)
    {
        if (String.IsNullOrWhiteSpace(eFirstName.Text))
        {
            await DisplayAlertAsync("Incomlete data!", "First Name can't be empty", "OK");
        }
        if (String.IsNullOrWhiteSpace(eLastName.Text))
        {
            await DisplayAlertAsync("Incomlete data!", "Last Name can't be empty", "OK");
        }
        if (pPosition.SelectedItem == null)
        {
            await DisplayAlertAsync("Incomlete data!", "Position must be selected", "OK");
        }
        if (dpDoB.Date == null)
        {
            await DisplayAlertAsync("Incomlete data!", "Date of birth mus be selected", "OK");
        }
        //var lecturer = new LecturerUIModel(Guid.Empty)
        //{
        //    FirstName = eFirstName.Text,
        //    LastName = eLastName.Text,
        //    Position = ((EnumWithName<LecturerPosition>)pPosition.SelectedItem).Value,
        //    DateOfBirth = dpDoB.Date.Value
        //};
        //lecturer.SaveChangesToDBModel();
        //DisplayAlert("Lecturer Created!", $"Lecturer {lecturer.FirstName} {lecturer.LastName} was created successfully, his age is {lecturer.Age}", "OK");
    }

    private void BackClicked(object sender, EventArgs e)
    {
        //TODO: Navigate back
    }
}