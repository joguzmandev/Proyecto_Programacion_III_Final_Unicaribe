namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoTblSector : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sectores",
                c => new
                    {
                        CodigoCiudad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        CodigoCiudadFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoCiudad)
                .ForeignKey("dbo.Ciudades", t => t.CodigoCiudadFK, cascadeDelete: true)
                .Index(t => t.CodigoCiudadFK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sectores", "CodigoCiudadFK", "dbo.Ciudades");
            DropIndex("dbo.Sectores", new[] { "CodigoCiudadFK" });
            DropTable("dbo.Sectores");
        }
    }
}
