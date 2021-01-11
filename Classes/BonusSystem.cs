namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.BonusSystem")]
    public partial class BonusSystem
    {
        [Key]
        public long IDBonusSystem { get; set; }

        public long IDcontract { get; set; }

        public int IDclient { get; set; }

        [Required]
        [StringLength(100)]
        public string CumulativeSystemOfBonusesAndDiscounts { get; set; }

        [Required]
        [StringLength(200)]
        public string Celebration { get; set; }

        public virtual Client Client { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
