using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projeto09
{
    public class ServiceCEP
    {
        private static string UrlBase = "https://viacep.com.br/ws/{0}/json/";

        public static async Task<CEP> GetCEP( string cep )
        {
            try
            {
                string url = string.Format( UrlBase , cep );

                HttpClient httpClient = new HttpClient();

                httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );

                HttpResponseMessage httpResponse = await httpClient.GetAsync( url ).ConfigureAwait( false );

                if( httpResponse.IsSuccessStatusCode )
                {
                    string stream = await httpResponse.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<CEP>( stream );

                }

                return null;
            }
            catch( JsonException ex )
            {

                throw new System.Exception( ex.Message );
            }
        }
    }
}
