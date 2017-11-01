using Projeto04.DataAccess;
using Projeto04.Models;
using Projeto04.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto04.Views
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public partial class TarefaPage : ContentPage
    {
        protected Tarefa tarefa;
        TarefaDataAccess dataAccess = new TarefaDataAccess();
        public TarefaPage()
        {
            InitializeComponent();

            BindingContext = new TarefaPageViewModel();

            //this.btnSalvar.Clicked += BtnSalvar_Clicked;
        }

        //private void BtnSalvar_Clicked( object sender , EventArgs e )
        //{
        //    if( this.tarefa == null )
        //    {
        //        Tarefa tarefa = new Tarefa();
        //        tarefa.Nome = this.txbNome.Text;
        //        tarefa.Finalizada = false;

        //        dataAccess.Insert( tarefa );
        //    }
        //    else
        //    {
        //        this.tarefa.Nome = this.txbNome.Text;

        //        dataAccess.Update( this.tarefa );
        //    }

        //    this.txbNome.Text = string.Empty;
        //    this.tarefa = null;

        //    this.listViewTarefa.ItemsSource = null;
        //    this.listViewTarefa.ItemsSource = dataAccess.GetList();
        //}

        //private void MenuItem_Excluir( object sender , EventArgs e )
        //{
        //    Tarefa tarefa = ( ( MenuItem ) sender ).CommandParameter as Tarefa;

        //    dataAccess.Delete( tarefa );

        //    BindingContext = new TarefaPageViewModel();
        //}

        //private void MenuItem_Editar( object sender , EventArgs e )
        //{
        //    Tarefa tarefa = ( ( MenuItem ) sender ).CommandParameter as Tarefa;

        //    this.tarefa = tarefa;

        //    this.txbNome.Text = this.tarefa.Nome;
        //}

        //private void BtnFinalizar_Status( object sender , EventArgs e )
        //{
        //    Tarefa tarefa = ( ( Button ) sender ).CommandParameter as Tarefa;

        //    if( tarefa.Finalizada )
        //    {
        //        tarefa.Finalizada = false;
        //    }
        //    else
        //    {
        //        tarefa.Finalizada = true;
        //    }

        //    dataAccess.Update( tarefa );

        //    this.BindingContext = new TarefaPageViewModel();
        //}
    }
}