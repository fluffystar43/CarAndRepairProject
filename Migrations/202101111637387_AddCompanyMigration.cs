namespace Прокат_и_ремонт_автомобилей.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CARDB.BonusSystem",
                c => new
                    {
                        IDBonusSystem = c.Long(nullable: false, identity: true),
                        IDcontract = c.Long(nullable: false),
                        IDclient = c.Int(nullable: false),
                        CumulativeSystemOfBonusesAndDiscounts = c.String(nullable: false, maxLength: 100),
                        Celebration = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDBonusSystem)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .ForeignKey("CARDB.Contract", t => t.IDcontract)
                .Index(t => t.IDcontract)
                .Index(t => t.IDclient);
            
            CreateTable(
                "CARDB.Client",
                c => new
                    {
                        IDclient = c.Int(nullable: false, identity: true),
                        FamilyName = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Patronymic = c.String(nullable: false, maxLength: 50),
                        PassportData = c.String(nullable: false, maxLength: 200),
                        DriversLicense = c.String(nullable: false, maxLength: 200),
                        NumberOfPhone = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.IDclient);
            
            CreateTable(
                "CARDB.Booking",
                c => new
                    {
                        IDBooking = c.Int(nullable: false, identity: true),
                        IDclient = c.Int(nullable: false),
                        TypeOfService = c.String(nullable: false, maxLength: 30),
                        Period = c.String(nullable: false, maxLength: 30),
                        Source = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.IDBooking)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .Index(t => t.IDclient);
            
            CreateTable(
                "CARDB.ClientsFine",
                c => new
                    {
                        IDClientFine = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        IDclient = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                        Cost = c.Long(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.IDClientFine)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .Index(t => t.IDcar)
                .Index(t => t.IDclient);
            
            CreateTable(
                "CARDB.Car",
                c => new
                    {
                        IDcar = c.Long(nullable: false, identity: true),
                        VINnumber = c.String(nullable: false, maxLength: 200),
                        Brand = c.String(nullable: false, maxLength: 200),
                        Class = c.String(nullable: false, maxLength: 100),
                        Transmission = c.String(nullable: false, maxLength: 100),
                        Mileage = c.Long(nullable: false),
                        YearOfManufacture = c.Short(nullable: false),
                        Cost = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.IDcar);
            
            CreateTable(
                "CARDB.Contract",
                c => new
                    {
                        IDContract = c.Long(nullable: false, identity: true),
                        IDregistration = c.Int(nullable: false),
                        IDcar = c.Long(),
                        IDclient = c.Int(nullable: false),
                        DateOfConclusion = c.DateTime(nullable: false),
                        DateOfCompletion = c.DateTime(nullable: false),
                        Profit = c.Long(nullable: false),
                        NumberofServices = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.IDContract)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .ForeignKey("CARDB.Registration", t => t.IDregistration)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .Index(t => t.IDregistration)
                .Index(t => t.IDcar)
                .Index(t => t.IDclient);
            
            CreateTable(
                "CARDB.Registration",
                c => new
                    {
                        IDRegistration = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        FamilyName = c.String(nullable: false, maxLength: 30),
                        Name = c.String(nullable: false, maxLength: 30),
                        Patronymic = c.String(maxLength: 50),
                        SeriesAndNumber = c.String(nullable: false, maxLength: 15),
                        DriverLicense = c.String(nullable: false, maxLength: 20),
                        NumberOfPhone = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.IDRegistration);
            
            CreateTable(
                "CARDB.InstalledSpareDetail",
                c => new
                    {
                        IDInstalledSpareDetail = c.Long(nullable: false, identity: true),
                        IDclient = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        IDcar = c.Long(nullable: false),
                        IDdetail = c.Long(),
                        Quantity = c.Int(nullable: false),
                        Warranty = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.IDInstalledSpareDetail)
                .ForeignKey("CARDB.Detail", t => t.IDdetail)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .Index(t => t.IDclient)
                .Index(t => t.IDcar)
                .Index(t => t.IDdetail);
            
            CreateTable(
                "CARDB.Detail",
                c => new
                    {
                        IDdetail = c.Long(nullable: false, identity: true),
                        BrandOfCar = c.String(nullable: false, maxLength: 100),
                        Cost = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDdetail);
            
            CreateTable(
                "CARDB.PurchaseOfCar",
                c => new
                    {
                        IDPurchaseOfCar = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        Cost = c.Long(),
                        NewORWithMileage = c.String(nullable: false, maxLength: 100),
                        Registration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDPurchaseOfCar)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .Index(t => t.IDcar);
            
            CreateTable(
                "CARDB.RentACar",
                c => new
                    {
                        IDRentACar = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        IDclient = c.Int(nullable: false),
                        IDrate = c.Long(nullable: false),
                        DateOfIssue = c.DateTime(nullable: false),
                        InitialMileage = c.Long(nullable: false),
                        Condition = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDRentACar)
                .ForeignKey("CARDB.Rate", t => t.IDrate)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .ForeignKey("CARDB.Client", t => t.IDclient)
                .Index(t => t.IDcar)
                .Index(t => t.IDclient)
                .Index(t => t.IDrate);
            
            CreateTable(
                "CARDB.Rate",
                c => new
                    {
                        IDRate = c.Long(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 200),
                        Cost = c.Long(nullable: false),
                        TypeOfService = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDRate);
            
            CreateTable(
                "CARDB.TheNameOfTheService",
                c => new
                    {
                        IDTheNameOfTheService = c.Long(nullable: false, identity: true),
                        IDRent = c.Long(nullable: false),
                        IDrepair = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.IDTheNameOfTheService)
                .ForeignKey("CARDB.Repair", t => t.IDrepair)
                .ForeignKey("CARDB.RentACar", t => t.IDRent)
                .Index(t => t.IDRent)
                .Index(t => t.IDrepair);
            
            CreateTable(
                "CARDB.Repair",
                c => new
                    {
                        IDrepair = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        IDworker = c.Long(nullable: false),
                        Cost = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDrepair)
                .ForeignKey("CARDB.WorkingPersonnel", t => t.IDworker)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .Index(t => t.IDcar)
                .Index(t => t.IDworker);
            
            CreateTable(
                "CARDB.WorkingPersonnel",
                c => new
                    {
                        IDworker = c.Long(nullable: false, identity: true),
                        FamilyName = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false, maxLength: 200),
                        Patronymic = c.String(nullable: false, maxLength: 200),
                        Specialization = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDworker);
            
            CreateTable(
                "CARDB.DoneWork",
                c => new
                    {
                        IDDoneWork = c.Long(nullable: false, identity: true),
                        IDworker = c.Long(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Duration = c.Long(nullable: false),
                        Warranty = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.IDDoneWork)
                .ForeignKey("CARDB.WorkingPersonnel", t => t.IDworker)
                .Index(t => t.IDworker);
            
            CreateTable(
                "CARDB.ReturnACar",
                c => new
                    {
                        IDReturnACar = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        InspectionORCondition = c.String(nullable: false, maxLength: 1),
                        FinalMileage = c.Long(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IDReturnACar)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .Index(t => t.IDcar);
            
            CreateTable(
                "CARDB.SaleOrDeRegistrationOfACar",
                c => new
                    {
                        IDSaleOrDeRegistrationOfACar = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        Cost = c.Int(nullable: false),
                        WorkingLife = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDSaleOrDeRegistrationOfACar)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .Index(t => t.IDcar);
            
            CreateTable(
                "CARDB.Transportation",
                c => new
                    {
                        IDTransportation = c.Long(nullable: false, identity: true),
                        IDcar = c.Long(nullable: false),
                        Distance = c.Long(nullable: false),
                        Registration = c.DateTime(nullable: false),
                        Address = c.String(nullable: false, maxLength: 1),
                        Duration = c.Long(nullable: false),
                        Cost = c.Int(nullable: false),
                        Type = c.String(nullable: false, maxLength: 1),
                    })
                .PrimaryKey(t => t.IDTransportation)
                .ForeignKey("CARDB.Car", t => t.IDcar)
                .Index(t => t.IDcar);
            
            CreateTable(
                "CARDB.CommonFine",
                c => new
                    {
                        IDCommonFine = c.Long(nullable: false, identity: true),
                        IDClient = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 200),
                        Cost = c.Long(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.IDCommonFine)
                .ForeignKey("CARDB.Client", t => t.IDClient)
                .Index(t => t.IDClient);
            
            CreateTable(
                "CARDB.LocationOfCar",
                c => new
                    {
                        IDLocationOfCar = c.Long(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 200),
                        Terrain = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.IDLocationOfCar);
            
        }
        
        public override void Down()
        {
            DropForeignKey("CARDB.RentACar", "IDclient", "CARDB.Client");
            DropForeignKey("CARDB.InstalledSpareDetail", "IDclient", "CARDB.Client");
            DropForeignKey("CARDB.Contract", "IDclient", "CARDB.Client");
            DropForeignKey("CARDB.CommonFine", "IDClient", "CARDB.Client");
            DropForeignKey("CARDB.ClientsFine", "IDclient", "CARDB.Client");
            DropForeignKey("CARDB.Transportation", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.SaleOrDeRegistrationOfACar", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.ReturnACar", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.Repair", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.RentACar", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.TheNameOfTheService", "IDRent", "CARDB.RentACar");
            DropForeignKey("CARDB.Repair", "IDworker", "CARDB.WorkingPersonnel");
            DropForeignKey("CARDB.DoneWork", "IDworker", "CARDB.WorkingPersonnel");
            DropForeignKey("CARDB.TheNameOfTheService", "IDrepair", "CARDB.Repair");
            DropForeignKey("CARDB.RentACar", "IDrate", "CARDB.Rate");
            DropForeignKey("CARDB.PurchaseOfCar", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.InstalledSpareDetail", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.InstalledSpareDetail", "IDdetail", "CARDB.Detail");
            DropForeignKey("CARDB.Contract", "IDregistration", "CARDB.Registration");
            DropForeignKey("CARDB.Contract", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.BonusSystem", "IDcontract", "CARDB.Contract");
            DropForeignKey("CARDB.ClientsFine", "IDcar", "CARDB.Car");
            DropForeignKey("CARDB.Booking", "IDclient", "CARDB.Client");
            DropForeignKey("CARDB.BonusSystem", "IDclient", "CARDB.Client");
            DropIndex("CARDB.CommonFine", new[] { "IDClient" });
            DropIndex("CARDB.Transportation", new[] { "IDcar" });
            DropIndex("CARDB.SaleOrDeRegistrationOfACar", new[] { "IDcar" });
            DropIndex("CARDB.ReturnACar", new[] { "IDcar" });
            DropIndex("CARDB.DoneWork", new[] { "IDworker" });
            DropIndex("CARDB.Repair", new[] { "IDworker" });
            DropIndex("CARDB.Repair", new[] { "IDcar" });
            DropIndex("CARDB.TheNameOfTheService", new[] { "IDrepair" });
            DropIndex("CARDB.TheNameOfTheService", new[] { "IDRent" });
            DropIndex("CARDB.RentACar", new[] { "IDrate" });
            DropIndex("CARDB.RentACar", new[] { "IDclient" });
            DropIndex("CARDB.RentACar", new[] { "IDcar" });
            DropIndex("CARDB.PurchaseOfCar", new[] { "IDcar" });
            DropIndex("CARDB.InstalledSpareDetail", new[] { "IDdetail" });
            DropIndex("CARDB.InstalledSpareDetail", new[] { "IDcar" });
            DropIndex("CARDB.InstalledSpareDetail", new[] { "IDclient" });
            DropIndex("CARDB.Contract", new[] { "IDclient" });
            DropIndex("CARDB.Contract", new[] { "IDcar" });
            DropIndex("CARDB.Contract", new[] { "IDregistration" });
            DropIndex("CARDB.ClientsFine", new[] { "IDclient" });
            DropIndex("CARDB.ClientsFine", new[] { "IDcar" });
            DropIndex("CARDB.Booking", new[] { "IDclient" });
            DropIndex("CARDB.BonusSystem", new[] { "IDclient" });
            DropIndex("CARDB.BonusSystem", new[] { "IDcontract" });
            DropTable("CARDB.LocationOfCar");
            DropTable("CARDB.CommonFine");
            DropTable("CARDB.Transportation");
            DropTable("CARDB.SaleOrDeRegistrationOfACar");
            DropTable("CARDB.ReturnACar");
            DropTable("CARDB.DoneWork");
            DropTable("CARDB.WorkingPersonnel");
            DropTable("CARDB.Repair");
            DropTable("CARDB.TheNameOfTheService");
            DropTable("CARDB.Rate");
            DropTable("CARDB.RentACar");
            DropTable("CARDB.PurchaseOfCar");
            DropTable("CARDB.Detail");
            DropTable("CARDB.InstalledSpareDetail");
            DropTable("CARDB.Registration");
            DropTable("CARDB.Contract");
            DropTable("CARDB.Car");
            DropTable("CARDB.ClientsFine");
            DropTable("CARDB.Booking");
            DropTable("CARDB.Client");
            DropTable("CARDB.BonusSystem");
        }
    }
}
