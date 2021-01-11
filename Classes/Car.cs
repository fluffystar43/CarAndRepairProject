namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARDB.Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            ClientsFine = new HashSet<ClientsFine>();
            Contract = new HashSet<Contract>();
            InstalledSpareDetail = new HashSet<InstalledSpareDetail>();
            PurchaseOfCar = new HashSet<PurchaseOfCar>();
            RentACar = new HashSet<RentACar>();
            Repair = new HashSet<Repair>();
            ReturnACar = new HashSet<ReturnACar>();
            SaleOrDeRegistrationOfACar = new HashSet<SaleOrDeRegistrationOfACar>();
            Transportation = new HashSet<Transportation>();
        }       

        [Key]
        public long IDcar { get; set; }

        [Required]
        [StringLength(200)]
        public string VINnumber { get; set; }

        [Required]
        [StringLength(200)]
        public string Brand { get; set; }

        [Required]
        [StringLength(100)]
        public string Class { get; set; }

        [Required]
        [StringLength(100)]
        public string Transmission { get; set; }

        public long Mileage { get; set; }

        public short YearOfManufacture { get; set; }

        public long Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientsFine> ClientsFine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstalledSpareDetail> InstalledSpareDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseOfCar> PurchaseOfCar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentACar> RentACar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Repair> Repair { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnACar> ReturnACar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SaleOrDeRegistrationOfACar> SaleOrDeRegistrationOfACar { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transportation> Transportation { get; set; }
    }
}
