namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ELITE_ORDER
    {
        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string ITEMS { get; set; }

        [Required]
        [StringLength(25)]
        public string STATUS { get; set; }

        [Column(TypeName = "money")]
        public decimal TOTAL_PRICE { get; set; }

        public int CABIN_ID { get; set; }
    }
}
