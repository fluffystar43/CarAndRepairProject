namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.CommonFine")]
    public partial class CommonFine
    {
        [Key]
        public long IDCommonFine { get; set; }

        public int IDClient { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public long Cost { get; set; }

        public DateTime Date { get; set; }

        [StringLength(200)]
        public string Status { get; set; }

        public virtual Client Client { get; set; }
    }
}
