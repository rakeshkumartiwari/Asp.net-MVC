namespace CatShelterMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingFullName : DbMigration
    {
        public override void Up()
        {
           RenameColumn("dbo.Cats","FullName","Name");
            
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Cats", "Name", "FullName");
        }
    }
}
