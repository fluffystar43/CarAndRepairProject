namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.ReturnACar")]
    public partial class ReturnACar
    {
        [Key]
        public long IDReturnACar { get; set; }

        public long IDcar { get; set; }

        [Required]
        [StringLength(1)]
        public string InspectionORCondition { get; set; }

        public long FinalMileage { get; set; }

        public DateTime ReturnDate { get; set; }

        public virtual Car Car { get; set; }
    }
}
