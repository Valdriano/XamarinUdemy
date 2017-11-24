using Newtonsoft.Json;

namespace ValDrive.Model
{
    public class Localizacao
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("Lng")]
        public double Longitude { get; set; }
    }
}
