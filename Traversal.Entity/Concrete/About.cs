using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class About : BaseEntity, IEntity
    {
        public string Details { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
