namespace RestoranManagementAdminPanel
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }
        private async void onLoginButton (object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///AdminPanel");
        }

    }
}
