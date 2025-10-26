namespace RestoranManagementinFastApi.Pages;

public partial class ProductCategoryPanel : ContentPage
{
	public ProductCategoryPanel()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RestaurantManagerPanel");
    }
}