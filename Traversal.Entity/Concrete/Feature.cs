using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class Feature : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
