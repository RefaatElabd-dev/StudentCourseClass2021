using System.Collections.Generic;

namespace Core.Repo
{
    public interface IRepository<T, I>
    {
        public T insert(T entity);
        public ICollection<T> GetAll();

        public T GetById(I ID);

        public T Update(T entity);

        public bool Delete(T entity);
    }
}
