using System.ComponentModel.DataAnnotations;

namespace SimplyPlan.Core.Entities
{
    public class Project : BaseEntity
    {
        [Key]
        public new int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }


    }
}
