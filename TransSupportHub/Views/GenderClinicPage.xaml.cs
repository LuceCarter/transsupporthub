namespace TransSupportHub.Views;

public partial class GenderClinicPage : ContentPage
{
	public GenderClinicPage()
	{
		InitializeComponent();
		BindingContext = new GenderClinicViewModel();
	}
}