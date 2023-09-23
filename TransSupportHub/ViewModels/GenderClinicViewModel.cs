using MongoDB.Bson;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransSupportHub.Models;
using TransSupportHub.Services;

namespace TransSupportHub.ViewModels
{
    public partial class GenderClinicViewModel : ObservableObject
    {
        private Realm realm;

        [ObservableProperty]
        IQueryable<Clinician> clinicians;

        public void InitialiseRealm()
        {
            realm = RealmDatabaseService.GetRealm();

            try
            {
                Clinicians = realm.All<Clinician>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
