using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleMVC6RoseNoir.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required, StringLength(60)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; } = 0;

        // Navigation Property

        public virtual ICollection<Variation> Variations { get; set; }
    }
}
