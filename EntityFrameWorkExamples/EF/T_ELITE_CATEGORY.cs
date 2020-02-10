namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("T_ELITE_CATEGORY")]
    public partial class T_ELITE_CATEGORY
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CATEGORY { get; set; }
    }
}
