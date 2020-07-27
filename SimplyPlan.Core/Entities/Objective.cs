using System.ComponentModel.DataAnnotations;

namespace SimplyPlan.Core.Entities
{
    public class Objective
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
