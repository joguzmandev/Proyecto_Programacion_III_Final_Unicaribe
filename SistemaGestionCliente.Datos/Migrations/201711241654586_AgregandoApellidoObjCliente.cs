namespace SistemaGestionCliente.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregandoApellidoObjCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Apellido", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Apellido");
        }
    }
}
