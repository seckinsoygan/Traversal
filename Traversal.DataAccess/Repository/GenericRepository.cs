using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.UnitOfWorks;
using Traversal.Entity.Abstract;

namespace Traversal.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity, new()
    {
        private readonly Context _context;
        private readonly IUnitOfWork _unitOfWork;

        public GenericRepository(Context context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _unitOfWork.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _unitOfWork.SaveChanges();
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _unitOfWork.SaveChanges();
        }
    }
}
