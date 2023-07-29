    using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;


namespace TransSupportHub.ViewModels
{
    partial class EventsViewModel : ObservableObject
    {

        public EventsViewModel()
        {
            
        }
    }


public class Event
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Start { get; set; }
        public DateTimeOffset End { get; set; }
        // add additional properties as needed
    }
}
