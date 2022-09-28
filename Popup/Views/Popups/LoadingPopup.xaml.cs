namespace Popup.Views.Popups;

public partial class LoadingPopup : CommunityToolkit.Maui.Views.Popup
{
	public LoadingPopup()
	{
		InitializeComponent();

		verticalStackLayout.Loaded += (s, e) =>
		{
			verticalStackLayout.BackgroundColor = Colors.Red;
		};

		label.Loaded += (s, e) =>
		{
			label.Text = "label.Loaded FIRE";
		};

		Content.Loaded += (s, e) =>
		{
			Content.BackgroundColor = Colors.Green;
		};
	}

    void chkDismiss_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		if (chkDismiss.IsChecked)
			CanBeDismissedByTappingOutsideOfPopup = true;
		else
			CanBeDismissedByTappingOutsideOfPopup = false;
    }
}
