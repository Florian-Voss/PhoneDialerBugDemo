namespace PhoneDialerBugDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		string phoneNumber = "12345";
		if(PhoneDialer.Default.IsSupported)
		{
			PhoneDialer.Default.Open("12345");
		}
	}
}

