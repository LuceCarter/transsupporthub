namespace TransSupportHub.ViewModels;

public partial class WelcomeViewModel : ObservableObject
{
    [RelayCommand]
    async void GetStarted()
    {
        await Shell.Current.GoToAsync($"{nameof(MenuPage)}");
    }
}
