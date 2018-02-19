namespace Test_Adneom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBoissonInUtilisateursTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Utilisateurs", "Boisson", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Utilisateurs", "Boisson", c => c.String());
        }
    }
}
