using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.ViewModels
{
    public partial class LocationViewModel: ObservableObject
    {
        [ObservableProperty]
        string postcode;

        [RelayCommand]
        async Task<string> GetCurrentLocation()
        {
            try
            {
                Location location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                    await App.Current.MainPage.DisplayAlert("Location", $"Latitude: {location.Latitude}, Longitude: {location.Longitude}", "OK");
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                await App.Current.MainPage.DisplayAlert("Error", "Not supported on this device. Please enter postcode", "OK");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
                await App.Current.MainPage.DisplayAlert("Error", "Not enabled on this device. Please enter postcode", "OK");

            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                await App.Current.MainPage.DisplayAlert("Error", "Permission not granted for location. Please enable in device settings or enter postcode", "OK");

            }
            catch (Exception ex)
            {
                // Unable to get location
                await App.Current.MainPage.DisplayAlert("Error", "Unable to fetch location. Please enter postcode", "OK");

            }

            return "None";
           
        }
        
        }
}
