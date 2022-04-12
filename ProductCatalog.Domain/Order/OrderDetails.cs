using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class OrderDetails
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("user_id", Order = 1)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User Users { get; set; }

        [Column("totalamount", Order = 2)]
        [Required]
        public int Total { get; set; }

        [Column("payment_id", Order = 3)]
        [Required]
        public int paymentID { get; set; }
        public virtual PaymentDetails PaymentDetails { get; set; }

        [Column("created_at_utc", Order = 4)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("modified_at_utc", Order = 5)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("created_by", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 7)]
        public DateTime ModifiedBy { get; set; }

        
      

        
    }
}
