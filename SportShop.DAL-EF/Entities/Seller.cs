using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShop.DAL_EF.Entities
{
    public class Seller
    {
        [Key]
        [Column(nameof(SellerId), TypeName = "UNIQUEIDENTIFIER")]
        [Required]
        public Guid SellerId { get; set; }

        [Column(nameof(Name), TypeName = "NVARCHAR")]
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }

        [Column(nameof(City), TypeName = "NVARCHAR")]
        [MaxLength(64)]
        [Required]
        public string City { get; set; }

        [Column(nameof(Street), TypeName = "NVARCHAR")]
        [MaxLength(128)]
        [Required]
        public string Street { get; set; }

        [Column(nameof(Number), TypeName = "NVARCHAR")]
        [MaxLength(16)]
        [Required]
        public string Number { get; set; }

        [Column(nameof(ZipCode), TypeName = "NVARCHAR")]
        [MaxLength(8)]
        [Required]
        public string ZipCode { get; set; }

        [Column(nameof(Country), TypeName = "NVARCHAR")]
        [MaxLength(16)]
        [Required]
        public string Country { get; set; }
    }
}
