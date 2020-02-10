namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ELITE_DINING_CABIN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string ASSIGNED_WAITER { get; set; }

        public int SEATING_CAPACITY { get; set; }
    }
}
