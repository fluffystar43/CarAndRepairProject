namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Contract")]
    public partial class Contract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contract()
        {
            BonusSystem = new HashSet<BonusSystem>();
        }

        [Key]
        public long IDContract { get; set; }

        public int IDregistration { get; set; }

        public long? IDcar { get; set; }

        public int IDclient { get; set; }

        public DateTime DateOfConclusion { get; set; }

        public DateTime DateOfCompletion { get; set; }

        public long Profit { get; set; }

        public long NumberofServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusSystem> BonusSystem { get; set; }

        public virtual Car Car { get; set; }

        public virtual Client Client { get; set; }

        public virtual Registration Registration { get; set; }
    }
}
