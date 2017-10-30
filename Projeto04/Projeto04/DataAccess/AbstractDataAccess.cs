using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace Projeto04.DataAccess
{
    public abstract class AbstractDataAccess<T> : IDataAccess<T> where T : class
    {
        protected SQLiteConnection database;
        public AbstractDataAccess()
        {
            database = DependencyService.Get<IDatabase>().GetConnection();

            database.CreateTable<T>();
        }

        public virtual int Delete( T table )
        {
            throw new NotImplementedException();
        }

        public virtual T Get( object id )
        {
            throw new NotImplementedException();
        }

        public virtual List<T> GetList()
        {
            throw new NotImplementedException();
        }

        public virtual int Insert( T table )
        {
            throw new NotImplementedException();
        }

        public virtual int Update( T table )
        {
            throw new NotImplementedException();
        }
    }
}
