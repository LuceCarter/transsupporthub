namespace TransSupportHub.Views;

public partial class AgePage : ContentPage
{
	public AgePage()
	{
		InitializeComponent();
		BindingContext = new AgeViewModel();
	}
}