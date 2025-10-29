namespace RestoranManagementAdminPanel.Pages;

public partial class AdminPanel : ContentPage
{
	public AdminPanel()
	{
		InitializeComponent();
	}
	private async void onRestoranManagementPanelTransferClicked (object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("///RestoranManagementPanel");
	}
}