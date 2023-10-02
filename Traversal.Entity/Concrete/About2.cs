using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class About2 : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
