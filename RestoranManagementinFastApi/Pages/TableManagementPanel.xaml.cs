namespace RestoranManagementinFastApi.Pages;

public partial class TableManagementPanel : ContentPage
{
	public TableManagementPanel()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///RestaurantManagerPanel");
    }
}