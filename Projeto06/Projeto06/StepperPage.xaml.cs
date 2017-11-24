using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto06
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class StepperPage : ContentPage
    {
        public StepperPage()
        {
            InitializeComponent();
        }

        private void Stepper1_ValueChanged( object sender , ValueChangedEventArgs e )
        {
            this.Label1.Text = Convert.ToString( this.Stepper1.Value );
        }
    }
}