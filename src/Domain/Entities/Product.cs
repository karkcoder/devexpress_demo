using Domain.Commons;

namespace Domain.Entities
{
    public class Product : AuditEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}