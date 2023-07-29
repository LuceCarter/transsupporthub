using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.ViewModels
{
    public partial class FeedbackViewModel : ObservableObject
    {
        [ObservableProperty]
        string nameText;

        [ObservableProperty]
        string emailText;

        [ObservableProperty]
        string feedbackText;

        [RelayCommand]
        async Task SubmitInfo()
        {

        }
    }
}
