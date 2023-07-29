using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.ViewModels
{
    public partial class HelpCommunityViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task YesAnswer()
        {
            await AppShell.Current.GoToAsync($"{nameof(BusinessFormPage)}");
        }

        [RelayCommand]
        public async Task NoAnswer()
        {
            await AppShell.Current.GoToAsync("../");
        }
    }
}
