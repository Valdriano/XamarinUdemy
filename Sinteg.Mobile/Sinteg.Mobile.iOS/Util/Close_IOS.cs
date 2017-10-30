using Sinteg.Mobile.iOS.Util;
using Sinteg.Mobile.Util;
using System.Threading;
using Xamarin.Forms;

[assembly: Dependency( typeof( Close_IOS ) )]
namespace Sinteg.Mobile.iOS.Util
{
    public class Close_IOS : ICloseApplication
    {
        public void Close()
        {
            Thread.CurrentThread.Abort();
        }
    }
}