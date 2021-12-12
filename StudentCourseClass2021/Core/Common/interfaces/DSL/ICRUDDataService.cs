using System.Collections.Generic;

namespace Core.Common.interfaces.DSL
{
    public interface ICRUDDataService<T, I>
    {
        public T insert(T entity);
        public ICollection<T> GetAll();

        public T GetById(I ID);

        public T Update(T entity);

        public bool Delete(T entity);
    }
}