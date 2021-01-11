namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Repair")]
    public partial class Repair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Repair()
        {
            TheNameOfTheService = new HashSet<TheNameOfTheService>();
        }

        [Key]
        public long IDrepair { get; set; }

        public long IDcar { get; set; }

        public long IDworker { get; set; }

        public int Cost { get; set; }

        public virtual Car Car { get; set; }

        public virtual WorkingPersonnel WorkingPersonnel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheNameOfTheService> TheNameOfTheService { get; set; }
    }
}
