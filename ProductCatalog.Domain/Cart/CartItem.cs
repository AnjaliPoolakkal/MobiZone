using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Cart
{
    public class CartItem
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("look_up_id", Order = 1)]
        [Required]
        public int LookUpId { get; set; }
        public virtual Products.LookUp LookUp { get; set; }

        [Column("user_id", Order = 2)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User User { get; set; }

        [Column("quantity", Order = 3)]
        [Required]
        public int Quantity { get; set; }

        [Column("created_on_utc", Order = 4)]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 5)]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 7)]
        public DateTime ModifiedBy { get; set; }
    }
}
