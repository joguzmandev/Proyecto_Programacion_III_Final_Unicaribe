namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambiandoNombreTablaSectores : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sectores", name: "CodigoCiudad", newName: "CodigoSector");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Sectores", name: "CodigoSector", newName: "CodigoCiudad");
        }
    }
}
