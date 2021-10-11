using System.ComponentModel.DataAnnotations;

namespace Catalog.DTos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}