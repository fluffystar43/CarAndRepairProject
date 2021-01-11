namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.InstalledSpareDetail")]
    public partial class InstalledSpareDetail
    {
        [Key]
        public long IDInstalledSpareDetail { get; set; }

        public int IDclient { get; set; }

        public DateTime Date { get; set; }

        public long IDcar { get; set; }

        public long? IDdetail { get; set; }

        public int Quantity { get; set; }

        public short Warranty { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual Detail Detail { get; set; }
    }
}
