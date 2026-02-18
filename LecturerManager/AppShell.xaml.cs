namespace KMA.ProgrammingInCSharp2026.LecturerManager
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("DepartmentsPage/DepartmentDetails", typeof(Pages.DepartmentDetailsPage));
        }
    }
}
