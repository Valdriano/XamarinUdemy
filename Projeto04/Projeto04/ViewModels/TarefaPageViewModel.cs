using Projeto04.DataAccess;
using Projeto04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.ViewModels
{
    public class TarefaPageViewModel
    {
        public List<Tarefa> Tarefas { get; set; }

        public TarefaPageViewModel()
        {
            TarefaDataAccess dataAccess = new TarefaDataAccess();

            Tarefas = dataAccess.GetList();
        }
    }
}
