namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ELITE_CATEGORY_CUSTOMER_ORDERS
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORDER_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string ORDER_NAME { get; set; }
    }
}
