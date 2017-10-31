using System.Threading.Tasks;
using Sinteg.Mobile.Models;
using Xamarin.Forms;
using Sinteg.Mobile.Service;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;

[assembly: Dependency( typeof( UsuarioServiceApi ) )]
namespace Sinteg.Mobile.Service
{
    public class UsuarioServiceApi : IUsuarioServiceApi
    {
        private const string BaseUrl = "http://10.2.10.71/WebApp/api/";
        public async Task<Usuario> GetUsuario( string Login , string Senha )
        {
            HttpClient httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );

            //HttpResponseMessage httpResponseMessage = await httpClient.GetAsync( $"{BaseUrl}usuarios/Login/{Login}/{Senha}" ).ConfigureAwait( false );
            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync( $"{BaseUrl}usuarios/Login/{Login}/{Senha}" , null ).ConfigureAwait( false );

            if( httpResponseMessage.IsSuccessStatusCode )
            {
                using( Stream stream = await httpResponseMessage.Content.ReadAsStreamAsync().ConfigureAwait( false ) )
                {
                    return JsonConvert.DeserializeObject<Usuario>(
                        await new StreamReader( stream )
                        .ReadLineAsync()
                        .ConfigureAwait( false ) );
                }
            }

            return null;
        }
    }
}
