namespace Прокат_и_ремонт_автомобилей
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CarAndRepairDBModel : DbContext
    {
        public CarAndRepairDBModel()
            : base("name=CarAndRepairDBContext")
        {
        }

        public virtual DbSet<BonusSystem> BonusSystem { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientsFine> ClientsFine { get; set; }
        public virtual DbSet<CommonFine> CommonFine { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Detail> Detail { get; set; }
        public virtual DbSet<DoneWork> DoneWork { get; set; }
        public virtual DbSet<InstalledSpareDetail> InstalledSpareDetail { get; set; }
        public virtual DbSet<LocationOfCar> LocationOfCar { get; set; }
        public virtual DbSet<PurchaseOfCar> PurchaseOfCar { get; set; }
        public virtual DbSet<Rate> Rate { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RentACar> RentACar { get; set; }
        public virtual DbSet<Repair> Repair { get; set; }
        public virtual DbSet<ReturnACar> ReturnACar { get; set; }
        public virtual DbSet<SaleOrDeRegistrationOfACar> SaleOrDeRegistrationOfACar { get; set; }
        public virtual DbSet<TheNameOfTheService> TheNameOfTheService { get; set; }
        public virtual DbSet<Transportation> Transportation { get; set; }
        public virtual DbSet<WorkingPersonnel> WorkingPersonnel { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasMany(e => e.ClientsFine)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.InstalledSpareDetail)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.PurchaseOfCar)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.RentACar)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Repair)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.ReturnACar)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.SaleOrDeRegistrationOfACar)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Car>()
                .HasMany(e => e.Transportation)
                .WithRequired(e => e.Car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.BonusSystem)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Booking)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ClientsFine)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.CommonFine)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Contract)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.InstalledSpareDetail)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.RentACar)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.BonusSystem)
                .WithRequired(e => e.Contract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rate>()
                .HasMany(e => e.RentACar)
                .WithRequired(e => e.Rate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Registration>()
                .HasMany(e => e.Contract)
                .WithRequired(e => e.Registration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RentACar>()
                .HasMany(e => e.TheNameOfTheService)
                .WithRequired(e => e.RentACar)
                .HasForeignKey(e => e.IDRent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Repair>()
                .HasMany(e => e.TheNameOfTheService)
                .WithRequired(e => e.Repair)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkingPersonnel>()
                .HasMany(e => e.DoneWork)
                .WithRequired(e => e.WorkingPersonnel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WorkingPersonnel>()
                .HasMany(e => e.Repair)
                .WithRequired(e => e.WorkingPersonnel)
                .WillCascadeOnDelete(false);
        }
    }
}
