using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class Product
    {
        [Key]
        [Column("id",Order = 0)]
        public int Id { get; set; }

        [Column("name",Order = 1, TypeName = "Varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column("specification_id",Order = 2)]
        [ForeignKey("Specification")]
        public int SpecificationId { get; set; }
        public Specification Specification { get; set; }

        [Column("price",Order = 3)]
        [Required]
        public decimal Price { get; set; }



        [Column("available_stock",Order = 4)]
        [Required]
        public int AvailableStock { get; set; }

        [Column("is_active",Order = 5, TypeName = "Varchar(50)")]
        [Required]
        public string IsActive { get; set; }


        [Column("created_on_utc",Order = 6)]
        [Required]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc",Order = 7)]
        [Required]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("deleted_on_utc", Order = 8)]
        [Required]
        public DateTime DeletedOnUTC { get; set; }

        [Column("created_by",Order = 9)]
        [Required]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by",Order = 10)]
        [Required]
        public DateTime ModifiedBy { get; set; }

        //navigation 
        public virtual ICollection<Image> Images { get; set; }

        public int LookUpId { get; set; }
        public virtual LookUp LookUp { get; set; }
    }
}
