using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class LookUp
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }

        [Column("name", Order = 1)]
        public string name { get; set; }

        [Column("description", Order = 2)]
        public string Description { get; set; }

        [Column("parent_id", Order = 3)]
        public LookUpId ParentId { get; set; }

        [Column("created_on_utc", Order = 4)]
        public DateTime CreatedOnUTC { get; set; }

        [Column("modified_on_utc", Order = 5)]
        public DateTime ModifiedOnUTC { get; set; }

        [Column("created_by", Order = 6)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 7)]
        public DateTime ModifiedBy { get; set; }

        public void Add(LookUp lookUp)
        {
            throw new NotImplementedException();
        }
    }
}
