using Android.OS;
using Sinteg.Mobile.Droid.Util;
using Sinteg.Mobile.Util;
using Xamarin.Forms;

[assembly: Dependency( typeof( Close_Android ) )]
namespace Sinteg.Mobile.Droid.Util
{
    public class Close_Android : ICloseApplication
    {
        public void Close()
        {
            Process.KillProcess( Process.MyPid() );
        }
    }
}