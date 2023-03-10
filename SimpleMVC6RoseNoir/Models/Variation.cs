using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMVC6RoseNoir.Models
{
    public class Variation
    {
        public int VariationId { get; set; }

        public int ProductId { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = String.Empty;

        [StringLength(400)]
        public string Description { get; set; } = String.Empty;

        // Alternative option price if not the same as the main product

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
         public decimal Price { get; set; } = 0;

        [StringLength(30), Required]
        public string Colour { get; set; }= String.Empty;

        // Navigation Property

        public virtual Product Product { get; set; }

    }
}
