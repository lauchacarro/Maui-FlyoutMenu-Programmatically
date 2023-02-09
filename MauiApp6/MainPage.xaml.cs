namespace MauiApp6;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}



    private void Button1Btn_Clicked(object sender, EventArgs e)
    {
		

        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }

    private void Button2Btn_Clicked(object sender, EventArgs e)
    {
        HideLbl.Text = "WorkAround";

        Shell.Current.FlyoutIsPresented = !Shell.Current.FlyoutIsPresented;
    }
}

