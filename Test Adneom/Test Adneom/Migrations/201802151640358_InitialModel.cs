namespace Test_Adneom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Boisson = c.String(nullable: false),
                        WithMug = c.Boolean(nullable: false),
                        QuantiteSucre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilisateurs");
        }
    }
}
