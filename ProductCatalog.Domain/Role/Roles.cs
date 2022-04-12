using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Role
{
    public class Roles
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("roles", Order = 1)]
        [Required]
        public string UserRole { get; set; }

        [Column("user_id", Order = 2)]
        [Required]
        public int UserId { get; set; }
        public virtual Customers.User User { get; set; }

        [Column("created_at_utc", Order = 3)]
        public DateTime CreatedAtUTC { get; set; }

        [Column("modified_at_utc", Order = 4)]
        public DateTime ModifiedAtUTC { get; set; }

        [Column("created_by", Order = 5)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 6)]
        public DateTime ModifiedBy { get; set; }



       
        
    }
}
