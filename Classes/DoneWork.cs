namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.DoneWork")]
    public partial class DoneWork
    {
        [Key]
        public long IDDoneWork { get; set; }

        public long IDworker { get; set; }

        public DateTime Date { get; set; }

        public long Duration { get; set; }

        public short Warranty { get; set; }

        public virtual WorkingPersonnel WorkingPersonnel { get; set; }
    }
}
