using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }

        public void Add(About entity)
        {
            aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            return aboutDal.GetAll();
        }

        public About GetById(int id)
        {
            return aboutDal.Get(id);
        }

        public void Update(About entity)
        {
            aboutDal.Update(entity);
        }
    }
}
