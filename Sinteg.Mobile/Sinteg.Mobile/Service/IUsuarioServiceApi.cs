using Sinteg.Mobile.Models;
using System.Threading.Tasks;

namespace Sinteg.Mobile.Service
{
    public interface IUsuarioServiceApi
    {
        Task<Usuario> GetUsuario( string Login , string Senha );
    }
}
