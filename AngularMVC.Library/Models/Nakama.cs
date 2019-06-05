using Newtonsoft.Json;
using SqlKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Models {

    public sealed class Nakama {

        [JsonProperty("id")]
        public int ObjectID { get; set; }

        [JsonProperty("name")]
        public string CrewName { get; set; }

        [JsonProperty("image_url")]
        public string WantedPoster { get; set; }

        [JsonProperty("crew_position")]
        public string CrewPosition { get; set; }

        [JsonProperty("bounty")]
        public int Bounty { get; set; }

        //[JsonProperty("description")]
        //public string Description { get; set; }

        public Nakama() { }

        public Nakama(int id, string name, string url, string position, int bounty) {
			ObjectID = id;
			CrewName = name;
            WantedPoster = url;
            CrewPosition = position;
            Bounty = bounty;
        }
    }
}
