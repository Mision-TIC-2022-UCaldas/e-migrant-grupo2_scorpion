namespace emigrant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emigrantes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false),
                        apellidos = c.String(nullable: false),
                        tipoIdentificacion = c.String(nullable: false),
                        numeroIdentificacion = c.String(nullable: false),
                        pais = c.String(nullable: false),
                        fechaNacimiento = c.DateTime(nullable: false),
                        correoElectronico = c.String(),
                        numeroTelefonico = c.String(),
                        direccionActual = c.String(),
                        ciudad = c.String(),
                        situacionLaboral = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emigrantes");
        }
    }
}
