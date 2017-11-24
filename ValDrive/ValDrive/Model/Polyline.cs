using Newtonsoft.Json;
using System.Collections.Generic;
using Xamarin.Forms.Maps;

namespace ValDrive.Model
{
    public class Polyline
    {
        public string Points { get; set; }
     
        [JsonIgnore]
        public IEnumerable<Position> Positions
        {
            get
            {
                return GooglePoints.Decode(this.Points);
            }
        }
    }
}
