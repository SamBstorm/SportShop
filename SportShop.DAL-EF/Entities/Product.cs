using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL_EF.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(nameof(Reference), TypeName="INTEGER")]
        [Required]
        public int Reference { get; set; }
        
        [Column(nameof(ProductName), TypeName="NVARCHAR")]
        [MaxLength(64)]
        [Required]
        public string ProductName { get; set; }
        
        [Column(nameof(ProductDescription), TypeName = "NVARCHAR")]
        [MaxLength(4000)]
        public string ProductDescription { get; set; }
        
        [Column(nameof(PicsUrl), TypeName = "VARCHAR")]
        [MaxLength(256)]
        [Required]
        public string PicsUrl { get; set; }
        
        [Column(nameof(SellerId), TypeName = "UNIQUEIDENTIFIER")]
        [Required]
        public Guid SellerId { get; set; }
        
        [Column(nameof(Price), TypeName = "MONEY")]
        [Required]
        public decimal Price { get; set; }
        
        [Column(nameof(Weigth), TypeName="INTEGER")]
        [Required]
        public int Weigth { get; set; }
        
        [Column(nameof(Volume), TypeName="INTEGER")]
        [Required]
        public int Volume { get; set; }
        
        [Column(nameof(Model), TypeName = "NVARCHAR")]
        [MaxLength(16)]
        [Required]
        public string Model { get; set; }

        [Column(nameof(Color), TypeName = "NVARCHAR")]
        [MaxLength(16)]
        [Required]
        public string Color { get; set; }

        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; }
    }
}
