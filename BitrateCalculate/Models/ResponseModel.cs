using Newtonsoft.Json;


namespace BitrateCalculate.Models
{
    public class ResponseModel
    {
        [JsonProperty("Device")]
        public string Device { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

        [JsonProperty("NIC")]
        public List<NIC> Nic { get; set; }
    }
}
