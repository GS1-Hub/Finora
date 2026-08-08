using System.ComponentModel.DataAnnotations;

namespace Finora.Models
{
    public class Fin
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }

    }
}
