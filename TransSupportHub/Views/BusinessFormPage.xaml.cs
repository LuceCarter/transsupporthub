namespace TransSupportHub.Views;

public partial class BusinessFormPage : ContentPage
{
	public BusinessFormPage()
	{
		InitializeComponent();
		BindingContext = new BusinessFormViewModel();
	}
}