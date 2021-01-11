namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Detail")]
    public partial class Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Detail()
        {
            InstalledSpareDetail = new HashSet<InstalledSpareDetail>();
        }

        [Key]
        public long IDdetail { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandOfCar { get; set; }

        public int Cost { get; set; }

        public int Quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstalledSpareDetail> InstalledSpareDetail { get; set; }
    }
}
