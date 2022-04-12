using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class UserAddress
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("user_id", Order = 1)]
        [Required]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Column("address_line", Order = 2)]
        [Required]
        public string AddressLine { get; set; }

        [Column("contact", Order = 3)]
        [Required]
        public int Contact { get; set; }

        [Column("user_location_id", Order = 4)]
        [Required]
        public int UserLocationId { get; set; }
        public virtual UserLocation UserLocation { get; set; }

        [Column("created_on_utc", Order = 5)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 6)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 7)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 8)]
        [Required]
        public DateTime ModifiedBy { get; set; }
    }
}
