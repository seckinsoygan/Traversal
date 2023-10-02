using System.ComponentModel.DataAnnotations;

namespace Traversal.Entity.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
