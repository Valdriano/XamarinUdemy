using Projeto04.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto04.DataAccess
{
    public class TarefaDataAccess : AbstractDataAccess<Tarefa>
    {
        public override Tarefa Get( object id )
        {
            return database.Table<Tarefa>().FirstOrDefault( f => f.Id == Convert.ToInt32( id ) );
        }

        public override List<Tarefa> GetList()
        {
            return database.Table<Tarefa>().ToList();
        }

        public override int Insert( Tarefa table )
        {
            return database.Insert( table );
        }

        public override int Update( Tarefa table )
        {
            return database.Update( table );
        }

        public override int Delete( Tarefa table )
        {
            return database.Delete( table );
        }
    }
}
