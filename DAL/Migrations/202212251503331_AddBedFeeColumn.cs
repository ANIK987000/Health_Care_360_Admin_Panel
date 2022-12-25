namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBedFeeColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BedAllotments", "BedFee", c => c.String(nullable: false));
            AddColumn("dbo.Beds", "BedFee", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beds", "BedFee");
            DropColumn("dbo.BedAllotments", "BedFee");
        }
    }
}
