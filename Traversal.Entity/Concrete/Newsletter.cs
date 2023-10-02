using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class Newsletter : BaseEntity, IEntity
    {
        public string Mail { get; set; }
    }
}
