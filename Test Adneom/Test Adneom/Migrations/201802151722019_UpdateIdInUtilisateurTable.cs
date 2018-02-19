namespace Test_Adneom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIdInUtilisateurTable : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Utilisateurs");
            AlterColumn("dbo.Utilisateurs", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Utilisateurs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Utilisateurs");
            AlterColumn("dbo.Utilisateurs", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Utilisateurs", "Id");
        }
    }
}
