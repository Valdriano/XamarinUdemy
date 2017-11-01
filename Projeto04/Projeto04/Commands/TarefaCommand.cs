using Projeto04.Models;
using Projeto04.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms.Xaml;

namespace Projeto04.Commands
{
    [XamlCompilation( XamlCompilationOptions.Compile )]
    public class TarefaCommand : ICommand
    {
        protected TypeCommand typeCommand;
        protected TarefaPageViewModel tarefaPageViewModel;
        public event EventHandler CanExecuteChanged;
        public TarefaCommand( TypeCommand typeCommand )
        {
            this.typeCommand = typeCommand;
        }

        public TarefaCommand( TypeCommand typeCommand , TarefaPageViewModel tarefaPageViewModel )
        {
            this.typeCommand = typeCommand;
            this.tarefaPageViewModel = tarefaPageViewModel;
        }

        public bool CanExecute( object parameter )
        {
            return true;
        }

        public void Execute( object parameter )
        {
            Tarefa tarefa;

            if( parameter != null )
            {
                tarefa = ( Tarefa ) parameter;
            }
            else
            {
                tarefa = new Tarefa();
            }

            switch( typeCommand )
            {
                case TypeCommand.Salva:
                    if( tarefa.Id == 0 )
                    {
                        tarefa.Finalizada = false;
                        this.tarefaPageViewModel.dataAccess.Insert( tarefa );
                    }
                    else
                    {
                        this.tarefaPageViewModel.dataAccess.Update( tarefa );
                    }

                    tarefa = new Tarefa();
                    this.tarefaPageViewModel.CarregaTarefas();
                    this.tarefaPageViewModel.OnPropertyChanged( nameof( tarefa ) );
                    break;


                default:
                    throw new Exception( "Comando inválido..." );

            }
        }
    }
}
