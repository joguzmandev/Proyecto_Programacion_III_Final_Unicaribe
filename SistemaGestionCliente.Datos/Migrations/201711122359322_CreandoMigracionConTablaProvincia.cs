namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreandoMigracionConTablaProvincia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provincias",
                c => new
                    {               
                        CodigoProvincia = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CodigoProvincia);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Provincias");
        }
    }
}
