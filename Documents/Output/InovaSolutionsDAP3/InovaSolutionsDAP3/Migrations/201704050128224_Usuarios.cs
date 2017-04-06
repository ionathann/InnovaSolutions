namespace InovaSolutionsDAP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Usuarios : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Candidatos", "usuario_pkUsuario", c => c.Int());
            CreateIndex("dbo.Candidatos", "usuario_pkUsuario");
            AddForeignKey("dbo.Candidatos", "usuario_pkUsuario", "dbo.Usuarios", "pkUsuario");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Candidatos", "usuario_pkUsuario", "dbo.Usuarios");
            DropIndex("dbo.Candidatos", new[] { "usuario_pkUsuario" });
            DropColumn("dbo.Candidatos", "usuario_pkUsuario");
        }
    }
}
