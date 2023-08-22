namespace RefreshScrollRepro;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    async void RefreshView_Refreshing(System.Object sender, System.EventArgs e)
    {
		await Task.Delay(2000);

		this.refreshView.IsRefreshing = false;
    }
}


