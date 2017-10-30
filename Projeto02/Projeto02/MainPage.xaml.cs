using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.btnSomar.Clicked += delegate
            {
                decimal a = Convert.ToDecimal( this.txbValor1.Text );
                decimal b = Convert.ToDecimal( this.txbValor2.Text );

                this.lblResultado.Text = $"O resultado é: {Mat.Somar( a , b )}";
            };
        }
    }
}
