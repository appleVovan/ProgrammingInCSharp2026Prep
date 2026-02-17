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

    }

    private void BackClicked(object sender, EventArgs e)
    {

    }
}