using Foundation;
using Projeto06.iOS;
using Xamarin.Forms;

[assembly: Dependency( typeof( BaseUrl_IOS ) )]
namespace Projeto06.iOS
{
    public class BaseUrl_IOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}
