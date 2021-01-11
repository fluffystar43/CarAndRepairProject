namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Booking")]
    public partial class Booking
    {
        [Key]
        public int IDBooking { get; set; }

        public int IDclient { get; set; }

        [Required]
        [StringLength(30)]
        public string TypeOfService { get; set; }

        [Required]
        [StringLength(30)]
        public string Period { get; set; }

        [Required]
        [StringLength(30)]
        public string Source { get; set; }

        public virtual Client Client { get; set; }
    }
}
