using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class About : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public bool Status { get; set; }
    }
}
