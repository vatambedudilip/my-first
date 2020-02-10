namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ELITE_CATEGORY_ITEMS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Column(TypeName = "money")]
        public decimal PRICE { get; set; }

        public int CATEGORY_ID { get; set; }
    }
}
