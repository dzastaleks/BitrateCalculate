using Newtonsoft.Json;

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
