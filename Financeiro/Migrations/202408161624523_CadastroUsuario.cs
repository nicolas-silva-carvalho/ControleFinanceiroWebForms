namespace Financeiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CadastroUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CadastroUsuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        Senha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CadastroUsuarios");
        }
    }
}
