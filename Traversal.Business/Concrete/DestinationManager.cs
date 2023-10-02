using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            this.destinationDal = destinationDal;
        }

        public void Add(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public List<Destination> GetAll()
        {
            return destinationDal.GetAll();
        }

        public Destination GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
