using CommunityToolkit.Maui.Views;
using Popup.Views.Popups;

namespace Popup;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		this.ShowPopupAsync(new LoadingPopup()
		{

		});
    }
}


