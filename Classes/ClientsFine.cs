namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.ClientsFine")]
    public partial class ClientsFine
    {
        [Key]
        public long IDClientFine { get; set; }

        public long IDcar { get; set; }

        public int IDclient { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public long Cost { get; set; }

        public DateTime Date { get; set; }

        [StringLength(200)]
        public string Status { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }
    }
}
