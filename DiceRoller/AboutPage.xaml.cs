namespace DiceRoller;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void GitHub_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://github.com/Enzo-N-Freitas");
    }
}