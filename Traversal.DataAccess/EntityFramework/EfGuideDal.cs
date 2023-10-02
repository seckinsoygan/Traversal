using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.DataAccess.UnitOfWorks;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public EfGuideDal(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
