namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ELITE_CATEGORY_CUSTOMERS
    {
        public int ID { get; set; }

        public int CUSTOMER_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string FNAME { get; set; }

        [Required]
        [StringLength(100)]
        public string LNAME { get; set; }
    }
}
