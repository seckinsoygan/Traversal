using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context context;

        public UnitOfWork(Context context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
