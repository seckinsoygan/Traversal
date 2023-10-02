using Traversal.Entity.Abstract;

namespace Traversal.Entity.Concrete
{
    public class Guide : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string SocialMedia1 { get; set; }
        public string SocialMedia2 { get; set; }
        public bool Status { get; set; }
    }
}
