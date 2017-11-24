using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnLabel_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new LabelPage() );
        }

        private void btnEntry_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new EntryPage() );
        }

        private void btnButton_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new ButtonPage() );
        }

        private void btnBoxView_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new BoxViewPage() );
        }

        private void btnListView_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new ListViewPage() );
        }

        private void btnActivityIndicator_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new ActivityIndicatorPage() );
        }

        private void btnDateTimePicker_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new DateTimePickerPage() );
        }

        private void btnEditor_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new EditorPage() );
        }

        private void btnPicker_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new PickerPage() );
        }

        private void btnProgressBar_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new ProgressBarPage() );
        }

        private void btnSlider_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new SliderPage() );
        }

        private void btnStepper_Clicked( object sender , EventArgs e )
        {
            Navigation.PushAsync( new StepperPage() );
        }
    }
}
