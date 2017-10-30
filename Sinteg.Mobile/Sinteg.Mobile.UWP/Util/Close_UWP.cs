using Sinteg.Mobile.Util;
using Sinteg.Mobile.UWP.Util;
using Xamarin.Forms;

[assembly: Dependency( typeof( Close_UWP ) )]
namespace Sinteg.Mobile.UWP.Util
{
    public class Close_UWP : ICloseApplication
    {
        public void Close()
        {
            Windows.UI.Xaml.Application.Current.Exit();
        }
    }
}
