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
        TarefaDataAccess dataAccess = new TarefaDataAccess();
        public TarefaPage()
        {
            InitializeComponent();

            BindingContext = new TarefaPageViewModel();

            this.btnAdd.Clicked += BtnAdd_Clicked;
        }

        private void BtnAdd_Clicked( object sender , EventArgs e )
        {
            Tarefa tarefa = new Tarefa();

            tarefa.Nome = this.txbNome.Text;
            tarefa.Finalizada = false;

            dataAccess.Insert( tarefa );

            this.txbNome.Text = string.Empty;

            this.listViewTarefa.ItemsSource = null;

            this.listViewTarefa.ItemsSource = dataAccess.GetList();
        }

        private void MenuItem_Excluir( object sender , EventArgs e )
        {
            Tarefa tarefa = ( ( MenuItem ) sender ).CommandParameter as Tarefa;

            dataAccess.Delete( tarefa );

            BindingContext = new TarefaPageViewModel();
        }
    }
}