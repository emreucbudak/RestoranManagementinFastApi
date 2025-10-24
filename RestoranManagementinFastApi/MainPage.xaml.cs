namespace RestoranManagementinFastApi
{
    public partial class MainPage : ContentPage
    {
      

        public MainPage()
        {
            InitializeComponent();
        }
        private async void onRestaurantManagerLoginTransfer(object sender, EventArgs e)
        {
           
            await Shell.Current.GoToAsync("///RestaurantManagerLogin");
        }
        private async void onWaiterLoginTransfer(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("///WaiterLogin");
        }

    }
}
