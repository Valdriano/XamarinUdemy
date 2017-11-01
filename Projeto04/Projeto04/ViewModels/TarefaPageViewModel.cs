using Projeto04.Commands;
using Projeto04.DataAccess;
using Projeto04.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto04.ViewModels
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public class TarefaPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Tarefa> Tarefas { get; set; }
        public Tarefa tarefa { get; set; }
        //public ICommand SalvarCommand { get; set; }
        public Command SalvarCommand { get; set; }
        public Command EditarCommand { get; set; }
        public Command ExcluirCommand { get; set; }
        public Command StatusCommand { get; set; }

        public TarefaDataAccess dataAccess { get; private set; }

        public TarefaPageViewModel()
        {
            dataAccess = new TarefaDataAccess();
            tarefa = new Tarefa();
            Tarefas = new ObservableCollection<Tarefa>( dataAccess.GetList() );

            //SalvarCommand = new TarefaCommand( TypeCommand.Salva , this );
            SalvarCommand = new Command( Salvar );
            EditarCommand = new Command<Tarefa>( Editar );
            ExcluirCommand = new Command<Tarefa>( Excluir );
            StatusCommand = new Command<Tarefa>( Status );
        }

        public void CarregaTarefas()
        {
            Tarefas = new ObservableCollection<Tarefa>( dataAccess.GetList() );
            OnPropertyChanged( "Tarefas" );
        }

        private void Salvar()
        {
            if( tarefa.Id == 0 )
            {
                tarefa.Finalizada = false;
                dataAccess.Insert( tarefa );
            }
            else
            {
                dataAccess.Update( tarefa );
            }

            tarefa = new Tarefa();
            CarregaTarefas();
            OnPropertyChanged( "tarefa" );
        }

        private void Editar( Tarefa tarefa )
        {
            this.tarefa = tarefa;
            OnPropertyChanged( "tarefa" );
        }

        private void Excluir( Tarefa tarefa )
        {
            dataAccess.Delete( tarefa );
            CarregaTarefas();
        }

        private void Status( Tarefa tarefa )
        {
            if( tarefa.Finalizada )
            {
                tarefa.Finalizada = false;
            }
            else
            {
                tarefa.Finalizada = true;
            }

            dataAccess.Update( tarefa );
            CarregaTarefas();
            OnPropertyChanged( "tarefa" );
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged( [CallerMemberName] string propertyName = null )
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            handler?.Invoke( this , new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
