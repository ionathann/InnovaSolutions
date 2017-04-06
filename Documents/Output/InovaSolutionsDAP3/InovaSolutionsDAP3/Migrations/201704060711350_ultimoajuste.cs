namespace InovaSolutionsDAP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultimoajuste : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Votos", "sDescrip", c => c.String(maxLength: 150, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Votos", "sDescrip", c => c.String(maxLength: 100, storeType: "nvarchar"));
        }
    }
}
