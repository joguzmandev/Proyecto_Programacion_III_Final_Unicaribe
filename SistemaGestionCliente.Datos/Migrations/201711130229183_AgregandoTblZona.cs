namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoTblZona : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zonas",
                c => new
                    {
                        CodigoZona = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        CodigoSectorFK = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoZona)
                .ForeignKey("dbo.Sectores", t => t.CodigoSectorFK, cascadeDelete: true)
                .Index(t => t.CodigoSectorFK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zonas", "CodigoSectorFK", "dbo.Sectores");
            DropIndex("dbo.Zonas", new[] { "CodigoSectorFK" });
            DropTable("dbo.Zonas");
        }
    }
}
