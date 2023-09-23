namespace TransSupportHub.Views;

public partial class GenderClinicPage : ContentPage
{
    GenderClinicViewModel viewModel = new GenderClinicViewModel();
	public GenderClinicPage()
	{

		InitializeComponent();
		viewModel = new GenderClinicViewModel();
		BindingContext = viewModel;
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
		viewModel.InitialiseRealm();
    }
}