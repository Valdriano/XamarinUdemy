using Newtonsoft.Json;
using System.Collections.Generic;

namespace ValDrive.Model
{
    public class ResultadoRota
    {
        public string Summary { get; set; }

        [JsonProperty("overview_polyline")]
        public Polyline Polyline { get; set; }
    
        public ResultadoBounds Bounds { get; set; }
       
        public IEnumerable<ResultadoLeg> Legs { get; set; }
    }
}
