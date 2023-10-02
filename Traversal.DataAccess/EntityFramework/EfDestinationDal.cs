using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.DataAccess.UnitOfWorks;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        public EfDestinationDal(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
