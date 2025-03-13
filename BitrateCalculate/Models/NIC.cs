using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitrateCalculate.Models
{
    public class NIC
    {
        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("MAC")]
        public string Mac { get; set; }

        [JsonProperty("Timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonProperty("Rx")]
        public long Rx { get; set; }

        [JsonProperty("Tx")]
        public long Tx { get; set; }
    }
}
