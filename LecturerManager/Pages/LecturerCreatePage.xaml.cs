namespace KMA.ProgrammingInCSharp2026.LecturerManager.Pages;

public partial class LecturerCreatePage : ContentPage
{
	public LecturerCreatePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		But2.Text += " (Clicked)";
    }
}