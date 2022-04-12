using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserLocation
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("city", Order = 1)]
        [Required]
        public string City { get; set; }

        [Column("postal_code", Order = 2)]
        [Required]
        public string PostalCode { get; set; }

        [Column("country", Order = 3)]
        [Required]
        public string Country { get; set; }

        [Column("created_on_utc", Order = 4)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 5)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 6)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 7)]
        [Required]
        public DateTime ModifiedBy { get; set; }
    }
}
