namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.SaleOrDeRegistrationOfACar")]
    public partial class SaleOrDeRegistrationOfACar
    {
        [Key]
        public long IDSaleOrDeRegistrationOfACar { get; set; }

        public long IDcar { get; set; }

        public int Cost { get; set; }

        public int WorkingLife { get; set; }

        public virtual Car Car { get; set; }
    }
}
