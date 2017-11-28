namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoTblCiudad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ciudades",
                c => new
                    {
                        CodigoCiudad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        CodigoProvinciaFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoCiudad)
                .ForeignKey("dbo.Provincias", t => t.CodigoProvinciaFK, cascadeDelete: true)
                .Index(t => t.CodigoProvinciaFK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ciudades", "CodigoProvinciaFK", "dbo.Provincias");
            DropIndex("dbo.Ciudades", new[] { "CodigoProvinciaFK" });
            DropTable("dbo.Ciudades");
        }
    }
}
