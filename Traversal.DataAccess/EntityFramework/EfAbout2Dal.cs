using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.DataAccess.UnitOfWorks;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
        public EfAbout2Dal(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
