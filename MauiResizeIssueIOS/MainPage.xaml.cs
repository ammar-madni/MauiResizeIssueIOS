namespace MauiResizeIssueIOS;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void OnToggleClicked(object sender, EventArgs e)
    {
        AddressDetails.IsVisible = !AddressDetails.IsVisible;
    }
}


