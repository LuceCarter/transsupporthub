namespace TransSupportHub.ViewModels;

public partial class MenuViewModel : ObservableObject
{

    [RelayCommand]
    public async Task OnAppearing()
    {
        await RealmService.Init();
        
    }

    [RelayCommand]
    async Task FindGenderClinic()
    {
        await Shell.Current.GoToAsync($"{nameof(GenderClinicPage)}");
    }

    [RelayCommand]
    async Task HelpCommunity()
    {
        await Shell.Current.GoToAsync($"{nameof(HelpCommunityPage)}");
    }

    [RelayCommand]
    async Task Feedback()
    {
        await Shell.Current.GoToAsync($"{nameof(FeedbackPage)}");
    }

    [RelayCommand]
    async Task ClothesSwap()
    {
        await Shell.Current.GoToAsync($"{nameof(EventsPage)}");
    }
}
