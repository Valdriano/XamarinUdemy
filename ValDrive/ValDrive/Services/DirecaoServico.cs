using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using ValDrive.Model;

namespace ValDrive.Services
{
    public class DirecaoServico
    {
        private readonly string baseUrl = "https://maps.googleapis.com/maps/api/directions/";
        private HttpClient httpClient;
        private readonly string key;

        public DirecaoServico( string _key ) => key = _key;

        public async Task<DirecaoResposta> ObterRota( string origem , string destino )
        {
            httpClient = new HttpClient();

            string url = string.Format( baseUrl + $"json?origin={origem}&destination={destino}&key={key}" );

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync( url );

            string json = await httpResponseMessage.Content.ReadAsStringAsync();

            if( httpResponseMessage.IsSuccessStatusCode )
            {
                var result = JsonConvert.DeserializeObject<DirecaoResposta>( json );

                return result;
            }

            return null;
        }
    }
}
