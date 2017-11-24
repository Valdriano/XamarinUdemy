using Newtonsoft.Json;
using System.Collections.Generic;

namespace ValDrive.Model
{
    public class ResultadoLeg
    {
        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        [JsonProperty("end_address")]
        public string EndAddress { get; set; }
 
        [JsonProperty("start_location")]
        public Localizacao StartLocation { get; set; }
      

        [JsonProperty("end_location")]
        public Localizacao EndLocation { get; set; }


        public TextValue Distance { get; set; }

        public TextValue Duration { get; set; }

        public IEnumerable<ResultadoSteps> Steps { get; set; }
    }
}
