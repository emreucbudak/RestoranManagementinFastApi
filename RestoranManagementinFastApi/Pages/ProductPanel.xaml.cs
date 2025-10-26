namespace RestoranManagementinFastApi.Pages;

public partial class ProductPanel : ContentPage
{
	public ProductPanel()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RestaurantManagerPanel");
    }
}