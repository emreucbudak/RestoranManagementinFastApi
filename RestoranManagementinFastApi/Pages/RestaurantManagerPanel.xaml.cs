using System.Threading.Tasks;

namespace RestoranManagementinFastApi.Pages;

public partial class RestaurantManagerPanel : ContentPage
{
	public RestaurantManagerPanel()
	{
		InitializeComponent();
	}
	private async void OnProductManagementTransfer (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///ProductPanel");
	}
	private async void OnProductCategoryManagementTransfer (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///ProductCategoryPanel");
	}
	private async void onAddWaiterButton (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///WaiterManagementPanel");
	}
	private async void OnTableManagementTransfer (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///TableManagementPanel");
	}
}