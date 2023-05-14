using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Core.Models
{
    /// <summary>
    /// product view model
    /// </summary>
    public class ProductDto
    {
        public Guid Id { get; set; }
    
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        [Range(typeof(decimal), "0.1", "1000", ConvertValueInInvariantCulture = true)]    
        public decimal Price { get; set; }

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
