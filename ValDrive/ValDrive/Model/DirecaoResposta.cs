using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValDrive.Model
{
    public class DirecaoResposta
    {
        [JsonProperty( "status" )]
        private string StatusText { get; set; }
        [JsonProperty( "routes" )]
        public IEnumerable<ResultadoRota> Rotas { get; set; }
    }
}
