namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Transportation")]
    public partial class Transportation
    {
        [Key]
        public long IDTransportation { get; set; }

        public long IDcar { get; set; }

        public long Distance { get; set; }

        public DateTime Registration { get; set; }

        [Required]
        [StringLength(1)]
        public string Address { get; set; }

        public long Duration { get; set; }

        public int Cost { get; set; }

        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        public virtual Car Car { get; set; }
    }
}
