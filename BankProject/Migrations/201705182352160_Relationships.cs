namespace BankProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Relationships : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Transactions", "AccountNubmber");
            AddForeignKey("dbo.Transactions", "AccountNubmber", "dbo.Accounts", "AccountNumber", cascadeDelete: true);
            DropColumn("dbo.Transactions", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "MyProperty", c => c.Int(nullable: false));
            DropForeignKey("dbo.Transactions", "AccountNubmber", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "AccountNubmber" });
        }
    }
}
