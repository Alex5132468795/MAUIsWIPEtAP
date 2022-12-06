namespace MauiApp5;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
	{
        OWO.Text = "==OWO";
        OWO.TextColor = Color.FromRgb(122, 255, 122);
        await OWO.TranslateTo(100, 0);
        await OWO.TranslateTo(0, 0);
    }
	private async void SwipeGestureRecognizer_Swiped_2(object sender, SwipedEventArgs e)
	{
        await QWQ.TranslateTo(0,-50);
        await QWQ.TranslateTo(0, 0);
    }

	private async void SwipeGestureRecognizer_Swiped_3(object sender, SwipedEventArgs e)
	{
		OWO.Text = "OWO==";
		OWO.TextColor = Color.FromRgb(100,100,255);
		await OWO.TranslateTo(-100,0);
        await OWO.TranslateTo(0,0);
    }

	private async void SwipeGestureRecognizer_Swiped_4(object sender, SwipedEventArgs e)
    {
        await QWQ.TranslateTo(0,50);
        await QWQ.TranslateTo(0, 0);
    }

	/*
	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
		var c = (sender as Frame);
		if (c != null)
		{
			await c.RelRotateTo(45, 45);
		}
		else
		{
			var dc = (sender as VerticalStackLayout);
			await dc.RelRotateTo(45, 45);
		}
    }
	*/
}

