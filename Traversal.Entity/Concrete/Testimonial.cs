using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class Testimonial : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
