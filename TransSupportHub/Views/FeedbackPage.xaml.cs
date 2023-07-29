namespace TransSupportHub.Views;

public partial class FeedbackPage : ContentPage
{
	public FeedbackPage()
	{
		InitializeComponent();
		BindingContext = new FeedbackViewModel();
	}
}