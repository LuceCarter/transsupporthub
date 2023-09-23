using Realms.Sync;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.Services
{
    public static class RealmDatabaseService
    {
        public static Realm GetRealm()
        {            
                return Realm.GetInstance();           
        }
    }
       
}
