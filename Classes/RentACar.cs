namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.RentACar")]
    public partial class RentACar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentACar()
        {
            TheNameOfTheService = new HashSet<TheNameOfTheService>();
        }

        [Key]
        public long IDRentACar { get; set; }

        public long IDcar { get; set; }

        public int IDclient { get; set; }

        public long IDrate { get; set; }

        public DateTime DateOfIssue { get; set; }

        public long InitialMileage { get; set; }

        [Required]
        [StringLength(200)]
        public string Condition { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual Rate Rate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheNameOfTheService> TheNameOfTheService { get; set; }
    }
}
