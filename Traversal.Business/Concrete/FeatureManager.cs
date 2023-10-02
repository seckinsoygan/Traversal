using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            this.featureDal = featureDal;
        }

        public void Add(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetAll()
        {
            return featureDal.GetAll();
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
