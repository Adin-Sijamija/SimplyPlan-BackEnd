using System.ComponentModel.DataAnnotations;

namespace SimplyPlan.Core.Entities
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
