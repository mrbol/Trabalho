namespace Clony_Exemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 250),
                        DataNascimento = c.DateTime(nullable: false),
                        Identidade = c.String(maxLength: 9),
                        Mae = c.String(maxLength: 250),
                        Pai = c.String(maxLength: 250),
                        EstadoCivil = c.String(maxLength: 20),
                        Filhos = c.Boolean(nullable: false),
                        Quantos = c.Int(nullable: false),
                        Endereco = c.String(maxLength: 250),
                        Cep = c.String(),
                        Telefone = c.String(nullable: false),
                        Facebook = c.String(),
                        Email = c.String(),
                        DataBatismo = c.DateTime(),
                        Cargo = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Membroes");
        }
    }
}
