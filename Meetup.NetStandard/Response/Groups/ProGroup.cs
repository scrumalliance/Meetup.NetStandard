using Meetup.NetStandard.Response.Topics;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Meetup.NetStandard.Response.Groups
{
    public class ProGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("urlname")]
        public string UrlName { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("gender_unknown")]
        public double GenderUnknown { get; set; }

        [JsonProperty("gender_female")]
        public double GenderFemale { get; set; }

        [JsonProperty("gender_male")]
        public double GenderMale { get; set; }

        [JsonProperty("gender_other")]
        public double GenderOther { get; set; }

        [JsonProperty("organizers")]
        public List<Organizer> Organizers { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("organizer_photo")]
        public OrganizerPhoto OrganizerPhoto { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("average_age")]
        public double AverageAge { get; set; }

        [JsonProperty("founded_date")]
        public long FoundedDate { get; set; }

        [JsonProperty("pro_join_date")]
        public long ProJoinDate { get; set; }

        [JsonProperty("past_events")]
        public int PastEvents { get; set; }

        [JsonProperty("upcoming_events")]
        public int UpcomingEvents { get; set; }

        [JsonProperty("past_rsvps")]
        public int PastRsvps { get; set; }

        [JsonProperty("rsvps_per_event")]
        public double RsvpsPerEvent { get; set; }

        [JsonProperty("repeat_rsvpers")]
        public int RepeatRsvpers { get; set; }

        [JsonProperty("topics")]
        public List<Topic> Topics { get; set; }
    }
}
