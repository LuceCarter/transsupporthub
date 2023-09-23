using MongoDB.Bson;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransSupportHub.Models
{
    public partial class Clinician : IRealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("owner_id")]
        [Required]
        public string OwnerId { get; set; }

        [MapTo("name")]
        [Required]
        public string Name { get; set; }

        [MapTo("pronouns")]
        public string Pronouns { get; set; }

        [MapTo("job_title")]
        public string JobTitle { get; set; }

        [MapTo("qualifications")]
        public IList<string> Qualifications { get;}

        [MapTo("location")]
        [Required]
        public string Location { get; set; }

        [MapTo("clinic_name")]
        [Required]
        public string ClinicName { get; set; }

        [MapTo("clinic_address")]
        public ClinicAddress ClinicAddress { get; set; }
    }

    public partial class ClinicAddress : IRealmObject
    {
        [MapTo("address_line_1")]
        public string AddressLine1 { get; set; }

        [MapTo("city")]
        public string City { get; set; }

        [MapTo("postcode")]
        public string Postcode { get; set; }

        [MapTo("coords")]
        public Coords Coords { get; set; }
    }

    public partial class Coords : IRealmObject
    {
        [MapTo("point")]
        public string Point { get; set; }

        [MapTo("coordinates")]
        public IList<int> Coordinates { get; }
    }
}
