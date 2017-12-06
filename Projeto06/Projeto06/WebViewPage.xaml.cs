using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto06
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            HtmlWebViewSource html = new HtmlWebViewSource();

            html.BaseUrl = DependencyService.Get<IBaseUrl>().Get();

            this.webView.Source = html;
        }
    }
}