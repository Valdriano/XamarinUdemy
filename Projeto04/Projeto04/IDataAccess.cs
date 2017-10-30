using System.Collections.Generic;

namespace Projeto04
{
    public interface IDataAccess<T>
    {
        T Get( object id );
        List<T> GetList();
        int Insert( T table );
        int Update( T table );
        int Delete( T table );
    }
}
