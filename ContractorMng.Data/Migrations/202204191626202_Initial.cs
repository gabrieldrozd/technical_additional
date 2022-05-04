namespace ContractorMng.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false, maxLength: 50),
                        Street = c.String(nullable: false, maxLength: 50),
                        BuildingNo = c.String(nullable: false, maxLength: 10),
                        FlatNo = c.String(maxLength: 10),
                        PostalCode = c.String(nullable: false, maxLength: 6),
                        Post = c.String(maxLength: 50),
                        Community = c.String(maxLength: 50),
                        District = c.String(maxLength: 50),
                        Province = c.String(maxLength: 50),
                        Country = c.String(nullable: false, maxLength: 50),
                        Contractor_ContractorId = c.Int(),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.Contractor", t => t.Contractor_ContractorId)
                .Index(t => t.Contractor_ContractorId);
            
            CreateTable(
                "dbo.KindOfAddress",
                c => new
                    {
                        KindOfAddessId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KindOfAddessId);
            
            CreateTable(
                "dbo.Contractor",
                c => new
                    {
                        ContractorId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Nip = c.String(maxLength: 10),
                        PhoneNo = c.String(maxLength: 20),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ContractorId);
            
            CreateTable(
                "dbo.KindOfAddressAddresses",
                c => new
                    {
                        KindOfAddress_KindOfAddessId = c.Int(nullable: false),
                        Address_AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KindOfAddress_KindOfAddessId, t.Address_AddressId })
                .ForeignKey("dbo.KindOfAddress", t => t.KindOfAddress_KindOfAddessId, cascadeDelete: true)
                .ForeignKey("dbo.Address", t => t.Address_AddressId, cascadeDelete: true)
                .Index(t => t.KindOfAddress_KindOfAddessId)
                .Index(t => t.Address_AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "Contractor_ContractorId", "dbo.Contractor");
            DropForeignKey("dbo.KindOfAddressAddresses", "Address_AddressId", "dbo.Address");
            DropForeignKey("dbo.KindOfAddressAddresses", "KindOfAddress_KindOfAddessId", "dbo.KindOfAddress");
            DropIndex("dbo.KindOfAddressAddresses", new[] { "Address_AddressId" });
            DropIndex("dbo.KindOfAddressAddresses", new[] { "KindOfAddress_KindOfAddessId" });
            DropIndex("dbo.Address", new[] { "Contractor_ContractorId" });
            DropTable("dbo.KindOfAddressAddresses");
            DropTable("dbo.Contractor");
            DropTable("dbo.KindOfAddress");
            DropTable("dbo.Address");
        }
    }
}
