namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EliminarZonaRequerida : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "CodigoZonaPK", "dbo.Zonas");
            AddForeignKey("dbo.Clientes", "CodigoZonaPK", "dbo.Zonas", "CodigoZona", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CodigoZonaPK", "dbo.Zonas");
            AddForeignKey("dbo.Clientes", "CodigoZonaPK", "dbo.Zonas", "CodigoZona");
        }
    }
}
