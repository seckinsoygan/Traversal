using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.DataAccess.UnitOfWorks;
using Traversal.Entity.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(Context context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
