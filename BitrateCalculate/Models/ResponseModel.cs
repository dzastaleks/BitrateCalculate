using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
