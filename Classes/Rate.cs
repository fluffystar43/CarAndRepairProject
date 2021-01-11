namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Rate")]
    public partial class Rate
    {
        private string description;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rate()
        {
            RentACar = new HashSet<RentACar>();
        }

        [Key]
        public long IDRate { get; set; }

        [Required]
        [StringLength(200)]
        public string Description 
        { 
            get => description;
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Value is null", nameof(value));

                if (value.Length > 200)
                    throw new ArgumentNullException("value.Length > 200", nameof(value));
                     description = value; 
            } 
        }

        public long Cost { get; set; }

        [Required]
        [StringLength(200)]
        public string TypeOfService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentACar> RentACar { get; set; }
    }
}
