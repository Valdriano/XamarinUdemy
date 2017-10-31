using Sinteg.Mobile.Models;
using Sinteg.Mobile.Service;
using Sinteg.Mobile.Util;
using System;
using Xamarin.Forms;

namespace Sinteg.Mobile.ViewModels
{
    public class UsuarioViewModel : BaseViewModel
    {
        private readonly IUsuarioServiceApi usuarioServiceApi;

        public Usuario Usuario { get; set; }
        public Command LoginCommand { get; }
        public Command SairCommand { get; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public UsuarioViewModel( IUsuarioServiceApi usuarioServiceApi )
        {
            this.usuarioServiceApi = usuarioServiceApi;

            LoginCommand = new Command( ExecuteLogin );
            SairCommand = new Command( ExecuteSair );
        }

        private async void ExecuteLogin()
        {
            try
            {
                if( IsBusy )
                    return;

                if( string.IsNullOrWhiteSpace( Login ) )
                {
                    await DisplayAlert( "Aviso" , "Informe o nome de login:" , "OK" );

                    return;
                }

                if( string.IsNullOrWhiteSpace( Senha ) )
                {
                    await DisplayAlert( "Aviso" , "Informe a senha:" , "OK" );

                    return;
                }

                IsBusy = true;

                Usuario = await usuarioServiceApi.GetUsuario( Login , Senha );

                if( Usuario != null )
                {
                    await PushAsync<MainViewModel>();
                }
                else
                {
                    await DisplayAlert( "Alerta" , "Usuário ou senha incorretos" , "OK" );

                    return;
                }
            }
            catch( Exception ex )
            {

                await DisplayAlert( "Mensagem de Erro" , $"{ex.Message}" , "OK" );
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void ExecuteSair()
        {
            var sair = DisplayAlert( "Sinteg" , "Deseja sair do aplicativo?" , "sim" , "não" );

            DependencyService.Get<ICloseApplication>().Close();
        }
    }
}
