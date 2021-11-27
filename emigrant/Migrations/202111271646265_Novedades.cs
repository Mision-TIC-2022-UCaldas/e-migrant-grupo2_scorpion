namespace emigrant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Novedades : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Novedades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FechaNovedad = c.String(nullable: false),
                        DiasActiva = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Novedades");
        }
    }
}
