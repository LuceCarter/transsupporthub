using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.ViewModels
{
    public partial class AgeViewModel : ObservableObject
    {
        [RelayCommand]
        async Task AgeRadioButtonSelectionChanged(string selectedAge)
        {
            await App.Current.MainPage.DisplayPromptAsync("OK", selectedAge, "OK");
        }
    }
}
