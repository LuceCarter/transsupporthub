namespace TransSupportHub.Views;

public partial class HelpCommunityPage : ContentPage
{
	public HelpCommunityPage()
	{
		InitializeComponent();
		BindingContext = new HelpCommunityViewModel();
	}
}