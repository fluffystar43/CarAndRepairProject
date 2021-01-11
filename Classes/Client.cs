namespace Прокат_и_ремонт_автомобилей
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CARDB.Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            BonusSystem = new HashSet<BonusSystem>();
            Booking = new HashSet<Booking>();
            ClientsFine = new HashSet<ClientsFine>();
            CommonFine = new HashSet<CommonFine>();
            Contract = new HashSet<Contract>();
            InstalledSpareDetail = new HashSet<InstalledSpareDetail>();
            RentACar = new HashSet<RentACar>();
        }
        public Client(int idclient, string familyname, string name, string patronymic, string passportdata, string driverlicense, string numberofphone)
        {
            this.IDclient = idclient;
            this.FamilyName = familyname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.PassportData = passportdata;
            this.DriversLicense = driverlicense;
            this.NumberOfPhone = numberofphone;
        }

        [Key]
        public int IDclient { get; set; }

        [Required]
        [StringLength(50)]
        public string FamilyName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(200)]
        public string PassportData { get; set; }

        [Required]
        [StringLength(200)]
        public string DriversLicense { get; set; }

        [StringLength(200)]
        public string NumberOfPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusSystem> BonusSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientsFine> ClientsFine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommonFine> CommonFine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contract> Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstalledSpareDetail> InstalledSpareDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentACar> RentACar { get; set; }
    }
}
