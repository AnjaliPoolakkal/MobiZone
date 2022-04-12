using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Products
{
    public class Specification
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }

        [Column("version", Order = 1, TypeName = "Varchar(50)")]
        public string Version { get; set; }

        [Column("os_supported", Order = 2, TypeName = "Varchar(100)")]
        public string OsSupported { get; set; }

        [Column("system_requirement", Order = 3, TypeName = "Varchar(100)")]
        public string SystemRequirement { get; set; }

        [Column("sim_type", Order = 4, TypeName = "Varchar(100)")]
        public string SimType { get; set; }

        [Column("hybrid_slot", Order = 5, TypeName = "Varchar(100)")]
        public string HybridSlot { get; set; }

        [Column("display_size", Order = 6, TypeName = "Varchar(100)")]
        public string DisplaySize { get; set; }

        [Column("resolution", Order = 7, TypeName = "Varchar(100)")]
        public string Resolution { get; set; }

        [Column("resolution_type", Order = 8, TypeName = "Varchar(100)")]
        public string ResolutionType { get; set; }

        [Column("display_type", Order = 9, TypeName = "Varchar(100)")]
        public string DisplayType { get; set; }

        [Column("other_features", Order = 10, TypeName = "Varchar(500)")]
        public string OtherFeatures { get; set; }

        [Column("created_at_ust", Order = 11)]
        public DateTime CreatedAtUST { get; set; }

        [Column("modified_at_ust", Order = 12)]
        public DateTime ModifiedAtUST { get; set; }

        [Column("created_by", Order = 13)]
        public DateTime CreatedBy { get; set; }

        [Column("modified_by", Order = 14)]
        public DateTime ModifiedBy { get; set; }

    }
}
