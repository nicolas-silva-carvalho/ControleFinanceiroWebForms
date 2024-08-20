namespace Financeiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Controlef : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ControleFinanceiroes", "QtdParcelas", c => c.Int(nullable: false));
            AddColumn("dbo.ControleFinanceiroes", "Precototal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.ControleFinanceiroes", "PrecoPorParcela", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.ControleFinanceiroes", "Descricao", c => c.String(nullable: false));
            AddColumn("dbo.ControleFinanceiroes", "DataCompra", c => c.DateTime(nullable: false));
            AddColumn("dbo.ControleFinanceiroes", "UltimoDiaParcela", c => c.DateTime(nullable: false));
            AddColumn("dbo.ControleFinanceiroes", "QuantidadeDeProdutos", c => c.Int(nullable: false));
            AlterColumn("dbo.ControleFinanceiroes", "Produto", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ControleFinanceiroes", "Produto", c => c.String());
            DropColumn("dbo.ControleFinanceiroes", "QuantidadeDeProdutos");
            DropColumn("dbo.ControleFinanceiroes", "UltimoDiaParcela");
            DropColumn("dbo.ControleFinanceiroes", "DataCompra");
            DropColumn("dbo.ControleFinanceiroes", "Descricao");
            DropColumn("dbo.ControleFinanceiroes", "PrecoPorParcela");
            DropColumn("dbo.ControleFinanceiroes", "Precototal");
            DropColumn("dbo.ControleFinanceiroes", "QtdParcelas");
        }
    }
}
