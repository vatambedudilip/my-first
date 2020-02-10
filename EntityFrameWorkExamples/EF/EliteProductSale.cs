namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("T_ELITE_PRODUCT_SALE")]
    public partial class EliteProductSale
    {
        public long ID { get; set; }

        [StringLength(255)]
        public string Segment { get; set; }

        [StringLength(255)]
        public string Country { get; set; }

        [StringLength(255)]
        public string Product { get; set; }

        [Column("Discount Band")]
        [StringLength(255)]
        public string Discount_Band { get; set; }

        [Column("Units Sold")]
        public double? Units_Sold { get; set; }

        [Column("Manufacturing Price", TypeName = "money")]
        public decimal? Manufacturing_Price { get; set; }

        [Column("Sale Price", TypeName = "money")]
        public decimal? Sale_Price { get; set; }

        [Column("Gross Sales", TypeName = "money")]
        public decimal? Gross_Sales { get; set; }

        [Column(TypeName = "money")]
        public decimal? Discounts { get; set; }

        [Column(TypeName = "money")]
        public decimal? Sales { get; set; }

        [Column(TypeName = "money")]
        public decimal? COGS { get; set; }

        [Column(TypeName = "money")]
        public decimal? Profit { get; set; }

        public DateTime? Date { get; set; }

        [Column("Month Number")]
        public double? Month_Number { get; set; }

        [Column("Month Name")]
        [StringLength(255)]
        public string Month_Name { get; set; }

        [StringLength(255)]
        public string Year { get; set; }
    }
}
