namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoTblCliente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        CodigoCliente = c.String(nullable: false, maxLength: 11),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Telefono = c.String(nullable: false, maxLength: 10),
                        Email = c.String(maxLength: 50),
                        Contacto = c.String(nullable: false, maxLength: 50),
                        TipoCliente = c.Int(),
                        CodigoZonaPK = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoCliente)
                .ForeignKey("dbo.Zonas", t => t.CodigoZonaPK, cascadeDelete: true)
                .Index(t => t.CodigoZonaPK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CodigoZonaPK", "dbo.Zonas");
            DropIndex("dbo.Clientes", new[] { "CodigoZonaPK" });
            DropTable("dbo.Clientes");
        }
    }
}
