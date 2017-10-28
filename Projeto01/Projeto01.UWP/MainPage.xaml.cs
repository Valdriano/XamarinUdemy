using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Projeto01.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //LoadApplication( new Projeto01.App() );

            this.btnSomar.Click += delegate
            {
                decimal valor1 = Convert.ToDecimal( this.txbValor1.Text );
                decimal valor2 = Convert.ToDecimal( this.txbValor2.Text );

                this.txbResultado.Text = $"O resultado é: {MyClass.Somar(valor1,valor2).ToString("N2")}";
            };
        }
    }
}
