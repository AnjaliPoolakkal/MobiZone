using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Customers
{
    public class User
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("user_name", Order = 1)]
        [Required]
        public string UserName { get; set; }

        [Column("password", Order = 2)]
        [Required]
        public string Password { get; set; }

        [Column("first_name", Order = 3, TypeName = "Varchar(50)")]
        [Required]
        public string FirstName { get; set; }

        [Column("last_name", Order = 4, TypeName = "Varchar(50)")]
        [Required]
        public string LastName { get; set; }

        [Column("email", Order = 5, TypeName = "Varchar(100)")]
        [Required]
        public string Email { get; set; }

        [Column("contact", Order = 6, TypeName = "bigInt")]
        [Required]
        public long Contact { get; set; }

        [Column("created_on_utc", Order = 7)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 8)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 9)]
        [Required]
        public string CreatedBy { get; set; }

        [Column("modified_by", Order = 10)]
        [Required]
        public string ModifiedBy { get; set; }

        //navigatation 
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<Cart.CartItem> CartItems { get; set; }
        public virtual ICollection<Order.OrderDetails> OrderDetails { get; set; }
    }
}
