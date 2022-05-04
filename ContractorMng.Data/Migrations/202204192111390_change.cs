namespace ContractorMng.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Address", "Contractor_ContractorId", "dbo.Contractor");
            DropIndex("dbo.Address", new[] { "Contractor_ContractorId" });
            RenameColumn(table: "dbo.Address", name: "Contractor_ContractorId", newName: "ContractorId");
            AlterColumn("dbo.Address", "ContractorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Address", "ContractorId");
            AddForeignKey("dbo.Address", "ContractorId", "dbo.Contractor", "ContractorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Address", "ContractorId", "dbo.Contractor");
            DropIndex("dbo.Address", new[] { "ContractorId" });
            AlterColumn("dbo.Address", "ContractorId", c => c.Int());
            RenameColumn(table: "dbo.Address", name: "ContractorId", newName: "Contractor_ContractorId");
            CreateIndex("dbo.Address", "Contractor_ContractorId");
            AddForeignKey("dbo.Address", "Contractor_ContractorId", "dbo.Contractor", "ContractorId");
        }
    }
}
