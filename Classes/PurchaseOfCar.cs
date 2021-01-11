namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.PurchaseOfCar")]
    public partial class PurchaseOfCar
    {
        [Key]
        public long IDPurchaseOfCar { get; set; }

        public long IDcar { get; set; }

        public long? Cost { get; set; }

        [Required]
        [StringLength(100)]
        public string NewORWithMileage { get; set; }

        public DateTime Registration { get; set; }

        public virtual Car Car { get; set; }
    }
}
