using Traversal.Entity.Abstract;

namespace Traversal.DataAccess.Repository
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
