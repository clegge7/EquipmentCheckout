namespace EquipmentCheckout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipments", "ExtraInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipments", "ExtraInfo");
        }
    }
}
