using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Order
{
    public class CatalogOrder
    {
        [Key]
        [Column("id", Order = 0)]
        [Required]
        public int Id { get; set; }

        [Column("product_id", Order = 1)]
        [Required]
        public int product_id { get; set; }
        public virtual Products.Product Product { get; set; }

        [Column("look_up_id", Order = 2)]
        [Required]
        public int LookUpId { get; set; }
        public virtual Products.LookUp LookUp { get; set; }

        [Column("quantity", Order = 3)]
        [Required]
        public int Quantity { get; set; }

        [Column("price", Order = 4)]
        [Required]
        public decimal Price { get; set; }

        [Column("order_details_id", Order = 5)]
        public int OrderDetailsId { get; set; }
        public virtual OrderDetails OrderDetails { get; set; }

        [Column("created_on_utc", Order = 6)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 7)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 8)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 9)]
        [Required]
        public DateTime ModifiedBy { get; set; }

        

        
    }
}
