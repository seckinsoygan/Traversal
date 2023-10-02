using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class SubAbout : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
