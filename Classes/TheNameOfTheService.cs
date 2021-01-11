namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.TheNameOfTheService")]
    public partial class TheNameOfTheService
    {
        [Key]
        public long IDTheNameOfTheService { get; set; }

        public long IDRent { get; set; }

        public long IDrepair { get; set; }

        public virtual RentACar RentACar { get; set; }

        public virtual Repair Repair { get; set; }
    }
}
