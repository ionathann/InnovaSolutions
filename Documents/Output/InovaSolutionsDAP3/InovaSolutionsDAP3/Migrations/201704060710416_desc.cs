namespace InovaSolutionsDAP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class desc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Votos", "sDescrip", c => c.String(maxLength: 100, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Votos", "sDescrip");
        }
    }
}
