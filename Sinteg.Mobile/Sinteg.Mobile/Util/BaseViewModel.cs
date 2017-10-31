using Sinteg.Mobile.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sinteg.Mobile.Util
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty( ref _title , value ); }
        }

        private bool isBusy;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty( ref isBusy , value ); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChanged?.Invoke( this , new PropertyChangedEventArgs( propertyName ) );
        }

        protected bool SetProperty<T>( ref T storage , T value , [CallerMemberName] string propertyName = null )
        {
            if( EqualityComparer<T>.Default.Equals( storage , value ) )
            {
                return false;
            }

            storage = value;
            OnPropertyChanged( propertyName );
            return true;
        }

        public async Task PushAsync<TViewModel>( params object[] args ) where TViewModel : BaseViewModel
        {
            var viewModelType = typeof( TViewModel );
            var viewModelTypeName = viewModelType.Name;
            var viewModelWordLength = "ViewModel".Length;
            var viewTypeName = $"Sinteg.Mobile.Views.{viewModelTypeName.Substring( 0 , viewModelTypeName.Length - viewModelWordLength )}Page";
            var viewType = Type.GetType( viewTypeName );

            var page = Activator.CreateInstance( viewType ) as Page;

            if( viewModelType.GetTypeInfo().DeclaredConstructors.Any( c => c.GetParameters().Any( p => p.ParameterType == typeof( IUsuarioServiceApi ) ) ) )
            {
                var argsList = args.ToList();
                var ApiService = DependencyService.Get<IUsuarioServiceApi>();
                argsList.Insert( 0 , ApiService );
                args = argsList.ToArray();
            }

            var viewModel = Activator.CreateInstance( viewModelType , args );
            if( page != null )
            {
                page.BindingContext = viewModel;
            }

            if( viewTypeName != "Sinteg.Mobile.Views.MainPage" )
                await Application.Current.MainPage.Navigation.PushAsync( page );
            else
                Application.Current.MainPage = new NavigationPage( page );
        }

        public virtual Task LoadAsync()
        {
            return Task.FromResult( 0 );
        }

        public async Task DisplayAlert( string title , string message , string cancel )
        {
            await Application.Current.MainPage.DisplayAlert( title , message , cancel );
        }

        public async Task DisplayAlert( string title , string message , string accept , string cancel )
        {
            await Application.Current.MainPage.DisplayAlert( title , message , accept , cancel );
        }
    }
}
